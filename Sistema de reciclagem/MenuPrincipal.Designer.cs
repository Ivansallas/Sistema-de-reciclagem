namespace Sistema_de_reciclagem
{
    partial class Frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            bt_CadastrarMaterial = new Button();
            bt_RegistrarCompra = new Button();
            bt_Relatório = new Button();
            Gpb_Menu = new GroupBox();
            pictureBox1 = new PictureBox();
            Gpb_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_CadastrarMaterial
            // 
            bt_CadastrarMaterial.BackColor = SystemColors.ActiveCaption;
            bt_CadastrarMaterial.ForeColor = SystemColors.ActiveCaptionText;
            bt_CadastrarMaterial.Location = new Point(127, 35);
            bt_CadastrarMaterial.Name = "bt_CadastrarMaterial";
            bt_CadastrarMaterial.Size = new Size(153, 72);
            bt_CadastrarMaterial.TabIndex = 0;
            bt_CadastrarMaterial.Text = "Cadastrar Material";
            bt_CadastrarMaterial.UseVisualStyleBackColor = false;
            bt_CadastrarMaterial.Click += bt_CadastrarMaterial_Click;
            // 
            // bt_RegistrarCompra
            // 
            bt_RegistrarCompra.BackColor = SystemColors.ControlDarkDark;
            bt_RegistrarCompra.Location = new Point(127, 206);
            bt_RegistrarCompra.Name = "bt_RegistrarCompra";
            bt_RegistrarCompra.Size = new Size(153, 69);
            bt_RegistrarCompra.TabIndex = 1;
            bt_RegistrarCompra.Text = "Registrar Compra";
            bt_RegistrarCompra.UseVisualStyleBackColor = false;
            bt_RegistrarCompra.Click += bt_RegistrarCompra_Click;
            // 
            // bt_Relatório
            // 
            bt_Relatório.BackColor = SystemColors.Info;
            bt_Relatório.Location = new Point(127, 358);
            bt_Relatório.Name = "bt_Relatório";
            bt_Relatório.Size = new Size(153, 71);
            bt_Relatório.TabIndex = 2;
            bt_Relatório.Text = "Relatório";
            bt_Relatório.UseVisualStyleBackColor = false;
            bt_Relatório.Click += bt_Relatório_Click;
            // 
            // Gpb_Menu
            // 
            Gpb_Menu.Controls.Add(bt_CadastrarMaterial);
            Gpb_Menu.Controls.Add(bt_Relatório);
            Gpb_Menu.Controls.Add(bt_RegistrarCompra);
            Gpb_Menu.Location = new Point(332, 30);
            Gpb_Menu.Name = "Gpb_Menu";
            Gpb_Menu.Size = new Size(391, 456);
            Gpb_Menu.TabIndex = 3;
            Gpb_Menu.TabStop = false;
            Gpb_Menu.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 495);
            Controls.Add(pictureBox1);
            Controls.Add(Gpb_Menu);
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Reciclagem";
            Gpb_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bt_CadastrarMaterial;
        private Button bt_RegistrarCompra;
        private Button bt_Relatório;
        private GroupBox Gpb_Menu;
        private PictureBox pictureBox1;
    }
}
