﻿namespace newArchive
{
    partial class Main_Form
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
            this.create_archive = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.choseFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // create_archive
            // 
            this.create_archive.Location = new System.Drawing.Point(205, 146);
            this.create_archive.Name = "create_archive";
            this.create_archive.Size = new System.Drawing.Size(75, 23);
            this.create_archive.TabIndex = 0;
            this.create_archive.Text = "архивация";
            this.create_archive.UseVisualStyleBackColor = true;
            this.create_archive.Click += new System.EventHandler(this.create_archive_Click);
            // 
            // choseFile
            // 
            this.choseFile.FileName = "choseFie";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 403);
            this.Controls.Add(this.create_archive);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_archive;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog choseFile;
    }
}

