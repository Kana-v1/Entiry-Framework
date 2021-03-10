
namespace WindowsFormsApp1
{
    partial class ShowAllTables
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
            this.clientBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberBtn = new System.Windows.Forms.Button();
            this.tafirrBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientBtn
            // 
            this.clientBtn.Location = new System.Drawing.Point(17, 208);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(126, 76);
            this.clientBtn.TabIndex = 0;
            this.clientBtn.Text = "Show Clients";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(17, 328);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(126, 83);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 426);
            this.dataGridView1.TabIndex = 4;
            // 
            // numberBtn
            // 
            this.numberBtn.Location = new System.Drawing.Point(17, 107);
            this.numberBtn.Name = "numberBtn";
            this.numberBtn.Size = new System.Drawing.Size(126, 76);
            this.numberBtn.TabIndex = 5;
            this.numberBtn.Text = "Show phone numbers";
            this.numberBtn.UseVisualStyleBackColor = true;
            this.numberBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // tafirrBtn
            // 
            this.tafirrBtn.Location = new System.Drawing.Point(17, 12);
            this.tafirrBtn.Name = "tafirrBtn";
            this.tafirrBtn.Size = new System.Drawing.Size(126, 76);
            this.tafirrBtn.TabIndex = 6;
            this.tafirrBtn.Text = "Show tariffes";
            this.tafirrBtn.UseVisualStyleBackColor = true;
            this.tafirrBtn.Click += new System.EventHandler(this.tafirrBtn_Click);
            // 
            // ShowAllTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tafirrBtn);
            this.Controls.Add(this.numberBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clientBtn);
            this.Name = "ShowAllTables";
            this.Text = "ShowAllTables";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button numberBtn;
        private System.Windows.Forms.Button tafirrBtn;
    }
}