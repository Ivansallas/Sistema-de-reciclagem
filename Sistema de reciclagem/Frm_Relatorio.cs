using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_reciclagem
{
    public partial class Frm_Relatorio : Form
    {
        public Frm_Relatorio()
        {
            InitializeComponent();
        }

        private void Frm_Relatorio_Load(object sender, EventArgs e)
        {
            if (Sistema.Compras.Count == 0)
            {
                richTextBox1.Text = "Nenhuma compra registrada ainda.";
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RELATÓRIO DE COMPRAS");
            sb.AppendLine(new string('-', 60));

            foreach (var c in Sistema.Compras)
            {
                sb.AppendLine(
                    $"{c.Data:dd/MM/yyyy} | " +
                    $"{c.Catador,-15} | " +
                    $"{c.Material.Nome,-10} | " +
                    $"{c.QuantidadeKg,5} Kg | " +
                    $"R$ {c.ValorTotal,8:F2}"
                );
            }

            sb.AppendLine(new string('-', 60));
            sb.AppendLine($"Total de compras: {Sistema.Compras.Count}");
            sb.AppendLine($"Valor total pago: R$ {Sistema.Compras.Sum(x => x.ValorTotal):F2}");

            richTextBox1.Text = sb.ToString();
        }
    }
}
