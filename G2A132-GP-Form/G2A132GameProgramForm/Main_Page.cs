using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace G2A132GameProgramForm
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(820, 500);
            this.MaximizeBox = false;
            picTopPageIcon.Image = Properties.Resources.text_noclaim_noreturn;
            picTopPageIcon.SizeMode = PictureBoxSizeMode.Zoom;
        }
        
        private void button_ChangeNewMember_Click(object sender, EventArgs e)
        {
            // 新規会員登録フォームをメインフォームに設定
            Program.SetMainForm(new NewMember_Page());
            // 現在のメインフォームを取得 (直前で設定したフォーム)
            Form mainPageOpen = Program.GetMainForm();
            // メインページを開く
            mainPageOpen.Show();
            // 新規会員登録ページを閉じる
            this.Close();
        }

        private void button_MainLogin_Click(object sender, EventArgs e)
        {
            // 新規会員登録フォームをメインフォームに設定
            Program.SetMainForm(new Login_Page());
            // 現在のメインフォームを取得 (直前で設定したフォーム)
            Form mainPageOpen = Program.GetMainForm();
            // メインページを開く
            mainPageOpen.Show();
            // 新規会員登録ページを閉じる
            this.Close();
        }

        private void btnChengeDB_Click(object sender, EventArgs e)
        {
            using (var startSQL = new SQLiteConnection("Data Source=GEO.db"))
            {
                startSQL.Open();
                using (SQLiteCommand command = startSQL.CreateCommand())
                {
                    command.CommandText = "create table if not exists member_info(CD INTEGER PRIMARY KEY AUTOINCREMENT, MemberID TEXT not null, MemberPassword TEXT not null, MemberLastName TEXT not null, MemberFirstName TEXT not null, MemberFuriganaLastName TEXT not null, MemberFuriganaFirstName TEXT not null, MemberBirthYear INTEGER not null, MemberBirthMonth INTEGER not null, MemberBirthDate INTEGER not null, MemberAddress TEXT not null, MemberPhoneNumberLead INTEGER not null, MemberPhoneNumberMiddle INTEGER not null, MemberPhoneNumberEnd INTEGER not null, MemberEmailAddress TEXT not null)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into " +
                        "member_info(MemberID, MemberPassword, MemberLastName, MemberFirstName, MemberFuriganaLastName, MemberFuriganaFirstName, MemberBirthYear, MemberBirthMonth, MemberBirthDate, MemberAddress, MemberPhoneNumberLead, MemberPhoneNumberMiddle, MemberPhoneNumberEnd, MemberEmailAddress) " +
                        "VALUES (@id, @password, @lastname, @firstname, @furiganalastname, @furiganafirstname, @birthyear, @birthmonth, @birthdate, @address, @phonenumberlead, @phonenumbermiddle, @phonenumberend, @emailaddress)";

                    #region admin account info
                    command.Parameters.Add("id", System.Data.DbType.String);
                    command.Parameters.Add("password", System.Data.DbType.String);
                    command.Parameters.Add("lastname", System.Data.DbType.String);
                    command.Parameters.Add("firstname", System.Data.DbType.String);
                    command.Parameters.Add("furiganalastname", System.Data.DbType.String);
                    command.Parameters.Add("furiganafirstname", System.Data.DbType.String);
                    command.Parameters.Add("birthyear", System.Data.DbType.Int32);
                    command.Parameters.Add("birthmonth", System.Data.DbType.Int32);
                    command.Parameters.Add("birthdate", System.Data.DbType.Int32);
                    command.Parameters.Add("address", System.Data.DbType.String);
                    command.Parameters.Add("phonenumberlead", System.Data.DbType.String);
                    command.Parameters.Add("phonenumbermiddle", System.Data.DbType.String);
                    command.Parameters.Add("phonenumberend", System.Data.DbType.String);
                    command.Parameters.Add("emailaddress", System.Data.DbType.String);

                    command.Parameters["id"].Value = "000000";
                    command.Parameters["password"].Value = "aaaaaaaa";
                    command.Parameters["lastname"].Value = "田中";
                    command.Parameters["firstname"].Value = "太郎";
                    command.Parameters["furiganalastname"].Value = "タナカ";
                    command.Parameters["furiganafirstname"].Value = "タロウ";
                    command.Parameters["birthyear"].Value = 2003;
                    command.Parameters["birthmonth"].Value = 4;
                    command.Parameters["birthdate"].Value = 1;
                    command.Parameters["address"].Value = "札幌市中央区北1条西2丁目";
                    command.Parameters["phonenumberlead"].Value = "011";
                    command.Parameters["phonenumbermiddle"].Value = "222";
                    command.Parameters["phonenumberend"].Value = "4894";
                    command.Parameters["emailaddress"].Value = "20217099-TanakaTarou@hcs.ac.jp";
                    #endregion

                    command.ExecuteNonQuery();
                    command.CommandText = "create table if not exists product_class(ClassID INTEGER not null PRIMARY KEY, ClassName TEXT not null)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_class(ClassName) VALUES (Software-Switch)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_class(ClassName) VALUES (Software-PS4)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_class(ClassName) VALUES (Software-PS5)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_class(ClassName) VALUES (Console)";
                    command.ExecuteNonQuery();
                    command.CommandText = "create table if not exists product_info(ProductID INTEGER PRIMARY KEY AUTOINCREMENT, ProductName TEXT not null, ProductPrice INTEGER not null, ProductClassification INTEGER not null, ProductStock INTEGER not null, ViewCount INTEGER not null, PictureName TEXT not null, FOREIGN KEY(ProductClassification) REFERENCES [product_class](ClassID))";
                    command.ExecuteNonQuery();
                    #region 商品登録
                    // Switch
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｍｉｎｅｃｒａｆｔ, 3960, 1, 10, 0, Switch-MINECRAFT.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｘｅｎｏｂｌａｄｅ　Ｄｅｆｉｎｉｔｉｖｅ　Ｅｄｉｔｉｏｎ, 6578, 1, 10, 0, Switch-Xenoblade_DefinitiveEdition.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｘｅｎｏｂｌａｄｅ２, 8778, 1, 10, 0, Switch-Xenoblade_2.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｘｅｎｏｂｌａｄｅ３, 8778, 1, 10, 0, Switch-Xenoblade_3.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (クライシス　コア－ファイナルファンタジーVII－　リユニオン, 6820, 1, 10, 0, Switch-CRISISCODE-FF_VII-REUNION.png)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (スプラトゥーン３, 6578, 1, 10, 0, Switch-Splatoon3.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ドラゴンクエスト　トレジャーズ蒼き瞳と大空の羅針盤, 7990, 1, 10, 0, Switch-DRAGONQUEST_TREASURES.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ペルソナ５　ザ・ロイヤル, 7678, 1, 10, 0, Switch-Persona_5-TheRoyal.png)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ポケットモンスター　スカーレット, 6578, 1, 10, 0, Switch-Pokemon-Scarlet.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ポケットモンスター　バイオレット, 6578, 1, 10, 0, Switch-Pokemon-Violet.png)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (マリオカート８　デラックス, 6578, 1, 10, 0, Switch-MarioKart8Deluxe.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (モンスターハンターライズ, 8789, 1, 10, 0, Switch-MonsterHunterRise.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (モンスターハンターライズ＋サンブレイク　セット, 8789, 1, 10, 0, Switch-MonsterHunterRise-SunBreakSet.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (大乱闘スマッシュブラザーズ　ＳＰＥＣＩＡＬ, 7920, 1, 10, 0, Switch-SmashBros-Special.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (遊戯王ラッシュデュエル　最強バトルロイヤル！！　いくぞ！ゴーラッシュ！！　スペシャルエディション, 6600, 1, 10, 0, Switch-YuGiOh-RushDuelSpecialEdition.png)";
                    command.ExecuteNonQuery();
                    // PS4
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＢＩＯＨＡＺＡＲＤ　ＲＥ：３, 8580, 2, 10, 0, PS4-BIOHAZARD_RE3.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＢＩＯＨＡＺＡＲＤ　ＲＥ：４, 8789, 2, 10, 0, PS4-BIOHAZARD_RE4.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＢＩＯＨＡＺＡＲＤ　ＶＩＬＬＡＧＥ, 8789, 2, 10, 0, PS4-BIOHAZARD_VILLAGE.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＤＡＲＫ　ＳＯＵＬＳ３, 8173, 2, 10, 0, PS4-DarkSouls_III.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｆａｌｌｏｕｔ４, 8778, 2, 10, 0, PS4-Fallout_4.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＦＩＦＡ　２３, 8699, 2, 10, 0, PS4-FIFA_23.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｈｏｒｉｚｏｎ　Ｚｅｒｏ　Ｄａｗｎ, 7590, 2, 10, 0, PS4-HorizonZeroDawn.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＪＵＤＧＥ　ＥＹＥＳ：死神の遺言, 9119, 2, 10, 0, PS4-JudgeEyes.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｍａｒｖｅｌ’ｓ　Ｓｐｉｄｅｒ－Ｍａｎ, 7590, 2, 10, 0, PS4-Marvels_Spider-man.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｍｉｎｅｃｒａｆｔ　Ｓｔａｒｔｅｒ　Ｃｏｌｌｅｃｔｉｏｎ, 3960, 2, 10, 0, PS4-Minecraft.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＯＮＥ　ＰＩＥＣＥ　ＯＤＹＳＳＥＹ, 8778, 2, 10, 0, PS4-ONEPIECE-ODYSSEY.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｓｕｂｎａｕｔｉｃａ, 4708, 2, 10, 0, PS4-Subnautica.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｔａｌｅｓ　ｏｆ　ＡＲＩＳＥ, 8778, 2, 10, 0, PS4-TALESofARISE.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｔｈｅ　Ｌａｓｔ　ｏｆ　Ｕｓ　Ｒｅｍａｓｔｅｒｅｄ, 2189, 2, 10, 0, PS4-TheLastOfUs_Remasterd.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ぷよぷよテトリス　２, 5489, 2, 10, 0, PS4-PuyoPuyoTetris_2.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (アサシン クリード オリジンズ, 9240, 2, 10, 0, PS4-AssassinsCreedOrigins.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ウィッチャー３　ワイルドハント, 9020, 2, 10, 0, PS4-TheWitcher_III.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ウォッチドッグス, 9240, 2, 10, 0, PS4-WatchDogs.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ウォッチドッグス２, 9240, 2, 10, 0, PS4-WatchDogs_2.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ウォッチドッグス　レギオン, 9240, 2, 10, 0, PS4-WatchDogs_Legion.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (キングダム　ハーツＩＩＩ, 9680, 2, 10, 0, PS4-KingdomHearts_III.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (キングダム　ハーツ　-ＨＤ　１．５＋２．５　リミックス-, 7480, 2, 10, 0, PS4-KingdomHeartsHD_1.5+2.5.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (キングダム　ハーツ　ＨＤ２．８　ファイナルチャプタープロローグ, 7480, 2, 10, 0, PS4-KingdomHeartsHD_2.8.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (クライシス コア－ファイナルファンタジーVII－ リユニオン, 6820, 2, 10, 0, PS4-CRISISCODE-FF_VII-REUNION.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (グランド・セフト・オート５, 5489, 2, 10, 0, PS4-GrandTheftAuto_V.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ゴッド・オブ・ウォー, 7590, 2, 10, 0, PS4-GodOfWar.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (サイコブレイク, 8030, 2, 10, 0, PS4-PHYCHOBREAK.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (サイコブレイク　２, 8778, 2, 10, 0, PS4-PSYCHOBREAK_2.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ストリートファイター　３０ｔｈ　アニバーサリーコレクション　インターナショナル, 5489, 2, 10, 0, PS4-StreetFighter_30thAnniversaryCollection.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (タイタンフォール　２, 8580, 2, 10, 0, PS4-TitanFall_2.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ドラゴンクエストＸＩ 過ぎ去りし時を求めて, 9878, 2, 10, 0,  PS4-DragonQuest_XI.jpg)"; 
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ドラゴンクエストＸ　目覚めし五つの種族　オフライン, 8580, 2, 10, 0, PS4-DRAGONQUEST_X-Offline.png)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ドラゴンクエストビルダーズ２　破壊神シドーとからっぽの島, 8580, 2, 10, 0, PS4-DragonQuestBuilders_2.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ニーア　レプリカントｖｅｒ．１．２２４７４４８７１３９．．．, 8580, 2, 10, 0, PS4-NieR_Replicant_ver.1.22474487139.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (バイオハザード７ レジデント イービル, 8789, 2, 10, 0, PS4-BIOHAZARD_7.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ヒューマン　フォール　フラット, 3850, 2, 10, 0, PS4-HumanFallFlat.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ファークライ５, 9240, 2, 10, 0, PS4-FARCRY_5.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ファイナルファンタジーＸＶ, 9680, 2, 10, 0, PS4-FINALFANTASY_XV.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ペルソナ５, 9680, 2, 10, 0, PS4-PERSONA_5.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ホグワーツ・レガシー, 8778, 2, 10, 0, PS4-HogwartsLegacy.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ミラーズエッジ　カタリスト, 8580, 2, 10, 0, PS4-MirrorsEdge_Catalyst.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ライザのアトリエ２, 8580, 2, 10, 0, PS4-AtelierRyza2.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (英雄伝説　黎の軌跡II　－ＣＲＩＭＳＯＮ　ＳｉＮ－, 8580, 2, 10, 0, PS4-TheLegendOfHeroesII-Crimson.png)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (深夜廻, 7678, 2, 10, 0, PS4-Yomawari_MidnightShadows.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (地球防衛軍６, 8980, 2, 10, 0, PS4-EarthDefenseForces_6.png)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (二ノ国２　レヴァナントキングダム, 8800, 2, 10, 0, PS4-NiNoKuni_II.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (夜廻三, 7678, 2, 10, 0, PS4-Yomawari_LostInTheDark.jpg)";
                    command.ExecuteNonQuery();
                    // PS5
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (, , 3, 10, 0)";
                    command.ExecuteNonQuery();
                    // Console
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＰｌａｙＳｔａｔｉｏｎ４, 32978, 4, 10, 0, PS4.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＰｌａｙＳｔａｔｉｏｎ４　Ｐｒｏ, 43978, 4, 10, 0, PS4_Pro.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (ＰｌａｙＳｔａｔｉｏｎ５, 54978, 4, 10, 0, PS5.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｎｉｎｔｅｎｄｏ　Ｓｗｉｔｃｈ（有機ＥＬモデル), 37980, 4, 10, 0, SwitchOLED-Black.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｎｉｎｔｅｎｄｏ　Ｓｗｉｔｃｈ, 32978, 4, 10, 0, SwitchNormal-Black.jpg)";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount) VALUES (Ｎｉｎｔｅｎｄｏ　Ｓｗｉｔｃｈ　Ｌｉｔｅ, 21978, 4, 10, 0, SwitchLite-Turquoise.jpg)";
                    command.ExecuteNonQuery();
                    #endregion
                    Console.WriteLine("あああ");
                }
                startSQL.Close();
            }
        }
    }
}