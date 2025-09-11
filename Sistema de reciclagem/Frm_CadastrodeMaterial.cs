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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtPreco.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                var mat = new Material
                {
                    Nome = txtNome.Text,
                    PrecoPorKg = decimal.Parse(txtPreco.Text)
                };

                Sistema.Materiais.Add(mat);
                Sistema.Salvar(); // 🔹 salva imediatamente

                MessageBox.Show("Material cadastrado com sucesso!");
                txtNome.Clear();
                txtPreco.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar material: " + ex.Message);
            }
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            // Implemente aqui a lógica para salvar o material
            MessageBox.Show("Material salvo com sucesso!");
        }
    }
}
