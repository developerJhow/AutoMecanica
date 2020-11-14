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
    public partial class UC_UsersEnd : UserControl
    {
        public UC_UsersEnd()
        {
            InitializeComponent();
        }
        private void gunaTextBox10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(gunaTextBox10.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor digite apenas numeros.");
                gunaTextBox10.Text = gunaTextBox10.Text.Remove(gunaTextBox10.Text.Length - 1);
            }
        }
    }
}
