using System;
using System.Windows.Forms;

namespace Sistema_de_reciclagem
{
    public partial class Frm_RegistraCompras : Form
    {
        // Adicione estas linhas para declarar os campos de texto
        private TextBox txtCatador;
        private TextBox txtQuantidade;
        private ComboBox cmbMateriais;

        public Frm_RegistraCompras()
        {
            InitializeComponent();

            // Inicialize os campos de texto se não estiver sendo feito no designer
            txtCatador = new TextBox();
            txtCatador.Location = new System.Drawing.Point(10, 10); // ajuste conforme necessário
            Controls.Add(txtCatador);

            txtQuantidade = new TextBox();
            txtQuantidade.Location = new System.Drawing.Point(10, 40); // ajuste conforme necessário
            txtQuantidade.TextChanged += txt_Quantidade_TextChanged; // evento para atualizar valor
            Controls.Add(txtQuantidade);

            cmbMateriais = new ComboBox();
            cmbMateriais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateriais.Location = new System.Drawing.Point(10, 70); // ajuste conforme necessário
            Controls.Add(cmbMateriais);

            cmbMateriais.DataSource = null;
            cmbMateriais.DataSource = Sistema.Materiais;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMateriais.SelectedItem is not Material mat)
                {
                    MessageBox.Show("Selecione um material.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCatador.Text) || string.IsNullOrWhiteSpace(txtQuantidade.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                var compra = new Compra
                {
                    Catador = txtCatador.Text,
                    Material = mat,
                    QuantidadeKg = decimal.Parse(txtQuantidade.Text)
                };

                Sistema.Compras.Add(compra);
                Sistema.Salvar(); // 🔹 salva imediatamente

                MessageBox.Show($"Compra registrada! Valor a pagar: R$ {compra.ValorTotal:F2}");

                txtCatador.Clear();
                txtQuantidade.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar compra: " + ex.Message);
            }
        }

        private void cb_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implemente aqui a lógica que deve ocorrer quando o material for alterado.
            // Por exemplo, atualizar o valor a pagar ou outros campos.
        }

        private void txt_Quantidade_TextChanged(object? sender, EventArgs e)
        {
            // Exemplo: Atualiza o valor a pagar conforme a quantidade digitada
            decimal quantidade;
            if (decimal.TryParse(txtQuantidade.Text, out quantidade))
            {
                // Supondo que o valor do material seja fixo, por exemplo, 2.50 por Kg
                decimal valorPorKg = 2.50m;
                decimal valorTotal = quantidade * valorPorKg;
                lb_ValoraPagar.Text = $"Valor a pagar: R$ {valorTotal:N2}";
            }
            else
            {
                lb_ValoraPagar.Text = "Valor a pagar: R$ 0,00";
            }
        }
    }
}
