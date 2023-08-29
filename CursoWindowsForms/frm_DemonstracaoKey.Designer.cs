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
            SuspendLayout();
            // 
            // txt_Input
            // 
            txt_Input.Location = new Point(8, 8);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(100, 23);
            txt_Input.TabIndex = 0;
            // 
            // txt_Msg
            // 
            txt_Msg.Location = new Point(8, 40);
            txt_Msg.Name = "txt_Msg";
            txt_Msg.ScrollBars = ScrollBars.Vertical;
            txt_Msg.Size = new Size(304, 23);
            txt_Msg.TabIndex = 1;
            txt_Msg.TabStop = false;
            // 
            // frm_DemonstracaoKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 329);
            Controls.Add(txt_Msg);
            Controls.Add(txt_Input);
            Name = "frm_DemonstracaoKey";
            Text = "Demonstracao Evento Key";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Input;
        private TextBox txt_Msg;
    }
}