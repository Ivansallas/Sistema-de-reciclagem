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
            new Frm_Cadastro_de_Material().ShowDialog();
            MessageBox.Show("Abrindo a tela de cadastro de material.");
        }

        private void bt_RegistrarCompra_Click(object sender, EventArgs e)
        {
            new Frm_RegistraCompras().ShowDialog();
        }

        private void bt_Relatório_Click(object sender, EventArgs e)
        {
            new Frm_Relatorio().ShowDialog();
        }
    }
}
