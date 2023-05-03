namespace PizzeriaWorkflow;

partial class PizzeriaForm
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
        btnCancelCourier = new Button();
        label5 = new Label();
        tbNumCourier = new TextBox();
        btnAcceptCor = new Button();
        btnChangeStates = new Button();
        boxKithcenState = new GroupBox();
        btnCancelKitchen = new Button();
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
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(412, 476);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Функции и состояния";
        // 
        // boxCouriersState
        // 
        boxCouriersState.Controls.Add(btnCancelCourier);
        boxCouriersState.Controls.Add(label5);
        boxCouriersState.Controls.Add(tbNumCourier);
        boxCouriersState.Controls.Add(btnAcceptCor);
        boxCouriersState.Location = new Point(6, 141);
        boxCouriersState.Name = "boxCouriersState";
        boxCouriersState.Size = new Size(383, 108);
        boxCouriersState.TabIndex = 7;
        boxCouriersState.TabStop = false;
        boxCouriersState.Text = "Курьеры";
        boxCouriersState.Visible = false;
        // 
        // btnCancelCourier
        // 
        btnCancelCourier.Location = new Point(247, 62);
        btnCancelCourier.Name = "btnCancelCourier";
        btnCancelCourier.Size = new Size(118, 23);
        btnCancelCourier.TabIndex = 3;
        btnCancelCourier.Text = "Отменить";
        btnCancelCourier.UseVisualStyleBackColor = true;
        btnCancelCourier.Click += btnCancelCourier_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(13, 25);
        label5.Name = "label5";
        label5.Size = new Size(97, 15);
        label5.TabIndex = 2;
        label5.Text = "Исполнитель№:";
        // 
        // tbNumCourier
        // 
        tbNumCourier.Location = new Point(127, 22);
        tbNumCourier.Name = "tbNumCourier";
        tbNumCourier.Size = new Size(94, 23);
        tbNumCourier.TabIndex = 1;
        // 
        // btnAcceptCor
        // 
        btnAcceptCor.Location = new Point(13, 62);
        btnAcceptCor.Name = "btnAcceptCor";
        btnAcceptCor.Size = new Size(207, 23);
        btnAcceptCor.TabIndex = 0;
        btnAcceptCor.Text = "Принять заказ";
        btnAcceptCor.UseVisualStyleBackColor = true;
        btnAcceptCor.Click += btnAcceptCor_Click;
        // 
        // btnChangeStates
        // 
        btnChangeStates.Location = new Point(208, 447);
        btnChangeStates.Name = "btnChangeStates";
        btnChangeStates.Size = new Size(181, 23);
        btnChangeStates.TabIndex = 3;
        btnChangeStates.Text = "Изменение состояний";
        btnChangeStates.UseVisualStyleBackColor = true;
        btnChangeStates.Click += btnChangeStates_Click;
        // 
        // boxKithcenState
        // 
        boxKithcenState.Controls.Add(btnCancelKitchen);
        boxKithcenState.Controls.Add(label4);
        boxKithcenState.Controls.Add(tbNumProd);
        boxKithcenState.Controls.Add(btnAcceptProd);
        boxKithcenState.Location = new Point(6, 21);
        boxKithcenState.Name = "boxKithcenState";
        boxKithcenState.Size = new Size(383, 114);
        boxKithcenState.TabIndex = 2;
        boxKithcenState.TabStop = false;
        boxKithcenState.Text = "Кухня";
        boxKithcenState.Visible = false;
        // 
        // btnCancelKitchen
        // 
        btnCancelKitchen.Location = new Point(247, 67);
        btnCancelKitchen.Name = "btnCancelKitchen";
        btnCancelKitchen.Size = new Size(118, 23);
        btnCancelKitchen.TabIndex = 4;
        btnCancelKitchen.Text = "Отменить";
        btnCancelKitchen.UseVisualStyleBackColor = true;
        btnCancelKitchen.Click += btnCancelKitchen_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(13, 25);
        label4.Name = "label4";
        label4.Size = new Size(69, 15);
        label4.TabIndex = 2;
        label4.Text = "Продукт№:";
        // 
        // tbNumProd
        // 
        tbNumProd.Location = new Point(127, 25);
        tbNumProd.Name = "tbNumProd";
        tbNumProd.Size = new Size(94, 23);
        tbNumProd.TabIndex = 1;
        // 
        // btnAcceptProd
        // 
        btnAcceptProd.Location = new Point(13, 67);
        btnAcceptProd.Name = "btnAcceptProd";
        btnAcceptProd.Size = new Size(207, 23);
        btnAcceptProd.TabIndex = 0;
        btnAcceptProd.Text = "Принять заказ";
        btnAcceptProd.UseVisualStyleBackColor = true;
        btnAcceptProd.Click += btnAcceptProd_Click;
        // 
        // btnAddEntries
        // 
        btnAddEntries.Location = new Point(6, 447);
        btnAddEntries.Name = "btnAddEntries";
        btnAddEntries.Size = new Size(181, 23);
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
        boxCourierAdd.Location = new Point(6, 195);
        boxCourierAdd.Name = "boxCourierAdd";
        boxCourierAdd.Size = new Size(389, 73);
        boxCourierAdd.TabIndex = 1;
        boxCourierAdd.TabStop = false;
        boxCourierAdd.Text = "Добавить курьера";
        // 
        // tbNameCourier
        // 
        tbNameCourier.Location = new Point(52, 22);
        tbNameCourier.Name = "tbNameCourier";
        tbNameCourier.Size = new Size(240, 23);
        tbNameCourier.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(15, 25);
        label3.Name = "label3";
        label3.Size = new Size(31, 15);
        label3.TabIndex = 4;
        label3.Text = "Имя";
        // 
        // btnAddCourier
        // 
        btnAddCourier.Location = new Point(308, 42);
        btnAddCourier.Name = "btnAddCourier";
        btnAddCourier.Size = new Size(75, 23);
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
        boxProductAdd.Location = new Point(6, 104);
        boxProductAdd.Name = "boxProductAdd";
        boxProductAdd.Size = new Size(389, 85);
        boxProductAdd.TabIndex = 1;
        boxProductAdd.TabStop = false;
        boxProductAdd.Text = "Добавить продукт";
        // 
        // tbNameProduct
        // 
        tbNameProduct.Location = new Point(52, 31);
        tbNameProduct.Name = "tbNameProduct";
        tbNameProduct.Size = new Size(240, 23);
        tbNameProduct.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(15, 34);
        label2.Name = "label2";
        label2.Size = new Size(31, 15);
        label2.TabIndex = 4;
        label2.Text = "Имя";
        // 
        // btnAddProduct
        // 
        btnAddProduct.Location = new Point(308, 51);
        btnAddProduct.Name = "btnAddProduct";
        btnAddProduct.Size = new Size(75, 23);
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
        boxClientAdd.Location = new Point(6, 22);
        boxClientAdd.Name = "boxClientAdd";
        boxClientAdd.Size = new Size(389, 76);
        boxClientAdd.TabIndex = 0;
        boxClientAdd.TabStop = false;
        boxClientAdd.Text = "Добавить клиента";
        // 
        // tbNameClient
        // 
        tbNameClient.Location = new Point(52, 26);
        tbNameClient.Name = "tbNameClient";
        tbNameClient.Size = new Size(240, 23);
        tbNameClient.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(15, 29);
        label1.Name = "label1";
        label1.Size = new Size(31, 15);
        label1.TabIndex = 1;
        label1.Text = "Имя";
        // 
        // btnAddClient
        // 
        btnAddClient.Location = new Point(308, 46);
        btnAddClient.Name = "btnAddClient";
        btnAddClient.Size = new Size(75, 23);
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
        groupBox2.Controls.Add(dataProducts);
        groupBox2.Controls.Add(dataCouriers);
        groupBox2.Controls.Add(dataClients);
        groupBox2.Location = new Point(433, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(784, 476);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Данные";
        // 
        // btnDelCourier
        // 
        btnDelCourier.Enabled = false;
        btnDelCourier.Location = new Point(171, 390);
        btnDelCourier.Margin = new Padding(3, 2, 3, 2);
        btnDelCourier.Name = "btnDelCourier";
        btnDelCourier.Size = new Size(82, 22);
        btnDelCourier.TabIndex = 15;
        btnDelCourier.Text = "Удалить";
        btnDelCourier.UseVisualStyleBackColor = true;
        btnDelCourier.Click += btnDelCourier_Click;
        // 
        // btnDelProduct
        // 
        btnDelProduct.Enabled = false;
        btnDelProduct.Location = new Point(171, 355);
        btnDelProduct.Margin = new Padding(3, 2, 3, 2);
        btnDelProduct.Name = "btnDelProduct";
        btnDelProduct.Size = new Size(82, 22);
        btnDelProduct.TabIndex = 14;
        btnDelProduct.Text = "Удалить";
        btnDelProduct.UseVisualStyleBackColor = true;
        btnDelProduct.Click += btnDelProduct_Click;
        // 
        // btnDelClient
        // 
        btnDelClient.Enabled = false;
        btnDelClient.Location = new Point(171, 320);
        btnDelClient.Margin = new Padding(3, 2, 3, 2);
        btnDelClient.Name = "btnDelClient";
        btnDelClient.Size = new Size(82, 22);
        btnDelClient.TabIndex = 13;
        btnDelClient.Text = "Удалить";
        btnDelClient.UseVisualStyleBackColor = true;
        btnDelClient.Click += btnDelClient_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(152, 436);
        btnRefresh.Margin = new Padding(3, 2, 3, 2);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(121, 22);
        btnRefresh.TabIndex = 12;
        btnRefresh.Text = "Обновить";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // lbCourier
        // 
        lbCourier.AutoSize = true;
        lbCourier.Location = new Point(80, 390);
        lbCourier.Name = "lbCourier";
        lbCourier.Size = new Size(0, 15);
        lbCourier.TabIndex = 11;
        // 
        // lbProduct
        // 
        lbProduct.AutoSize = true;
        lbProduct.Location = new Point(80, 358);
        lbProduct.Name = "lbProduct";
        lbProduct.Size = new Size(0, 15);
        lbProduct.TabIndex = 10;
        // 
        // lbClient
        // 
        lbClient.AutoSize = true;
        lbClient.Location = new Point(80, 327);
        lbClient.Name = "lbClient";
        lbClient.Size = new Size(0, 15);
        lbClient.TabIndex = 9;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(10, 390);
        label8.Name = "label8";
        label8.Size = new Size(52, 15);
        label8.TabIndex = 8;
        label8.Text = "Курьер: ";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(10, 358);
        label7.Name = "label7";
        label7.Size = new Size(59, 15);
        label7.TabIndex = 7;
        label7.Text = "Продукт: ";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(10, 327);
        label6.Name = "label6";
        label6.Size = new Size(52, 15);
        label6.TabIndex = 6;
        label6.Text = "Клиент: ";
        // 
        // dataProducts
        // 
        dataProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataProducts.Location = new Point(184, 22);
        dataProducts.Name = "dataProducts";
        dataProducts.RowHeadersWidth = 51;
        dataProducts.RowTemplate.Height = 25;
        dataProducts.Size = new Size(312, 260);
        dataProducts.TabIndex = 2;
        dataProducts.MouseClick += dataProducts_MouseClick;
        // 
        // dataCouriers
        // 
        dataCouriers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataCouriers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataCouriers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataCouriers.Location = new Point(502, 22);
        dataCouriers.Name = "dataCouriers";
        dataCouriers.RowHeadersWidth = 51;
        dataCouriers.RowTemplate.Height = 25;
        dataCouriers.Size = new Size(265, 260);
        dataCouriers.TabIndex = 1;
        dataCouriers.MouseClick += dataCouriers_MouseClick;
        // 
        // dataClients
        // 
        dataClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataClients.Location = new Point(6, 22);
        dataClients.Name = "dataClients";
        dataClients.RowHeadersWidth = 51;
        dataClients.RowTemplate.Height = 25;
        dataClients.Size = new Size(172, 260);
        dataClients.TabIndex = 0;
        dataClients.MouseClick += dataClients_MouseClick;
        // 
        // PizzeriaForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1221, 500);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "PizzeriaForm";
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
    private Button btnCancelCourier;
    private Button btnCancelKitchen;
}