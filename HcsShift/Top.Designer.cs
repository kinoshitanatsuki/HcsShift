
namespace HcsShift
{
    partial class Top
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
            this.RegistrationManagement = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.Shift = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistrationManagement
            // 
            this.RegistrationManagement.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RegistrationManagement.Location = new System.Drawing.Point(258, 161);
            this.RegistrationManagement.Name = "RegistrationManagement";
            this.RegistrationManagement.Size = new System.Drawing.Size(184, 56);
            this.RegistrationManagement.TabIndex = 0;
            this.RegistrationManagement.Text = "登録管理";
            this.RegistrationManagement.UseVisualStyleBackColor = true;
            this.RegistrationManagement.Click += new System.EventHandler(this.RegistrationManagementClick);
            // 
            // End
            // 
            this.End.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.End.Location = new System.Drawing.Point(258, 257);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(184, 56);
            this.End.TabIndex = 1;
            this.End.Text = "終了";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.EndClick);
            // 
            // Shift
            // 
            this.Shift.AutoSize = true;
            this.Shift.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Shift.Location = new System.Drawing.Point(228, 53);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(232, 50);
            this.Shift.TabIndex = 2;
            this.Shift.Text = "シフト登録";
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(710, 396);
            this.Controls.Add(this.Shift);
            this.Controls.Add(this.End);
            this.Controls.Add(this.RegistrationManagement);
            this.Name = "Top";
            this.Text = "Top";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrationManagement;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Label Shift;
    }
}

