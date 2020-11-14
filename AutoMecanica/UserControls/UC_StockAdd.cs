using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AutoMecanica.UserControls
{
    public partial class UC_StockAdd : UserControl
    {
        public UC_StockAdd()
        {
            InitializeComponent();
        }
        ProgrammingClassDataContext db = new ProgrammingClassDataContext();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int estoqueatual = int.Parse(atual.Text),
            estoqueamin = int.Parse(min.Text),
            quantidade = int.Parse(quant.Text),
            estoquemax = int.Parse(max.Text);


            var venda = Convert.ToDecimal(precVenda.Text);
            var compra = Convert.ToDecimal(precComp.Text);
            var cota = Convert.ToDecimal(valCota.Text);
            var lucro = Convert.ToDecimal(porLucro.Text);


            string nomeprod = tbProdName.Text,
                codbarras = txCodBarras.Text,
                fab = tbFab.Text,
                end = tbEnd.Text,
                fone = tbFone.Text,
                email = tbEmail.Text,
                codsub = codSub.Text,
                categ = categoria.Text,
                uni = unidade.Text,
                setores = setor.Text,
                fornec = fornercedor.Text,
                obs = gunaTextBox4.Text;



            DateTime vencimento = DateTime.Parse(tbVenc.Text),
                dateCotacao = DateTime.Parse(dateCot.Text);

            var st = new TableEstoque
            {
                CodBarras = codbarras,
                Atual = estoqueatual,
                Minimo = estoqueamin,
                Maximo = estoquemax,
                QuantCotacao = quantidade,
                PreCom = compra,
                PreVen = (decimal)venda,
                ValCotacao = cota,
                Lucro = lucro,
                Vencimento = vencimento,
                DataCotacao = dateCotacao,
                ProdName = nomeprod,
                Fabricante = fab,
                Endereco = end,
                Telefone = fone,
                Email = email,
                CodSubs = codsub,
                Categoria = categ,
                Unidade = uni,
                Setor = setores,
                Fornecedor = fornec,
                Observação = obs
            };
            db.TableEstoque.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Sucesso ao adicionar produto ao estoque");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.TraverseControlsAndSetTextEmpty(this);
        }
        private void TraverseControlsAndSetTextEmpty(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var box = c as TextBox;
                if (box != null)
                {
                    box.Text = string.Empty;
                }

                this.TraverseControlsAndSetTextEmpty(c);
            }
        }

        private void precComp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
