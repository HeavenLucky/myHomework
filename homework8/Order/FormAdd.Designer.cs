
namespace Order
{
    partial class FormManage
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
            this.buttonadd1 = new System.Windows.Forms.Button();
            this.orderidtext = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelorderid = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonadd1
            // 
            this.buttonadd1.Location = new System.Drawing.Point(291, 281);
            this.buttonadd1.Name = "buttonadd1";
            this.buttonadd1.Size = new System.Drawing.Size(143, 41);
            this.buttonadd1.TabIndex = 0;
            this.buttonadd1.Text = "add";
            this.buttonadd1.UseVisualStyleBackColor = true;
            this.buttonadd1.Click += new System.EventHandler(this.buttonadd1_Click);
            // 
            // orderidtext
            // 
            this.orderidtext.Location = new System.Drawing.Point(333, 81);
            this.orderidtext.Name = "orderidtext";
            this.orderidtext.Size = new System.Drawing.Size(304, 35);
            this.orderidtext.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(333, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(304, 35);
            this.textBox2.TabIndex = 2;
            // 
            // labelorderid
            // 
            this.labelorderid.AutoSize = true;
            this.labelorderid.Location = new System.Drawing.Point(185, 92);
            this.labelorderid.Name = "labelorderid";
            this.labelorderid.Size = new System.Drawing.Size(94, 24);
            this.labelorderid.TabIndex = 3;
            this.labelorderid.Text = "orderid";
            this.labelorderid.Click += new System.EventHandler(this.label1_Click);
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(159, 182);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(154, 24);
            this.customer.TabIndex = 4;
            this.customer.Text = "customername";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 35);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "address";
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.labelorderid);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.orderidtext);
            this.Controls.Add(this.buttonadd1);
            this.Name = "FormManage";
            this.Text = "FormManage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonadd1;
        private System.Windows.Forms.TextBox orderidtext;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelorderid;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}