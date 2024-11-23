using System.Windows.Forms;

namespace RblDownload
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.ChoseDLPathBtn = new System.Windows.Forms.Button();
            this.X1Type = new System.Windows.Forms.ComboBox();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePathText
            // 
            this.FilePathText.Location = new System.Drawing.Point(25, 28);
            this.FilePathText.Multiline = true;
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.Size = new System.Drawing.Size(399, 38);
            this.FilePathText.TabIndex = 0;
            // 
            // ChoseDLPathBtn
            // 
            this.ChoseDLPathBtn.Location = new System.Drawing.Point(534, 28);
            this.ChoseDLPathBtn.Name = "ChoseDLPathBtn";
            this.ChoseDLPathBtn.Size = new System.Drawing.Size(96, 38);
            this.ChoseDLPathBtn.TabIndex = 1;
            this.ChoseDLPathBtn.Text = "选择下载路径";
            this.ChoseDLPathBtn.UseVisualStyleBackColor = true;
            this.ChoseDLPathBtn.Click += new System.EventHandler(this.ChoseDLPathBtn_Click);
            // 
            // X1Type
            // 
            this.X1Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.X1Type.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.X1Type.FormattingEnabled = true;
            this.X1Type.ItemHeight = 16;
            this.X1Type.Items.AddRange(new object[] {
            "T113",
            "R6"});
            this.X1Type.Location = new System.Drawing.Point(25, 107);
            this.X1Type.Name = "X1Type";
            this.X1Type.Size = new System.Drawing.Size(119, 24);
            this.X1Type.TabIndex = 2;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Location = new System.Drawing.Point(249, 287);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(123, 40);
            this.DownloadBtn.TabIndex = 3;
            this.DownloadBtn.Text = "一键下载";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 393);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.X1Type);
            this.Controls.Add(this.ChoseDLPathBtn);
            this.Controls.Add(this.FilePathText);
            this.Name = "Form1";
            this.Text = "X1内核下载";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(Form_DragDrop);
            this.DragEnter += new DragEventHandler(Form_DragEnter); // 绑定拖放事件处理程序
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.Button ChoseDLPathBtn;
        private System.Windows.Forms.ComboBox X1Type;
        private System.Windows.Forms.Button DownloadBtn;
    }
}

