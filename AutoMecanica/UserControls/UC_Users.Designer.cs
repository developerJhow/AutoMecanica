namespace AutoMecanica.UserControls
{
    partial class UC_Users
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
            this.panelBack = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEnd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnDados = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelBack.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.Transparent;
            this.panelBack.Controls.Add(this.panel2);
            this.panelBack.Controls.Add(this.panel1);
            this.panelBack.Controls.Add(this.panelMenu);
            this.panelBack.Controls.Add(this.panelTitle);
            this.panelBack.Location = new System.Drawing.Point(4, 4);
            this.panelBack.Margin = new System.Windows.Forms.Padding(4);
            this.panelBack.Name = "panelBack";
            this.panelBack.ShadowDecoration.Parent = this.panelBack;
            this.panelBack.Size = new System.Drawing.Size(1037, 653);
            this.panelBack.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 514);
            this.panel1.TabIndex = 20;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.btnEnd);
            this.panelMenu.Controls.Add(this.guna2VSeparator1);
            this.panelMenu.Controls.Add(this.btnDados);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 31);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1037, 39);
            this.panelMenu.TabIndex = 19;
            // 
            // btnEnd
            // 
            this.btnEnd.CheckedState.Parent = this.btnEnd;
            this.btnEnd.CustomImages.Parent = this.btnEnd;
            this.btnEnd.FillColor = System.Drawing.Color.Transparent;
            this.btnEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.HoverState.Parent = this.btnEnd;
            this.btnEnd.Location = new System.Drawing.Point(187, 9);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.PressedColor = System.Drawing.Color.Transparent;
            this.btnEnd.ShadowDecoration.Parent = this.btnEnd;
            this.btnEnd.Size = new System.Drawing.Size(162, 32);
            this.btnEnd.TabIndex = 21;
            this.btnEnd.Text = "Endereço";
            this.btnEnd.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(171, 9);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 29);
            this.guna2VSeparator1.TabIndex = 20;
            // 
            // btnDados
            // 
            this.btnDados.CheckedState.Parent = this.btnDados;
            this.btnDados.CustomImages.Parent = this.btnDados;
            this.btnDados.FillColor = System.Drawing.Color.Transparent;
            this.btnDados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDados.ForeColor = System.Drawing.Color.White;
            this.btnDados.HoverState.Parent = this.btnDados;
            this.btnDados.Location = new System.Drawing.Point(3, 9);
            this.btnDados.Name = "btnDados";
            this.btnDados.ShadowDecoration.Parent = this.btnDados;
            this.btnDados.Size = new System.Drawing.Size(162, 32);
            this.btnDados.TabIndex = 18;
            this.btnDados.Text = "Dados Basicos";
            this.btnDados.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelTitle.Controls.Add(this.guna2TextBox1);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1037, 31);
            this.panelTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Pesquisar";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconRight = global::AutoMecanica.Properties.Resources.search_64px;
            this.guna2TextBox1.Location = new System.Drawing.Point(835, 7);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 9;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(178, 20);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 55);
            this.panel2.TabIndex = 21;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Image = global::AutoMecanica.Properties.Resources.save_32px_white;
            this.guna2Button2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(170)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(561, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(154, 33);
            this.guna2Button2.TabIndex = 20;
            this.guna2Button2.Text = "Salvar";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(381, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(154, 33);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "Cancelar";
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panelBack);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(1045, 661);
            this.panelBack.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitle;
        private Guna.UI2.WinForms.Guna2Button btnDados;
        private System.Windows.Forms.Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Button btnEnd;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
