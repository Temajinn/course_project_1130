namespace course_project_parking
{
    partial class CalculateForm
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
            this.txtbxNumberOfDays = new System.Windows.Forms.TextBox();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTariffs = new System.Windows.Forms.Label();
            this.rbtnTariffEconomic = new System.Windows.Forms.RadioButton();
            this.rbtnTariffLongTerm = new System.Windows.Forms.RadioButton();
            this.lbldisc = new System.Windows.Forms.Label();
            this.chbxDiscount = new System.Windows.Forms.CheckBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxNumberOfDays
            // 
            this.txtbxNumberOfDays.Location = new System.Drawing.Point(116, 6);
            this.txtbxNumberOfDays.Name = "txtbxNumberOfDays";
            this.txtbxNumberOfDays.Size = new System.Drawing.Size(100, 20);
            this.txtbxNumberOfDays.TabIndex = 2;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(12, 9);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(99, 13);
            this.lblNumberOfDays.TabIndex = 4;
            this.lblNumberOfDays.Text = "Количество дней: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 166);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // lblTariffs
            // 
            this.lblTariffs.AutoSize = true;
            this.lblTariffs.Location = new System.Drawing.Point(12, 35);
            this.lblTariffs.Name = "lblTariffs";
            this.lblTariffs.Size = new System.Drawing.Size(54, 13);
            this.lblTariffs.TabIndex = 6;
            this.lblTariffs.Text = "Тарифы: ";
            // 
            // rbtnTariffEconomic
            // 
            this.rbtnTariffEconomic.AutoSize = true;
            this.rbtnTariffEconomic.Location = new System.Drawing.Point(15, 64);
            this.rbtnTariffEconomic.Name = "rbtnTariffEconomic";
            this.rbtnTariffEconomic.Size = new System.Drawing.Size(84, 17);
            this.rbtnTariffEconomic.TabIndex = 7;
            this.rbtnTariffEconomic.TabStop = true;
            this.rbtnTariffEconomic.Text = "Экономный";
            this.rbtnTariffEconomic.UseVisualStyleBackColor = true;
            // 
            // rbtnTariffLongTerm
            // 
            this.rbtnTariffLongTerm.AutoSize = true;
            this.rbtnTariffLongTerm.Location = new System.Drawing.Point(15, 87);
            this.rbtnTariffLongTerm.Name = "rbtnTariffLongTerm";
            this.rbtnTariffLongTerm.Size = new System.Drawing.Size(63, 17);
            this.rbtnTariffLongTerm.TabIndex = 8;
            this.rbtnTariffLongTerm.TabStop = true;
            this.rbtnTariffLongTerm.Text = "Долгий";
            this.rbtnTariffLongTerm.UseVisualStyleBackColor = true;
            // 
            // lbldisc
            // 
            this.lbldisc.AutoSize = true;
            this.lbldisc.Location = new System.Drawing.Point(15, 111);
            this.lbldisc.Name = "lbldisc";
            this.lbldisc.Size = new System.Drawing.Size(152, 13);
            this.lbldisc.TabIndex = 9;
            this.lbldisc.Text = "Наличие дисконтной карты: ";
            // 
            // chbxDiscount
            // 
            this.chbxDiscount.AutoSize = true;
            this.chbxDiscount.Location = new System.Drawing.Point(173, 111);
            this.chbxDiscount.Name = "chbxDiscount";
            this.chbxDiscount.Size = new System.Drawing.Size(15, 14);
            this.chbxDiscount.TabIndex = 10;
            this.chbxDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(141, 131);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 11;
            this.btnCount.Text = "Вычислить";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 199);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.chbxDiscount);
            this.Controls.Add(this.lbldisc);
            this.Controls.Add(this.rbtnTariffLongTerm);
            this.Controls.Add(this.rbtnTariffEconomic);
            this.Controls.Add(this.lblTariffs);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.txtbxNumberOfDays);
            this.Name = "CalculateForm";
            this.Text = "Расчет стоимости";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxNumberOfDays;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTariffs;
        private System.Windows.Forms.RadioButton rbtnTariffEconomic;
        private System.Windows.Forms.RadioButton rbtnTariffLongTerm;
        private System.Windows.Forms.Label lbldisc;
        private System.Windows.Forms.CheckBox chbxDiscount;
        private System.Windows.Forms.Button btnCount;
    }
}