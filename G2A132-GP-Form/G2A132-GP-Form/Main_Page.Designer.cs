
namespace G2A132_GP_Form
{
    partial class Main_Page
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
            this.btnChangeBuy = new System.Windows.Forms.Button();
            this.picTopPageIcon = new System.Windows.Forms.PictureBox();
            this.btnChangeRental = new System.Windows.Forms.Button();
            this.btnChangePurchase = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNotice = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radRentalGame = new System.Windows.Forms.RadioButton();
            this.radRentalDVDBD = new System.Windows.Forms.RadioButton();
            this.radRentalCD = new System.Windows.Forms.RadioButton();
            this.radRentalMobile = new System.Windows.Forms.RadioButton();
            this.btnMainLogin = new System.Windows.Forms.Button();
            this.btnChangeNewMember = new System.Windows.Forms.Button();
            this.radOnlineGame = new System.Windows.Forms.RadioButton();
            this.radOnlineDVDBD = new System.Windows.Forms.RadioButton();
            this.radOnlineCD = new System.Windows.Forms.RadioButton();
            this.radOnlineMobile = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPageIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeBuy
            // 
            this.btnChangeBuy.Location = new System.Drawing.Point(30, 111);
            this.btnChangeBuy.Name = "btnChangeBuy";
            this.btnChangeBuy.Size = new System.Drawing.Size(144, 37);
            this.btnChangeBuy.TabIndex = 0;
            this.btnChangeBuy.Text = "ネット・店舗で買う";
            this.btnChangeBuy.UseVisualStyleBackColor = true;
            this.btnChangeBuy.Click += new System.EventHandler(this.button1_Click);
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
            // btnChangeRental
            // 
            this.btnChangeRental.Location = new System.Drawing.Point(30, 154);
            this.btnChangeRental.Name = "btnChangeRental";
            this.btnChangeRental.Size = new System.Drawing.Size(144, 37);
            this.btnChangeRental.TabIndex = 2;
            this.btnChangeRental.Text = "宅配レンタル";
            this.btnChangeRental.UseVisualStyleBackColor = true;
            // 
            // btnChangePurchase
            // 
            this.btnChangePurchase.Location = new System.Drawing.Point(30, 197);
            this.btnChangePurchase.Name = "btnChangePurchase";
            this.btnChangePurchase.Size = new System.Drawing.Size(144, 37);
            this.btnChangePurchase.TabIndex = 3;
            this.btnChangePurchase.Text = "ネット・店舗で売る";
            this.btnChangePurchase.UseVisualStyleBackColor = true;
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(259, 136);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(451, 100);
            this.dGV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(255, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "オンラインストア人気作品";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(255, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "宅配レンタル";
            // 
            // btnNotice
            // 
            this.btnNotice.Location = new System.Drawing.Point(30, 240);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(144, 37);
            this.btnNotice.TabIndex = 12;
            this.btnNotice.Text = "お知らせ";
            this.btnNotice.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(259, 325);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(451, 100);
            this.dataGridView2.TabIndex = 13;
            // 
            // radRentalGame
            // 
            this.radRentalGame.AutoSize = true;
            this.radRentalGame.Checked = true;
            this.radRentalGame.Location = new System.Drawing.Point(13, 6);
            this.radRentalGame.Name = "radRentalGame";
            this.radRentalGame.Size = new System.Drawing.Size(64, 19);
            this.radRentalGame.TabIndex = 14;
            this.radRentalGame.TabStop = true;
            this.radRentalGame.Text = "ゲーム";
            this.radRentalGame.UseVisualStyleBackColor = true;
            // 
            // radRentalDVDBD
            // 
            this.radRentalDVDBD.AutoSize = true;
            this.radRentalDVDBD.Location = new System.Drawing.Point(104, 6);
            this.radRentalDVDBD.Name = "radRentalDVDBD";
            this.radRentalDVDBD.Size = new System.Drawing.Size(122, 19);
            this.radRentalDVDBD.TabIndex = 15;
            this.radRentalDVDBD.Text = "DVD・ブルーレイ";
            this.radRentalDVDBD.UseVisualStyleBackColor = true;
            // 
            // radRentalCD
            // 
            this.radRentalCD.AutoSize = true;
            this.radRentalCD.Location = new System.Drawing.Point(232, 6);
            this.radRentalCD.Name = "radRentalCD";
            this.radRentalCD.Size = new System.Drawing.Size(48, 19);
            this.radRentalCD.TabIndex = 16;
            this.radRentalCD.Text = "CD";
            this.radRentalCD.UseVisualStyleBackColor = true;
            // 
            // radRentalMobile
            // 
            this.radRentalMobile.AutoSize = true;
            this.radRentalMobile.Location = new System.Drawing.Point(324, 6);
            this.radRentalMobile.Name = "radRentalMobile";
            this.radRentalMobile.Size = new System.Drawing.Size(75, 19);
            this.radRentalMobile.TabIndex = 17;
            this.radRentalMobile.Text = "モバイル";
            this.radRentalMobile.UseVisualStyleBackColor = true;
            // 
            // btnMainLogin
            // 
            this.btnMainLogin.Location = new System.Drawing.Point(656, 23);
            this.btnMainLogin.Name = "btnMainLogin";
            this.btnMainLogin.Size = new System.Drawing.Size(120, 23);
            this.btnMainLogin.TabIndex = 18;
            this.btnMainLogin.Text = "ログイン";
            this.btnMainLogin.UseVisualStyleBackColor = true;
            // 
            // btnChangeNewMember
            // 
            this.btnChangeNewMember.Location = new System.Drawing.Point(530, 23);
            this.btnChangeNewMember.Name = "btnChangeNewMember";
            this.btnChangeNewMember.Size = new System.Drawing.Size(120, 23);
            this.btnChangeNewMember.TabIndex = 19;
            this.btnChangeNewMember.Text = "新規会員登録";
            this.btnChangeNewMember.UseVisualStyleBackColor = true;
            // 
            // radOnlineGame
            // 
            this.radOnlineGame.AutoSize = true;
            this.radOnlineGame.Checked = true;
            this.radOnlineGame.Location = new System.Drawing.Point(11, 6);
            this.radOnlineGame.Name = "radOnlineGame";
            this.radOnlineGame.Size = new System.Drawing.Size(64, 19);
            this.radOnlineGame.TabIndex = 6;
            this.radOnlineGame.TabStop = true;
            this.radOnlineGame.Text = "ゲーム";
            this.radOnlineGame.UseVisualStyleBackColor = true;
            // 
            // radOnlineDVDBD
            // 
            this.radOnlineDVDBD.AutoSize = true;
            this.radOnlineDVDBD.Location = new System.Drawing.Point(102, 6);
            this.radOnlineDVDBD.Name = "radOnlineDVDBD";
            this.radOnlineDVDBD.Size = new System.Drawing.Size(122, 19);
            this.radOnlineDVDBD.TabIndex = 7;
            this.radOnlineDVDBD.Text = "DVD・ブルーレイ";
            this.radOnlineDVDBD.UseVisualStyleBackColor = true;
            // 
            // radOnlineCD
            // 
            this.radOnlineCD.AutoSize = true;
            this.radOnlineCD.Location = new System.Drawing.Point(230, 6);
            this.radOnlineCD.Name = "radOnlineCD";
            this.radOnlineCD.Size = new System.Drawing.Size(48, 19);
            this.radOnlineCD.TabIndex = 8;
            this.radOnlineCD.Text = "CD";
            this.radOnlineCD.UseVisualStyleBackColor = true;
            // 
            // radOnlineMobile
            // 
            this.radOnlineMobile.AutoSize = true;
            this.radOnlineMobile.Location = new System.Drawing.Point(322, 6);
            this.radOnlineMobile.Name = "radOnlineMobile";
            this.radOnlineMobile.Size = new System.Drawing.Size(75, 19);
            this.radOnlineMobile.TabIndex = 9;
            this.radOnlineMobile.Text = "モバイル";
            this.radOnlineMobile.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radOnlineMobile);
            this.panel1.Controls.Add(this.radOnlineCD);
            this.panel1.Controls.Add(this.radOnlineDVDBD);
            this.panel1.Controls.Add(this.radOnlineGame);
            this.panel1.Location = new System.Drawing.Point(273, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 31);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radRentalMobile);
            this.panel2.Controls.Add(this.radRentalCD);
            this.panel2.Controls.Add(this.radRentalDVDBD);
            this.panel2.Controls.Add(this.radRentalGame);
            this.panel2.Location = new System.Drawing.Point(273, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 31);
            this.panel2.TabIndex = 21;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChangeNewMember);
            this.Controls.Add(this.btnMainLogin);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnNotice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.btnChangePurchase);
            this.Controls.Add(this.btnChangeRental);
            this.Controls.Add(this.picTopPageIcon);
            this.Controls.Add(this.btnChangeBuy);
            this.Name = "Main_Page";
            this.Text = "メインページ";
            this.Load += new System.EventHandler(this.TopPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTopPageIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeBuy;
        private System.Windows.Forms.PictureBox picTopPageIcon;
        private System.Windows.Forms.Button btnChangeRental;
        private System.Windows.Forms.Button btnChangePurchase;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radRentalGame;
        private System.Windows.Forms.RadioButton radRentalDVDBD;
        private System.Windows.Forms.RadioButton radRentalCD;
        private System.Windows.Forms.RadioButton radRentalMobile;
        private System.Windows.Forms.Button btnMainLogin;
        private System.Windows.Forms.Button btnChangeNewMember;
        private System.Windows.Forms.RadioButton radOnlineGame;
        private System.Windows.Forms.RadioButton radOnlineDVDBD;
        private System.Windows.Forms.RadioButton radOnlineCD;
        private System.Windows.Forms.RadioButton radOnlineMobile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

