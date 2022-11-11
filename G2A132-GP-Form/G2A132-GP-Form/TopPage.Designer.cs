
namespace G2A132_GP_Form
{
    partial class TopPage
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.picTopPageIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picTopPageIcon
            // 
            this.picTopPageIcon.Location = new System.Drawing.Point(12, 12);
            this.picTopPageIcon.Name = "picTopPageIcon";
            this.picTopPageIcon.Size = new System.Drawing.Size(144, 73);
            this.picTopPageIcon.TabIndex = 1;
            this.picTopPageIcon.TabStop = false;
            this.picTopPageIcon.Click += new System.EventHandler(this.picTopPageIcon_Click);
            // 
            // TopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picTopPageIcon);
            this.Controls.Add(this.button1);
            this.Name = "TopPage";
            this.Text = "TopPage";
            this.Load += new System.EventHandler(this.TopPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTopPageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picTopPageIcon;
    }
}

