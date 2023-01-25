
namespace HcsShift
{
    partial class Submenu
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
            this.CreateaTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteTable = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delet = new System.Windows.Forms.Button();
            this.Top = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateaTable
            // 
            this.CreateaTable.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CreateaTable.Location = new System.Drawing.Point(36, 112);
            this.CreateaTable.Name = "CreateaTable";
            this.CreateaTable.Size = new System.Drawing.Size(184, 58);
            this.CreateaTable.TabIndex = 0;
            this.CreateaTable.Text = "テーブル作成";
            this.CreateaTable.UseVisualStyleBackColor = true;
            this.CreateaTable.Click += new System.EventHandler(this.CreateaTableClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "登録管理";
            // 
            // DeleteTable
            // 
            this.DeleteTable.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DeleteTable.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteTable.Location = new System.Drawing.Point(307, 112);
            this.DeleteTable.Name = "DeleteTable";
            this.DeleteTable.Size = new System.Drawing.Size(184, 58);
            this.DeleteTable.TabIndex = 2;
            this.DeleteTable.Text = "テーブル削除";
            this.DeleteTable.UseVisualStyleBackColor = true;
            this.DeleteTable.Click += new System.EventHandler(this.DeleteTableClick);
            // 
            // Registration
            // 
            this.Registration.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Registration.Location = new System.Drawing.Point(36, 211);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(184, 58);
            this.Registration.TabIndex = 3;
            this.Registration.Text = "登録";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.RegistrationClick);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Update.Location = new System.Drawing.Point(36, 313);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(184, 58);
            this.Update.TabIndex = 4;
            this.Update.Text = "変更";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.UpdateClick);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Search.Location = new System.Drawing.Point(307, 211);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(184, 58);
            this.Search.TabIndex = 5;
            this.Search.Text = "検索";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.SearchClick);
            // 
            // Delet
            // 
            this.Delet.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Delet.Location = new System.Drawing.Point(307, 313);
            this.Delet.Name = "Delet";
            this.Delet.Size = new System.Drawing.Size(184, 58);
            this.Delet.TabIndex = 6;
            this.Delet.Text = "削除";
            this.Delet.UseVisualStyleBackColor = true;
            this.Delet.Click += new System.EventHandler(this.DeletClick);
            // 
            // Top
            // 
            this.Top.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Top.Location = new System.Drawing.Point(589, 313);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(184, 58);
            this.Top.TabIndex = 7;
            this.Top.Text = "トップに戻る";
            this.Top.UseVisualStyleBackColor = true;
            this.Top.Click += new System.EventHandler(this.TopClick);
            // 
            // Submenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Delet);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.DeleteTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateaTable);
            this.Name = "Submenu";
            this.Text = "Submenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateaTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteTable;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delet;
        private System.Windows.Forms.Button Top;
    }
}