
namespace HcsShift
{
    partial class Delete
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
            this.HcsShiftDeleteView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HcsShiftDeleteView)).BeginInit();
            this.SuspendLayout();
            // 
            // HcsShiftDeleteView
            // 
            this.HcsShiftDeleteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HcsShiftDeleteView.Location = new System.Drawing.Point(12, 116);
            this.HcsShiftDeleteView.Name = "HcsShiftDeleteView";
            this.HcsShiftDeleteView.RowHeadersWidth = 51;
            this.HcsShiftDeleteView.RowTemplate.Height = 24;
            this.HcsShiftDeleteView.Size = new System.Drawing.Size(619, 174);
            this.HcsShiftDeleteView.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteButton.Location = new System.Drawing.Point(377, 296);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 42);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeletionButtonClick);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReturnButton.Location = new System.Drawing.Point(521, 296);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(110, 42);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "戻る";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "IDを入力して削除してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(512, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(517, 88);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(114, 22);
            this.ID.TabIndex = 5;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(643, 348);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.HcsShiftDeleteView);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.DeleteLoad);
            ((System.ComponentModel.ISupportInitialize)(this.HcsShiftDeleteView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HcsShiftDeleteView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
    }
}