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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // exemplo comentário em 1 linha
            /*
             exemplo comentário em 2 linhas 
             */
            MessageBox.Show("Teste mensagem box Vivian");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string nome, sobrenome = "Barbosa";
            nome = "Vivian";
            string nomeCompleto = $"{nome}{sobrenome}";
            MessageBox.Show(nomeCompleto);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int numeroInteiro;
            string tipoTexto;
            decimal tipoDecimal;
            double numeroDecimal;
            short numeroInteiroMenor;
            byte numeroInteiromenor;
            DateTime dataehora;
            bool VerdadeiroouFalso;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
