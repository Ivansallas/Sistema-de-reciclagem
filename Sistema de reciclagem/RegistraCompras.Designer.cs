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
            // 
            // txt_QuantidadeemKg
            // 
            txt_QuantidadeemKg.Location = new Point(26, 249);
            txt_QuantidadeemKg.Name = "txt_QuantidadeemKg";
            txt_QuantidadeemKg.Size = new Size(337, 27);
            txt_QuantidadeemKg.TabIndex = 1;
            txt_QuantidadeemKg.Text = "Quantidade em Kg";
            // 
            // txt_NomedoCatador
            // 
            txt_NomedoCatador.Location = new Point(26, 180);
            txt_NomedoCatador.Name = "txt_NomedoCatador";
            txt_NomedoCatador.Size = new Size(337, 27);
            txt_NomedoCatador.TabIndex = 2;
            txt_NomedoCatador.Text = "Nome do Catador";
            // 
            // lb_ValoraPagar
            // 
            lb_ValoraPagar.AutoSize = true;
            lb_ValoraPagar.Location = new Point(26, 309);
            lb_ValoraPagar.Name = "lb_ValoraPagar";
            lb_ValoraPagar.Size = new Size(96, 20);
            lb_ValoraPagar.TabIndex = 3;
            lb_ValoraPagar.Text = "Valor a Pagar";
            // 
            // Frm_RegistraCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 505);
            Controls.Add(lb_ValoraPagar);
            Controls.Add(txt_NomedoCatador);
            Controls.Add(txt_QuantidadeemKg);
            Controls.Add(cb_Material);
            Name = "Frm_RegistraCompras";
            Text = "RegistraCompras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Material;
        private TextBox txt_QuantidadeemKg;
        private TextBox txt_NomedoCatador;
        private Label lb_ValoraPagar;
    }
}