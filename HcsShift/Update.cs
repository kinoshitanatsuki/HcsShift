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

namespace HcsShift
{
    /// <summary>
    /// 変更
    /// </summary>
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 変更する処理ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "UPDATE t_product SET name = @Name, companyname = @Company, phone = @Phone, hourlyrate = @Hourly WHERE ID = @Id;";
                    // パラメータセット
                    cmd.Parameters.Add("Name", DbType.String);
                    cmd.Parameters.Add("Company", DbType.String);
                    cmd.Parameters.Add("Phone", DbType.Int64);
                    cmd.Parameters.Add("Hourly", DbType.Int64);
                    cmd.Parameters.Add("Id", DbType.Int64);
                    // データ修正
                    cmd.Parameters["Name"].Value = Identity.Text;
                    cmd.Parameters["Company"].Value = CompanyName.Text;
                    cmd.Parameters["Phone"].Value = int.Parse(TelephoneNumber.Text);
                    cmd.Parameters["Hourly"].Value = int.Parse(HourlyWage.Text);
                    cmd.Parameters["Id"].Value = int.Parse(ID.Text);
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                    //DataTableを作成します。
                    DataTable dataTable = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                    adapter.Fill(dataTable);
                    HcsShiftUpdateView.DataSource = dataTable;
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
    }
}
