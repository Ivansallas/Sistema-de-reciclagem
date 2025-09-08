using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_reciclagem
{
    public partial class Frm_RegistraCompras : Form
    {

        public Frm_RegistraCompras()
        {
            InitializeComponent();
        }

        private void Frm_RegistraCompras_Load(object sender, EventArgs e)
        {
            cb_Material.Items.Clear();
            cb_Material.Items.AddRange(new string[] { "Papelão", "vidro", "Ferro" });
        }

        private void lb_ValoraPagar_Click(object sender, EventArgs e)
        {

        }

        private void bt_Registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra registrada com sucesso!");
            Hide();
        }

        private void cb_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para atualizar o valor a pagar conforme o material selecionado
            decimal valorPorKg = 0m;
            switch (cb_Material.SelectedItem?.ToString())
            {
                case "Papelão":
                    valorPorKg = 0.50m;
                    break;
                case "vidro":
                    valorPorKg = 0.30m;
                    break;
                case "Ferro":
                    valorPorKg = 1.00m;
                    break;
                default:
                    valorPorKg = 0m;
                    break;
            }


        }
    }
}
