namespace CursoWindowsForms
{
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Titulo_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Bruno você é muito bom.");
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            this.lbl_Titulo.Text = text_ConteudoLabel.Text;
        }
    }
}