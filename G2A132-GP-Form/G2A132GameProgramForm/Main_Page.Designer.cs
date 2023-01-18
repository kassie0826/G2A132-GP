
namespace G2A132GameProgramForm
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
            this.button_ChangeBuy = new System.Windows.Forms.Button();
            this.button_ChangeRental = new System.Windows.Forms.Button();
            this.button_ChangePurchase = new System.Windows.Forms.Button();
            this.label_OnlinePopular = new System.Windows.Forms.Label();
            this.label_RentalPopular = new System.Windows.Forms.Label();
            this.button_Notice = new System.Windows.Forms.Button();
            this.button_MainLogin = new System.Windows.Forms.Button();
            this.button_ChangeNewMember = new System.Windows.Forms.Button();
            this.tabControl_OnlineGame = new System.Windows.Forms.TabControl();
            this.tabControl_OnlineGameTab = new System.Windows.Forms.TabPage();
            this.tabControl_OnlineDVDBDTab = new System.Windows.Forms.TabPage();
            this.tabControl_OnlineCDTab = new System.Windows.Forms.TabPage();
            this.tabControl_OnlineMobileTab = new System.Windows.Forms.TabPage();
            this.tabControl_RentalGameTab = new System.Windows.Forms.TabControl();
            this.tabControl_RentalNewRelease = new System.Windows.Forms.TabPage();
            this.tabControl_RentalDVDBD = new System.Windows.Forms.TabPage();
            this.tabControl_RentalCD = new System.Windows.Forms.TabPage();
            this.tabControl_RentalComic = new System.Windows.Forms.TabPage();
            this.btnChengeDB = new System.Windows.Forms.Button();
            this.picTopPageIcon = new System.Windows.Forms.PictureBox();
            this.tabControl_OnlineGame.SuspendLayout();
            this.tabControl_RentalGameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ChangeBuy
            // 
            this.button_ChangeBuy.Location = new System.Drawing.Point(30, 111);
            this.button_ChangeBuy.Name = "button_ChangeBuy";
            this.button_ChangeBuy.Size = new System.Drawing.Size(144, 37);
            this.button_ChangeBuy.TabIndex = 0;
            this.button_ChangeBuy.Text = "ネット・店舗で買う";
            this.button_ChangeBuy.UseVisualStyleBackColor = true;
            // 
            // button_ChangeRental
            // 
            this.button_ChangeRental.Location = new System.Drawing.Point(30, 154);
            this.button_ChangeRental.Name = "button_ChangeRental";
            this.button_ChangeRental.Size = new System.Drawing.Size(144, 37);
            this.button_ChangeRental.TabIndex = 2;
            this.button_ChangeRental.Text = "宅配レンタル";
            this.button_ChangeRental.UseVisualStyleBackColor = true;
            // 
            // button_ChangePurchase
            // 
            this.button_ChangePurchase.Location = new System.Drawing.Point(30, 197);
            this.button_ChangePurchase.Name = "button_ChangePurchase";
            this.button_ChangePurchase.Size = new System.Drawing.Size(144, 37);
            this.button_ChangePurchase.TabIndex = 3;
            this.button_ChangePurchase.Text = "ネット・店舗で売る";
            this.button_ChangePurchase.UseVisualStyleBackColor = true;
            // 
            // label_OnlinePopular
            // 
            this.label_OnlinePopular.AutoSize = true;
            this.label_OnlinePopular.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_OnlinePopular.Location = new System.Drawing.Point(255, 79);
            this.label_OnlinePopular.Name = "label_OnlinePopular";
            this.label_OnlinePopular.Size = new System.Drawing.Size(206, 20);
            this.label_OnlinePopular.TabIndex = 10;
            this.label_OnlinePopular.Text = "オンラインストア人気作品";
            // 
            // label_RentalPopular
            // 
            this.label_RentalPopular.AutoSize = true;
            this.label_RentalPopular.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_RentalPopular.Location = new System.Drawing.Point(255, 268);
            this.label_RentalPopular.Name = "label_RentalPopular";
            this.label_RentalPopular.Size = new System.Drawing.Size(189, 20);
            this.label_RentalPopular.TabIndex = 11;
            this.label_RentalPopular.Text = "宅配レンタル人気作品";
            // 
            // button_Notice
            // 
            this.button_Notice.Location = new System.Drawing.Point(30, 240);
            this.button_Notice.Name = "button_Notice";
            this.button_Notice.Size = new System.Drawing.Size(144, 37);
            this.button_Notice.TabIndex = 12;
            this.button_Notice.Text = "お知らせ";
            this.button_Notice.UseVisualStyleBackColor = true;
            // 
            // button_MainLogin
            // 
            this.button_MainLogin.Location = new System.Drawing.Point(656, 23);
            this.button_MainLogin.Name = "button_MainLogin";
            this.button_MainLogin.Size = new System.Drawing.Size(120, 25);
            this.button_MainLogin.TabIndex = 18;
            this.button_MainLogin.Text = "ログイン";
            this.button_MainLogin.UseVisualStyleBackColor = true;
            this.button_MainLogin.Click += new System.EventHandler(this.button_MainLogin_Click);
            // 
            // button_ChangeNewMember
            // 
            this.button_ChangeNewMember.Location = new System.Drawing.Point(530, 23);
            this.button_ChangeNewMember.Name = "button_ChangeNewMember";
            this.button_ChangeNewMember.Size = new System.Drawing.Size(120, 25);
            this.button_ChangeNewMember.TabIndex = 19;
            this.button_ChangeNewMember.Text = "新規会員登録";
            this.button_ChangeNewMember.UseVisualStyleBackColor = true;
            this.button_ChangeNewMember.Click += new System.EventHandler(this.button_ChangeNewMember_Click);
            // 
            // tabControl_OnlineGame
            // 
            this.tabControl_OnlineGame.Controls.Add(this.tabControl_OnlineGameTab);
            this.tabControl_OnlineGame.Controls.Add(this.tabControl_OnlineDVDBDTab);
            this.tabControl_OnlineGame.Controls.Add(this.tabControl_OnlineCDTab);
            this.tabControl_OnlineGame.Controls.Add(this.tabControl_OnlineMobileTab);
            this.tabControl_OnlineGame.ItemSize = new System.Drawing.Size(136, 21);
            this.tabControl_OnlineGame.Location = new System.Drawing.Point(238, 102);
            this.tabControl_OnlineGame.Name = "tabControl_OnlineGame";
            this.tabControl_OnlineGame.SelectedIndex = 0;
            this.tabControl_OnlineGame.Size = new System.Drawing.Size(550, 150);
            this.tabControl_OnlineGame.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_OnlineGame.TabIndex = 20;
            // 
            // tabControl_OnlineGameTab
            // 
            this.tabControl_OnlineGameTab.BackColor = System.Drawing.Color.White;
            this.tabControl_OnlineGameTab.Location = new System.Drawing.Point(4, 25);
            this.tabControl_OnlineGameTab.Name = "tabControl_OnlineGameTab";
            this.tabControl_OnlineGameTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_OnlineGameTab.Size = new System.Drawing.Size(542, 121);
            this.tabControl_OnlineGameTab.TabIndex = 0;
            this.tabControl_OnlineGameTab.Text = "ゲーム";
            // 
            // tabControl_OnlineDVDBDTab
            // 
            this.tabControl_OnlineDVDBDTab.Location = new System.Drawing.Point(4, 25);
            this.tabControl_OnlineDVDBDTab.Name = "tabControl_OnlineDVDBDTab";
            this.tabControl_OnlineDVDBDTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_OnlineDVDBDTab.Size = new System.Drawing.Size(542, 121);
            this.tabControl_OnlineDVDBDTab.TabIndex = 1;
            this.tabControl_OnlineDVDBDTab.Text = "DVD・ブルーレイ";
            this.tabControl_OnlineDVDBDTab.UseVisualStyleBackColor = true;
            // 
            // tabControl_OnlineCDTab
            // 
            this.tabControl_OnlineCDTab.Location = new System.Drawing.Point(4, 25);
            this.tabControl_OnlineCDTab.Name = "tabControl_OnlineCDTab";
            this.tabControl_OnlineCDTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_OnlineCDTab.Size = new System.Drawing.Size(542, 121);
            this.tabControl_OnlineCDTab.TabIndex = 2;
            this.tabControl_OnlineCDTab.Text = "CD";
            this.tabControl_OnlineCDTab.UseVisualStyleBackColor = true;
            // 
            // tabControl_OnlineMobileTab
            // 
            this.tabControl_OnlineMobileTab.Location = new System.Drawing.Point(4, 25);
            this.tabControl_OnlineMobileTab.Name = "tabControl_OnlineMobileTab";
            this.tabControl_OnlineMobileTab.Size = new System.Drawing.Size(542, 121);
            this.tabControl_OnlineMobileTab.TabIndex = 3;
            this.tabControl_OnlineMobileTab.Text = "モバイル";
            this.tabControl_OnlineMobileTab.UseVisualStyleBackColor = true;
            // 
            // tabControl_RentalGameTab
            // 
            this.tabControl_RentalGameTab.Controls.Add(this.tabControl_RentalNewRelease);
            this.tabControl_RentalGameTab.Controls.Add(this.tabControl_RentalDVDBD);
            this.tabControl_RentalGameTab.Controls.Add(this.tabControl_RentalCD);
            this.tabControl_RentalGameTab.Controls.Add(this.tabControl_RentalComic);
            this.tabControl_RentalGameTab.ItemSize = new System.Drawing.Size(136, 21);
            this.tabControl_RentalGameTab.Location = new System.Drawing.Point(238, 291);
            this.tabControl_RentalGameTab.Name = "tabControl_RentalGameTab";
            this.tabControl_RentalGameTab.SelectedIndex = 0;
            this.tabControl_RentalGameTab.Size = new System.Drawing.Size(550, 150);
            this.tabControl_RentalGameTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_RentalGameTab.TabIndex = 21;
            // 
            // tabControl_RentalNewRelease
            // 
            this.tabControl_RentalNewRelease.Location = new System.Drawing.Point(4, 25);
            this.tabControl_RentalNewRelease.Name = "tabControl_RentalNewRelease";
            this.tabControl_RentalNewRelease.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_RentalNewRelease.Size = new System.Drawing.Size(542, 121);
            this.tabControl_RentalNewRelease.TabIndex = 0;
            this.tabControl_RentalNewRelease.Text = "Newリリース";
            this.tabControl_RentalNewRelease.UseVisualStyleBackColor = true;
            // 
            // tabControl_RentalDVDBD
            // 
            this.tabControl_RentalDVDBD.Location = new System.Drawing.Point(4, 25);
            this.tabControl_RentalDVDBD.Name = "tabControl_RentalDVDBD";
            this.tabControl_RentalDVDBD.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_RentalDVDBD.Size = new System.Drawing.Size(542, 121);
            this.tabControl_RentalDVDBD.TabIndex = 1;
            this.tabControl_RentalDVDBD.Text = "DVD・ブルーレイ";
            this.tabControl_RentalDVDBD.UseVisualStyleBackColor = true;
            // 
            // tabControl_RentalCD
            // 
            this.tabControl_RentalCD.Location = new System.Drawing.Point(4, 25);
            this.tabControl_RentalCD.Name = "tabControl_RentalCD";
            this.tabControl_RentalCD.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_RentalCD.Size = new System.Drawing.Size(542, 121);
            this.tabControl_RentalCD.TabIndex = 2;
            this.tabControl_RentalCD.Text = "CD";
            this.tabControl_RentalCD.UseVisualStyleBackColor = true;
            // 
            // tabControl_RentalComic
            // 
            this.tabControl_RentalComic.Location = new System.Drawing.Point(4, 25);
            this.tabControl_RentalComic.Name = "tabControl_RentalComic";
            this.tabControl_RentalComic.Size = new System.Drawing.Size(542, 121);
            this.tabControl_RentalComic.TabIndex = 3;
            this.tabControl_RentalComic.Text = "コミック";
            this.tabControl_RentalComic.UseVisualStyleBackColor = true;
            // 
            // btnChengeDB
            // 
            this.btnChengeDB.Location = new System.Drawing.Point(30, 357);
            this.btnChengeDB.Name = "btnChengeDB";
            this.btnChengeDB.Size = new System.Drawing.Size(144, 23);
            this.btnChengeDB.TabIndex = 22;
            this.btnChengeDB.UseVisualStyleBackColor = true;
            this.btnChengeDB.Click += new System.EventHandler(this.btnChengeDB_Click);
            // 
            // picTopPageIcon
            // 
            this.picTopPageIcon.Location = new System.Drawing.Point(12, 12);
            this.picTopPageIcon.Name = "picTopPageIcon";
            this.picTopPageIcon.Size = new System.Drawing.Size(144, 73);
            this.picTopPageIcon.TabIndex = 1;
            this.picTopPageIcon.TabStop = false;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.btnChengeDB);
            this.Controls.Add(this.tabControl_RentalGameTab);
            this.Controls.Add(this.tabControl_OnlineGame);
            this.Controls.Add(this.button_ChangeNewMember);
            this.Controls.Add(this.button_MainLogin);
            this.Controls.Add(this.button_Notice);
            this.Controls.Add(this.label_RentalPopular);
            this.Controls.Add(this.label_OnlinePopular);
            this.Controls.Add(this.button_ChangePurchase);
            this.Controls.Add(this.button_ChangeRental);
            this.Controls.Add(this.picTopPageIcon);
            this.Controls.Add(this.button_ChangeBuy);
            this.Name = "Main_Page";
            this.Text = "メインページ";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl_OnlineGame.ResumeLayout(false);
            this.tabControl_RentalGameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTopPageIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ChangeBuy;
        private System.Windows.Forms.PictureBox picTopPageIcon;
        private System.Windows.Forms.Button button_ChangeRental;
        private System.Windows.Forms.Button button_ChangePurchase;
        private System.Windows.Forms.Label label_OnlinePopular;
        private System.Windows.Forms.Label label_RentalPopular;
        private System.Windows.Forms.Button button_Notice;
        private System.Windows.Forms.Button button_MainLogin;
        private System.Windows.Forms.Button button_ChangeNewMember;
        private System.Windows.Forms.TabControl tabControl_OnlineGame;
        private System.Windows.Forms.TabPage tabControl_OnlineGameTab;
        private System.Windows.Forms.TabPage tabControl_OnlineDVDBDTab;
        private System.Windows.Forms.TabPage tabControl_OnlineCDTab;
        private System.Windows.Forms.TabPage tabControl_OnlineMobileTab;
        private System.Windows.Forms.TabControl tabControl_RentalGameTab;
        private System.Windows.Forms.TabPage tabControl_RentalNewRelease;
        private System.Windows.Forms.TabPage tabControl_RentalDVDBD;
        private System.Windows.Forms.TabPage tabControl_RentalCD;
        private System.Windows.Forms.TabPage tabControl_RentalComic;
        private System.Windows.Forms.Button btnChengeDB;
    }
}

