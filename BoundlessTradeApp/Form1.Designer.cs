namespace BoundlessTradeApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.buyListBox = new System.Windows.Forms.ListBox();
            this.sellListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROFIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theyBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theySell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(667, 26);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(364, 407);
            this.itemListBox.TabIndex = 1;
            this.itemListBox.Visible = false;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // buyListBox
            // 
            this.buyListBox.FormattingEnabled = true;
            this.buyListBox.Location = new System.Drawing.Point(6, 40);
            this.buyListBox.Name = "buyListBox";
            this.buyListBox.Size = new System.Drawing.Size(155, 199);
            this.buyListBox.TabIndex = 2;
            // 
            // sellListBox
            // 
            this.sellListBox.FormattingEnabled = true;
            this.sellListBox.Location = new System.Drawing.Point(167, 40);
            this.sellListBox.Name = "sellListBox";
            this.sellListBox.Size = new System.Drawing.Size(155, 199);
            this.sellListBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buyListBox);
            this.groupBox1.Controls.Add(this.sellListBox);
            this.groupBox1.Location = new System.Drawing.Point(1047, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 251);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Item from Left Box";
            this.groupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shop Stand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Request Basket";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM,
            this.PROFIT,
            this.theyBuy,
            this.theySell});
            this.dataGridView1.Location = new System.Drawing.Point(15, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 725);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(938, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Click Twice to Item";
            // 
            // ITEM
            // 
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.Name = "ITEM";
            this.ITEM.ReadOnly = true;
            this.ITEM.Width = 200;
            // 
            // PROFIT
            // 
            this.PROFIT.HeaderText = "PROFIT";
            this.PROFIT.Name = "PROFIT";
            this.PROFIT.ReadOnly = true;
            this.PROFIT.Width = 50;
            // 
            // theyBuy
            // 
            this.theyBuy.HeaderText = "THEY SELL";
            this.theyBuy.Name = "theyBuy";
            this.theyBuy.ReadOnly = true;
            this.theyBuy.Width = 250;
            // 
            // theySell
            // 
            this.theySell.HeaderText = "THEY BUY";
            this.theySell.Name = "theySell";
            this.theySell.ReadOnly = true;
            this.theySell.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 763);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Boundless Easy Money";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.ListBox buyListBox;
        private System.Windows.Forms.ListBox sellListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn theyBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn theySell;
    }
}

