
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
            this.userName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.OrdersView = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersView)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.FormattingEnabled = true;
            this.userName.Location = new System.Drawing.Point(271, 43);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(258, 24);
            this.userName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(307, 86);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(178, 23);
            this.OrderButton.TabIndex = 2;
            this.OrderButton.Text = "Show Customer Orders";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // OrdersView
            // 
            this.OrdersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersView.Location = new System.Drawing.Point(12, 115);
            this.OrdersView.Name = "OrdersView";
            this.OrdersView.RowHeadersWidth = 51;
            this.OrdersView.RowTemplate.Height = 24;
            this.OrdersView.Size = new System.Drawing.Size(776, 251);
            this.OrdersView.TabIndex = 3;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(321, 382);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(132, 29);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Disconnected_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.OrdersView);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Name = "Disconnected_Form";
            this.Text = "Disconnected_Form";
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
    }
}