
namespace WindowsFormsApp1
{
    partial class AddTariff
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
            this.nameTb = new System.Windows.Forms.TextBox();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.MonthPayTb = new System.Windows.Forms.TextBox();
            this.ConnectPayTb = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(14, 82);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(155, 20);
            this.nameTb.TabIndex = 0;
            this.nameTb.Text = "Default Name";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Location = new System.Drawing.Point(305, 82);
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(155, 20);
            this.DescriptionTb.TabIndex = 1;
            this.DescriptionTb.Text = "Default description";
            // 
            // MonthPayTb
            // 
            this.MonthPayTb.Location = new System.Drawing.Point(14, 224);
            this.MonthPayTb.Name = "MonthPayTb";
            this.MonthPayTb.Size = new System.Drawing.Size(155, 20);
            this.MonthPayTb.TabIndex = 2;
            this.MonthPayTb.Text = "50";
            // 
            // ConnectPayTb
            // 
            this.ConnectPayTb.Location = new System.Drawing.Point(14, 344);
            this.ConnectPayTb.Name = "ConnectPayTb";
            this.ConnectPayTb.Size = new System.Drawing.Size(155, 20);
            this.ConnectPayTb.TabIndex = 3;
            this.ConnectPayTb.Text = "250";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(301, 177);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(253, 89);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add new Tariff";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(301, 308);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(253, 95);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ConnectPayTb);
            this.Controls.Add(this.MonthPayTb);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.nameTb);
            this.Name = "AddTariff";
            this.Text = "AddTariff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.TextBox MonthPayTb;
        private System.Windows.Forms.TextBox ConnectPayTb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}