namespace AutoMecanica.UserControls
{
    partial class UC_UsersDados
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelConteinerBg = new System.Windows.Forms.Panel();
            this.panelDados = new System.Windows.Forms.Panel();
            this.dataNasc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNf = new Guna.UI.WinForms.GunaTextBox();
            this.lblNf = new System.Windows.Forms.Label();
            this.gunaTextBox15 = new Guna.UI.WinForms.GunaTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtCnpj = new Guna.UI.WinForms.GunaTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.gunaTextBox5 = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.lblNomeClient = new System.Windows.Forms.Label();
            this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblIcms = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelConteinerBg.SuspendLayout();
            this.panelDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConteinerBg
            // 
            this.panelConteinerBg.Controls.Add(this.panelDados);
            this.panelConteinerBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteinerBg.Location = new System.Drawing.Point(0, 0);
            this.panelConteinerBg.Name = "panelConteinerBg";
            this.panelConteinerBg.Size = new System.Drawing.Size(1031, 514);
            this.panelConteinerBg.TabIndex = 0;
            // 
            // panelDados
            // 
            this.panelDados.BackColor = System.Drawing.Color.Transparent;
            this.panelDados.Controls.Add(this.dataNasc);
            this.panelDados.Controls.Add(this.txtNf);
            this.panelDados.Controls.Add(this.lblNf);
            this.panelDados.Controls.Add(this.gunaTextBox15);
            this.panelDados.Controls.Add(this.lblRg);
            this.panelDados.Controls.Add(this.txtCnpj);
            this.panelDados.Controls.Add(this.lblCnpj);
            this.panelDados.Controls.Add(this.gunaTextBox5);
            this.panelDados.Controls.Add(this.label10);
            this.panelDados.Controls.Add(this.lblDataNasc);
            this.panelDados.Controls.Add(this.gunaTextBox3);
            this.panelDados.Controls.Add(this.label8);
            this.panelDados.Controls.Add(this.gunaTextBox2);
            this.panelDados.Controls.Add(this.lblCpf);
            this.panelDados.Controls.Add(this.gunaTextBox1);
            this.panelDados.Controls.Add(this.lblNomeClient);
            this.panelDados.Controls.Add(this.guna2ComboBox3);
            this.panelDados.Controls.Add(this.lblIcms);
            this.panelDados.Controls.Add(this.guna2ComboBox2);
            this.panelDados.Controls.Add(this.lblSituacao);
            this.panelDados.Controls.Add(this.guna2ComboBox1);
            this.panelDados.Controls.Add(this.lblPessoa);
            this.panelDados.Controls.Add(this.guna2Separator1);
            this.panelDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDados.Location = new System.Drawing.Point(0, 0);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(1031, 514);
            this.panelDados.TabIndex = 6;
            // 
            // dataNasc
            // 
            this.dataNasc.CheckedState.Parent = this.dataNasc;
            this.dataNasc.CustomFormat = "DD-MM-AAAA";
            this.dataNasc.FillColor = System.Drawing.Color.Transparent;
            this.dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNasc.HoverState.Parent = this.dataNasc;
            this.dataNasc.Location = new System.Drawing.Point(675, 182);
            this.dataNasc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dataNasc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.ShadowDecoration.Parent = this.dataNasc;
            this.dataNasc.Size = new System.Drawing.Size(147, 36);
            this.dataNasc.TabIndex = 26;
            this.dataNasc.Value = new System.DateTime(2020, 11, 12, 0, 0, 0, 0);
            // 
            // txtNf
            // 
            this.txtNf.AccessibleDescription = "CNPJ";
            this.txtNf.AccessibleName = "CNPJ";
            this.txtNf.BackColor = System.Drawing.Color.Transparent;
            this.txtNf.BaseColor = System.Drawing.Color.White;
            this.txtNf.BorderColor = System.Drawing.Color.Silver;
            this.txtNf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNf.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNf.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNf.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNf.ForeColor = System.Drawing.Color.Black;
            this.txtNf.Location = new System.Drawing.Point(589, 269);
            this.txtNf.Name = "txtNf";
            this.txtNf.PasswordChar = '\0';
            this.txtNf.Radius = 6;
            this.txtNf.SelectedText = "";
            this.txtNf.Size = new System.Drawing.Size(266, 30);
            this.txtNf.TabIndex = 25;
            this.txtNf.Visible = false;
            // 
            // lblNf
            // 
            this.lblNf.AutoSize = true;
            this.lblNf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNf.Location = new System.Drawing.Point(586, 230);
            this.lblNf.Name = "lblNf";
            this.lblNf.Size = new System.Drawing.Size(128, 21);
            this.lblNf.TabIndex = 24;
            this.lblNf.Text = "Nome Fantasia";
            this.lblNf.Visible = false;
            // 
            // gunaTextBox15
            // 
            this.gunaTextBox15.AccessibleDescription = "CPF";
            this.gunaTextBox15.AccessibleName = "CPF";
            this.gunaTextBox15.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox15.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox15.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox15.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox15.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox15.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox15.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox15.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox15.Location = new System.Drawing.Point(508, 182);
            this.gunaTextBox15.Name = "gunaTextBox15";
            this.gunaTextBox15.PasswordChar = '\0';
            this.gunaTextBox15.Radius = 6;
            this.gunaTextBox15.SelectedText = "";
            this.gunaTextBox15.Size = new System.Drawing.Size(142, 30);
            this.gunaTextBox15.TabIndex = 23;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRg.Location = new System.Drawing.Point(505, 143);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 21);
            this.lblRg.TabIndex = 22;
            this.lblRg.Text = "RG";
            // 
            // txtCnpj
            // 
            this.txtCnpj.AccessibleDescription = "CNPJ";
            this.txtCnpj.AccessibleName = "CNPJ";
            this.txtCnpj.BackColor = System.Drawing.Color.Transparent;
            this.txtCnpj.BaseColor = System.Drawing.Color.White;
            this.txtCnpj.BorderColor = System.Drawing.Color.Silver;
            this.txtCnpj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCnpj.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCnpj.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCnpj.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCnpj.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCnpj.ForeColor = System.Drawing.Color.Black;
            this.txtCnpj.Location = new System.Drawing.Point(403, 269);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.PasswordChar = '\0';
            this.txtCnpj.Radius = 6;
            this.txtCnpj.SelectedText = "";
            this.txtCnpj.Size = new System.Drawing.Size(142, 30);
            this.txtCnpj.TabIndex = 21;
            this.txtCnpj.Visible = false;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCnpj.Location = new System.Drawing.Point(400, 230);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(52, 21);
            this.lblCnpj.TabIndex = 20;
            this.lblCnpj.Text = "CNPJ";
            this.lblCnpj.Visible = false;
            // 
            // gunaTextBox5
            // 
            this.gunaTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox5.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox5.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox5.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox5.Location = new System.Drawing.Point(33, 342);
            this.gunaTextBox5.Multiline = true;
            this.gunaTextBox5.Name = "gunaTextBox5";
            this.gunaTextBox5.PasswordChar = '\0';
            this.gunaTextBox5.Radius = 6;
            this.gunaTextBox5.SelectedText = "";
            this.gunaTextBox5.Size = new System.Drawing.Size(493, 130);
            this.gunaTextBox5.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(40, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Observação";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDataNasc.Location = new System.Drawing.Point(671, 143);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(94, 21);
            this.lblDataNasc.TabIndex = 14;
            this.lblDataNasc.Text = "Data Nasc";
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox3.Location = new System.Drawing.Point(33, 267);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 6;
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(337, 30);
            this.gunaTextBox3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(37, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Inc. Estadual";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.AccessibleDescription = "CPF";
            this.gunaTextBox2.AccessibleName = "CPF";
            this.gunaTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox2.Location = new System.Drawing.Point(352, 182);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 6;
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(142, 30);
            this.gunaTextBox2.TabIndex = 11;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCpf.Location = new System.Drawing.Point(349, 143);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 21);
            this.lblCpf.TabIndex = 10;
            this.lblCpf.Text = "CPF";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox1.Location = new System.Drawing.Point(37, 182);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 6;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(284, 30);
            this.gunaTextBox1.TabIndex = 9;
            // 
            // lblNomeClient
            // 
            this.lblNomeClient.AutoSize = true;
            this.lblNomeClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNomeClient.Location = new System.Drawing.Point(33, 143);
            this.lblNomeClient.Name = "lblNomeClient";
            this.lblNomeClient.Size = new System.Drawing.Size(140, 21);
            this.lblNomeClient.TabIndex = 8;
            this.lblNomeClient.Text = "Nome Completo";
            // 
            // guna2ComboBox3
            // 
            this.guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox3.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox3.FocusedState.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox3.FormattingEnabled = true;
            this.guna2ComboBox3.HoverState.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.ItemHeight = 30;
            this.guna2ComboBox3.Items.AddRange(new object[] {
            "Contribuinte",
            "Isento",
            "Não Contrinuinte",
            "Exterior"});
            this.guna2ComboBox3.ItemsAppearance.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.Location = new System.Drawing.Point(433, 73);
            this.guna2ComboBox3.Name = "guna2ComboBox3";
            this.guna2ComboBox3.ShadowDecoration.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox3.StartIndex = 0;
            this.guna2ComboBox3.TabIndex = 7;
            // 
            // lblIcms
            // 
            this.lblIcms.AutoSize = true;
            this.lblIcms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIcms.Location = new System.Drawing.Point(429, 39);
            this.lblIcms.Name = "lblIcms";
            this.lblIcms.Size = new System.Drawing.Size(51, 21);
            this.lblIcms.TabIndex = 6;
            this.lblIcms.Text = "ICMS";
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.FormattingEnabled = true;
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(248, 75);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.TabIndex = 5;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSituacao.Location = new System.Drawing.Point(244, 41);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(80, 21);
            this.lblSituacao.TabIndex = 4;
            this.lblSituacao.Text = "Situação";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(38, 75);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 3;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged_1);
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPessoa.Location = new System.Drawing.Point(33, 41);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(62, 21);
            this.lblPessoa.TabIndex = 2;
            this.lblPessoa.Text = "Pessoa";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(13, 18);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1012, 10);
            this.guna2Separator1.TabIndex = 1;
            // 
            // UC_UsersDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panelConteinerBg);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_UsersDados";
            this.Size = new System.Drawing.Size(1031, 514);
            this.panelConteinerBg.ResumeLayout(false);
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConteinerBg;
        private System.Windows.Forms.Panel panelDados;
        private Guna.UI2.WinForms.Guna2DateTimePicker dataNasc;
        private Guna.UI.WinForms.GunaTextBox txtNf;
        private System.Windows.Forms.Label lblNf;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox15;
        private System.Windows.Forms.Label lblRg;
        private Guna.UI.WinForms.GunaTextBox txtCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDataNasc;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private System.Windows.Forms.Label lblCpf;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.Label lblNomeClient;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
        private System.Windows.Forms.Label lblIcms;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.Label lblSituacao;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label lblPessoa;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
