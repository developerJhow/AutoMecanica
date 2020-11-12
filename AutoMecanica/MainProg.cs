using AutoMecanica.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMecanica
{
    public partial class MainProg : Form
    {
        public MainProg()
        {
            InitializeComponent();

            // UserControl Defaul Dashboard
            UC_Dashboard uC_Dashboad = new UC_Dashboard();
            addUserControl(uC_Dashboad);

        }

        private void MainProg_Load(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panelContainer.Controls.Add(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Users uC_Users = new UC_Users();
            addUserControl(uC_Users);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Dashboard uC_Dashboad = new UC_Dashboard();
            addUserControl(uC_Dashboad);
        }

        private void addUserControlVbar(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.None;
            uc.BringToFront();
            panelContainer.Controls.Add(uc);
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            UC_Estoque uC_Estoque = new UC_Estoque();
            addUserControlVbar(uC_Estoque);
        }
    }
}
