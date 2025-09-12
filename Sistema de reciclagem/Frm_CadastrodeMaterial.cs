using System;
using System.Windows.Forms;

namespace Sistema_de_reciclagem
{
    public partial class Frm_Cadastro_de_Material : Form
    {
        public Frm_Cadastro_de_Material()
        {
            InitializeComponent();
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Nome.Text) || string.IsNullOrWhiteSpace(txt_Preco.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                if (!decimal.TryParse(txt_Preco.Text, out decimal preco))
                {
                    MessageBox.Show("Digite um preço válido!");
                    return;
                }

                var material = new Material
                {
                    Nome = txt_Nome.Text,
                    PrecoPorKg = preco
                };

                Sistema.Materiais.Add(material);
                Sistema.Salvar();

                MessageBox.Show("Material cadastrado com sucesso!");

                txt_Nome.Clear();
                txt_Preco.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar material: " + ex.Message);
            }
        }
    }
}
