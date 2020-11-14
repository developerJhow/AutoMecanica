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
    public partial class UC_StockEdit : UserControl
    {
        public UC_StockEdit()
        {
            InitializeComponent();
        }
        ProgrammingClassDataContext db = new ProgrammingClassDataContext();

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            string search = btnSearch.Text;
            var searchName =
            from s in db.TableEstoque
            where s.ProdName == search
            select s;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {   
            var stexist = (from s in db.TableEstoque where (s.ProdName == btnSearch.Text || s.CodBarras == btnSearch.Text) select s).Count();
            if (stexist > 0)
            {


                var st = (from s in db.TableEstoque where (s.ProdName == btnSearch.Text || s.CodBarras == btnSearch.Text) select s).First();
                atual.Text = st.Atual.ToString();
                min.Text = st.Minimo.ToString();
                quant.Text = st.QuantCotacao.ToString();
                max.Text = st.Maximo.ToString();
                precComp.Text = st.PreCom.ToString();
                precVenda.Text = st.PreVen.ToString();
                valCota.Text = st.ValCotacao.ToString();
                porLucro.Text = st.Lucro.ToString();
                tbProdName.Text = st.ProdName;
                txCodBarras.Text = st.CodBarras;
                tbFab.Text = st.Fabricante;
                tbEnd.Text = st.Endereco;
                tbFone.Text = st.Telefone;
                tbEmail.Text = st.Email;
                codSub.Text = st.CodSubs;
                categoria.Text = st.Categoria;
                unidade.Text = st.Unidade;
                setor.Text = st.Setor;
                fornercedor.Text = st.Fornecedor;
                gunaTextBox4.Text = st.Observação;
                tbVenc.Text = st.Vencimento.ToString();
                dateCot.Text = st.DataCotacao.ToString();

                db.SubmitChanges();
                MessageBox.Show("Dados do Produto carregados, altere com cuidado", "Aviso Importante",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Não exite nenhum produto Com esse nome ou com esse codigo", "Aviso Importante",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int estoqueatual = int.Parse(atual.Text),
            estoqueamin = int.Parse(min.Text),
            quantidade = int.Parse(quant.Text),
            estoquemax = int.Parse(max.Text);


            //                venda = double.Parse(precVenda.Text, CultureInfo.InvariantCulture),
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

            var st = (from s in db.TableEstoque where (s.ProdName == btnSearch.Text || s.CodBarras == btnSearch.Text) select s).First();

            st.CodBarras = codbarras;
            st.Atual = estoqueatual;
            st.Minimo = estoqueamin;
            st.Maximo = estoquemax;
            st.QuantCotacao = quantidade;
            st.PreCom = compra;
            st.PreVen = venda;
            st.ValCotacao = cota;
            st.Lucro = lucro;
            st.Vencimento = vencimento;
            st.DataCotacao = dateCotacao;
            st.ProdName = nomeprod;
            st.Fabricante = fab;
            st.Endereco = end;
            st.Telefone = fone;
            st.Email = email;
            st.CodSubs = codsub;
            st.Categoria = categ;
            st.Unidade = uni;
            st.Setor = setores;
            st.Fornecedor = fornec;
            st.Observação = obs;

            db.SubmitChanges();
            MessageBox.Show("Sucesso ao atualizar produtos do estoque");
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
    }
}
