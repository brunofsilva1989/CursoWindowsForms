﻿using System;
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
    public partial class frm_Mascara : Form
    {
        public frm_Mascara()
        {
            InitializeComponent();
        }

        private void btn_Hora_Click(object sender, EventArgs e)
        {
            //Definir mascara no TextBox
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "00:00";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Text = "";
            //Altera o foco de onde o cursos vai aparecer
            msk_TextBox.Focus();

        }

        private void btn_VerConteudo_Click(object sender, EventArgs e)
        {
            lbl_Conteudo.Text = msk_TextBox.Text;

        }

        private void btn_CEP_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "00000-000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
        }

        private void btn_Moeda_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "$ 000,000,000.00";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
        }

        private void btn_Data_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "00/00/0000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
        }

        private void btn_Senha_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = true;
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "000000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Text = "";
            msk_TextBox.Focus();
        }

        private void btn_Telefone_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            msk_TextBox.Mask = "(00) 00000-0000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Text = "";
            msk_TextBox.Focus();

        }
    }
}
