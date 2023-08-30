namespace CursoWindowsForms
{
    partial class frm_DemonstracaoKey
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
            txt_Input = new TextBox();
            txt_Msg = new TextBox();
            btn_Reset = new Button();
            lbl_Minus = new Label();
            lbl_Maius = new Label();
            lbl_Upper = new Label();
            lbl_Lower = new Label();
            SuspendLayout();
            // 
            // txt_Input
            // 
            txt_Input.Location = new Point(8, 8);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(100, 23);
            txt_Input.TabIndex = 0;
            txt_Input.KeyDown += txt_Input_KeyDown;
            // 
            // txt_Msg
            // 
            txt_Msg.Location = new Point(8, 40);
            txt_Msg.Multiline = true;
            txt_Msg.Name = "txt_Msg";
            txt_Msg.ScrollBars = ScrollBars.Vertical;
            txt_Msg.Size = new Size(304, 232);
            txt_Msg.TabIndex = 1;
            txt_Msg.TabStop = false;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(328, 8);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(75, 28);
            btn_Reset.TabIndex = 2;
            btn_Reset.Text = "Limpa";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // lbl_Minus
            // 
            lbl_Minus.AutoSize = true;
            lbl_Minus.Location = new Point(317, 104);
            lbl_Minus.Name = "lbl_Minus";
            lbl_Minus.Size = new Size(43, 15);
            lbl_Minus.TabIndex = 3;
            lbl_Minus.Text = "Minus.";
            // 
            // lbl_Maius
            // 
            lbl_Maius.AutoSize = true;
            lbl_Maius.Location = new Point(320, 59);
            lbl_Maius.Name = "lbl_Maius";
            lbl_Maius.Size = new Size(42, 15);
            lbl_Maius.TabIndex = 4;
            lbl_Maius.Text = "Maius.";
            // 
            // lbl_Upper
            // 
            lbl_Upper.BorderStyle = BorderStyle.Fixed3D;
            lbl_Upper.Location = new Point(368, 56);
            lbl_Upper.Name = "lbl_Upper";
            lbl_Upper.Size = new Size(32, 23);
            lbl_Upper.TabIndex = 5;
            // 
            // lbl_Lower
            // 
            lbl_Lower.BorderStyle = BorderStyle.Fixed3D;
            lbl_Lower.Location = new Point(368, 100);
            lbl_Lower.Name = "lbl_Lower";
            lbl_Lower.Size = new Size(32, 23);
            lbl_Lower.TabIndex = 6;
            // 
            // frm_DemonstracaoKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 281);
            Controls.Add(lbl_Lower);
            Controls.Add(lbl_Upper);
            Controls.Add(lbl_Maius);
            Controls.Add(lbl_Minus);
            Controls.Add(btn_Reset);
            Controls.Add(txt_Msg);
            Controls.Add(txt_Input);
            Name = "frm_DemonstracaoKey";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demonstracao Evento Key";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Input;
        private TextBox txt_Msg;
        private Button btn_Reset;
        private Label lbl_Minus;
        private Label lbl_Maius;
        private Label lbl_Upper;
        private Label lbl_Lower;
    }
}