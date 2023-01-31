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
    public partial class DBProduction : Form
    {
        public DBProduction()
        {
            InitializeComponent();
        }

        private void DBProduction_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            int[] tBoxCount = new int[9];
            for (int i = 1, c = 1; i < 10; i++)
            {
                if (((TextBox)Controls[$"tBoxColumn{i}"]).Text != String.Empty)
                {
                    tBoxCount[c] = i;
                    c++;
                }
            }

            if (tBoxCount != null)
            {
                string createTableName = tBoxCreateTableName.Text;
                string createTableColumn = null;
                string[] INTEGER = new string[9];
                string[] TEXT = new string[9];
                foreach (int num in tBoxCount)
                {
                    if (((RadioButton)Controls["rButtonINTEGER" + $"{tBoxCount[num]}"]).Checked == true)
                    {
                        createTableColumn += (((TextBox)Controls[$"Column" + $"{tBoxCount[num]}"]).Text) + " " + $"INTEGER{num}" + ",";
                    }
                    else if (((RadioButton)Controls[$"rButtonTEXT" + "{tBoxCount[num]}"]).Checked == true)
                    {
                        createTableColumn += (((TextBox)Controls[$"Column" + "{tBoxCount[num]}"]).Text) + " " + $"TEXT{num}" + ",";
                    }
                    else if (((RadioButton)Controls[$"rButtonINTEGER" + "{tBoxCount[num]}"]).Checked == false && ((RadioButton)Controls[$"rButtonTEXT{tBoxCount[num]}"]).Checked == false)
                    {
                        MessageBox.Show("値の型を選んでください。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                }
                string createTableColumn2 = createTableColumn.Remove(createTableColumn.Length - 1);
                using (var con = new SQLiteConnection($"Data Source=GEO.db"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText = $"create table {createTableName}(CD INTEGER   PRIMARY KEY AUTOINCREMENT" + createTableColumn2 + ")";
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            else if (tBoxCount == null)
            {
                MessageBox.Show("列名を入力してください", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //using (var startSQL = new SQLiteConnection("Data Source=GEO.db"))
        //    {
        //        startSQL.Open();
        //        using (SQLiteCommand command = startSQL.CreateCommand())
        //        {
        //            command.CommandText = "create table if not exists member_info(MemberID INTEGER PRIMARY KEY AUTOINCREMENT, MemberPassword TEXT not null, MemberLastName TEXT not null, MemberFirstName TEXT not null, MemberFuriganaLastName TEXT not null, MemberFuriganaFirstName TEXT not null, MemberBirthYear INTEGER not null, MemberBirthMonth INTEGER not null, MemberBirthDate INTEGER not null, MemberAddress TEXT not null, MemberPhoneNumberLead INTEGER not null, MemberPhoneNumberMiddle INTEGER not null, MemberPhoneNumberEnd INTEGER not null, MemberEmailAddress TEXT not null)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "create table if not exists product_class(ClassID INTEGER not null PRIMARY KEY, ClassName TEXT not null)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_class(ClassName) VALUES (@classname)";
        //            command.Parameters.Add("classname", System.Data.DbType.String);
        //            command.Parameters["classname"].Value = "Software-Switch";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_class(ClassName) VALUES (@classname)";
        //            command.Parameters.Add("classname", System.Data.DbType.String);
        //            command.Parameters["classname"].Value = "Software-PS4";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_class(ClassName) VALUES (@classname)";
        //            command.Parameters.Add("classname", System.Data.DbType.String);
        //            command.Parameters["classname"].Value = "Console";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "create table if not exists product_info(ProductID INTEGER PRIMARY KEY AUTOINCREMENT, ProductName TEXT not null, ProductPrice INTEGER not null, ProductClassification INTEGER not null, ProductStock INTEGER not null, ViewCount INTEGER not null, PictureName TEXT not null, FOREIGN KEY(ProductClassification) REFERENCES [product_class](ClassID))";
        //            command.ExecuteNonQuery();
        //            #region 商品登録
        //            // Switch
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｍｉｎｅｃｒａｆｔ, 3960, 1, 10, 0, Switch-MINECRAFT.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｘｅｎｏｂｌａｄｅ　Ｄｅｆｉｎｉｔｉｖｅ　Ｅｄｉｔｉｏｎ, 6578, 1, 10, 0, Switch-Xenoblade_DefinitiveEdition.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｘｅｎｏｂｌａｄｅ２, 8778, 1, 10, 0, Switch-Xenoblade_2.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｘｅｎｏｂｌａｄｅ３, 8778, 1, 10, 0, Switch-Xenoblade_3.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (クライシス　コア－ファイナルファンタジーVII－　リユニオン, 6820, 1, 10, 0, Switch-CRISISCODE-FF_VII-REUNION.png)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (スプラトゥーン３, 6578, 1, 10, 0, Switch-Splatoon3.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ドラゴンクエスト　トレジャーズ蒼き瞳と大空の羅針盤, 7990, 1, 10, 0, Switch-DRAGONQUEST_TREASURES.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ペルソナ５　ザ・ロイヤル, 7678, 1, 10, 0, Switch-Persona_5-TheRoyal.png)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ポケットモンスター　スカーレット, 6578, 1, 10, 0, Switch-Pokemon-Scarlet.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ポケットモンスター　バイオレット, 6578, 1, 10, 0, Switch-Pokemon-Violet.png)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (マリオカート８　デラックス, 6578, 1, 10, 0, Switch-MarioKart8Deluxe.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (モンスターハンターライズ, 8789, 1, 10, 0, Switch-MonsterHunterRise.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (モンスターハンターライズ＋サンブレイク　セット, 8789, 1, 10, 0, Switch-MonsterHunterRise-SunBreakSet.jpg)";
        //            command.ExecuteNonQuery();
        //
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (大乱闘スマッシュブラザーズ　ＳＰＥＣＩＡＬ, 7920, 1, 10, 0, Switch-SmashBros-Special.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (遊戯王ラッシュデュエル　最強バトルロイヤル！！　いくぞ！ゴーラッシュ！！　スペシャルエディション, 6600, 1, 10, 0, Switch-YuGiOh-RushDuelSpecialEdition.png)";
        //            command.ExecuteNonQuery();
        //            // PS4
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ＢＩＯＨＡＺＡＲＤ　ＲＥ：３, 8580, 2, 10, 0, PS4-BIOHAZARD_RE3.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ＢＩＯＨＡＺＡＲＤ　ＲＥ：４, 8789, 2, 10, 0, PS4-BIOHAZARD_RE4.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ＢＩＯＨＡＺＡＲＤ　ＶＩＬＬＡＧＥ, 8789, 2, 10, 0, PS4-BIOHAZARD_VILLAGE.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ＤＡＲＫ　ＳＯＵＬＳ３, 8173, 2, 10, 0, PS4-DarkSouls_III.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｆａｌｌｏｕｔ４, 8778, 2, 10, 0, PS4-Fallout_4.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ＦＩＦＡ　２３, 8699, 2, 10, 0, PS4-FIFA_23.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｈｏｒｉｚｏｎ　Ｚｅｒｏ　Ｄａｗｎ, 7590, 2, 10, 0, PS4-HorizonZeroDawn.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ＪＵＤＧＥ　ＥＹＥＳ：死神の遺言, 9119, 2, 10, 0, PS4-JudgeEyes.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｍａｒｖｅｌ’ｓ　Ｓｐｉｄｅｒ－Ｍａｎ, 7590, 2, 10, 0, PS4-Marvels_Spider-man.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｍｉｎｅｃｒａｆｔ　Ｓｔａｒｔｅｒ　Ｃｏｌｌｅｃｔｉｏｎ, 3960, 2, 10, 0, PS4-Minecraft.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ＯＮＥ　ＰＩＥＣＥ　ＯＤＹＳＳＥＹ, 8778, 2, 10, 0, PS4-ONEPIECE-ODYSSEY.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｓｕｂｎａｕｔｉｃａ, 4708, 2, 10, 0, PS4-Subnautica.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｔａｌｅｓ　ｏｆ　ＡＲＩＳＥ, 8778, 2, 10, 0, PS4-TALESofARISE.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｔｈｅ　Ｌａｓｔ　ｏｆ　Ｕｓ　Ｒｅｍａｓｔｅｒｅｄ, 2189, 2, 10, 0, PS4-TheLastOfUs_Remasterd.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ぷよぷよテトリス　２, 5489, 2, 10, 0, PS4-PuyoPuyoTetris_2.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (アサシン クリード オリジンズ, 9240, 2, 10, 0, PS4-AssassinsCreedOrigins.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ウィッチャー３　ワイルドハント, 9020, 2, 10, 0, PS4-TheWitcher_III.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ウォッチドッグス, 9240, 2, 10, 0, PS4-WatchDogs.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ウォッチドッグス２, 9240, 2, 10, 0, PS4-WatchDogs_2.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ウォッチドッグス　レギオン, 9240, 2, 10, 0, PS4-WatchDogs_Legion.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (キングダム　ハーツＩＩＩ, 9680, 2, 10, 0, PS4-KingdomHearts_III.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (キングダム　ハーツ　-ＨＤ　１．５＋２．５　リミックス-, 7480, 2, 10, 0, PS4-KingdomHeartsHD_1.5+2.5.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (キングダム　ハーツ　ＨＤ２．８　ファイナルチャプタープロローグ, 7480, 2, 10, 0, PS4-KingdomHeartsHD_2.8.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (クライシス コア－ファイナルファンタジーVII－ リユニオン, 6820, 2, 10, 0, PS4-CRISISCODE-FF_VII-REUNION.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (グランド・セフト・オート５, 5489, 2, 10, 0, PS4-GrandTheftAuto_V.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ゴッド・オブ・ウォー, 7590, 2, 10, 0, PS4-GodOfWar.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (サイコブレイク, 8030, 2, 10, 0, PS4-PHYCHOBREAK.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (サイコブレイク　２, 8778, 2, 10, 0, PS4-PSYCHOBREAK_2.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ストリートファイター　３０ｔｈ　アニバーサリーコレクション　インターナショナル, 5489, 2, 10, 0, PS4-StreetFighter_30thAnniversaryCollection.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (タイタンフォール　２, 8580, 2, 10, 0, PS4-TitanFall_2.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ドラゴンクエストＸＩ 過ぎ去りし時を求めて, 9878, 2, 10, 0,  PS4-DragonQuest_XI.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ドラゴンクエストＸ　目覚めし五つの種族　オフライン, 8580, 2, 10, 0, PS4-DRAGONQUEST_X-Offline.png)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ドラゴンクエストビルダーズ２　破壊神シドーとからっぽの島, 8580, 2, 10, 0, PS4-DragonQuestBuilders_2.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ニーア　レプリカントｖｅｒ．１．２２４７４４８７１３９．．．, 8580, 2, 10, 0, PS4-NieR_Replicant_ver.1.22474487139.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (バイオハザード７ レジデント イービル, 8789, 2, 10, 0, PS4-BIOHAZARD_7.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ヒューマン　フォール　フラット, 3850, 2, 10, 0, PS4-HumanFallFlat.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ファークライ５, 9240, 2, 10, 0, PS4-FARCRY_5.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ファイナルファンタジーＸＶ, 9680, 2, 10, 0, PS4-FINALFANTASY_XV.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ペルソナ５, 9680, 2, 10, 0, PS4-PERSONA_5.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ホグワーツ・レガシー, 8778, 2, 10, 0, PS4-HogwartsLegacy.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ミラーズエッジ　カタリスト, 8580, 2, 10, 0, PS4-MirrorsEdge_Catalyst.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ライザのアトリエ２, 8580, 2, 10, 0, PS4-AtelierRyza2.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (英雄伝説　黎の軌跡II　－ＣＲＩＭＳＯＮ　ＳｉＮ－, 8580, 2, 10, 0, PS4-TheLegendOfHeroesII-Crimson.png)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (深夜廻, 7678, 2, 10, 0, PS4-Yomawari_MidnightShadows.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (地球防衛軍６, 8980, 2, 10, 0, PS4-EarthDefenseForces_6.png)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (二ノ国２　レヴァナントキングダム, 8800, 2, 10, 0, PS4-NiNoKuni_II.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (夜廻三, 7678, 2, 10, 0, PS4-Yomawari_LostInTheDark.jpg)";
        //            command.ExecuteNonQuery();
        //            // Console
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ＰｌａｙＳｔａｔｉｏｎ４, 32978, 3, 10, 0, PS4.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (ＰｌａｙＳｔａｔｉｏｎ４　Ｐｒｏ, 43978, 3, 10, 0, PS4_Pro.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｎｉｎｔｅｎｄｏ　Ｓｗｉｔｃｈ（有機ＥＬモデル), 37980, 3, 10, 0, SwitchOLED-Black.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｎｉｎｔｅｎｄｏ　Ｓｗｉｔｃｈ, 32978, 3, 10, 0, SwitchNormal-Black.jpg)";
        //            command.ExecuteNonQuery();
        //            command.CommandText = "insert or ignore into product_info(ProductName, ProductPrice, ProductClassification, ProductStock, ViewCount, PictureName) VALUES (Ｎｉｎｔｅｎｄｏ　Ｓｗｉｔｃｈ　Ｌｉｔｅ, 21978, 3, 10, 0, SwitchLite-Turquoise.jpg)";
        //            command.ExecuteNonQuery();
        //            #endregion
        //            Console.WriteLine("あああ");
        //        }
        //        startSQL.Close();
        //    }
    }
}
