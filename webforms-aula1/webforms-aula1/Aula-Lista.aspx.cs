using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webforms_aula1
{
    public partial class Aula_Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lstEmails.Items.Add(txtEmail.Text);
            ddlEmail.Items.Add(txtEmail.Text);
            txtEmail.Text = string.Empty;
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            string ItemSelecionado = lstEmails.SelectedValue;
            lstEmails.Items.Remove(ItemSelecionado);
            txtEmail.Text = string.Empty;
        }

        protected void ddlEmail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}