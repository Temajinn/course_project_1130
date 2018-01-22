namespace course_project_parking
{
    partial class ClientList
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
            this.lblcllisthelp = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnShowDebtors = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.lstbxClienList = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFDClientFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFDClientList = new System.Windows.Forms.SaveFileDialog();
            this.btnReturnToMainList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcllisthelp
            // 
            this.lblcllisthelp.AutoSize = true;
            this.lblcllisthelp.Location = new System.Drawing.Point(13, 13);
            this.lblcllisthelp.Name = "lblcllisthelp";
            this.lblcllisthelp.Size = new System.Drawing.Size(100, 13);
            this.lblcllisthelp.TabIndex = 0;
            this.lblcllisthelp.Text = "Список клиентов: ";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(33, 168);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(132, 31);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnShowDebtors
            // 
            this.btnShowDebtors.Location = new System.Drawing.Point(33, 205);
            this.btnShowDebtors.Name = "btnShowDebtors";
            this.btnShowDebtors.Size = new System.Drawing.Size(132, 31);
            this.btnShowDebtors.TabIndex = 3;
            this.btnShowDebtors.Text = "Показать должников";
            this.btnShowDebtors.UseVisualStyleBackColor = true;
            this.btnShowDebtors.Click += new System.EventHandler(this.btnShowDebtors_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(184, 242);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(132, 42);
            this.btnCalculator.TabIndex = 5;
            this.btnCalculator.Text = "Калькулятор";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // lstbxClienList
            // 
            this.lstbxClienList.FormattingEnabled = true;
            this.lstbxClienList.Location = new System.Drawing.Point(16, 29);
            this.lstbxClienList.Name = "lstbxClienList";
            this.lstbxClienList.Size = new System.Drawing.Size(657, 95);
            this.lstbxClienList.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(184, 205);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(132, 30);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFDClientFile
            // 
            this.openFDClientFile.FileName = "ClientList.txt";
            this.saveFDClientList.FileName = "ClientList.txt";
            // 
            // btnReturnToMainList
            // 
            this.btnReturnToMainList.Location = new System.Drawing.Point(33, 242);
            this.btnReturnToMainList.Name = "btnReturnToMainList";
            this.btnReturnToMainList.Size = new System.Drawing.Size(132, 42);
            this.btnReturnToMainList.TabIndex = 8;
            this.btnReturnToMainList.Text = "Вернуться к основному списку.";
            this.btnReturnToMainList.UseVisualStyleBackColor = true;
            this.btnReturnToMainList.Click += new System.EventHandler(this.btnReturnToMainList_Click);
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 309);
            this.Controls.Add(this.btnReturnToMainList);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lstbxClienList);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowDebtors);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblcllisthelp);
            this.Name = "ClientList";
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.ClientList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcllisthelp;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnShowDebtors;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.ListBox lstbxClienList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFDClientFile;
        private System.Windows.Forms.SaveFileDialog saveFDClientList;
        private System.Windows.Forms.Button btnReturnToMainList;
    }
}