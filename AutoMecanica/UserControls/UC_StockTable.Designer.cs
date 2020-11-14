namespace AutoMecanica.UserControls
{
    partial class UC_StockTable
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preVenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descAplicacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codSubsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCotacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valCotacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantCotacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDBDataSet1 = new AutoMecanica.LoginDBDataSet1();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.tableEstoqueTableAdapter = new AutoMecanica.LoginDBDataSet1TableAdapters.TableEstoqueTableAdapter();
            this.btnSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 608);
            this.panel1.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeight = 19;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codBarrasDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.fabricanteDataGridViewTextBoxColumn,
            this.vencimentoDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.atualDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn,
            this.preComDataGridViewTextBoxColumn,
            this.preVenDataGridViewTextBoxColumn,
            this.lucroDataGridViewTextBoxColumn,
            this.descAplicacaoDataGridViewTextBoxColumn,
            this.codSubsDataGridViewTextBoxColumn,
            this.dataCotacaoDataGridViewTextBoxColumn,
            this.valCotacaoDataGridViewTextBoxColumn,
            this.quantCotacaoDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.observaçãoDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.tableEstoqueBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dataGrid.Location = new System.Drawing.Point(0, 109);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1045, 499);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 19;
            this.dataGrid.ThemeStyle.ReadOnly = true;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 25F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codBarrasDataGridViewTextBoxColumn
            // 
            this.codBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodBarras";
            this.codBarrasDataGridViewTextBoxColumn.FillWeight = 45F;
            this.codBarrasDataGridViewTextBoxColumn.HeaderText = "CodBarras";
            this.codBarrasDataGridViewTextBoxColumn.Name = "codBarrasDataGridViewTextBoxColumn";
            this.codBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBarrasDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.FillWeight = 70F;
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodNameDataGridViewTextBoxColumn.ToolTipText = "null";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.FillWeight = 70F;
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.FillWeight = 25F;
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            this.fabricanteDataGridViewTextBoxColumn.DataPropertyName = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.FillWeight = 50F;
            this.fabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            this.fabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vencimentoDataGridViewTextBoxColumn
            // 
            this.vencimentoDataGridViewTextBoxColumn.DataPropertyName = "Vencimento";
            this.vencimentoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.vencimentoDataGridViewTextBoxColumn.HeaderText = "Vencimento";
            this.vencimentoDataGridViewTextBoxColumn.Name = "vencimentoDataGridViewTextBoxColumn";
            this.vencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // setorDataGridViewTextBoxColumn
            // 
            this.setorDataGridViewTextBoxColumn.DataPropertyName = "Setor";
            this.setorDataGridViewTextBoxColumn.FillWeight = 50F;
            this.setorDataGridViewTextBoxColumn.HeaderText = "Setor";
            this.setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            this.setorDataGridViewTextBoxColumn.ReadOnly = true;
            this.setorDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.FillWeight = 75F;
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 75F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // atualDataGridViewTextBoxColumn
            // 
            this.atualDataGridViewTextBoxColumn.DataPropertyName = "Atual";
            this.atualDataGridViewTextBoxColumn.FillWeight = 25F;
            this.atualDataGridViewTextBoxColumn.HeaderText = "Atual";
            this.atualDataGridViewTextBoxColumn.Name = "atualDataGridViewTextBoxColumn";
            this.atualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.FillWeight = 25F;
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.ReadOnly = true;
            this.minDataGridViewTextBoxColumn.Visible = false;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.FillWeight = 25F;
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxDataGridViewTextBoxColumn.Visible = false;
            // 
            // preComDataGridViewTextBoxColumn
            // 
            this.preComDataGridViewTextBoxColumn.DataPropertyName = "PreCom";
            this.preComDataGridViewTextBoxColumn.FillWeight = 35F;
            this.preComDataGridViewTextBoxColumn.HeaderText = "PreCom";
            this.preComDataGridViewTextBoxColumn.Name = "preComDataGridViewTextBoxColumn";
            this.preComDataGridViewTextBoxColumn.ReadOnly = true;
            this.preComDataGridViewTextBoxColumn.Visible = false;
            // 
            // preVenDataGridViewTextBoxColumn
            // 
            this.preVenDataGridViewTextBoxColumn.DataPropertyName = "PreVen";
            this.preVenDataGridViewTextBoxColumn.FillWeight = 35F;
            this.preVenDataGridViewTextBoxColumn.HeaderText = "PreVen";
            this.preVenDataGridViewTextBoxColumn.Name = "preVenDataGridViewTextBoxColumn";
            this.preVenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lucroDataGridViewTextBoxColumn
            // 
            this.lucroDataGridViewTextBoxColumn.DataPropertyName = "Lucro";
            this.lucroDataGridViewTextBoxColumn.FillWeight = 25F;
            this.lucroDataGridViewTextBoxColumn.HeaderText = "Lucro";
            this.lucroDataGridViewTextBoxColumn.Name = "lucroDataGridViewTextBoxColumn";
            this.lucroDataGridViewTextBoxColumn.ReadOnly = true;
            this.lucroDataGridViewTextBoxColumn.Visible = false;
            // 
            // descAplicacaoDataGridViewTextBoxColumn
            // 
            this.descAplicacaoDataGridViewTextBoxColumn.DataPropertyName = "DescAplicacao";
            this.descAplicacaoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.descAplicacaoDataGridViewTextBoxColumn.HeaderText = "DescAplicacao";
            this.descAplicacaoDataGridViewTextBoxColumn.Name = "descAplicacaoDataGridViewTextBoxColumn";
            this.descAplicacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descAplicacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codSubsDataGridViewTextBoxColumn
            // 
            this.codSubsDataGridViewTextBoxColumn.DataPropertyName = "CodSubs";
            this.codSubsDataGridViewTextBoxColumn.FillWeight = 25F;
            this.codSubsDataGridViewTextBoxColumn.HeaderText = "CodSubs";
            this.codSubsDataGridViewTextBoxColumn.Name = "codSubsDataGridViewTextBoxColumn";
            this.codSubsDataGridViewTextBoxColumn.ReadOnly = true;
            this.codSubsDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataCotacaoDataGridViewTextBoxColumn
            // 
            this.dataCotacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCotacao";
            this.dataCotacaoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dataCotacaoDataGridViewTextBoxColumn.HeaderText = "DataCotacao";
            this.dataCotacaoDataGridViewTextBoxColumn.Name = "dataCotacaoDataGridViewTextBoxColumn";
            this.dataCotacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCotacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // valCotacaoDataGridViewTextBoxColumn
            // 
            this.valCotacaoDataGridViewTextBoxColumn.DataPropertyName = "ValCotacao";
            this.valCotacaoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.valCotacaoDataGridViewTextBoxColumn.HeaderText = "ValCotacao";
            this.valCotacaoDataGridViewTextBoxColumn.Name = "valCotacaoDataGridViewTextBoxColumn";
            this.valCotacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valCotacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantCotacaoDataGridViewTextBoxColumn
            // 
            this.quantCotacaoDataGridViewTextBoxColumn.DataPropertyName = "QuantCotacao";
            this.quantCotacaoDataGridViewTextBoxColumn.FillWeight = 25F;
            this.quantCotacaoDataGridViewTextBoxColumn.HeaderText = "QuantCotacao";
            this.quantCotacaoDataGridViewTextBoxColumn.Name = "quantCotacaoDataGridViewTextBoxColumn";
            this.quantCotacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantCotacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.FillWeight = 50F;
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observaçãoDataGridViewTextBoxColumn
            // 
            this.observaçãoDataGridViewTextBoxColumn.DataPropertyName = "Observação";
            this.observaçãoDataGridViewTextBoxColumn.FillWeight = 70F;
            this.observaçãoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observaçãoDataGridViewTextBoxColumn.Name = "observaçãoDataGridViewTextBoxColumn";
            this.observaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableEstoqueBindingSource
            // 
            this.tableEstoqueBindingSource.DataMember = "TableEstoque";
            this.tableEstoqueBindingSource.DataSource = this.loginDBDataSet1;
            // 
            // loginDBDataSet1
            // 
            this.loginDBDataSet1.DataSetName = "LoginDBDataSet1";
            this.loginDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnDel);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1045, 109);
            this.panelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 63);
            this.label1.TabIndex = 60;
            this.label1.Text = "Use o Campo de texto ao lado para \r\npesquisar um produto no estoque e\r\nvisualizal" +
    "o na tabela abaixo\r\n";
            // 
            // btnDel
            // 
            this.btnDel.BorderRadius = 8;
            this.btnDel.CheckedState.Parent = this.btnDel;
            this.btnDel.CustomImages.Image = global::AutoMecanica.Properties.Resources.trash_32px;
            this.btnDel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDel.CustomImages.Parent = this.btnDel;
            this.btnDel.FillColor = System.Drawing.Color.Red;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(170)))));
            this.btnDel.HoverState.Parent = this.btnDel;
            this.btnDel.Location = new System.Drawing.Point(775, 32);
            this.btnDel.Name = "btnDel";
            this.btnDel.ShadowDecoration.Parent = this.btnDel;
            this.btnDel.Size = new System.Drawing.Size(159, 33);
            this.btnDel.TabIndex = 59;
            this.btnDel.Text = "Apagar";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tableEstoqueTableAdapter
            // 
            this.tableEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSearch.DefaultText = "";
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnSearch.DisabledState.Parent = this.btnSearch;
            this.btnSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.FocusedState.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.IconRight = global::AutoMecanica.Properties.Resources.search_64px;
            this.btnSearch.Location = new System.Drawing.Point(369, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PasswordChar = '\0';
            this.btnSearch.PlaceholderText = "Pesquisar por Nome";
            this.btnSearch.SelectedText = "";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(371, 28);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.TextChanged += new System.EventHandler(this.btnSearch_TextChanged);
            // 
            // UC_StockTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_StockTable";
            this.Size = new System.Drawing.Size(1045, 608);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private System.Windows.Forms.BindingSource tableEstoqueBindingSource;
        private LoginDBDataSet1 loginDBDataSet1;
        private LoginDBDataSet1TableAdapters.TableEstoqueTableAdapter tableEstoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preVenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lucroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descAplicacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSubsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCotacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valCotacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantCotacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2TextBox btnSearch;
        private System.Windows.Forms.Label label1;
    }
}
