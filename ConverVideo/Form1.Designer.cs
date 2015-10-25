namespace ConverVideo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileButton = new System.Windows.Forms.Button();
            this.convertToH = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.convertToS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(168, 49);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "openFile";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // convertToH
            // 
            this.convertToH.Location = new System.Drawing.Point(58, 167);
            this.convertToH.Name = "convertToH";
            this.convertToH.Size = new System.Drawing.Size(102, 23);
            this.convertToH.TabIndex = 1;
            this.convertToH.Text = "S264 To H264";
            this.convertToH.UseVisualStyleBackColor = true;
            this.convertToH.Click += new System.EventHandler(this.start_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // convertToS
            // 
            this.convertToS.Location = new System.Drawing.Point(236, 167);
            this.convertToS.Name = "convertToS";
            this.convertToS.Size = new System.Drawing.Size(102, 23);
            this.convertToS.TabIndex = 1;
            this.convertToS.Text = "H264 To S264";
            this.convertToS.UseVisualStyleBackColor = true;
            this.convertToS.Click += new System.EventHandler(this.convertToS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 256);
            this.Controls.Add(this.convertToS);
            this.Controls.Add(this.convertToH);
            this.Controls.Add(this.openFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button convertToH;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button convertToS;
    }
}

