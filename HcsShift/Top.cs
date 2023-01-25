using System;
using System.Windows.Forms;

namespace HcsShift
{
    /// <summary>
    /// トップ
    /// </summary>
    public partial class Top : Form
    {
        public Top()
        {
            InitializeComponent();
        }
        /// <summary>
        /// サブメニューを表示するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationManagementClick(object sender, EventArgs e)
        {
            //サブメニューを表示
            Submenu SubmenuFrom = new Submenu();
            SubmenuFrom.Visible = true;
            Visible = false;
        }
        /// <summary>
        /// 終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("終了してもいいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
