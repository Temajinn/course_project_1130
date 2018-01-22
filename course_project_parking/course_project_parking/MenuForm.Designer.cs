namespace course_project_parking
{
    partial class MenuForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncllist = new System.Windows.Forms.Button();
            this.btnparkmap = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncllist
            // 
            this.btncllist.Location = new System.Drawing.Point(12, 12);
            this.btncllist.Name = "btncllist";
            this.btncllist.Size = new System.Drawing.Size(118, 23);
            this.btncllist.TabIndex = 0;
            this.btncllist.Text = "Список клиентов";
            this.btncllist.UseVisualStyleBackColor = true;
            this.btncllist.Click += new System.EventHandler(this.btncllist_Click);
            // 
            // btnparkmap
            // 
            this.btnparkmap.Location = new System.Drawing.Point(12, 41);
            this.btnparkmap.Name = "btnparkmap";
            this.btnparkmap.Size = new System.Drawing.Size(118, 23);
            this.btnparkmap.TabIndex = 1;
            this.btnparkmap.Text = "План парковки";
            this.btnparkmap.UseVisualStyleBackColor = true;
            this.btnparkmap.Click += new System.EventHandler(this.btnparkmap_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(12, 70);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(118, 23);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Выход";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 107);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnparkmap);
            this.Controls.Add(this.btncllist);
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncllist;
        private System.Windows.Forms.Button btnparkmap;
        private System.Windows.Forms.Button btnexit;

    }
}

