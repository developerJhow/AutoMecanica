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
            addUserPanel(panelDados);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelEndereço_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            addUserPanel(panelEnd);
            panelDados.Enabled = false;
            panelDados.Visible = false;
            panelEnd.Enabled = true;
            panelEnd.Visible = true;            
        }

        private void gunaTextBox10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(gunaTextBox10.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor digite apenas numeros.");
                gunaTextBox10.Text = gunaTextBox10.Text.Remove(gunaTextBox10.Text.Length - 1);
            }
        }

        private void addUserPanel(Panel panel)
        {
            panel1.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            panel.BringToFront();
            panel1.Controls.Add(panel);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addUserPanel(panelDados);
            panelDados.Visible = true;
            panelDados.Enabled = true;
            panelEnd.Visible = false;
            panelEnd.Enabled = false;
            //panelDados.Show();
            
        }

        private void panelEnd_Paint(object sender, PaintEventArgs e)
        {

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
