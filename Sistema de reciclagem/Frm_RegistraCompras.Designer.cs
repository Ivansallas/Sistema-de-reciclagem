namespace Sistema_de_reciclagem
{
    partial class Frm_RegistraCompras
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.ComboBox cb_Material;
        private System.Windows.Forms.Label lbCatador;
        private System.Windows.Forms.TextBox txt_Catador;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Label lb_ValoraPagar;
        private System.Windows.Forms.Button bt_Registrar;
        private System.Windows.Forms.GroupBox gpbCompra;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            gpbCompra = new GroupBox();
            lbMaterial = new Label();
            cb_Material = new ComboBox();
            lbCatador = new Label();
            txt_Catador = new TextBox();
            lbQuantidade = new Label();
            txt_Quantidade = new TextBox();
            lb_ValoraPagar = new Label();
            bt_Registrar = new Button();
            gpbCompra.SuspendLayout();
            SuspendLayout();
            // 
            // gpbCompra
            // 
            gpbCompra.Controls.Add(lbMaterial);
            gpbCompra.Controls.Add(cb_Material);
            gpbCompra.Controls.Add(lbCatador);
            gpbCompra.Controls.Add(txt_Catador);
            gpbCompra.Controls.Add(lbQuantidade);
            gpbCompra.Controls.Add(txt_Quantidade);
            gpbCompra.Controls.Add(lb_ValoraPagar);
            gpbCompra.Controls.Add(bt_Registrar);
            gpbCompra.Location = new Point(12, 12);
            gpbCompra.Name = "gpbCompra";
            gpbCompra.Size = new Size(400, 250);
            gpbCompra.TabIndex = 0;
            gpbCompra.TabStop = false;
            gpbCompra.Text = "Registrar Compra";
            // 
            // lbMaterial
            // 
            lbMaterial.AutoSize = true;
            lbMaterial.Location = new Point(20, 40);
            lbMaterial.Name = "lbMaterial";
            lbMaterial.Size = new Size(67, 20);
            lbMaterial.TabIndex = 0;
            lbMaterial.Text = "Material:";
            // 
            // cb_Material
            // 
            cb_Material.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Material.Location = new Point(140, 37);
            cb_Material.Name = "cb_Material";
            cb_Material.Size = new Size(200, 28);
            cb_Material.TabIndex = 1;
            cb_Material.SelectedIndexChanged += cb_Material_SelectedIndexChanged;
            // 
            // lbCatador
            // 
            lbCatador.AutoSize = true;
            lbCatador.Location = new Point(20, 80);
            lbCatador.Name = "lbCatador";
            lbCatador.Size = new Size(65, 20);
            lbCatador.TabIndex = 2;
            lbCatador.Text = "Catador:";
            // 
            // txt_Catador
            // 
            txt_Catador.Location = new Point(140, 77);
            txt_Catador.Name = "txt_Catador";
            txt_Catador.Size = new Size(200, 27);
            txt_Catador.TabIndex = 3;
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(20, 120);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(122, 20);
            lbQuantidade.TabIndex = 4;
            lbQuantidade.Text = "Quantidade (Kg):";
            // 
            // txt_Quantidade
            // 
            txt_Quantidade.Location = new Point(140, 117);
            txt_Quantidade.Name = "txt_Quantidade";
            txt_Quantidade.Size = new Size(200, 27);
            txt_Quantidade.TabIndex = 5;
            txt_Quantidade.TextChanged += txt_Quantidade_TextChanged;
            // 
            // lb_ValoraPagar
            // 
            lb_ValoraPagar.AutoSize = true;
            lb_ValoraPagar.Location = new Point(20, 160);
            lb_ValoraPagar.Name = "lb_ValoraPagar";
            lb_ValoraPagar.Size = new Size(153, 20);
            lb_ValoraPagar.TabIndex = 6;
            lb_ValoraPagar.Text = "Valor a pagar: R$ 0,00";
            // 
            // bt_Registrar
            // 
            bt_Registrar.Location = new Point(140, 190);
            bt_Registrar.Name = "bt_Registrar";
            bt_Registrar.Size = new Size(100, 35);
            bt_Registrar.TabIndex = 7;
            bt_Registrar.Text = "Registrar";
            // 
            // Frm_RegistraCompras
            // 
            ClientSize = new Size(450, 300);
            Controls.Add(gpbCompra);
            Name = "Frm_RegistraCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Compra";
            gpbCompra.ResumeLayout(false);
            gpbCompra.PerformLayout();
            ResumeLayout(false);
        }
    }
}
