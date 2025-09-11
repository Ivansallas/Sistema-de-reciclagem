using System;
using System.Windows.Forms;

namespace Sistema_de_reciclagem
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void bt_CadastrarMaterial_Click(object sender, EventArgs e)
        {
            // Apenas abre o formul�rio de cadastro
            new Frm_Cadastro_de_Material().ShowDialog();
        }

        private void bt_RegistrarCompra_Click(object sender, EventArgs e)
        {
            // Apenas abre o formul�rio de registro de compras
            new Frm_RegistraCompras().ShowDialog();
        }

        private void bt_Relat�rio_Click(object sender, EventArgs e)
        {
            // Abre o relat�rio em um novo formul�rio
            new Frm_Relatorio().ShowDialog();
        }
    }
}
