namespace maduka_ComputerVision
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.lblImgPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtComputerVisionResult = new System.Windows.Forms.TextBox();
            this.txtCaptions = new System.Windows.Forms.TextBox();
            this.btnTranslator = new System.Windows.Forms.Button();
            this.txtTranslatorResult = new System.Windows.Forms.TextBox();
            this.plImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtImagePath
            // 
            this.txtImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagePath.Location = new System.Drawing.Point(42, 10);
            this.txtImagePath.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(610, 22);
            this.txtImagePath.TabIndex = 0;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenImage.Location = new System.Drawing.Point(658, 9);
            this.btnOpenImage.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 1;
            this.btnOpenImage.Text = "Open";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // lblImgPath
            // 
            this.lblImgPath.AutoSize = true;
            this.lblImgPath.Location = new System.Drawing.Point(12, 15);
            this.lblImgPath.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblImgPath.Name = "lblImgPath";
            this.lblImgPath.Size = new System.Drawing.Size(29, 12);
            this.lblImgPath.TabIndex = 4;
            this.lblImgPath.Text = "圖片";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG檔案|*.jpg|PNG檔案|*.png";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtComputerVisionResult
            // 
            this.txtComputerVisionResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComputerVisionResult.Location = new System.Drawing.Point(12, 447);
            this.txtComputerVisionResult.Multiline = true;
            this.txtComputerVisionResult.Name = "txtComputerVisionResult";
            this.txtComputerVisionResult.ReadOnly = true;
            this.txtComputerVisionResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComputerVisionResult.Size = new System.Drawing.Size(721, 127);
            this.txtComputerVisionResult.TabIndex = 5;
            // 
            // txtCaptions
            // 
            this.txtCaptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaptions.Location = new System.Drawing.Point(12, 580);
            this.txtCaptions.Name = "txtCaptions";
            this.txtCaptions.ReadOnly = true;
            this.txtCaptions.Size = new System.Drawing.Size(640, 22);
            this.txtCaptions.TabIndex = 6;
            // 
            // btnTranslator
            // 
            this.btnTranslator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTranslator.Location = new System.Drawing.Point(658, 580);
            this.btnTranslator.Name = "btnTranslator";
            this.btnTranslator.Size = new System.Drawing.Size(75, 23);
            this.btnTranslator.TabIndex = 7;
            this.btnTranslator.Text = "Translator";
            this.btnTranslator.UseVisualStyleBackColor = true;
            this.btnTranslator.Click += new System.EventHandler(this.btnTranslator_Click);
            // 
            // txtTranslatorResult
            // 
            this.txtTranslatorResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTranslatorResult.Location = new System.Drawing.Point(12, 607);
            this.txtTranslatorResult.Name = "txtTranslatorResult";
            this.txtTranslatorResult.ReadOnly = true;
            this.txtTranslatorResult.Size = new System.Drawing.Size(721, 22);
            this.txtTranslatorResult.TabIndex = 8;
            // 
            // plImage
            // 
            this.plImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plImage.Location = new System.Drawing.Point(14, 37);
            this.plImage.Name = "plImage";
            this.plImage.Size = new System.Drawing.Size(719, 404);
            this.plImage.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 641);
            this.Controls.Add(this.plImage);
            this.Controls.Add(this.txtTranslatorResult);
            this.Controls.Add(this.btnTranslator);
            this.Controls.Add(this.txtCaptions);
            this.Controls.Add(this.txtComputerVisionResult);
            this.Controls.Add(this.lblImgPath);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.txtImagePath);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmMain";
            this.Text = "Computer Vision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Label lblImgPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtComputerVisionResult;
        private System.Windows.Forms.TextBox txtCaptions;
        private System.Windows.Forms.Button btnTranslator;
        private System.Windows.Forms.TextBox txtTranslatorResult;
        private System.Windows.Forms.Panel plImage;
    }
}

