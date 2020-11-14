using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.NET;
using System.Web.Mvc;
using ViaCep;

namespace AutoMecanica.UserControls
{
    public partial class UC_UsersDados : UserControl
    {
        public UC_UsersDados()
        {
            InitializeComponent();            
        }
        ProgrammingClassDataContext db = new ProgrammingClassDataContext();

        public class HomeController : AsyncController
        {

        }
        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txtPessoa.SelectedIndex == 1)
            {
                lblNomeClient.Text = "Nome completo do Responsavel";
                txtInsEst.Visible = true;
                lblInsEst.Visible = true;
                lblCnpj.Visible = true;
                txtCnpj.Visible = true;
                lblNf.Visible = true;
                txtNf.Visible = true;
            }
            if (txtPessoa.SelectedIndex == 0)
            {
                txtInsEst.Visible = false;
                lblInsEst.Visible = false;
                lblCnpj.Visible = false;
                txtCnpj.Visible = false;
                lblNf.Visible = false;
                txtNf.Visible = false;
            }
        }

        private void panelDados_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txtLimpar_Click(object sender, EventArgs e)
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

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {

                var result = new ViaCepClient().Search(txtCep.Text); //searches for the postal code 01001-000
                var zip = result.ZipCode;
                if (zip != null)
                {
                    var estado = result.StateInitials; //Praça da Sé
                    var city = result.City; //São Paulo
                    var bairro = result.Neighborhood;
                    var rua = result.Street;
                    txtEstado.Text = estado;
                    txtCidade.Text = city;
                    txtBairro.Text = bairro;
                    txtRua.Text = rua;
                }
                else
                {
                    MessageBox.Show("Cep não localizado...");
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            string username = txtName.Text,
                cpf = txtCpf.Text,
                situacao = txtSituacao.Text,
                pessoa = txtPessoa.Text,
                rg = txtRg.Text,
                icms = txtIcms.Text,
                telefon = txtTel.Text,
                email = txtEmail.Text,
                estado = txtEstado.Text,
                cidade = txtCidade.Text,
                cep = txtCep.Text,
                bairro = txtBairro.Text,
                rua = txtRua.Text,
                numero = txtNum.Text,
                complemento = txtComp.Text,
                insestadual = txtInsEst.Text,
                cnpj = txtCnpj.Text,
                nomefantasia = txtNf.Text,
                obs = txtObs.Text;



            DateTime nascimento = DateTime.Parse(dataNasc.Text);

            var st = new TbUsers
            {
                UserName = username,
                UserCpf = cpf,
                UserPessoa = pessoa,
                UserSituacao = situacao,
                UserNasc = nascimento,
                UserRg = rg,
                UserIcms = icms,
                UserTel = telefon,
                UserEmail = email,
                UserEst = estado,
                UserCid = cidade,
                UserBairro = bairro,
                UserRua = rua,
                UserCep = cep,
                UserNumero = numero,
                UserCompl = complemento,
                InsEstadual = insestadual,
                Cnpj = cnpj,
                NomeFantasia = nomefantasia,
                Observação = obs
            };
            db.TbUsers.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Sucesso ao adicionar produto ao estoque");
        }
    }
}
