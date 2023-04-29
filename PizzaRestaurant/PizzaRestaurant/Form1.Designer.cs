namespace PizzaRestaurant;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBox1 = new GroupBox();
        boxCouriersState = new GroupBox();
        label5 = new Label();
        tbNumCourier = new TextBox();
        btnAcceptCor = new Button();
        btnChangeStates = new Button();
        boxKithcenState = new GroupBox();
        label4 = new Label();
        tbNumProd = new TextBox();
        btnAcceptProd = new Button();
        btnAddEntries = new Button();
        boxCourierAdd = new GroupBox();
        tbNameCourier = new TextBox();
        label3 = new Label();
        btnAddCourier = new Button();
        boxProductAdd = new GroupBox();
        tbNameProduct = new TextBox();
        label2 = new Label();
        btnAddProduct = new Button();
        boxClientAdd = new GroupBox();
        tbNameClient = new TextBox();
        label1 = new Label();
        btnAddClient = new Button();
        groupBox2 = new GroupBox();
        btnDelCourier = new Button();
        btnDelProduct = new Button();
        btnDelClient = new Button();
        btnRefresh = new Button();
        lbCourier = new Label();
        lbProduct = new Label();
        lbClient = new Label();
        label8 = new Label();
        label7 = new Label();
        label6 = new Label();
        btnProductsView = new Button();
        btnCouriersView = new Button();
        btnClientView = new Button();
        dataProducts = new DataGridView();
        dataCouriers = new DataGridView();
        dataClients = new DataGridView();
        groupBox1.SuspendLayout();
        boxCouriersState.SuspendLayout();
        boxKithcenState.SuspendLayout();
        boxCourierAdd.SuspendLayout();
        boxProductAdd.SuspendLayout();
        boxClientAdd.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataCouriers).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataClients).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(boxCouriersState);
        groupBox1.Controls.Add(btnChangeStates);
        groupBox1.Controls.Add(boxKithcenState);
        groupBox1.Controls.Add(btnAddEntries);
        groupBox1.Controls.Add(boxCourierAdd);
        groupBox1.Controls.Add(boxProductAdd);
        groupBox1.Controls.Add(boxClientAdd);
        groupBox1.Location = new Point(14, 16);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(471, 635);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Функции и состояния";
        // 
        // boxCouriersState
        // 
        boxCouriersState.Controls.Add(label5);
        boxCouriersState.Controls.Add(tbNumCourier);
        boxCouriersState.Controls.Add(btnAcceptCor);
        boxCouriersState.Location = new Point(7, 188);
        boxCouriersState.Margin = new Padding(3, 4, 3, 4);
        boxCouriersState.Name = "boxCouriersState";
        boxCouriersState.Padding = new Padding(3, 4, 3, 4);
        boxCouriersState.Size = new Size(274, 144);
        boxCouriersState.TabIndex = 7;
        boxCouriersState.TabStop = false;
        boxCouriersState.Text = "Курьеры";
        boxCouriersState.Visible = false;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(15, 33);
        label5.Name = "label5";
        label5.Size = new Size(121, 20);
        label5.TabIndex = 2;
        label5.Text = "Исполнитель№:";
        // 
        // tbNumCourier
        // 
        tbNumCourier.Location = new Point(145, 30);
        tbNumCourier.Margin = new Padding(3, 4, 3, 4);
        tbNumCourier.Name = "tbNumCourier";
        tbNumCourier.Size = new Size(107, 27);
        tbNumCourier.TabIndex = 1;
        // 
        // btnAcceptCor
        // 
        btnAcceptCor.Location = new Point(15, 82);
        btnAcceptCor.Margin = new Padding(3, 4, 3, 4);
        btnAcceptCor.Name = "btnAcceptCor";
        btnAcceptCor.Size = new Size(237, 31);
        btnAcceptCor.TabIndex = 0;
        btnAcceptCor.Text = "Принять заказ";
        btnAcceptCor.UseVisualStyleBackColor = true;
        btnAcceptCor.Click += btnAcceptCor_Click;
        // 
        // btnChangeStates
        // 
        btnChangeStates.Location = new Point(238, 596);
        btnChangeStates.Margin = new Padding(3, 4, 3, 4);
        btnChangeStates.Name = "btnChangeStates";
        btnChangeStates.Size = new Size(207, 31);
        btnChangeStates.TabIndex = 3;
        btnChangeStates.Text = "Изменение состояний";
        btnChangeStates.UseVisualStyleBackColor = true;
        btnChangeStates.Click += btnChangeStates_Click;
        // 
        // boxKithcenState
        // 
        boxKithcenState.Controls.Add(label4);
        boxKithcenState.Controls.Add(tbNumProd);
        boxKithcenState.Controls.Add(btnAcceptProd);
        boxKithcenState.Location = new Point(7, 28);
        boxKithcenState.Margin = new Padding(3, 4, 3, 4);
        boxKithcenState.Name = "boxKithcenState";
        boxKithcenState.Padding = new Padding(3, 4, 3, 4);
        boxKithcenState.Size = new Size(274, 152);
        boxKithcenState.TabIndex = 2;
        boxKithcenState.TabStop = false;
        boxKithcenState.Text = "Кухня";
        boxKithcenState.Visible = false;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(15, 33);
        label4.Name = "label4";
        label4.Size = new Size(86, 20);
        label4.TabIndex = 2;
        label4.Text = "Продукт№:";
        // 
        // tbNumProd
        // 
        tbNumProd.Location = new Point(145, 33);
        tbNumProd.Margin = new Padding(3, 4, 3, 4);
        tbNumProd.Name = "tbNumProd";
        tbNumProd.Size = new Size(107, 27);
        tbNumProd.TabIndex = 1;
        // 
        // btnAcceptProd
        // 
        btnAcceptProd.Location = new Point(15, 89);
        btnAcceptProd.Margin = new Padding(3, 4, 3, 4);
        btnAcceptProd.Name = "btnAcceptProd";
        btnAcceptProd.Size = new Size(237, 31);
        btnAcceptProd.TabIndex = 0;
        btnAcceptProd.Text = "Принять заказ";
        btnAcceptProd.UseVisualStyleBackColor = true;
        btnAcceptProd.Click += btnAcceptProd_Click;
        // 
        // btnAddEntries
        // 
        btnAddEntries.Location = new Point(7, 596);
        btnAddEntries.Margin = new Padding(3, 4, 3, 4);
        btnAddEntries.Name = "btnAddEntries";
        btnAddEntries.Size = new Size(207, 31);
        btnAddEntries.TabIndex = 2;
        btnAddEntries.Text = "Добавление записей";
        btnAddEntries.UseVisualStyleBackColor = true;
        btnAddEntries.Click += btnAddEntries_Click;
        // 
        // boxCourierAdd
        // 
        boxCourierAdd.Controls.Add(tbNameCourier);
        boxCourierAdd.Controls.Add(label3);
        boxCourierAdd.Controls.Add(btnAddCourier);
        boxCourierAdd.Location = new Point(7, 260);
        boxCourierAdd.Margin = new Padding(3, 4, 3, 4);
        boxCourierAdd.Name = "boxCourierAdd";
        boxCourierAdd.Padding = new Padding(3, 4, 3, 4);
        boxCourierAdd.Size = new Size(445, 97);
        boxCourierAdd.TabIndex = 1;
        boxCourierAdd.TabStop = false;
        boxCourierAdd.Text = "Добавить курьера";
        // 
        // tbNameCourier
        // 
        tbNameCourier.Location = new Point(59, 29);
        tbNameCourier.Margin = new Padding(3, 4, 3, 4);
        tbNameCourier.Name = "tbNameCourier";
        tbNameCourier.Size = new Size(274, 27);
        tbNameCourier.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(17, 33);
        label3.Name = "label3";
        label3.Size = new Size(39, 20);
        label3.TabIndex = 4;
        label3.Text = "Имя";
        // 
        // btnAddCourier
        // 
        btnAddCourier.Location = new Point(352, 56);
        btnAddCourier.Margin = new Padding(3, 4, 3, 4);
        btnAddCourier.Name = "btnAddCourier";
        btnAddCourier.Size = new Size(86, 31);
        btnAddCourier.TabIndex = 3;
        btnAddCourier.Text = "Добавить";
        btnAddCourier.UseVisualStyleBackColor = true;
        btnAddCourier.Click += btnAddCourier_Click;
        // 
        // boxProductAdd
        // 
        boxProductAdd.Controls.Add(tbNameProduct);
        boxProductAdd.Controls.Add(label2);
        boxProductAdd.Controls.Add(btnAddProduct);
        boxProductAdd.Location = new Point(7, 139);
        boxProductAdd.Margin = new Padding(3, 4, 3, 4);
        boxProductAdd.Name = "boxProductAdd";
        boxProductAdd.Padding = new Padding(3, 4, 3, 4);
        boxProductAdd.Size = new Size(445, 113);
        boxProductAdd.TabIndex = 1;
        boxProductAdd.TabStop = false;
        boxProductAdd.Text = "Добавить продукт";
        // 
        // tbNameProduct
        // 
        tbNameProduct.Location = new Point(59, 41);
        tbNameProduct.Margin = new Padding(3, 4, 3, 4);
        tbNameProduct.Name = "tbNameProduct";
        tbNameProduct.Size = new Size(274, 27);
        tbNameProduct.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(17, 45);
        label2.Name = "label2";
        label2.Size = new Size(39, 20);
        label2.TabIndex = 4;
        label2.Text = "Имя";
        // 
        // btnAddProduct
        // 
        btnAddProduct.Location = new Point(352, 68);
        btnAddProduct.Margin = new Padding(3, 4, 3, 4);
        btnAddProduct.Name = "btnAddProduct";
        btnAddProduct.Size = new Size(86, 31);
        btnAddProduct.TabIndex = 3;
        btnAddProduct.Text = "Добавить";
        btnAddProduct.UseVisualStyleBackColor = true;
        btnAddProduct.Click += btnAddProduct_Click;
        // 
        // boxClientAdd
        // 
        boxClientAdd.Controls.Add(tbNameClient);
        boxClientAdd.Controls.Add(label1);
        boxClientAdd.Controls.Add(btnAddClient);
        boxClientAdd.Location = new Point(7, 29);
        boxClientAdd.Margin = new Padding(3, 4, 3, 4);
        boxClientAdd.Name = "boxClientAdd";
        boxClientAdd.Padding = new Padding(3, 4, 3, 4);
        boxClientAdd.Size = new Size(445, 101);
        boxClientAdd.TabIndex = 0;
        boxClientAdd.TabStop = false;
        boxClientAdd.Text = "Добавить клиента";
        // 
        // tbNameClient
        // 
        tbNameClient.Location = new Point(59, 35);
        tbNameClient.Margin = new Padding(3, 4, 3, 4);
        tbNameClient.Name = "tbNameClient";
        tbNameClient.Size = new Size(274, 27);
        tbNameClient.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 39);
        label1.Name = "label1";
        label1.Size = new Size(39, 20);
        label1.TabIndex = 1;
        label1.Text = "Имя";
        // 
        // btnAddClient
        // 
        btnAddClient.Location = new Point(352, 61);
        btnAddClient.Margin = new Padding(3, 4, 3, 4);
        btnAddClient.Name = "btnAddClient";
        btnAddClient.Size = new Size(86, 31);
        btnAddClient.TabIndex = 0;
        btnAddClient.Text = "Добавить";
        btnAddClient.UseVisualStyleBackColor = true;
        btnAddClient.Click += btnAddClient_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnDelCourier);
        groupBox2.Controls.Add(btnDelProduct);
        groupBox2.Controls.Add(btnDelClient);
        groupBox2.Controls.Add(btnRefresh);
        groupBox2.Controls.Add(lbCourier);
        groupBox2.Controls.Add(lbProduct);
        groupBox2.Controls.Add(lbClient);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(btnProductsView);
        groupBox2.Controls.Add(btnCouriersView);
        groupBox2.Controls.Add(btnClientView);
        groupBox2.Controls.Add(dataProducts);
        groupBox2.Controls.Add(dataCouriers);
        groupBox2.Controls.Add(dataClients);
        groupBox2.Location = new Point(495, 16);
        groupBox2.Margin = new Padding(3, 4, 3, 4);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(3, 4, 3, 4);
        groupBox2.Size = new Size(471, 635);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Данные";
        // 
        // btnDelCourier
        // 
        btnDelCourier.Enabled = false;
        btnDelCourier.Location = new Point(195, 520);
        btnDelCourier.Name = "btnDelCourier";
        btnDelCourier.Size = new Size(94, 29);
        btnDelCourier.TabIndex = 15;
        btnDelCourier.Text = "Удалить";
        btnDelCourier.UseVisualStyleBackColor = true;
        btnDelCourier.Click += btnDelCourier_Click;
        // 
        // btnDelProduct
        // 
        btnDelProduct.Enabled = false;
        btnDelProduct.Location = new Point(195, 473);
        btnDelProduct.Name = "btnDelProduct";
        btnDelProduct.Size = new Size(94, 29);
        btnDelProduct.TabIndex = 14;
        btnDelProduct.Text = "Удалить";
        btnDelProduct.UseVisualStyleBackColor = true;
        btnDelProduct.Click += btnDelProduct_Click;
        // 
        // btnDelClient
        // 
        btnDelClient.Enabled = false;
        btnDelClient.Location = new Point(195, 427);
        btnDelClient.Name = "btnDelClient";
        btnDelClient.Size = new Size(94, 29);
        btnDelClient.TabIndex = 13;
        btnDelClient.Text = "Удалить";
        btnDelClient.UseVisualStyleBackColor = true;
        btnDelClient.Click += btnDelClient_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(174, 582);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(138, 29);
        btnRefresh.TabIndex = 12;
        btnRefresh.Text = "Обновить";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // lbCourier
        // 
        lbCourier.AutoSize = true;
        lbCourier.Location = new Point(91, 520);
        lbCourier.Name = "lbCourier";
        lbCourier.Size = new Size(0, 20);
        lbCourier.TabIndex = 11;
        // 
        // lbProduct
        // 
        lbProduct.AutoSize = true;
        lbProduct.Location = new Point(91, 477);
        lbProduct.Name = "lbProduct";
        lbProduct.Size = new Size(0, 20);
        lbProduct.TabIndex = 10;
        // 
        // lbClient
        // 
        lbClient.AutoSize = true;
        lbClient.Location = new Point(91, 436);
        lbClient.Name = "lbClient";
        lbClient.Size = new Size(0, 20);
        lbClient.TabIndex = 9;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(12, 520);
        label8.Name = "label8";
        label8.Size = new Size(66, 20);
        label8.TabIndex = 8;
        label8.Text = "Курьер: ";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(12, 477);
        label7.Name = "label7";
        label7.Size = new Size(73, 20);
        label7.TabIndex = 7;
        label7.Text = "Продукт: ";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(12, 436);
        label6.Name = "label6";
        label6.Size = new Size(65, 20);
        label6.TabIndex = 6;
        label6.Text = "Клиент: ";
        // 
        // btnProductsView
        // 
        btnProductsView.Location = new Point(367, 384);
        btnProductsView.Margin = new Padding(3, 4, 3, 4);
        btnProductsView.Name = "btnProductsView";
        btnProductsView.Size = new Size(97, 31);
        btnProductsView.TabIndex = 5;
        btnProductsView.Text = "Продукты";
        btnProductsView.UseVisualStyleBackColor = true;
        btnProductsView.Click += btnProductsView_Click;
        // 
        // btnCouriersView
        // 
        btnCouriersView.Location = new Point(195, 384);
        btnCouriersView.Margin = new Padding(3, 4, 3, 4);
        btnCouriersView.Name = "btnCouriersView";
        btnCouriersView.Size = new Size(97, 31);
        btnCouriersView.TabIndex = 4;
        btnCouriersView.Text = "Курьеры";
        btnCouriersView.UseVisualStyleBackColor = true;
        btnCouriersView.Click += btnCouriersView_Click;
        // 
        // btnClientView
        // 
        btnClientView.Location = new Point(7, 384);
        btnClientView.Margin = new Padding(3, 4, 3, 4);
        btnClientView.Name = "btnClientView";
        btnClientView.Size = new Size(97, 31);
        btnClientView.TabIndex = 3;
        btnClientView.Text = "Клиенты";
        btnClientView.UseVisualStyleBackColor = true;
        btnClientView.Click += btnClientView_Click;
        // 
        // dataProducts
        // 
        dataProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
        dataProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataProducts.Location = new Point(6, 29);
        dataProducts.Margin = new Padding(3, 4, 3, 4);
        dataProducts.Name = "dataProducts";
        dataProducts.RowHeadersWidth = 51;
        dataProducts.RowTemplate.Height = 25;
        dataProducts.Size = new Size(457, 347);
        dataProducts.TabIndex = 2;
        dataProducts.Visible = false;
        dataProducts.MouseClick += dataProducts_MouseClick;
        // 
        // dataCouriers
        // 
        dataCouriers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataCouriers.Location = new Point(6, 29);
        dataCouriers.Margin = new Padding(3, 4, 3, 4);
        dataCouriers.Name = "dataCouriers";
        dataCouriers.RowHeadersWidth = 51;
        dataCouriers.RowTemplate.Height = 25;
        dataCouriers.Size = new Size(457, 347);
        dataCouriers.TabIndex = 1;
        dataCouriers.Visible = false;
        dataCouriers.MouseClick += dataCouriers_MouseClick;
        // 
        // dataClients
        // 
        dataClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataClients.Location = new Point(7, 29);
        dataClients.Margin = new Padding(3, 4, 3, 4);
        dataClients.Name = "dataClients";
        dataClients.RowHeadersWidth = 51;
        dataClients.RowTemplate.Height = 25;
        dataClients.Size = new Size(457, 347);
        dataClients.TabIndex = 0;
        dataClients.MouseClick += dataClients_MouseClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(975, 668);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        Text = "Workflow";
        groupBox1.ResumeLayout(false);
        boxCouriersState.ResumeLayout(false);
        boxCouriersState.PerformLayout();
        boxKithcenState.ResumeLayout(false);
        boxKithcenState.PerformLayout();
        boxCourierAdd.ResumeLayout(false);
        boxCourierAdd.PerformLayout();
        boxProductAdd.ResumeLayout(false);
        boxProductAdd.PerformLayout();
        boxClientAdd.ResumeLayout(false);
        boxClientAdd.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataCouriers).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataClients).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private DataGridView dataProducts;
    private DataGridView dataCouriers;
    private DataGridView dataClients;
    private GroupBox boxCourierAdd;
    private GroupBox boxProductAdd;
    private TextBox tbNameProduct;
    private Label label2;
    private Button btnAddProduct;
    private GroupBox boxClientAdd;
    private TextBox tbNameClient;
    private Label label1;
    private Button btnAddClient;
    private Button btnProductsView;
    private Button btnCouriersView;
    private Button btnClientView;
    private TextBox tbNameCourier;
    private Label label3;
    private Button btnAddCourier;
    private Button btnChangeStates;
    private Button btnAddEntries;
    private GroupBox boxKithcenState;
    private Label label4;
    private TextBox tbNumProd;
    private Button btnAcceptProd;
    private GroupBox boxCouriersState;
    private Label label5;
    private TextBox tbNumCourier;
    private Button btnAcceptCor;
    private Label lbCourier;
    private Label lbProduct;
    private Label lbClient;
    private Label label8;
    private Label label7;
    private Label label6;
    private Button btnRefresh;
    private Button btnDelCourier;
    private Button btnDelProduct;
    private Button btnDelClient;
}