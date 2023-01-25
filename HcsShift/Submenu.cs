using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HcsShift
{
    /// <summary>
    /// サブメニュー
    /// </summary>
    public partial class Submenu : Form
    {
        public Submenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// テーブル作成する処理ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateaTableClick(object sender, EventArgs e)
        {
            //コネクションを開いてテーブル作成して閉じる
            using (var con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    //menber_id 会員ID　name 氏名　companyname 会社名　phone 電話番号　hourlyrate 時給額
                    command.CommandText =
                        "create table t_product(ID INTEGER  PRIMARY KEY AUTOINCREMENT, name TEXT, companyname TEXT, phone INTEGER, hourlyrate INTEGER)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        /// <summary>
        /// テーブル削除する処理ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteTableClick(object sender, EventArgs e)
        {
            //コネクションを開いてテーブル削除して閉じる。
            using (var con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "drop table t_product";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        /// <summary>
        /// 登録画面を表示するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationClick(object sender, EventArgs e)
        {
            //登録メニューを表示
            Registration RegistrationFrom = new Registration();
            RegistrationFrom.Visible = true;
            Visible = false;
        }
        /// <summary>
        /// 変更画面を表示するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateClick(object sender, EventArgs e)
        {
            //変更メニューを表示
            Update UpdateFrom = new Update();
            UpdateFrom.Visible = true;
            Visible = false;
        }
        /// <summary>
        /// 検索画面を表示するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchClick(object sender, EventArgs e)
        {
            //検索メニューを表示
            Search SearchFrom = new Search();
            SearchFrom.Visible = true;
            Visible = false;
        }
        /// <summary>
        /// 削除画面を表示するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletClick(object sender, EventArgs e)
        {
            //削除メニューを表示
            Delete DeletionFrom = new Delete();
            DeletionFrom.Visible = true;
            Visible = false;
        }
        /// <summary>
        /// トップに戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopClick(object sender, EventArgs e)
        {
            //トップメニューを表示
            Top TopFrom = new Top();
            TopFrom.Visible = true;
            Visible = false;
        }
    }
}
