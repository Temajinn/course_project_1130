namespace course_project_parking
{
    partial class AddClientForm
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
            this.lblfio = new System.Windows.Forms.Label();
            this.lblparknumber = new System.Windows.Forms.Label();
            this.lbldaysnumb = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtbxfio = new System.Windows.Forms.TextBox();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblmark = new System.Windows.Forms.Label();
            this.txtbxnumber = new System.Windows.Forms.TextBox();
            this.txtbxmark = new System.Windows.Forms.TextBox();
            this.txtbxparknumber = new System.Windows.Forms.TextBox();
            this.chbxdiscount = new System.Windows.Forms.CheckBox();
            this.txtbxdaysnumb = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfio
            // 
            this.lblfio.AutoSize = true;
            this.lblfio.Location = new System.Drawing.Point(11, 15);
            this.lblfio.Name = "lblfio";
            this.lblfio.Size = new System.Drawing.Size(32, 13);
            this.lblfio.TabIndex = 0;
            this.lblfio.Text = "ФИ: ";
            // 
            // lblparknumber
            // 
            this.lblparknumber.AutoSize = true;
            this.lblparknumber.Location = new System.Drawing.Point(11, 37);
            this.lblparknumber.Name = "lblparknumber";
            this.lblparknumber.Size = new System.Drawing.Size(154, 13);
            this.lblparknumber.TabIndex = 1;
            this.lblparknumber.Text = "Номер парковочного места: ";
            // 
            // lbldaysnumb
            // 
            this.lbldaysnumb.AutoSize = true;
            this.lbldaysnumb.Location = new System.Drawing.Point(11, 62);
            this.lbldaysnumb.Name = "lbldaysnumb";
            this.lbldaysnumb.Size = new System.Drawing.Size(99, 13);
            this.lbldaysnumb.TabIndex = 2;
            this.lbldaysnumb.Text = "Количество дней: ";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(101, 157);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Добавить";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtbxfio
            // 
            this.txtbxfio.Location = new System.Drawing.Point(170, 12);
            this.txtbxfio.Name = "txtbxfio";
            this.txtbxfio.Size = new System.Drawing.Size(100, 20);
            this.txtbxfio.TabIndex = 6;
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(12, 134);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(47, 13);
            this.lblnumber.TabIndex = 10;
            this.lblnumber.Text = "Номер: ";
            // 
            // lblmark
            // 
            this.lblmark.AutoSize = true;
            this.lblmark.Location = new System.Drawing.Point(11, 108);
            this.lblmark.Name = "lblmark";
            this.lblmark.Size = new System.Drawing.Size(88, 13);
            this.lblmark.TabIndex = 9;
            this.lblmark.Text = "Марка машины:";
            // 
            // txtbxnumber
            // 
            this.txtbxnumber.Location = new System.Drawing.Point(171, 131);
            this.txtbxnumber.Name = "txtbxnumber";
            this.txtbxnumber.Size = new System.Drawing.Size(100, 20);
            this.txtbxnumber.TabIndex = 8;
            // 
            // txtbxmark
            // 
            this.txtbxmark.Location = new System.Drawing.Point(171, 105);
            this.txtbxmark.Name = "txtbxmark";
            this.txtbxmark.Size = new System.Drawing.Size(100, 20);
            this.txtbxmark.TabIndex = 7;
            // 
            // txtbxparknumber
            // 
            this.txtbxparknumber.Location = new System.Drawing.Point(171, 34);
            this.txtbxparknumber.Name = "txtbxparknumber";
            this.txtbxparknumber.Size = new System.Drawing.Size(100, 20);
            this.txtbxparknumber.TabIndex = 11;
            // 
            // chbxdiscount
            // 
            this.chbxdiscount.AutoSize = true;
            this.chbxdiscount.Location = new System.Drawing.Point(171, 85);
            this.chbxdiscount.Name = "chbxdiscount";
            this.chbxdiscount.Size = new System.Drawing.Size(15, 14);
            this.chbxdiscount.TabIndex = 12;
            this.chbxdiscount.UseVisualStyleBackColor = true;
            // 
            // txtbxdaysnumb
            // 
            this.txtbxdaysnumb.Location = new System.Drawing.Point(170, 59);
            this.txtbxdaysnumb.Name = "txtbxdaysnumb";
            this.txtbxdaysnumb.Size = new System.Drawing.Size(100, 20);
            this.txtbxdaysnumb.TabIndex = 13;
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Location = new System.Drawing.Point(11, 86);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(152, 13);
            this.lbldiscount.TabIndex = 14;
            this.lbldiscount.Text = "Наличие дисконтной карты: ";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 193);
            this.ControlBox = false;
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.txtbxdaysnumb);
            this.Controls.Add(this.chbxdiscount);
            this.Controls.Add(this.txtbxparknumber);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lblmark);
            this.Controls.Add(this.txtbxnumber);
            this.Controls.Add(this.txtbxmark);
            this.Controls.Add(this.txtbxfio);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lbldaysnumb);
            this.Controls.Add(this.lblparknumber);
            this.Controls.Add(this.lblfio);
            this.Name = "AddClientForm";
            this.Text = "Новый клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfio;
        private System.Windows.Forms.Label lblparknumber;
        private System.Windows.Forms.Label lbldaysnumb;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtbxfio;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblmark;
        private System.Windows.Forms.TextBox txtbxnumber;
        private System.Windows.Forms.TextBox txtbxmark;
        private System.Windows.Forms.TextBox txtbxparknumber;
        private System.Windows.Forms.CheckBox chbxdiscount;
        private System.Windows.Forms.TextBox txtbxdaysnumb;
        private System.Windows.Forms.Label lbldiscount;
    }
}