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
    public partial class frmArraay : Form
    {
        public frmArraay()
        {
            InitializeComponent();
        }

        string[] alunos = new string[8];

        private void BtnOk_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] == null)
                {
                    alunos[i] = txtNome.Text;
                    txtNome.Text = string.Empty;
                    break;
                }
            }
        }
    }
}
