namespace KencoSaleManagementAsm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupplierM = new System.Windows.Forms.Button();
            this.btnProductM = new System.Windows.Forms.Button();
            this.btnCategoryM = new System.Windows.Forms.Button();
            this.btnCartM = new System.Windows.Forms.Button();
            this.btnOrderM = new System.Windows.Forms.Button();
            this.btnInvoiceM = new System.Windows.Forms.Button();
            this.btnEmployeeM = new System.Windows.Forms.Button();
            this.btnCustomerM = new System.Windows.Forms.Button();
            this.lblNameCompanyM = new System.Windows.Forms.Label();
            this.pnTotalRevenue = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblInThisMonth = new System.Windows.Forms.Label();
            this.lblRevenueMoney = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.plTotalOrder = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTtOrderNum = new System.Windows.Forms.Label();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.pnTotalProduct = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTtProductNum = new System.Windows.Forms.Label();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.pnTotalCustomer = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTtCustomerNum = new System.Windows.Forms.Label();
            this.lblTotalCustomer = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.pnTotalRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.plTotalOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnTotalProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnTotalCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 94);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 32);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "         Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.btnSupplierM);
            this.panel1.Controls.Add(this.btnProductM);
            this.panel1.Controls.Add(this.btnCategoryM);
            this.panel1.Controls.Add(this.btnCartM);
            this.panel1.Controls.Add(this.btnOrderM);
            this.panel1.Controls.Add(this.btnInvoiceM);
            this.panel1.Controls.Add(this.btnEmployeeM);
            this.panel1.Controls.Add(this.btnCustomerM);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblNameCompanyM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 546);
            this.panel1.TabIndex = 0;
            // 
            // btnSupplierM
            // 
            this.btnSupplierM.FlatAppearance.BorderSize = 0;
            this.btnSupplierM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSupplierM.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierM.Image")));
            this.btnSupplierM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierM.Location = new System.Drawing.Point(12, 398);
            this.btnSupplierM.Name = "btnSupplierM";
            this.btnSupplierM.Size = new System.Drawing.Size(149, 32);
            this.btnSupplierM.TabIndex = 0;
            this.btnSupplierM.Text = "         Supplier";
            this.btnSupplierM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplierM.UseVisualStyleBackColor = true;
            // 
            // btnProductM
            // 
            this.btnProductM.FlatAppearance.BorderSize = 0;
            this.btnProductM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProductM.Image = ((System.Drawing.Image)(resources.GetObject("btnProductM.Image")));
            this.btnProductM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductM.Location = new System.Drawing.Point(12, 360);
            this.btnProductM.Name = "btnProductM";
            this.btnProductM.Size = new System.Drawing.Size(149, 32);
            this.btnProductM.TabIndex = 0;
            this.btnProductM.Text = "         Product";
            this.btnProductM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductM.UseVisualStyleBackColor = true;
            // 
            // btnCategoryM
            // 
            this.btnCategoryM.FlatAppearance.BorderSize = 0;
            this.btnCategoryM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCategoryM.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryM.Image")));
            this.btnCategoryM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoryM.Location = new System.Drawing.Point(12, 322);
            this.btnCategoryM.Name = "btnCategoryM";
            this.btnCategoryM.Size = new System.Drawing.Size(149, 32);
            this.btnCategoryM.TabIndex = 0;
            this.btnCategoryM.Text = "         Category";
            this.btnCategoryM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoryM.UseVisualStyleBackColor = true;
            // 
            // btnCartM
            // 
            this.btnCartM.FlatAppearance.BorderSize = 0;
            this.btnCartM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCartM.Image = ((System.Drawing.Image)(resources.GetObject("btnCartM.Image")));
            this.btnCartM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartM.Location = new System.Drawing.Point(12, 284);
            this.btnCartM.Name = "btnCartM";
            this.btnCartM.Size = new System.Drawing.Size(149, 32);
            this.btnCartM.TabIndex = 0;
            this.btnCartM.Text = "         Cart";
            this.btnCartM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCartM.UseVisualStyleBackColor = true;
            // 
            // btnOrderM
            // 
            this.btnOrderM.FlatAppearance.BorderSize = 0;
            this.btnOrderM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrderM.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderM.Image")));
            this.btnOrderM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderM.Location = new System.Drawing.Point(12, 246);
            this.btnOrderM.Name = "btnOrderM";
            this.btnOrderM.Size = new System.Drawing.Size(149, 32);
            this.btnOrderM.TabIndex = 0;
            this.btnOrderM.Text = "         Order";
            this.btnOrderM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderM.UseVisualStyleBackColor = true;
            // 
            // btnInvoiceM
            // 
            this.btnInvoiceM.FlatAppearance.BorderSize = 0;
            this.btnInvoiceM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInvoiceM.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceM.Image")));
            this.btnInvoiceM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceM.Location = new System.Drawing.Point(12, 208);
            this.btnInvoiceM.Name = "btnInvoiceM";
            this.btnInvoiceM.Size = new System.Drawing.Size(149, 32);
            this.btnInvoiceM.TabIndex = 0;
            this.btnInvoiceM.Text = "         Invoice";
            this.btnInvoiceM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoiceM.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeM
            // 
            this.btnEmployeeM.FlatAppearance.BorderSize = 0;
            this.btnEmployeeM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployeeM.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeM.Image")));
            this.btnEmployeeM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeM.Location = new System.Drawing.Point(12, 170);
            this.btnEmployeeM.Name = "btnEmployeeM";
            this.btnEmployeeM.Size = new System.Drawing.Size(149, 32);
            this.btnEmployeeM.TabIndex = 0;
            this.btnEmployeeM.Text = "         Employee";
            this.btnEmployeeM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeM.UseVisualStyleBackColor = true;
            // 
            // btnCustomerM
            // 
            this.btnCustomerM.FlatAppearance.BorderSize = 0;
            this.btnCustomerM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomerM.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerM.Image")));
            this.btnCustomerM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerM.Location = new System.Drawing.Point(12, 132);
            this.btnCustomerM.Name = "btnCustomerM";
            this.btnCustomerM.Size = new System.Drawing.Size(149, 32);
            this.btnCustomerM.TabIndex = 0;
            this.btnCustomerM.Text = "         Customer";
            this.btnCustomerM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerM.UseVisualStyleBackColor = true;
            this.btnCustomerM.Click += new System.EventHandler(this.btnCustomerM_Click);
            // 
            // lblNameCompanyM
            // 
            this.lblNameCompanyM.AutoSize = true;
            this.lblNameCompanyM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompanyM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNameCompanyM.Location = new System.Drawing.Point(40, 30);
            this.lblNameCompanyM.Name = "lblNameCompanyM";
            this.lblNameCompanyM.Size = new System.Drawing.Size(84, 30);
            this.lblNameCompanyM.TabIndex = 1;
            this.lblNameCompanyM.Text = "KENCO";
            // 
            // pnTotalRevenue
            // 
            this.pnTotalRevenue.BackColor = System.Drawing.Color.White;
            this.pnTotalRevenue.Controls.Add(this.pictureBox2);
            this.pnTotalRevenue.Controls.Add(this.lblInThisMonth);
            this.pnTotalRevenue.Controls.Add(this.lblRevenueMoney);
            this.pnTotalRevenue.Controls.Add(this.lblRevenue);
            this.pnTotalRevenue.Location = new System.Drawing.Point(186, 43);
            this.pnTotalRevenue.Name = "pnTotalRevenue";
            this.pnTotalRevenue.Size = new System.Drawing.Size(151, 136);
            this.pnTotalRevenue.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblInThisMonth
            // 
            this.lblInThisMonth.AutoSize = true;
            this.lblInThisMonth.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInThisMonth.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblInThisMonth.Location = new System.Drawing.Point(7, 116);
            this.lblInThisMonth.Name = "lblInThisMonth";
            this.lblInThisMonth.Size = new System.Drawing.Size(68, 13);
            this.lblInThisMonth.TabIndex = 3;
            this.lblInThisMonth.Text = "In this month";
            // 
            // lblRevenueMoney
            // 
            this.lblRevenueMoney.AutoSize = true;
            this.lblRevenueMoney.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueMoney.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRevenueMoney.Location = new System.Drawing.Point(3, 82);
            this.lblRevenueMoney.Name = "lblRevenueMoney";
            this.lblRevenueMoney.Size = new System.Drawing.Size(79, 29);
            this.lblRevenueMoney.TabIndex = 1;
            this.lblRevenueMoney.Text = "121.00";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.Location = new System.Drawing.Point(6, 66);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(69, 12);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "Total Revenue";
            // 
            // plTotalOrder
            // 
            this.plTotalOrder.BackColor = System.Drawing.Color.White;
            this.plTotalOrder.Controls.Add(this.pictureBox3);
            this.plTotalOrder.Controls.Add(this.label1);
            this.plTotalOrder.Controls.Add(this.lblTtOrderNum);
            this.plTotalOrder.Controls.Add(this.lblTotalOrder);
            this.plTotalOrder.Location = new System.Drawing.Point(376, 43);
            this.plTotalOrder.Name = "plTotalOrder";
            this.plTotalOrder.Size = new System.Drawing.Size(151, 136);
            this.plTotalOrder.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(7, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "In this month";
            // 
            // lblTtOrderNum
            // 
            this.lblTtOrderNum.AutoSize = true;
            this.lblTtOrderNum.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtOrderNum.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTtOrderNum.Location = new System.Drawing.Point(4, 82);
            this.lblTtOrderNum.Name = "lblTtOrderNum";
            this.lblTtOrderNum.Size = new System.Drawing.Size(61, 29);
            this.lblTtOrderNum.TabIndex = 1;
            this.lblTtOrderNum.Text = "2379";
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrder.Location = new System.Drawing.Point(6, 66);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Size = new System.Drawing.Size(58, 12);
            this.lblTotalOrder.TabIndex = 0;
            this.lblTotalOrder.Text = "Total Order";
            // 
            // pnTotalProduct
            // 
            this.pnTotalProduct.BackColor = System.Drawing.Color.White;
            this.pnTotalProduct.Controls.Add(this.pictureBox5);
            this.pnTotalProduct.Controls.Add(this.label4);
            this.pnTotalProduct.Controls.Add(this.lblTtProductNum);
            this.pnTotalProduct.Controls.Add(this.lblTotalProduct);
            this.pnTotalProduct.Location = new System.Drawing.Point(566, 43);
            this.pnTotalProduct.Name = "pnTotalProduct";
            this.pnTotalProduct.Size = new System.Drawing.Size(151, 136);
            this.pnTotalProduct.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "In this month";
            // 
            // lblTtProductNum
            // 
            this.lblTtProductNum.AutoSize = true;
            this.lblTtProductNum.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtProductNum.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTtProductNum.Location = new System.Drawing.Point(4, 82);
            this.lblTtProductNum.Name = "lblTtProductNum";
            this.lblTtProductNum.Size = new System.Drawing.Size(61, 29);
            this.lblTtProductNum.TabIndex = 1;
            this.lblTtProductNum.Text = "3456";
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.lblTotalProduct.Location = new System.Drawing.Point(6, 66);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(68, 12);
            this.lblTotalProduct.TabIndex = 0;
            this.lblTotalProduct.Text = "Total Product";
            // 
            // pnTotalCustomer
            // 
            this.pnTotalCustomer.BackColor = System.Drawing.Color.White;
            this.pnTotalCustomer.Controls.Add(this.pictureBox7);
            this.pnTotalCustomer.Controls.Add(this.label7);
            this.pnTotalCustomer.Controls.Add(this.lblTtCustomerNum);
            this.pnTotalCustomer.Controls.Add(this.lblTotalCustomer);
            this.pnTotalCustomer.Location = new System.Drawing.Point(756, 43);
            this.pnTotalCustomer.Name = "pnTotalCustomer";
            this.pnTotalCustomer.Size = new System.Drawing.Size(151, 136);
            this.pnTotalCustomer.TabIndex = 5;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(8, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(7, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "In this month";
            // 
            // lblTtCustomerNum
            // 
            this.lblTtCustomerNum.AutoSize = true;
            this.lblTtCustomerNum.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtCustomerNum.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTtCustomerNum.Location = new System.Drawing.Point(4, 82);
            this.lblTtCustomerNum.Name = "lblTtCustomerNum";
            this.lblTtCustomerNum.Size = new System.Drawing.Size(61, 29);
            this.lblTtCustomerNum.TabIndex = 1;
            this.lblTtCustomerNum.Text = "3000";
            // 
            // lblTotalCustomer
            // 
            this.lblTotalCustomer.AutoSize = true;
            this.lblTotalCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.lblTotalCustomer.Location = new System.Drawing.Point(6, 66);
            this.lblTotalCustomer.Name = "lblTotalCustomer";
            this.lblTotalCustomer.Size = new System.Drawing.Size(75, 12);
            this.lblTotalCustomer.TabIndex = 0;
            this.lblTotalCustomer.Text = "Total Customer";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(187, 208);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Total Revenue";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Total Orders";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Total Customers";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Total Products";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(721, 309);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 546);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pnTotalCustomer);
            this.Controls.Add(this.pnTotalProduct);
            this.Controls.Add(this.plTotalOrder);
            this.Controls.Add(this.pnTotalRevenue);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnTotalRevenue.ResumeLayout(false);
            this.pnTotalRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.plTotalOrder.ResumeLayout(false);
            this.plTotalOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnTotalProduct.ResumeLayout(false);
            this.pnTotalProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnTotalCustomer.ResumeLayout(false);
            this.pnTotalCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInvoiceM;
        private System.Windows.Forms.Button btnEmployeeM;
        private System.Windows.Forms.Button btnCustomerM;
        private System.Windows.Forms.Button btnSupplierM;
        private System.Windows.Forms.Button btnProductM;
        private System.Windows.Forms.Button btnCategoryM;
        private System.Windows.Forms.Button btnCartM;
        private System.Windows.Forms.Button btnOrderM;
        private System.Windows.Forms.Label lblNameCompanyM;
        private System.Windows.Forms.Panel pnTotalRevenue;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblRevenueMoney;
        private System.Windows.Forms.Label lblInThisMonth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel plTotalOrder;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTtOrderNum;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.Panel pnTotalProduct;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTtProductNum;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Panel pnTotalCustomer;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTtCustomerNum;
        private System.Windows.Forms.Label lblTotalCustomer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}