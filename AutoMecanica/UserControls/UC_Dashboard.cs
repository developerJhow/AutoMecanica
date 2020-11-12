using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoMecanica.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
            loadData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AU8FHEB\SQLSERVER;Initial Catalog=LoginDB;Integrated Security=True");
        ProgrammingClassDataContext db = new ProgrammingClassDataContext();
        
        void loadData()
        {
            var st = from s in db.Table_OSev select s;
            dataGrid.DataSource = st; 
            var purchCount = (from s in db.Table_OSev select s).Count();
            lblSev.Text = purchCount.ToString();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
