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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open_mode = new System.Windows.Forms.Button();
            this.closed_mode = new System.Windows.Forms.Button();
            this.reportButton1 = new System.Windows.Forms.Button();
            this.reportButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open_mode
            // 
            this.open_mode.BackColor = System.Drawing.Color.Transparent;
            this.open_mode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_mode.BackgroundImage")));
            this.open_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open_mode.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.open_mode.FlatAppearance.BorderSize = 0;
            this.open_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_mode.ForeColor = System.Drawing.Color.White;
            this.open_mode.Location = new System.Drawing.Point(45, 97);
            this.open_mode.Margin = new System.Windows.Forms.Padding(4);
            this.open_mode.Name = "open_mode";
            this.open_mode.Size = new System.Drawing.Size(237, 60);
            this.open_mode.TabIndex = 0;
            this.open_mode.Text = "Shops Form";
            this.open_mode.UseVisualStyleBackColor = false;
            this.open_mode.Click += new System.EventHandler(this.open_mode_Click);
            // 
            // closed_mode
            // 
            this.closed_mode.BackColor = System.Drawing.Color.Transparent;
            this.closed_mode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closed_mode.BackgroundImage")));
            this.closed_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closed_mode.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.closed_mode.FlatAppearance.BorderSize = 0;
            this.closed_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closed_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed_mode.ForeColor = System.Drawing.Color.White;
            this.closed_mode.Location = new System.Drawing.Point(45, 174);
            this.closed_mode.Margin = new System.Windows.Forms.Padding(4);
            this.closed_mode.Name = "closed_mode";
            this.closed_mode.Size = new System.Drawing.Size(237, 60);
            this.closed_mode.TabIndex = 1;
            this.closed_mode.Text = "Orders Form";
            this.closed_mode.UseVisualStyleBackColor = false;
            this.closed_mode.Click += new System.EventHandler(this.closed_mode_Click);
            // 
            // reportButton1
            // 
            this.reportButton1.BackColor = System.Drawing.Color.Transparent;
            this.reportButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportButton1.BackgroundImage")));
            this.reportButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportButton1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.reportButton1.FlatAppearance.BorderSize = 0;
            this.reportButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton1.ForeColor = System.Drawing.Color.White;
            this.reportButton1.Location = new System.Drawing.Point(45, 328);
            this.reportButton1.Name = "reportButton1";
            this.reportButton1.Size = new System.Drawing.Size(237, 60);
            this.reportButton1.TabIndex = 2;
            this.reportButton1.Text = "Shop Report";
            this.reportButton1.UseVisualStyleBackColor = false;
            this.reportButton1.Click += new System.EventHandler(this.reportButton1_Click);
            // 
            // reportButton2
            // 
            this.reportButton2.BackColor = System.Drawing.Color.Transparent;
            this.reportButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportButton2.BackgroundImage")));
            this.reportButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportButton2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.reportButton2.FlatAppearance.BorderSize = 0;
            this.reportButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton2.ForeColor = System.Drawing.Color.White;
            this.reportButton2.Location = new System.Drawing.Point(45, 251);
            this.reportButton2.Name = "reportButton2";
            this.reportButton2.Size = new System.Drawing.Size(237, 60);
            this.reportButton2.TabIndex = 3;
            this.reportButton2.Text = "Customer Report";
            this.reportButton2.UseVisualStyleBackColor = false;
            this.reportButton2.Click += new System.EventHandler(this.reportButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 519);
            this.Controls.Add(this.reportButton2);
            this.Controls.Add(this.reportButton1);
            this.Controls.Add(this.closed_mode);
            this.Controls.Add(this.open_mode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talabat";
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

