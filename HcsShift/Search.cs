using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HcsShift
{
    /// <summary>
    /// 検索
    /// </summary>
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 検索する処理ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButtonClick(object sender, EventArgs e)
        {
            HcsShiftSearchView.AllowUserToAddRows = false;
            HcsShiftSearchView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HcsShiftSearchView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gold;
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                //DataTableを作成します。
                DataTable dataTable = new DataTable();
                //SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE ID =" + ID.Text, con);
                adapter.Fill(dataTable);
                HcsShiftSearchView.DataSource = dataTable;
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
