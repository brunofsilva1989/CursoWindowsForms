namespace CursoWindowsForms
{
    partial class frm_ValidaCPF
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
            msk_CPF = new MaskedTextBox();
            lbl_Resultado = new Label();
            btn_Reset = new Button();
            btn_Valida = new Button();
            SuspendLayout();
            // 
            // msk_CPF
            // 
            msk_CPF.Location = new Point(12, 45);
            msk_CPF.Mask = "000,000,000-00";
            msk_CPF.Name = "msk_CPF";
            msk_CPF.Size = new Size(218, 23);
            msk_CPF.TabIndex = 0;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.AutoSize = true;
            lbl_Resultado.Font = new Font("Arial", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Resultado.Location = new Point(12, 90);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(0, 38);
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
            // btn_Valida
            // 
            btn_Valida.Location = new Point(245, 71);
            btn_Valida.Name = "btn_Valida";
            btn_Valida.Size = new Size(111, 23);
            btn_Valida.TabIndex = 2;
            btn_Valida.Text = "Valida";
            btn_Valida.UseVisualStyleBackColor = true;
            btn_Valida.Click += btn_Valida_Click;
            // 
            // frm_ValidaCPF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 154);
            Controls.Add(btn_Valida);
            Controls.Add(btn_Reset);
            Controls.Add(lbl_Resultado);
            Controls.Add(msk_CPF);
            Name = "frm_ValidaCPF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validação CPF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox msk_CPF;
        private Label lbl_Resultado;
        private Button btn_Reset;
        private Button btn_Valida;
    }
}