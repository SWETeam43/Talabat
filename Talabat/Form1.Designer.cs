namespace Talabat
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
            this.open_mode = new System.Windows.Forms.Button();
            this.closed_mode = new System.Windows.Forms.Button();
            this.reportButton1 = new System.Windows.Forms.Button();
            this.reportButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open_mode
            // 
            this.open_mode.Location = new System.Drawing.Point(47, 189);
            this.open_mode.Margin = new System.Windows.Forms.Padding(4);
            this.open_mode.Name = "open_mode";
            this.open_mode.Size = new System.Drawing.Size(120, 28);
            this.open_mode.TabIndex = 0;
            this.open_mode.Text = "Connected";
            this.open_mode.UseVisualStyleBackColor = true;
            this.open_mode.Click += new System.EventHandler(this.open_mode_Click);
            // 
            // closed_mode
            // 
            this.closed_mode.Location = new System.Drawing.Point(247, 189);
            this.closed_mode.Margin = new System.Windows.Forms.Padding(4);
            this.closed_mode.Name = "closed_mode";
            this.closed_mode.Size = new System.Drawing.Size(129, 28);
            this.closed_mode.TabIndex = 1;
            this.closed_mode.Text = "Disconnected";
            this.closed_mode.UseVisualStyleBackColor = true;
            this.closed_mode.Click += new System.EventHandler(this.closed_mode_Click);
            // 
            // reportButton1
            // 
            this.reportButton1.Location = new System.Drawing.Point(47, 254);
            this.reportButton1.Name = "reportButton1";
            this.reportButton1.Size = new System.Drawing.Size(120, 31);
            this.reportButton1.TabIndex = 2;
            this.reportButton1.Text = "Shop Report";
            this.reportButton1.UseVisualStyleBackColor = true;
            this.reportButton1.Click += new System.EventHandler(this.reportButton1_Click);
            // 
            // reportButton2
            // 
            this.reportButton2.Location = new System.Drawing.Point(247, 254);
            this.reportButton2.Name = "reportButton2";
            this.reportButton2.Size = new System.Drawing.Size(120, 31);
            this.reportButton2.TabIndex = 3;
            this.reportButton2.Text = "CustomerReport";
            this.reportButton2.UseVisualStyleBackColor = true;
            this.reportButton2.Click += new System.EventHandler(this.reportButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 554);
            this.Controls.Add(this.reportButton2);
            this.Controls.Add(this.reportButton1);
            this.Controls.Add(this.closed_mode);
            this.Controls.Add(this.open_mode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_mode;
        private System.Windows.Forms.Button closed_mode;
        private System.Windows.Forms.Button reportButton1;
        private System.Windows.Forms.Button reportButton2;
    }
}

