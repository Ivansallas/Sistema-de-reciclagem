namespace Sistema_de_reciclagem
{
    partial class Frm_Cadastro_de_Material
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.GroupBox gpbCadastro;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.gpbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.lbNome);
            this.gpbCadastro.Controls.Add(this.txtNome);
            this.gpbCadastro.Controls.Add(this.lbPreco);
            this.gpbCadastro.Controls.Add(this.txtPreco);
            this.gpbCadastro.Controls.Add(this.bt_Salvar);
            this.gpbCadastro.Location = new System.Drawing.Point(20, 20);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(360, 200);
            this.gpbCadastro.TabIndex = 0;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Cadastro de Material";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(20, 40);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(110, 20);
            this.lbNome.Text = "Nome Material:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 37);
            this.txtNome.Size = new System.Drawing.Size(200, 27);
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(20, 80);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(75, 20);
            this.lbPreco.Text = "Preço/Kg:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(140, 77);
            this.txtPreco.Size = new System.Drawing.Size(200, 27);
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(140, 130);
            this.bt_Salvar.Size = new System.Drawing.Size(100, 35);
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // Frm_Cadastro_de_Material
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.gpbCadastro);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Material";
            this.gpbCadastro.ResumeLayout(false);
            this.gpbCadastro.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
