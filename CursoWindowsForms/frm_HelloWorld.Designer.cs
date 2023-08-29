namespace CursoWindowsForms
{
    partial class frm_HelloWorld
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
            lbl_Titulo = new Label();
            btn_Sair = new Button();
            btn_ModificaLabel = new Button();
            text_ConteudoLabel = new TextBox();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Swis721 BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(74, 36);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(302, 29);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Visual Studio .NET Version";
            lbl_Titulo.MouseClick += lbl_Titulo_MouseClick;
            // 
            // btn_Sair
            // 
            btn_Sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sair.Location = new Point(371, 242);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(75, 23);
            btn_Sair.TabIndex = 1;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // btn_ModificaLabel
            // 
            btn_ModificaLabel.Location = new Point(74, 97);
            btn_ModificaLabel.Name = "btn_ModificaLabel";
            btn_ModificaLabel.Size = new Size(302, 23);
            btn_ModificaLabel.TabIndex = 2;
            btn_ModificaLabel.Text = "Modifica Texto do Label";
            btn_ModificaLabel.UseVisualStyleBackColor = true;
            btn_ModificaLabel.Click += btn_ModificaLabel_Click;
            // 
            // text_ConteudoLabel
            // 
            text_ConteudoLabel.Location = new Point(74, 68);
            text_ConteudoLabel.Name = "text_ConteudoLabel";
            text_ConteudoLabel.Size = new Size(302, 23);
            text_ConteudoLabel.TabIndex = 3;
            // 
            // frm_HelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 277);
            Controls.Add(text_ConteudoLabel);
            Controls.Add(btn_ModificaLabel);
            Controls.Add(btn_Sair);
            Controls.Add(lbl_Titulo);
            Name = "frm_HelloWorld";
            Text = "Hello World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
        private Button btn_Sair;
        private Button btn_ModificaLabel;
        private TextBox text_ConteudoLabel;
    }
}