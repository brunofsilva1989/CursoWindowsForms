namespace CursoWindowsForms
{
    partial class frm_ValidaSenha
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
            txt_Senha = new TextBox();
            lbl_Resultado = new Label();
            btn_Reset = new Button();
            btn_VerSenha = new Button();
            SuspendLayout();
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(12, 45);
            txt_Senha.Multiline = true;
            txt_Senha.Name = "txt_Senha";
            txt_Senha.PasswordChar = '*';
            txt_Senha.Size = new Size(218, 20);
            txt_Senha.TabIndex = 0;
            txt_Senha.KeyDown += txt_Senha_KeyDown;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.AutoSize = true;
            lbl_Resultado.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Resultado.Location = new Point(12, 90);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(0, 22);
            lbl_Resultado.TabIndex = 1;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(245, 42);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(111, 23);
            btn_Reset.TabIndex = 2;
            btn_Reset.Text = "Limpa";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_VerSenha
            // 
            btn_VerSenha.Location = new Point(245, 68);
            btn_VerSenha.Name = "btn_VerSenha";
            btn_VerSenha.Size = new Size(111, 23);
            btn_VerSenha.TabIndex = 3;
            btn_VerSenha.Text = "Ver Senha";
            btn_VerSenha.UseVisualStyleBackColor = true;
            btn_VerSenha.Click += btn_VerSenha_Click;
            // 
            // frm_ValidaSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 154);
            Controls.Add(btn_VerSenha);
            Controls.Add(btn_Reset);
            Controls.Add(lbl_Resultado);
            Controls.Add(txt_Senha);
            Name = "frm_ValidaSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validação de Senhas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Senha;
        private Label lbl_Resultado;
        private Button btn_Reset;
        private Button btn_VerSenha;
    }
}