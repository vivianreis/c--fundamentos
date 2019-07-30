using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            bool valido = true;
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("preencher o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valido = false;
            }

            if (txtSobrenome.Text == "")
            {
                MessageBox.Show("preencher o sobrenome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valido = false;
            }
            if (txtDataNascimento.Text == "")
            {
                MessageBox.Show("preencher a data de nascimento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valido = false;
            }

            //se o código estiver invalido sai fora do método
            if (valido == false) 
            {
                return;
            }

            string nome, sobrenome;
            DateTime dataNascimento;
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
  
            MessageBox.Show($@"Nome: {nome} 
Sobrenome: {sobrenome} 
DataNascimento: {dataNascimento}");


        }
    }
}
