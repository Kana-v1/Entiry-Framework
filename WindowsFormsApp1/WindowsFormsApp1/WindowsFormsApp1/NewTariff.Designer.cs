
namespace WindowsFormsApp1
{
    partial class NewTariff
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
            this.tariffCb = new System.Windows.Forms.ComboBox();
            this.num_cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tariffCb
            // 
            this.tariffCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tariffCb.FormattingEnabled = true;
            this.tariffCb.Location = new System.Drawing.Point(12, 98);
            this.tariffCb.Name = "tariffCb";
            this.tariffCb.Size = new System.Drawing.Size(121, 21);
            this.tariffCb.TabIndex = 0;
            // 
            // num_cb
            // 
            this.num_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num_cb.FormattingEnabled = true;
            this.num_cb.Location = new System.Drawing.Point(160, 98);
            this.num_cb.Name = "num_cb";
            this.num_cb.Size = new System.Drawing.Size(306, 21);
            this.num_cb.TabIndex = 1;
            this.num_cb.SelectedIndexChanged += new System.EventHandler(this.num_cb_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm new tariff";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 83);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter new tariff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(228, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter number";
            // 
            // NewTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_cb);
            this.Controls.Add(this.tariffCb);
            this.Name = "NewTariff";
            this.Text = "NewTariff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tariffCb;
        private System.Windows.Forms.ComboBox num_cb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}