using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HcsShift
{
    /// <summary>
    /// 削除
    /// </summary>
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 削除する処理ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DeletionButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "DELETE FROM t_product WHERE ID = @Id;";
                    // パラメータセット
                    cmd.Parameters.Add("Id", DbType.Int64);
                    // データ削除
                    cmd.Parameters["Id"].Value = int.Parse(ID.Text);
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                    //DataTableを作成します。
                    DataTable dataTable = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                    adapter.Fill(dataTable);
                    HcsShiftDeleteView.DataSource = dataTable;
                }
            }
        }
        /// <summary>
        /// サブメニューに戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButtonClick(object sender, EventArgs e)
        {
            //サブメニューを表示
            Submenu SubmenuFrom = new Submenu();
            SubmenuFrom.Visible = true;
            Visible = false;
        }
        /// <summary>
        /// 登録されてるいるものを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HcsShiftDeleteViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                //DataTableを作成します。
                DataTable dataTable = new DataTable();
                //SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTable);
                HcsShiftDeleteView.DataSource = dataTable;
            }
        }
    }
}
