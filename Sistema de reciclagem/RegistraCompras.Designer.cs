namespace Sistema_de_reciclagem
{
    partial class Frm_RegistraCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cb_Material = new ComboBox();
            txt_QuantidadeemKg = new TextBox();
            txt_NomedoCatador = new TextBox();
            lb_ValoraPagar = new Label();
            bt_Registrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cb_Material
            // 
            cb_Material.FormattingEnabled = true;
            cb_Material.Location = new Point(26, 84);
            cb_Material.Name = "cb_Material";
            cb_Material.Size = new Size(151, 28);
            cb_Material.TabIndex = 0;
            cb_Material.Text = "Material";
            cb_Material.SelectedIndexChanged += cb_Material_SelectedIndexChanged;
            // 
            // txt_QuantidadeemKg
            // 
            txt_QuantidadeemKg.Location = new Point(26, 222);
            txt_QuantidadeemKg.Name = "txt_QuantidadeemKg";
            txt_QuantidadeemKg.Size = new Size(337, 27);
            txt_QuantidadeemKg.TabIndex = 1;
            txt_QuantidadeemKg.Text = "Quantidade em Kg";
            // 
            // txt_NomedoCatador
            // 
            txt_NomedoCatador.Location = new Point(26, 156);
            txt_NomedoCatador.Name = "txt_NomedoCatador";
            txt_NomedoCatador.Size = new Size(337, 27);
            txt_NomedoCatador.TabIndex = 2;
            txt_NomedoCatador.Text = "Nome do Catador";
            // 
            // lb_ValoraPagar
            // 
            lb_ValoraPagar.AutoSize = true;
            lb_ValoraPagar.Location = new Point(26, 290);
            lb_ValoraPagar.Name = "lb_ValoraPagar";
            lb_ValoraPagar.Size = new Size(96, 20);
            lb_ValoraPagar.TabIndex = 3;
            lb_ValoraPagar.Text = "Valor a Pagar";
            lb_ValoraPagar.Click += lb_ValoraPagar_Click;
            // 
            // bt_Registrar
            // 
            bt_Registrar.Location = new Point(388, 418);
            bt_Registrar.Name = "bt_Registrar";
            bt_Registrar.Size = new Size(107, 42);
            bt_Registrar.TabIndex = 4;
            bt_Registrar.Text = "Registrar";
            bt_Registrar.UseVisualStyleBackColor = true;
            bt_Registrar.Click += bt_Registrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display Semibold", 12F);
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(157, 29);
            label1.TabIndex = 5;
            label1.Text = "Lista de materiais";
            // 
            // Frm_RegistraCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 505);
            Controls.Add(label1);
            Controls.Add(bt_Registrar);
            Controls.Add(lb_ValoraPagar);
            Controls.Add(txt_NomedoCatador);
            Controls.Add(txt_QuantidadeemKg);
            Controls.Add(cb_Material);
            Name = "Frm_RegistraCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistraCompras";
            Load += Frm_RegistraCompras_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Material;
        private TextBox txt_QuantidadeemKg;
        private TextBox txt_NomedoCatador;
        private Label lb_ValoraPagar;
        private Button bt_Registrar;
        private Label label1;
    }
}