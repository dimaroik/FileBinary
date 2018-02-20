namespace FileBinary.UI
{
    partial class Form1
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
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.ButtonInFolder = new System.Windows.Forms.Button();
            this.ComboBoxFiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonSelect.Location = new System.Drawing.Point(12, 29);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(193, 54);
            this.ButtonSelect.TabIndex = 2;
            this.ButtonSelect.Text = "Pack";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // ButtonInFolder
            // 
            this.ButtonInFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonInFolder.Location = new System.Drawing.Point(12, 134);
            this.ButtonInFolder.Name = "ButtonInFolder";
            this.ButtonInFolder.Size = new System.Drawing.Size(193, 72);
            this.ButtonInFolder.TabIndex = 3;
            this.ButtonInFolder.Text = "Unpack";
            this.ButtonInFolder.UseVisualStyleBackColor = true;
            this.ButtonInFolder.Click += new System.EventHandler(this.ButtonInFolder_Click);
            // 
            // ComboBoxFiles
            // 
            this.ComboBoxFiles.AutoCompleteCustomSource.AddRange(new string[] {
            "Select_File"});
            this.ComboBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ComboBoxFiles.FormattingEnabled = true;
            this.ComboBoxFiles.Location = new System.Drawing.Point(212, 85);
            this.ComboBoxFiles.Name = "ComboBoxFiles";
            this.ComboBoxFiles.Size = new System.Drawing.Size(162, 25);
            this.ComboBoxFiles.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(224, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your list with pack files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "button PACK - Add to list new pack file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "For button UNPACK - select a file with drop down list ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 264);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxFiles);
            this.Controls.Add(this.ButtonInFolder);
            this.Controls.Add(this.ButtonSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Button ButtonInFolder;
        private System.Windows.Forms.ComboBox ComboBoxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

