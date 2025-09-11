using System;
using System.Windows.Forms;

namespace Sistema_de_reciclagem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Sistema.Carregar(); // Carrega materiais e compras do JSON
            Application.Run(new Frm_Principal());
            Sistema.Salvar(); // Salva tudo ao fechar
        }
    }
}
