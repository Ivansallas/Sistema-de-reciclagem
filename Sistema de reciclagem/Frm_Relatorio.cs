using System;
using System.Windows.Forms;

namespace Sistema_de_reciclagem
{
    public partial class Frm_Relatorio : Form
    {
        public Frm_Relatorio()
        {
            InitializeComponent();
            AtualizarRelatorio();
        }

        private void AtualizarRelatorio()
        {
            lvCompras.Items.Clear();

            foreach (var compra in Sistema.Compras)
            {
                var item = new ListViewItem(compra.Catador);
                item.SubItems.Add(compra.Material.Nome);
                item.SubItems.Add(compra.QuantidadeKg.ToString("N2"));
                item.SubItems.Add(compra.Material.PrecoPorKg.ToString("C2"));
                item.SubItems.Add(compra.ValorTotal.ToString("C2"));
                lvCompras.Items.Add(item);
            }
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarRelatorio();
        }
    }
}
