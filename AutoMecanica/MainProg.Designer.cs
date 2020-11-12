namespace AutoMecanica
{
    partial class MainProg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnClientes = new Guna.UI2.WinForms.Guna2Button();
            this.btnVeiculos = new Guna.UI2.WinForms.Guna2Button();
            this.btnServices = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinance = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnEstoque = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 661);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel3.Controls.Add(this.btnEstoque);
            this.panel3.Controls.Add(this.btnFinance);
            this.panel3.Controls.Add(this.btnServices);
            this.panel3.Controls.Add(this.btnVeiculos);
            this.panel3.Controls.Add(this.btnClientes);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 661);
            this.panel3.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 18;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.CheckedImage = global::AutoMecanica.Properties.Resources.home_64pxb_blue;
            this.btnHome.CustomImages.HoveredImage = global::AutoMecanica.Properties.Resources.home_64pxb_blue;
            this.btnHome.CustomImages.Image = global::AutoMecanica.Properties.Resources.home_64px;
            this.btnHome.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(41, 192);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(163, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Inicio";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BorderRadius = 18;
            this.btnClientes.CheckedState.Parent = this.btnClientes;
            this.btnClientes.CustomImages.CheckedImage = global::AutoMecanica.Properties.Resources.user_64px_blue;
            this.btnClientes.CustomImages.HoveredImage = global::AutoMecanica.Properties.Resources.user_64px_blue;
            this.btnClientes.CustomImages.Image = global::AutoMecanica.Properties.Resources.user_64px;
            this.btnClientes.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClientes.CustomImages.Parent = this.btnClientes;
            this.btnClientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnClientes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnClientes.HoverState.Parent = this.btnClientes;
            this.btnClientes.Location = new System.Drawing.Point(41, 246);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ShadowDecoration.Parent = this.btnClientes;
            this.btnClientes.Size = new System.Drawing.Size(163, 45);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.BorderRadius = 18;
            this.btnVeiculos.CheckedState.Parent = this.btnVeiculos;
            this.btnVeiculos.CustomImages.CheckedImage = global::AutoMecanica.Properties.Resources.car_64px_blue;
            this.btnVeiculos.CustomImages.HoveredImage = global::AutoMecanica.Properties.Resources.car_64px_blue;
            this.btnVeiculos.CustomImages.Image = global::AutoMecanica.Properties.Resources.car_64px;
            this.btnVeiculos.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVeiculos.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnVeiculos.CustomImages.Parent = this.btnVeiculos;
            this.btnVeiculos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnVeiculos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculos.ForeColor = System.Drawing.Color.White;
            this.btnVeiculos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnVeiculos.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnVeiculos.HoverState.Parent = this.btnVeiculos;
            this.btnVeiculos.Location = new System.Drawing.Point(41, 462);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.ShadowDecoration.Parent = this.btnVeiculos;
            this.btnVeiculos.Size = new System.Drawing.Size(163, 45);
            this.btnVeiculos.TabIndex = 2;
            this.btnVeiculos.Text = "Veiculos";
            // 
            // btnServices
            // 
            this.btnServices.BorderRadius = 18;
            this.btnServices.CheckedState.Parent = this.btnServices;
            this.btnServices.CustomImages.CheckedImage = global::AutoMecanica.Properties.Resources.services_64px_blue;
            this.btnServices.CustomImages.HoveredImage = global::AutoMecanica.Properties.Resources.services_64px_blue;
            this.btnServices.CustomImages.Image = global::AutoMecanica.Properties.Resources.services_64px;
            this.btnServices.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnServices.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnServices.CustomImages.Parent = this.btnServices;
            this.btnServices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnServices.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnServices.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnServices.HoverState.Parent = this.btnServices;
            this.btnServices.Location = new System.Drawing.Point(41, 354);
            this.btnServices.Name = "btnServices";
            this.btnServices.ShadowDecoration.Parent = this.btnServices;
            this.btnServices.Size = new System.Drawing.Size(163, 45);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Serviços";
            // 
            // btnFinance
            // 
            this.btnFinance.BorderRadius = 18;
            this.btnFinance.CheckedState.Parent = this.btnFinance;
            this.btnFinance.CustomImages.CheckedImage = global::AutoMecanica.Properties.Resources.money_64px_blue;
            this.btnFinance.CustomImages.HoveredImage = global::AutoMecanica.Properties.Resources.money_64px_blue;
            this.btnFinance.CustomImages.Image = global::AutoMecanica.Properties.Resources.money_64px;
            this.btnFinance.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFinance.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFinance.CustomImages.Parent = this.btnFinance;
            this.btnFinance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnFinance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.ForeColor = System.Drawing.Color.White;
            this.btnFinance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnFinance.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnFinance.HoverState.Parent = this.btnFinance;
            this.btnFinance.Location = new System.Drawing.Point(41, 408);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.ShadowDecoration.Parent = this.btnFinance;
            this.btnFinance.Size = new System.Drawing.Size(163, 45);
            this.btnFinance.TabIndex = 4;
            this.btnFinance.Text = "Financeiro";
            this.btnFinance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.AutoSize = true;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(242, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1045, 661);
            this.panelContainer.TabIndex = 1;
            // 
            // btnEstoque
            // 
            this.btnEstoque.BorderRadius = 18;
            this.btnEstoque.CheckedState.Parent = this.btnEstoque;
            this.btnEstoque.CustomImages.CheckedImage = global::AutoMecanica.Properties.Resources.out_of_stock_64px_blue;
            this.btnEstoque.CustomImages.HoveredImage = global::AutoMecanica.Properties.Resources.out_of_stock_64px_blue;
            this.btnEstoque.CustomImages.Image = global::AutoMecanica.Properties.Resources.out_of_stock_64px;
            this.btnEstoque.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEstoque.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEstoque.CustomImages.Parent = this.btnEstoque;
            this.btnEstoque.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnEstoque.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btnEstoque.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEstoque.HoverState.Parent = this.btnEstoque;
            this.btnEstoque.Location = new System.Drawing.Point(41, 300);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.ShadowDecoration.Parent = this.btnEstoque;
            this.btnEstoque.Size = new System.Drawing.Size(163, 45);
            this.btnEstoque.TabIndex = 5;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // MainProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1287, 661);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(198)))), ((int)(((byte)(212)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainProg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Mecanica";
            this.Load += new System.EventHandler(this.MainProg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnFinance;
        private Guna.UI2.WinForms.Guna2Button btnServices;
        private Guna.UI2.WinForms.Guna2Button btnVeiculos;
        private Guna.UI2.WinForms.Guna2Button btnClientes;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnEstoque;
    }
}