using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMecanica.UserControls
{
    public partial class UC_UsersDados : UserControl
    {
        public UC_UsersDados()
        {
            InitializeComponent();
        }
        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 1)
            {
                lblNomeClient.Text = "Nome completo do Responsavel";
                lblCnpj.Visible = true;
                txtCnpj.Visible = true;
                lblNf.Visible = true;
                txtNf.Visible = true;
            }
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                lblCnpj.Visible = false;
                txtCnpj.Visible = false;
                lblNf.Visible = false;
                txtNf.Visible = false;
            }
        }
    }
}
