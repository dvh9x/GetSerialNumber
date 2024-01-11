namespace GetSerialNumber
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_serialNumber = new System.Windows.Forms.TextBox();
            this.bt_GetSerialNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SerialNumber";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_serialNumber
            // 
            this.txt_serialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_serialNumber.Location = new System.Drawing.Point(95, 159);
            this.txt_serialNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_serialNumber.Name = "txt_serialNumber";
            this.txt_serialNumber.Size = new System.Drawing.Size(395, 20);
            this.txt_serialNumber.TabIndex = 1;
            // 
            // bt_GetSerialNumber
            // 
            this.bt_GetSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_GetSerialNumber.Location = new System.Drawing.Point(494, 159);
            this.bt_GetSerialNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_GetSerialNumber.Name = "bt_GetSerialNumber";
            this.bt_GetSerialNumber.Size = new System.Drawing.Size(100, 20);
            this.bt_GetSerialNumber.TabIndex = 2;
            this.bt_GetSerialNumber.Text = "Get Serial";
            this.bt_GetSerialNumber.UseVisualStyleBackColor = true;
            this.bt_GetSerialNumber.Click += new System.EventHandler(this.bt_GetSerialNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bt_GetSerialNumber);
            this.Controls.Add(this.txt_serialNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_serialNumber;
        private System.Windows.Forms.Button bt_GetSerialNumber;
    }
}

