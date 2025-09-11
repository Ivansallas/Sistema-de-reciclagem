namespace Sistema_de_reciclagem
{
    partial class Frm_Relatorio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 15);
            this.richTextBox1.Size = new System.Drawing.Size(500, 400);
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 10F);
            // 
            // Frm_Relatorio
            // 
            this.ClientSize = new System.Drawing.Size(530, 430);
            this.Controls.Add(this.richTextBox1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Compras";
            this.Load += new System.EventHandler(this.Frm_Relatorio_Load);
            this.ResumeLayout(false);
        }
    }
}
