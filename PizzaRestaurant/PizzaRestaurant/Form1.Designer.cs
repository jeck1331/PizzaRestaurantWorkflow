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
        btnTermCor = new Button();
        btnCancelCor = new Button();
        btnDeliverCor = new Button();
        label5 = new Label();
        tbNumCourier = new TextBox();
        btnAcceptCor = new Button();
        btnChangeStates = new Button();
        boxKithcenState = new GroupBox();
        btnTermProd = new Button();
        btnCancelProd = new Button();
        btnDoneProd = new Button();
        btnBeginProd = new Button();
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
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(412, 476);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Функции и состояния";
        // 
        // boxCouriersState
        // 
        boxCouriersState.Controls.Add(btnTermCor);
        boxCouriersState.Controls.Add(btnCancelCor);
        boxCouriersState.Controls.Add(btnDeliverCor);
        boxCouriersState.Controls.Add(label5);
        boxCouriersState.Controls.Add(tbNumCourier);
        boxCouriersState.Controls.Add(btnAcceptCor);
        boxCouriersState.Location = new Point(6, 141);
        boxCouriersState.Name = "boxCouriersState";
        boxCouriersState.Size = new Size(389, 108);
        boxCouriersState.TabIndex = 7;
        boxCouriersState.TabStop = false;
        boxCouriersState.Text = "Курьеры";
        boxCouriersState.Visible = false;
        // 
        // btnTermCor
        // 
        btnTermCor.Location = new Point(163, 79);
        btnTermCor.Name = "btnTermCor";
        btnTermCor.Size = new Size(107, 23);
        btnTermCor.TabIndex = 6;
        btnTermCor.Text = "Просрочен";
        btnTermCor.UseVisualStyleBackColor = true;
        btnTermCor.Click += btnTermCor_Click;
        // 
        // btnCancelCor
        // 
        btnCancelCor.Location = new Point(6, 82);
        btnCancelCor.Name = "btnCancelCor";
        btnCancelCor.Size = new Size(140, 23);
        btnCancelCor.TabIndex = 5;
        btnCancelCor.Text = "Отменить";
        btnCancelCor.UseVisualStyleBackColor = true;
        btnCancelCor.Click += btnCancelCor_Click;
        // 
        // btnDeliverCor
        // 
        btnDeliverCor.Location = new Point(163, 54);
        btnDeliverCor.Name = "btnDeliverCor";
        btnDeliverCor.Size = new Size(107, 23);
        btnDeliverCor.TabIndex = 4;
        btnDeliverCor.Text = "Доставлен";
        btnDeliverCor.UseVisualStyleBackColor = true;
        btnDeliverCor.Click += btnDeliverCor_Click;
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
        tbNumCourier.Location = new Point(116, 22);
        tbNumCourier.Name = "tbNumCourier";
        tbNumCourier.Size = new Size(65, 23);
        tbNumCourier.TabIndex = 1;
        // 
        // btnAcceptCor
        // 
        btnAcceptCor.Location = new Point(6, 54);
        btnAcceptCor.Name = "btnAcceptCor";
        btnAcceptCor.Size = new Size(140, 23);
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
        boxKithcenState.Controls.Add(btnTermProd);
        boxKithcenState.Controls.Add(btnCancelProd);
        boxKithcenState.Controls.Add(btnDoneProd);
        boxKithcenState.Controls.Add(btnBeginProd);
        boxKithcenState.Controls.Add(label4);
        boxKithcenState.Controls.Add(tbNumProd);
        boxKithcenState.Controls.Add(btnAcceptProd);
        boxKithcenState.Location = new Point(6, 21);
        boxKithcenState.Name = "boxKithcenState";
        boxKithcenState.Size = new Size(389, 114);
        boxKithcenState.TabIndex = 2;
        boxKithcenState.TabStop = false;
        boxKithcenState.Text = "Кухня";
        boxKithcenState.Visible = false;
        // 
        // btnTermProd
        // 
        btnTermProd.Location = new Point(181, 75);
        btnTermProd.Name = "btnTermProd";
        btnTermProd.Size = new Size(107, 23);
        btnTermProd.TabIndex = 6;
        btnTermProd.Text = "Просрочен";
        btnTermProd.UseVisualStyleBackColor = true;
        btnTermProd.Click += btnTermProd_Click;
        // 
        // btnCancelProd
        // 
        btnCancelProd.Location = new Point(13, 75);
        btnCancelProd.Name = "btnCancelProd";
        btnCancelProd.Size = new Size(140, 23);
        btnCancelProd.TabIndex = 5;
        btnCancelProd.Text = "Отменить";
        btnCancelProd.UseVisualStyleBackColor = true;
        btnCancelProd.Click += btnCancelProd_Click;
        // 
        // btnDoneProd
        // 
        btnDoneProd.Location = new Point(181, 50);
        btnDoneProd.Name = "btnDoneProd";
        btnDoneProd.Size = new Size(107, 23);
        btnDoneProd.TabIndex = 4;
        btnDoneProd.Text = "Приготовлено";
        btnDoneProd.UseVisualStyleBackColor = true;
        btnDoneProd.Click += btnDoneProd_Click;
        // 
        // btnBeginProd
        // 
        btnBeginProd.Location = new Point(181, 25);
        btnBeginProd.Name = "btnBeginProd";
        btnBeginProd.Size = new Size(107, 23);
        btnBeginProd.TabIndex = 3;
        btnBeginProd.Text = "Начать готовить";
        btnBeginProd.UseVisualStyleBackColor = true;
        btnBeginProd.Click += btnBeginProd_Click;
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
        tbNumProd.Location = new Point(88, 22);
        tbNumProd.Name = "tbNumProd";
        tbNumProd.Size = new Size(65, 23);
        tbNumProd.TabIndex = 1;
        // 
        // btnAcceptProd
        // 
        btnAcceptProd.Location = new Point(13, 51);
        btnAcceptProd.Name = "btnAcceptProd";
        btnAcceptProd.Size = new Size(140, 23);
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
        groupBox2.Controls.Add(btnProductsView);
        groupBox2.Controls.Add(btnCouriersView);
        groupBox2.Controls.Add(btnClientView);
        groupBox2.Controls.Add(dataProducts);
        groupBox2.Controls.Add(dataCouriers);
        groupBox2.Controls.Add(dataClients);
        groupBox2.Location = new Point(433, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(412, 476);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Данные";
        // 
        // btnProductsView
        // 
        btnProductsView.Location = new Point(321, 288);
        btnProductsView.Name = "btnProductsView";
        btnProductsView.Size = new Size(85, 23);
        btnProductsView.TabIndex = 5;
        btnProductsView.Text = "Продукты";
        btnProductsView.UseVisualStyleBackColor = true;
        btnProductsView.Click += btnProductsView_Click;
        // 
        // btnCouriersView
        // 
        btnCouriersView.Location = new Point(171, 288);
        btnCouriersView.Name = "btnCouriersView";
        btnCouriersView.Size = new Size(85, 23);
        btnCouriersView.TabIndex = 4;
        btnCouriersView.Text = "Курьеры";
        btnCouriersView.UseVisualStyleBackColor = true;
        btnCouriersView.Click += btnCouriersView_Click;
        // 
        // btnClientView
        // 
        btnClientView.Location = new Point(6, 288);
        btnClientView.Name = "btnClientView";
        btnClientView.Size = new Size(85, 23);
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
        dataProducts.Location = new Point(6, 22);
        dataProducts.Name = "dataProducts";
        dataProducts.RowTemplate.Height = 25;
        dataProducts.Size = new Size(400, 260);
        dataProducts.TabIndex = 2;
        dataProducts.Visible = false;
        dataProducts.MouseClick += dataProducts_MouseClick;
        // 
        // dataCouriers
        // 
        dataCouriers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataCouriers.Location = new Point(6, 22);
        dataCouriers.Name = "dataCouriers";
        dataCouriers.RowTemplate.Height = 25;
        dataCouriers.Size = new Size(400, 260);
        dataCouriers.TabIndex = 1;
        dataCouriers.Visible = false;
        dataCouriers.MouseClick += dataCouriers_MouseClick;
        // 
        // dataClients
        // 
        dataClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataClients.Location = new Point(6, 22);
        dataClients.Name = "dataClients";
        dataClients.RowTemplate.Height = 25;
        dataClients.Size = new Size(400, 260);
        dataClients.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(853, 501);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
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
    private Button btnTermProd;
    private Button btnCancelProd;
    private Button btnDoneProd;
    private Button btnBeginProd;
    private Label label4;
    private TextBox tbNumProd;
    private Button btnAcceptProd;
    private GroupBox boxCouriersState;
    private Button btnTermCor;
    private Button btnCancelCor;
    private Button btnDeliverCor;
    private Label label5;
    private TextBox tbNumCourier;
    private Button btnAcceptCor;
}