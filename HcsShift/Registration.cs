using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HcsShift
{
    /// <summary>
    /// 登録
    /// </summary>
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登録する処理ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationButtonClick(object sender, EventArgs e)
        {
            HcsShiftRegistrationView.AllowUserToAddRows = false;
            HcsShiftRegistrationView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HcsShiftRegistrationView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "INSERT INTO t_product (name, companyname, phone, hourlyrate) VALUES (@Name, @Company, @Phone, @Hourly)";
                    // パラメータセット
                    cmd.Parameters.Add("Name", DbType.String);
                    cmd.Parameters.Add("Company", DbType.String);
                    cmd.Parameters.Add("Phone", DbType.Int64);
                    cmd.Parameters.Add("Hourly", DbType.Int64);
                    // データ追加
                    cmd.Parameters["Name"].Value = Identity.Text;
                    cmd.Parameters["Company"].Value = CompanyName.Text;
                    cmd.Parameters["Phone"].Value = int.Parse(TelephoneNumber.Text);
                    cmd.Parameters["Hourly"].Value = int.Parse(HourlyWage.Text);
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                    //DataTableを作成します。
                    DataTable dataTable = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                    adapter.Fill(dataTable);
                    HcsShiftRegistrationView.DataSource = dataTable;
                }
            }
        }
        /// <summary>
        /// サブメニューに戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            //サブメニューを表示
            Submenu SubmenuFrom = new Submenu();
            SubmenuFrom.Visible = true;
            Visible = false;
        }
    }
}
