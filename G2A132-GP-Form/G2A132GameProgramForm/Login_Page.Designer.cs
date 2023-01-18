
namespace G2A132GameProgramForm
{
    partial class Login_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_MemberID = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_MemberID = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_DispalySwitching = new System.Windows.Forms.Button();
            this.button_BackMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_MemberID
            // 
            this.textBox_MemberID.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_MemberID.Location = new System.Drawing.Point(320, 143);
            this.textBox_MemberID.Name = "textBox_MemberID";
            this.textBox_MemberID.Size = new System.Drawing.Size(200, 24);
            this.textBox_MemberID.TabIndex = 0;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Password.Location = new System.Drawing.Point(320, 241);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(200, 24);
            this.textBox_Password.TabIndex = 1;
            // 
            // label_MemberID
            // 
            this.label_MemberID.AutoSize = true;
            this.label_MemberID.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_MemberID.Location = new System.Drawing.Point(237, 146);
            this.label_MemberID.Name = "label_MemberID";
            this.label_MemberID.Size = new System.Drawing.Size(57, 17);
            this.label_MemberID.TabIndex = 2;
            this.label_MemberID.Text = "会員ID";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Password.Location = new System.Drawing.Point(220, 244);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(74, 17);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "パスワード";
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Login.Location = new System.Drawing.Point(356, 319);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(100, 40);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "ログイン";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_DispalySwitching
            // 
            this.button_DispalySwitching.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_DispalySwitching.Location = new System.Drawing.Point(541, 242);
            this.button_DispalySwitching.Name = "button_DispalySwitching";
            this.button_DispalySwitching.Size = new System.Drawing.Size(42, 23);
            this.button_DispalySwitching.TabIndex = 5;
            this.button_DispalySwitching.Text = "👁";
            this.button_DispalySwitching.UseVisualStyleBackColor = true;
            this.button_DispalySwitching.Click += new System.EventHandler(this.button_DispalySwitching_Click);
            // 
            // button_BackMainPage
            // 
            this.button_BackMainPage.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_BackMainPage.Location = new System.Drawing.Point(37, 376);
            this.button_BackMainPage.Name = "button_BackMainPage";
            this.button_BackMainPage.Size = new System.Drawing.Size(75, 40);
            this.button_BackMainPage.TabIndex = 6;
            this.button_BackMainPage.Text = "戻る";
            this.button_BackMainPage.UseVisualStyleBackColor = true;
            this.button_BackMainPage.Click += new System.EventHandler(this.button_BackMainPage_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_BackMainPage);
            this.Controls.Add(this.button_DispalySwitching);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_MemberID);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_MemberID);
            this.Name = "Login_Page";
            this.Text = "ログイン";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MemberID;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_MemberID;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_DispalySwitching;
        private System.Windows.Forms.Button button_BackMainPage;
    }
}