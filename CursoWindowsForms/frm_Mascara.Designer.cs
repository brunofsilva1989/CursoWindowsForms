namespace CursoWindowsForms
{
    partial class frm_Mascara
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
            msk_TextBox = new MaskedTextBox();
            lbl_Conteudo = new Label();
            lbl_MascaraAtiva = new Label();
            btn_Hora = new Button();
            btn_CEP = new Button();
            btn_Moeda = new Button();
            btn_Data = new Button();
            btn_Senha = new Button();
            btn_Telefone = new Button();
            btn_VerConteudo = new Button();
            SuspendLayout();
            // 
            // msk_TextBox
            // 
            msk_TextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            msk_TextBox.Location = new Point(23, 31);
            msk_TextBox.Name = "msk_TextBox";
            msk_TextBox.Size = new Size(258, 26);
            msk_TextBox.TabIndex = 0;
            // 
            // lbl_Conteudo
            // 
            lbl_Conteudo.AutoSize = true;
            lbl_Conteudo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Conteudo.Location = new Point(23, 246);
            lbl_Conteudo.Name = "lbl_Conteudo";
            lbl_Conteudo.Size = new Size(0, 19);
            lbl_Conteudo.TabIndex = 1;
            // 
            // lbl_MascaraAtiva
            // 
            lbl_MascaraAtiva.AutoSize = true;
            lbl_MascaraAtiva.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MascaraAtiva.Location = new Point(23, 75);
            lbl_MascaraAtiva.Name = "lbl_MascaraAtiva";
            lbl_MascaraAtiva.Size = new Size(0, 19);
            lbl_MascaraAtiva.TabIndex = 2;
            // 
            // btn_Hora
            // 
            btn_Hora.Location = new Point(23, 110);
            btn_Hora.Name = "btn_Hora";
            btn_Hora.Size = new Size(82, 37);
            btn_Hora.TabIndex = 3;
            btn_Hora.Text = "Hora";
            btn_Hora.UseVisualStyleBackColor = true;
            btn_Hora.Click += btn_Hora_Click;
            // 
            // btn_CEP
            // 
            btn_CEP.Location = new Point(111, 110);
            btn_CEP.Name = "btn_CEP";
            btn_CEP.Size = new Size(82, 37);
            btn_CEP.TabIndex = 4;
            btn_CEP.Text = "CEP";
            btn_CEP.UseVisualStyleBackColor = true;
            btn_CEP.Click += btn_CEP_Click;
            // 
            // btn_Moeda
            // 
            btn_Moeda.Location = new Point(199, 110);
            btn_Moeda.Name = "btn_Moeda";
            btn_Moeda.Size = new Size(82, 37);
            btn_Moeda.TabIndex = 5;
            btn_Moeda.Text = "Moeda";
            btn_Moeda.UseVisualStyleBackColor = true;
            btn_Moeda.Click += btn_Moeda_Click;
            // 
            // btn_Data
            // 
            btn_Data.Location = new Point(23, 153);
            btn_Data.Name = "btn_Data";
            btn_Data.Size = new Size(82, 37);
            btn_Data.TabIndex = 6;
            btn_Data.Text = "Data";
            btn_Data.UseVisualStyleBackColor = true;
            btn_Data.Click += btn_Data_Click;
            // 
            // btn_Senha
            // 
            btn_Senha.Location = new Point(111, 153);
            btn_Senha.Name = "btn_Senha";
            btn_Senha.Size = new Size(82, 37);
            btn_Senha.TabIndex = 7;
            btn_Senha.Text = "Senha";
            btn_Senha.UseVisualStyleBackColor = true;
            btn_Senha.Click += btn_Senha_Click;
            // 
            // btn_Telefone
            // 
            btn_Telefone.Location = new Point(199, 153);
            btn_Telefone.Name = "btn_Telefone";
            btn_Telefone.Size = new Size(82, 37);
            btn_Telefone.TabIndex = 8;
            btn_Telefone.Text = "Telefone";
            btn_Telefone.UseVisualStyleBackColor = true;
            btn_Telefone.Click += btn_Telefone_Click;
            // 
            // btn_VerConteudo
            // 
            btn_VerConteudo.Location = new Point(23, 196);
            btn_VerConteudo.Name = "btn_VerConteudo";
            btn_VerConteudo.Size = new Size(258, 37);
            btn_VerConteudo.TabIndex = 9;
            btn_VerConteudo.Text = "Ver Conteúdo";
            btn_VerConteudo.UseVisualStyleBackColor = true;
            btn_VerConteudo.Click += btn_VerConteudo_Click;
            // 
            // frm_Mascara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 283);
            Controls.Add(btn_VerConteudo);
            Controls.Add(btn_Telefone);
            Controls.Add(btn_Senha);
            Controls.Add(btn_Data);
            Controls.Add(btn_Moeda);
            Controls.Add(btn_CEP);
            Controls.Add(btn_Hora);
            Controls.Add(lbl_MascaraAtiva);
            Controls.Add(lbl_Conteudo);
            Controls.Add(msk_TextBox);
            Name = "frm_Mascara";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exemplo de Máscaras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox msk_TextBox;
        private Label lbl_Conteudo;
        private Label lbl_MascaraAtiva;
        private Button btn_Hora;
        private Button btn_CEP;
        private Button btn_Moeda;
        private Button btn_Data;
        private Button btn_Senha;
        private Button btn_Telefone;
        private Button btn_VerConteudo;
    }
}