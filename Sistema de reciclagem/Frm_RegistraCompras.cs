using System;
using System.Windows.Forms;

namespace Sistema_de_reciclagem
{
    public partial class Frm_RegistraCompras : Form
    {
        public Frm_RegistraCompras()
        {
            InitializeComponent();
            AtualizarComboMateriais();
        }

        private void bt_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Material.SelectedItem is not Material mat)
                {
                    MessageBox.Show("Selecione um material.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_Catador.Text) || string.IsNullOrWhiteSpace(txt_Quantidade.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                if (!decimal.TryParse(txt_Quantidade.Text, out decimal quantidade))
                {
                    MessageBox.Show("Digite uma quantidade válida!");
                    return;
                }

                var compra = new Compra
                {
                    Catador = txt_Catador.Text,
                    Material = mat,
                    QuantidadeKg = quantidade
                };

                Sistema.Compras.Add(compra);
                Sistema.Salvar();

                MessageBox.Show($"Compra registrada! Valor a pagar: R$ {compra.ValorTotal:F2}");

                txt_Catador.Clear();
                txt_Quantidade.Clear();
                lb_ValoraPagar.Text = "Valor a pagar: R$ 0,00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar compra: " + ex.Message);
            }
        }

        private void cb_Material_SelectedIndexChanged(object sender, EventArgs e) => AtualizarValorAPagar();

        private void txt_Quantidade_TextChanged(object sender, EventArgs e) => AtualizarValorAPagar();

        private void AtualizarValorAPagar()
        {
            if (cb_Material.SelectedItem is Material mat && decimal.TryParse(txt_Quantidade.Text, out decimal quantidade))
            {
                decimal valorTotal = mat.PrecoPorKg * quantidade;
                lb_ValoraPagar.Text = $"Valor a pagar: R$ {valorTotal:F2}";
            }
            else
            {
                lb_ValoraPagar.Text = "Valor a pagar: R$ 0,00";
            }
        }

        public void AtualizarComboMateriais()
        {
            cb_Material.DataSource = null;
            cb_Material.DataSource = Sistema.Materiais;
            cb_Material.DisplayMember = "Nome";
        }
    }
}
