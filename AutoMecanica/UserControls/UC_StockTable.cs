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
    public partial class UC_StockTable : UserControl
    {

        public UC_StockTable()
        {
            InitializeComponent();
            loadData();
        }
        ProgrammingClassDataContext db = new ProgrammingClassDataContext();
        void loadData()
        {
            var st = from s in db.TableEstoque select s;
            dataGrid.DataSource = st;

        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            string search = btnSearch.Text;
            var searchName =
            from s in db.TableEstoque
            where s.ProdName == search
            select s;
            dataGrid.DataSource = searchName;
            if (btnSearch.Text == "")
            {
                loadData();
            }
        }

        private void addUserControl(UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panel1.Controls.Add(uc);
        }
        
        private void btnDel_Click(object sender, EventArgs e)
        {

            //Delete
            if (MessageBox.Show("Voce deseja deletar esse item?", "Deletar item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var st = (from s in db.TableEstoque where s.ProdName == btnSearch.Text select s).First();
                db.TableEstoque.DeleteOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("Sucesso ao deletar produtos do estoque");
                loadData();
            }
        }
    }
}
