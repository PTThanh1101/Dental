namespace LAB4
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

        private void InitializeComponent()
        {
            this.textName = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExec = new System.Windows.Forms.Button();
            this.txtNameApp = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numerFillings = new System.Windows.Forms.NumericUpDown();
            this.ServicePriceList = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numerFillings)).BeginInit();
            this.ServicePriceList.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(176, 72);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(136, 22);
            this.textName.TabIndex = 2;
            // 
            // txtCustomer
            // 
            this.txtCustomer.AutoSize = true;
            this.txtCustomer.Location = new System.Drawing.Point(57, 72);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(107, 16);
            this.txtCustomer.TabIndex = 3;
            this.txtCustomer.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total";
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(356, 341);
            this.textTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(89, 22);
            this.textTotal.TabIndex = 5;
            this.textTotal.TextChanged += new System.EventHandler(this.textTotal_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(384, 392);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(78, 30);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(505, 392);
            this.btnExec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(78, 30);
            this.btnExec.TabIndex = 7;
            this.btnExec.Text = "Exec";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // txtNameApp
            // 
            this.txtNameApp.AutoSize = true;
            this.txtNameApp.Location = new System.Drawing.Point(314, 20);
            this.txtNameApp.Name = "txtNameApp";
            this.txtNameApp.Size = new System.Drawing.Size(130, 16);
            this.txtNameApp.TabIndex = 0;
            this.txtNameApp.Text = "Dental Payment App";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 46);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Scrape Tartar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 77);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Teeth Whitening";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(25, 110);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Fillings";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "$3,000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "$5,000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "$1,000/Item";
            // 
            // numerFillings
            // 
            this.numerFillings.Location = new System.Drawing.Point(105, 113);
            this.numerFillings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numerFillings.Name = "numerFillings";
            this.numerFillings.Size = new System.Drawing.Size(107, 22);
            this.numerFillings.TabIndex = 6;
            this.numerFillings.ValueChanged += new System.EventHandler(this.numerFillings_ValueChanged);
            // 
            // ServicePriceList
            // 
            this.ServicePriceList.Controls.Add(this.numerFillings);
            this.ServicePriceList.Controls.Add(this.label4);
            this.ServicePriceList.Controls.Add(this.label2);
            this.ServicePriceList.Controls.Add(this.label1);
            this.ServicePriceList.Controls.Add(this.checkBox3);
            this.ServicePriceList.Controls.Add(this.checkBox2);
            this.ServicePriceList.Controls.Add(this.checkBox1);
            this.ServicePriceList.Location = new System.Drawing.Point(57, 121);
            this.ServicePriceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServicePriceList.Name = "ServicePriceList";
            this.ServicePriceList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServicePriceList.Size = new System.Drawing.Size(534, 202);
            this.ServicePriceList.TabIndex = 1;
            this.ServicePriceList.TabStop = false;
            this.ServicePriceList.Text = "Service Price List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(643, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 116);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 461);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.ServicePriceList);
            this.Controls.Add(this.txtNameApp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numerFillings)).EndInit();
            this.ServicePriceList.ResumeLayout(false);
            this.ServicePriceList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label txtCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label txtNameApp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numerFillings;
        private System.Windows.Forms.GroupBox ServicePriceList;
        private System.Windows.Forms.ListBox listBox1;
    }
}

#region Windows Form Designer generated code

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>


#endregion
 

