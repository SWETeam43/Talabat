
namespace Talabat
{
    partial class Disconnected_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disconnected_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.OrdersView = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersView)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.FormattingEnabled = true;
            this.userName.Location = new System.Drawing.Point(547, 64);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(258, 24);
            this.userName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(317, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name :";
            // 
            // OrderButton
            // 
            this.OrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderButton.BackgroundImage")));
            this.OrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.Color.White;
            this.OrderButton.Location = new System.Drawing.Point(553, 114);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(247, 55);
            this.OrderButton.TabIndex = 2;
            this.OrderButton.Text = "Show Customer Orders";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // OrdersView
            // 
            this.OrdersView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.OrdersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersView.GridColor = System.Drawing.Color.Black;
            this.OrdersView.Location = new System.Drawing.Point(19, 187);
            this.OrdersView.Name = "OrdersView";
            this.OrdersView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.OrdersView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersView.RowTemplate.Height = 24;
            this.OrdersView.Size = new System.Drawing.Size(1317, 290);
            this.OrdersView.TabIndex = 3;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateButton.BackgroundImage")));
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(589, 495);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(175, 64);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update Orders";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Orders View";
            // 
            // Disconnected_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1348, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.OrdersView);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Name = "Disconnected_Form";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Disconnected_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.DataGridView OrdersView;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label2;
    }
}