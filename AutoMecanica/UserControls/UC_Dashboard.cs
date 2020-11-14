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
        
        ProgrammingClassDataContext db = new ProgrammingClassDataContext();
        
        void loadData()
        {
            var st = from s in db.Table_OSev select s;
            dataGrid.DataSource = st; 
            var purchCount = (from s in db.Table_OSev select s).Count();
            lblSev.Text = purchCount.ToString();
            /*
            var estoqueba = (from k in db.TableEstoque select k.Atual - k.Min).Max();
            */
            var estoqueba = (
                from k in db.TableEstoque
                where k.Atual - k.Minimo <= 0
                select k).Count();
            lblBaixaEstoque.Text = estoqueba.ToString();
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

        private void lblBaixaEstoque_Click(object sender, EventArgs e)
        {

        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Enter(object sender, EventArgs e)
        {
        }

        private List<Table_OSev> SearchName(string key)
        {
            var query =
                from prod in db.Table_OSev
                where prod.ClienteName.Contains(key)
                select prod;
            var result = query.ToList();
            return result;
        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            string search = btnSearch.Text;
            var searchName =
            from s in db.Table_OSev
            where s.ClienteName == search
            select s;
            dataGrid.DataSource = searchName;
            if (btnSearch.Text == "")
            {
                loadData();
            }

        }
    }
}
