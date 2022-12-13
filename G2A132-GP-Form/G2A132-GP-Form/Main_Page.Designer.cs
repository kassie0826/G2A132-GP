
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
            this.btnChangeRental = new System.Windows.Forms.Button();
            this.btnChangePurchase = new System.Windows.Forms.Button();
            this.labOnlinePopular = new System.Windows.Forms.Label();
            this.labRentalPopular = new System.Windows.Forms.Label();
            this.btnNotice = new System.Windows.Forms.Button();
            this.btnMainLogin = new System.Windows.Forms.Button();
            this.btnChangeNewMember = new System.Windows.Forms.Button();
            this.tabConOnlineGame = new System.Windows.Forms.TabControl();
            this.tabConOnlineGameTab = new System.Windows.Forms.TabPage();
            this.tabConOnlineDVDBDTab = new System.Windows.Forms.TabPage();
            this.tabConOnlineCDTab = new System.Windows.Forms.TabPage();
            this.tabConOnlineMobileTab = new System.Windows.Forms.TabPage();
            this.tabConRentalGameTab = new System.Windows.Forms.TabControl();
            this.tabRentalNewRelease = new System.Windows.Forms.TabPage();
            this.tabRentalDVDBD = new System.Windows.Forms.TabPage();
            this.tabRentalCD = new System.Windows.Forms.TabPage();
            this.tabRentalComic = new System.Windows.Forms.TabPage();
            this.btnChengeDB = new System.Windows.Forms.Button();
            this.picTopPageIcon = new System.Windows.Forms.PictureBox();
            this.tabConOnlineGame.SuspendLayout();
            this.tabConRentalGameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPageIcon)).BeginInit();
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
            // labOnlinePopular
            // 
            this.labOnlinePopular.AutoSize = true;
            this.labOnlinePopular.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labOnlinePopular.Location = new System.Drawing.Point(255, 79);
            this.labOnlinePopular.Name = "labOnlinePopular";
            this.labOnlinePopular.Size = new System.Drawing.Size(206, 20);
            this.labOnlinePopular.TabIndex = 10;
            this.labOnlinePopular.Text = "オンラインストア人気作品";
            // 
            // labRentalPopular
            // 
            this.labRentalPopular.AutoSize = true;
            this.labRentalPopular.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labRentalPopular.Location = new System.Drawing.Point(255, 268);
            this.labRentalPopular.Name = "labRentalPopular";
            this.labRentalPopular.Size = new System.Drawing.Size(189, 20);
            this.labRentalPopular.TabIndex = 11;
            this.labRentalPopular.Text = "宅配レンタル人気作品";
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
            this.btnChangeNewMember.Click += new System.EventHandler(this.btnChangeNewMember_Click);
            // 
            // tabConOnlineGame
            // 
            this.tabConOnlineGame.Controls.Add(this.tabConOnlineGameTab);
            this.tabConOnlineGame.Controls.Add(this.tabConOnlineDVDBDTab);
            this.tabConOnlineGame.Controls.Add(this.tabConOnlineCDTab);
            this.tabConOnlineGame.Controls.Add(this.tabConOnlineMobileTab);
            this.tabConOnlineGame.ItemSize = new System.Drawing.Size(136, 21);
            this.tabConOnlineGame.Location = new System.Drawing.Point(238, 102);
            this.tabConOnlineGame.Name = "tabConOnlineGame";
            this.tabConOnlineGame.SelectedIndex = 0;
            this.tabConOnlineGame.Size = new System.Drawing.Size(550, 150);
            this.tabConOnlineGame.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabConOnlineGame.TabIndex = 20;
            // 
            // tabConOnlineGameTab
            // 
            this.tabConOnlineGameTab.BackColor = System.Drawing.Color.White;
            this.tabConOnlineGameTab.Location = new System.Drawing.Point(4, 25);
            this.tabConOnlineGameTab.Name = "tabConOnlineGameTab";
            this.tabConOnlineGameTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabConOnlineGameTab.Size = new System.Drawing.Size(542, 121);
            this.tabConOnlineGameTab.TabIndex = 0;
            this.tabConOnlineGameTab.Text = "ゲーム";
            // 
            // tabConOnlineDVDBDTab
            // 
            this.tabConOnlineDVDBDTab.Location = new System.Drawing.Point(4, 25);
            this.tabConOnlineDVDBDTab.Name = "tabConOnlineDVDBDTab";
            this.tabConOnlineDVDBDTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabConOnlineDVDBDTab.Size = new System.Drawing.Size(542, 121);
            this.tabConOnlineDVDBDTab.TabIndex = 1;
            this.tabConOnlineDVDBDTab.Text = "DVD・ブルーレイ";
            this.tabConOnlineDVDBDTab.UseVisualStyleBackColor = true;
            // 
            // tabConOnlineCDTab
            // 
            this.tabConOnlineCDTab.Location = new System.Drawing.Point(4, 25);
            this.tabConOnlineCDTab.Name = "tabConOnlineCDTab";
            this.tabConOnlineCDTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabConOnlineCDTab.Size = new System.Drawing.Size(542, 121);
            this.tabConOnlineCDTab.TabIndex = 2;
            this.tabConOnlineCDTab.Text = "CD";
            this.tabConOnlineCDTab.UseVisualStyleBackColor = true;
            // 
            // tabConOnlineMobileTab
            // 
            this.tabConOnlineMobileTab.Location = new System.Drawing.Point(4, 25);
            this.tabConOnlineMobileTab.Name = "tabConOnlineMobileTab";
            this.tabConOnlineMobileTab.Size = new System.Drawing.Size(542, 121);
            this.tabConOnlineMobileTab.TabIndex = 3;
            this.tabConOnlineMobileTab.Text = "モバイル";
            this.tabConOnlineMobileTab.UseVisualStyleBackColor = true;
            // 
            // tabConRentalGameTab
            // 
            this.tabConRentalGameTab.Controls.Add(this.tabRentalNewRelease);
            this.tabConRentalGameTab.Controls.Add(this.tabRentalDVDBD);
            this.tabConRentalGameTab.Controls.Add(this.tabRentalCD);
            this.tabConRentalGameTab.Controls.Add(this.tabRentalComic);
            this.tabConRentalGameTab.ItemSize = new System.Drawing.Size(136, 21);
            this.tabConRentalGameTab.Location = new System.Drawing.Point(238, 291);
            this.tabConRentalGameTab.Name = "tabConRentalGameTab";
            this.tabConRentalGameTab.SelectedIndex = 0;
            this.tabConRentalGameTab.Size = new System.Drawing.Size(550, 150);
            this.tabConRentalGameTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabConRentalGameTab.TabIndex = 21;
            // 
            // tabRentalNewRelease
            // 
            this.tabRentalNewRelease.Location = new System.Drawing.Point(4, 25);
            this.tabRentalNewRelease.Name = "tabRentalNewRelease";
            this.tabRentalNewRelease.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentalNewRelease.Size = new System.Drawing.Size(542, 121);
            this.tabRentalNewRelease.TabIndex = 0;
            this.tabRentalNewRelease.Text = "Newリリース";
            this.tabRentalNewRelease.UseVisualStyleBackColor = true;
            // 
            // tabRentalDVDBD
            // 
            this.tabRentalDVDBD.Location = new System.Drawing.Point(4, 25);
            this.tabRentalDVDBD.Name = "tabRentalDVDBD";
            this.tabRentalDVDBD.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentalDVDBD.Size = new System.Drawing.Size(542, 121);
            this.tabRentalDVDBD.TabIndex = 1;
            this.tabRentalDVDBD.Text = "DVD・ブルーレイ";
            this.tabRentalDVDBD.UseVisualStyleBackColor = true;
            // 
            // tabRentalCD
            // 
            this.tabRentalCD.Location = new System.Drawing.Point(4, 25);
            this.tabRentalCD.Name = "tabRentalCD";
            this.tabRentalCD.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentalCD.Size = new System.Drawing.Size(542, 121);
            this.tabRentalCD.TabIndex = 2;
            this.tabRentalCD.Text = "CD";
            this.tabRentalCD.UseVisualStyleBackColor = true;
            // 
            // tabRentalComic
            // 
            this.tabRentalComic.Location = new System.Drawing.Point(4, 25);
            this.tabRentalComic.Name = "tabRentalComic";
            this.tabRentalComic.Size = new System.Drawing.Size(542, 121);
            this.tabRentalComic.TabIndex = 3;
            this.tabRentalComic.Text = "コミック";
            this.tabRentalComic.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.tabConRentalGameTab);
            this.Controls.Add(this.tabConOnlineGame);
            this.Controls.Add(this.btnChangeNewMember);
            this.Controls.Add(this.btnMainLogin);
            this.Controls.Add(this.btnNotice);
            this.Controls.Add(this.labRentalPopular);
            this.Controls.Add(this.labOnlinePopular);
            this.Controls.Add(this.btnChangePurchase);
            this.Controls.Add(this.btnChangeRental);
            this.Controls.Add(this.picTopPageIcon);
            this.Controls.Add(this.btnChangeBuy);
            this.Name = "Main_Page";
            this.Text = "メインページ";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabConOnlineGame.ResumeLayout(false);
            this.tabConRentalGameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTopPageIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeBuy;
        private System.Windows.Forms.PictureBox picTopPageIcon;
        private System.Windows.Forms.Button btnChangeRental;
        private System.Windows.Forms.Button btnChangePurchase;
        private System.Windows.Forms.Label labOnlinePopular;
        private System.Windows.Forms.Label labRentalPopular;
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.Button btnMainLogin;
        private System.Windows.Forms.Button btnChangeNewMember;
        private System.Windows.Forms.TabControl tabConOnlineGame;
        private System.Windows.Forms.TabPage tabConOnlineGameTab;
        private System.Windows.Forms.TabPage tabConOnlineDVDBDTab;
        private System.Windows.Forms.TabPage tabConOnlineCDTab;
        private System.Windows.Forms.TabPage tabConOnlineMobileTab;
        private System.Windows.Forms.TabControl tabConRentalGameTab;
        private System.Windows.Forms.TabPage tabRentalNewRelease;
        private System.Windows.Forms.TabPage tabRentalDVDBD;
        private System.Windows.Forms.TabPage tabRentalCD;
        private System.Windows.Forms.TabPage tabRentalComic;
        private System.Windows.Forms.Button btnChengeDB;
    }
}

