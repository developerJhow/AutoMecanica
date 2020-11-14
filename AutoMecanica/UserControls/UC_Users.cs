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
    public partial class UC_Users : UserControl
    {
        public UC_Users()
        {
            InitializeComponent();
            UC_UsersEnd usersEnd = new UC_UsersEnd();
            addUserControl(usersEnd);
            //Default UC 
            UC_UsersDados usersDados = new UC_UsersDados();
            addUserControl(usersDados);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelEndereço_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_UsersEnd uC = new UC_UsersEnd();
            addUserControl(uC);
        }


        private void addUserControl(UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panel1.Controls.Add(uc);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_UsersDados usersDados = new UC_UsersDados();
            addUserControl(usersDados);          
            
            
        }

        private void panelEnd_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
