
namespace Order
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.quebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.bindingSourcegoods = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panellow = new System.Windows.Forms.Panel();
            this.impbutton = new System.Windows.Forms.Button();
            this.expbutton = new System.Windows.Forms.Button();
            this.updbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceorder = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcegoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panellow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceorder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paneltop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1532, 100);
            this.panel1.TabIndex = 0;
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.quebutton);
            this.paneltop.Controls.Add(this.textBox1);
            this.paneltop.Controls.Add(this.comboBox);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneltop.Location = new System.Drawing.Point(0, 3);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1532, 97);
            this.paneltop.TabIndex = 3;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // quebutton
            // 
            this.quebutton.Location = new System.Drawing.Point(991, 43);
            this.quebutton.Name = "quebutton";
            this.quebutton.Size = new System.Drawing.Size(133, 39);
            this.quebutton.TabIndex = 2;
            this.quebutton.Text = "查询订单";
            this.quebutton.UseVisualStyleBackColor = true;
            this.quebutton.Click += new System.EventHandler(this.quebutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 35);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "所有订单",
            " id",
            "客户名",
            "货物名"});
            this.comboBox.Location = new System.Drawing.Point(141, 39);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(235, 32);
            this.comboBox.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.Location = new System.Drawing.Point(0, 192);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView3);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView4);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(1532, 452);
            this.splitContainer2.SplitterDistance = 873;
            this.splitContainer2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.customerDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn1,
            this.totalAmountDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.bindingSourceorder;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 37;
            this.dataGridView3.Size = new System.Drawing.Size(873, 452);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(873, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.amountPriceDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.bindingSourcegoods;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 82;
            this.dataGridView4.RowTemplate.Height = 37;
            this.dataGridView4.Size = new System.Drawing.Size(655, 452);
            this.dataGridView4.TabIndex = 1;
            // 
            // bindingSourcegoods
            // 
            this.bindingSourcegoods.DataMember = "orderlist";
            this.bindingSourcegoods.DataSource = this.bindingSourceorder;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.Size = new System.Drawing.Size(655, 452);
            this.dataGridView2.TabIndex = 0;
            // 
            // panellow
            // 
            this.panellow.Controls.Add(this.impbutton);
            this.panellow.Controls.Add(this.expbutton);
            this.panellow.Controls.Add(this.updbutton);
            this.panellow.Controls.Add(this.delbutton);
            this.panellow.Controls.Add(this.addbutton);
            this.panellow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellow.Location = new System.Drawing.Point(0, 0);
            this.panellow.Name = "panellow";
            this.panellow.Size = new System.Drawing.Size(1532, 644);
            this.panellow.TabIndex = 3;
            // 
            // impbutton
            // 
            this.impbutton.Location = new System.Drawing.Point(811, 138);
            this.impbutton.Name = "impbutton";
            this.impbutton.Size = new System.Drawing.Size(154, 48);
            this.impbutton.TabIndex = 4;
            this.impbutton.Text = "导入订单";
            this.impbutton.UseVisualStyleBackColor = true;
            this.impbutton.Click += new System.EventHandler(this.impbutton_Click);
            // 
            // expbutton
            // 
            this.expbutton.Location = new System.Drawing.Point(625, 138);
            this.expbutton.Name = "expbutton";
            this.expbutton.Size = new System.Drawing.Size(131, 48);
            this.expbutton.TabIndex = 3;
            this.expbutton.Text = "导出订单";
            this.expbutton.UseVisualStyleBackColor = true;
            this.expbutton.Click += new System.EventHandler(this.expbutton_Click);
            // 
            // updbutton
            // 
            this.updbutton.Location = new System.Drawing.Point(465, 138);
            this.updbutton.Name = "updbutton";
            this.updbutton.Size = new System.Drawing.Size(127, 48);
            this.updbutton.TabIndex = 2;
            this.updbutton.Text = "修改订单";
            this.updbutton.UseVisualStyleBackColor = true;
            this.updbutton.Click += new System.EventHandler(this.updbutton_Click);
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(263, 138);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(139, 48);
            this.delbutton.TabIndex = 1;
            this.delbutton.Text = "删除订单";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(79, 138);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(130, 48);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "添加订单";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.Width = 200;
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            this.customerDataGridViewTextBoxColumn1.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn1.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            this.customerDataGridViewTextBoxColumn1.Width = 200;
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            this.timeDataGridViewTextBoxColumn1.Width = 200;
            // 
            // totalAmountDataGridViewTextBoxColumn1
            // 
            this.totalAmountDataGridViewTextBoxColumn1.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn1.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.totalAmountDataGridViewTextBoxColumn1.Name = "totalAmountDataGridViewTextBoxColumn1";
            this.totalAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn1.Width = 200;
            // 
            // bindingSourceorder
            // 
            this.bindingSourceorder.DataSource = typeof(Order.Ordera);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GoodsAmount";
            this.dataGridViewTextBoxColumn1.HeaderText = "GoodsAmount";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Goods";
            this.dataGridViewTextBoxColumn2.HeaderText = "Goods";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // amountPriceDataGridViewTextBoxColumn
            // 
            this.amountPriceDataGridViewTextBoxColumn.DataPropertyName = "AmountPrice";
            this.amountPriceDataGridViewTextBoxColumn.HeaderText = "AmountPrice";
            this.amountPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.amountPriceDataGridViewTextBoxColumn.Name = "amountPriceDataGridViewTextBoxColumn";
            this.amountPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 644);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panellow);
            this.Name = "Form1";
            this.Text = "主窗口";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcegoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panellow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceorder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panellow;
        private System.Windows.Forms.Button quebutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button expbutton;
        private System.Windows.Forms.Button updbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button impbutton;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource bindingSourceorder;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource bindingSourcegoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

