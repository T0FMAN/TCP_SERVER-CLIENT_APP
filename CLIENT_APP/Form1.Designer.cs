namespace CLIENT_APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFilesBtn = new System.Windows.Forms.Button();
            this.SendFilesBtn = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.labelFilesToSend = new System.Windows.Forms.Label();
            this.labelCountSelectedFiles = new System.Windows.Forms.Label();
            this.labelPathToFolder = new System.Windows.Forms.Label();
            this.progressSendFiles = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // SelectFilesBtn
            // 
            this.SelectFilesBtn.Location = new System.Drawing.Point(264, 334);
            this.SelectFilesBtn.Name = "SelectFilesBtn";
            this.SelectFilesBtn.Size = new System.Drawing.Size(141, 23);
            this.SelectFilesBtn.TabIndex = 0;
            this.SelectFilesBtn.Text = "Выбрать файлы";
            this.SelectFilesBtn.UseVisualStyleBackColor = true;
            this.SelectFilesBtn.Click += new System.EventHandler(this.SelectFilesBtn_Click);
            // 
            // SendFilesBtn
            // 
            this.SendFilesBtn.Location = new System.Drawing.Point(411, 334);
            this.SendFilesBtn.Name = "SendFilesBtn";
            this.SendFilesBtn.Size = new System.Drawing.Size(141, 23);
            this.SendFilesBtn.TabIndex = 1;
            this.SendFilesBtn.Text = "Загрузить файлы";
            this.SendFilesBtn.UseVisualStyleBackColor = true;
            this.SendFilesBtn.Click += new System.EventHandler(this.SendFilesBtn_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 15;
            this.listBoxFiles.Location = new System.Drawing.Point(264, 96);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(288, 229);
            this.listBoxFiles.TabIndex = 2;
            // 
            // labelFilesToSend
            // 
            this.labelFilesToSend.AutoSize = true;
            this.labelFilesToSend.Location = new System.Drawing.Point(264, 78);
            this.labelFilesToSend.Name = "labelFilesToSend";
            this.labelFilesToSend.Size = new System.Drawing.Size(123, 15);
            this.labelFilesToSend.TabIndex = 3;
            this.labelFilesToSend.Text = "Файлов к отправке: 0";
            // 
            // labelCountSelectedFiles
            // 
            this.labelCountSelectedFiles.AutoSize = true;
            this.labelCountSelectedFiles.Location = new System.Drawing.Point(264, 63);
            this.labelCountSelectedFiles.Name = "labelCountSelectedFiles";
            this.labelCountSelectedFiles.Size = new System.Drawing.Size(114, 15);
            this.labelCountSelectedFiles.TabIndex = 4;
            this.labelCountSelectedFiles.Text = "Выбрано файлов: 0";
            // 
            // labelPathToFolder
            // 
            this.labelPathToFolder.AutoSize = true;
            this.labelPathToFolder.Location = new System.Drawing.Point(264, 48);
            this.labelPathToFolder.Name = "labelPathToFolder";
            this.labelPathToFolder.Size = new System.Drawing.Size(83, 15);
            this.labelPathToFolder.TabIndex = 5;
            this.labelPathToFolder.Text = "Путь к папке: ";
            // 
            // progressSendFiles
            // 
            this.progressSendFiles.Location = new System.Drawing.Point(264, 371);
            this.progressSendFiles.Name = "progressSendFiles";
            this.progressSendFiles.Size = new System.Drawing.Size(288, 23);
            this.progressSendFiles.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressSendFiles);
            this.Controls.Add(this.labelPathToFolder);
            this.Controls.Add(this.labelCountSelectedFiles);
            this.Controls.Add(this.labelFilesToSend);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.SendFilesBtn);
            this.Controls.Add(this.SelectFilesBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectFilesBtn;
        private Button SendFilesBtn;
        private ListBox listBoxFiles;
        private Label labelFilesToSend;
        private Label labelCountSelectedFiles;
        private Label labelPathToFolder;
        private ProgressBar progressSendFiles;
    }
}