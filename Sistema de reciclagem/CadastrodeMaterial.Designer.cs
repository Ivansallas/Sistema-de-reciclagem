namespace Sistema_de_reciclagem
{
    partial class Frm_Cadastro_de_Material
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
            txt_NomedoMaterial = new TextBox();
            textBox2 = new TextBox();
            bt_Salvar = new Button();
            lb_materias = new Label();
            SuspendLayout();
            // 
            // txt_NomedoMaterial
            // 
            txt_NomedoMaterial.Location = new Point(27, 117);
            txt_NomedoMaterial.Name = "txt_NomedoMaterial";
            txt_NomedoMaterial.Size = new Size(300, 27);
            txt_NomedoMaterial.TabIndex = 0;
            txt_NomedoMaterial.Text = "Nome do Material";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Preço por Kg";
            // 
            // bt_Salvar
            // 
            bt_Salvar.BackColor = Color.Chartreuse;
            bt_Salvar.Location = new Point(436, 211);
            bt_Salvar.Name = "bt_Salvar";
            bt_Salvar.Size = new Size(114, 43);
            bt_Salvar.TabIndex = 2;
            bt_Salvar.Text = "Salvar";
            bt_Salvar.UseVisualStyleBackColor = false;
            bt_Salvar.Click += bt_Salvar_Click;
            // 
            // lb_materias
            // 
            lb_materias.AutoSize = true;
            lb_materias.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_materias.Location = new Point(27, 70);
            lb_materias.Name = "lb_materias";
            lb_materias.Size = new Size(362, 23);
            lb_materias.TabIndex = 3;
            lb_materias.Text = "Qual materias você quer cadastrar?";
            lb_materias.Click += lb_materias_Click;
            // 
            // Frm_Cadastro_de_Material
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 284);
            Controls.Add(lb_materias);
            Controls.Add(bt_Salvar);
            Controls.Add(textBox2);
            Controls.Add(txt_NomedoMaterial);
            Name = "Frm_Cadastro_de_Material";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Material";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_NomedoMaterial;
        private TextBox textBox2;
        private Button bt_Salvar;
        private Label lb_materias;
    }
}