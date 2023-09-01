using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class frm_ValidaCPF_2 : Form
    {
        public frm_ValidaCPF_2()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            msk_CPF.Text = "";
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            //Validar se campo está vzio
            string vConteudo;
            vConteudo = msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();

            if (vConteudo == "")
            {
                MessageBox.Show("Esse campo não pode ser vazio", "Mensagem de Validação de Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 dígitos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Você deseja realmente valida o CPF", "Mensgaem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool validaCPF = false;
                        validaCPF = Cls_Uteis.Valida(msk_CPF.Text);
                        if (validaCPF == true)
                        {
                            MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF INVÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }

        }
    }
}
