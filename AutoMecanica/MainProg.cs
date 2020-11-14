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
            customizeDesing();

            // UserControl Defaul Dashboard
            UC_Dashboard uC_Dashboad = new UC_Dashboard();
            addUserControl(uC_Dashboad);

        }
        private void customizeDesing()
        {
            panelClientesSubMenu.Visible = false;
            panelEstoqueSubMenu.Visible = false;
            panelFinanceiroSubMenu.Visible = false;
            panelServicosSubMenu.Visible = false;
            panelVeiculosSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelClientesSubMenu.Visible == true)
            {
                panelClientesSubMenu.Visible = false;
            }
            if (panelEstoqueSubMenu.Visible == true)
            {
                panelEstoqueSubMenu.Visible = false;
            }
            if (panelFinanceiroSubMenu.Visible == true)
            {
                panelFinanceiroSubMenu.Visible = false;
            }
            if (panelServicosSubMenu.Visible == true)
            {
                panelServicosSubMenu.Visible = false;
            }
            if (panelVeiculosSubMenu.Visible == true)
            {
                panelVeiculosSubMenu.Visible = false;
            }

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
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
        #region ClientSubMenu
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientesSubMenu);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Dashboard uC_Dashboad = new UC_Dashboard();
            addUserControl(uC_Dashboad);

            //..
            //Meus Codigos
            //
            hideSubMenu();
        }
        #endregion
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEstoqueSubMenu);
            /*Testando Menu
            UC_Stock stock = new UC_Stock();
            addUserControl(stock);
            */
        }

        private void btnHome_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            UC_UsersDados uC_UD = new UC_UsersDados();
            addUserControl(uC_UD);
            //Nao  alterar em baixo
            hideSubMenu();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            //..
            //Meus Codigos
            //
            hideSubMenu();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            showSubMenu(panelServicosSubMenu);
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFinanceiroSubMenu);
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVeiculosSubMenu);
        }
    }
}
