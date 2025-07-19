using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnome.Clear();
            mskcpf.Clear();
            mskrg.Clear();
            mskcep.Clear();
            txtbairro.Clear();
            txtcidade.Clear();
            txtemail.Clear();
            mskcelular.Clear();
            mskdatanascimento.Clear();
            txtendereco.Clear();
        }
    }
}
