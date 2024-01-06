namespace ConnectedArchitectureCRUD
{
    partial class FrmCustomerCrudForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customer_id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customer_name_txt = new System.Windows.Forms.TextBox();
            this.customer_city_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customer_phnno_txt = new System.Windows.Forms.TextBox();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.moreForwardBtn = new System.Windows.Forms.Button();
            this.morePreviousBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
     //       this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Infoway Customer Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Id";
            // 
            // customer_id_txt
            // 
            this.customer_id_txt.Location = new System.Drawing.Point(407, 147);
            this.customer_id_txt.Name = "customer_id_txt";
            this.customer_id_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_id_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer City";
            // 
            // customer_name_txt
            // 
            this.customer_name_txt.Location = new System.Drawing.Point(407, 174);
            this.customer_name_txt.Name = "customer_name_txt";
            this.customer_name_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_name_txt.TabIndex = 6;
            // 
            // customer_city_txt
            // 
            this.customer_city_txt.Location = new System.Drawing.Point(407, 201);
            this.customer_city_txt.Name = "customer_city_txt";
            this.customer_city_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_city_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer Phone No";
            // 
            // customer_phnno_txt
            // 
            this.customer_phnno_txt.Location = new System.Drawing.Point(407, 227);
            this.customer_phnno_txt.Name = "customer_phnno_txt";
            this.customer_phnno_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_phnno_txt.TabIndex = 9;
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(280, 301);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 23);
            this.newBtn.TabIndex = 10;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(373, 301);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(464, 301);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyBtn.TabIndex = 12;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(555, 301);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(464, 272);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(75, 23);
            this.forwardBtn.TabIndex = 14;
            this.forwardBtn.Text = ">";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // moreForwardBtn
            // 
            this.moreForwardBtn.Location = new System.Drawing.Point(555, 272);
            this.moreForwardBtn.Name = "moreForwardBtn";
            this.moreForwardBtn.Size = new System.Drawing.Size(75, 23);
            this.moreForwardBtn.TabIndex = 15;
            this.moreForwardBtn.Text = ">>";
            this.moreForwardBtn.UseVisualStyleBackColor = true;
            this.moreForwardBtn.Click += new System.EventHandler(this.moreForwardBtn_Click);
            // 
            // morePreviousBtn
            // 
            this.morePreviousBtn.Location = new System.Drawing.Point(280, 272);
            this.morePreviousBtn.Name = "morePreviousBtn";
            this.morePreviousBtn.Size = new System.Drawing.Size(75, 23);
            this.morePreviousBtn.TabIndex = 16;
            this.morePreviousBtn.Text = "<<";
            this.morePreviousBtn.UseVisualStyleBackColor = true;
            this.morePreviousBtn.Click += new System.EventHandler(this.morePreviousBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(373, 272);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 23);
            this.previousBtn.TabIndex = 17;
            this.previousBtn.Text = "<";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // FrmCustomerCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.morePreviousBtn);
            this.Controls.Add(this.moreForwardBtn);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.customer_phnno_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customer_city_txt);
            this.Controls.Add(this.customer_name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customer_id_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCustomerCrudForm";
            this.Text = "FrmCustomerCrudForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customer_id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customer_name_txt;
        private System.Windows.Forms.TextBox customer_city_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customer_phnno_txt;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button moreForwardBtn;
        private System.Windows.Forms.Button morePreviousBtn;
        private System.Windows.Forms.Button previousBtn;
    }
}