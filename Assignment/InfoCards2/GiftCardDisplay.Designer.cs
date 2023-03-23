
namespace Assignment
{
    partial class GiftCardDisplay
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
            this.giftCardName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.giftLastName = new System.Windows.Forms.Label();
            this.giftFirstName = new System.Windows.Forms.Label();
            this.giftAmount = new System.Windows.Forms.Label();
            this.giftDateIssued = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giftCardName
            // 
            this.giftCardName.AutoSize = true;
            this.giftCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.giftCardName.Location = new System.Drawing.Point(137, 40);
            this.giftCardName.Name = "giftCardName";
            this.giftCardName.Size = new System.Drawing.Size(115, 24);
            this.giftCardName.TabIndex = 0;
            this.giftCardName.Text = "Card Name";
            this.giftCardName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date Issued:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Card Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Card Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 25;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // giftLastName
            // 
            this.giftLastName.AutoSize = true;
            this.giftLastName.Location = new System.Drawing.Point(138, 115);
            this.giftLastName.Name = "giftLastName";
            this.giftLastName.Size = new System.Drawing.Size(58, 13);
            this.giftLastName.TabIndex = 26;
            this.giftLastName.Text = "Last Name";
            // 
            // giftFirstName
            // 
            this.giftFirstName.AutoSize = true;
            this.giftFirstName.Location = new System.Drawing.Point(138, 85);
            this.giftFirstName.Name = "giftFirstName";
            this.giftFirstName.Size = new System.Drawing.Size(38, 13);
            this.giftFirstName.TabIndex = 27;
            this.giftFirstName.Text = "Name ";
            // 
            // giftAmount
            // 
            this.giftAmount.AutoSize = true;
            this.giftAmount.Location = new System.Drawing.Point(138, 145);
            this.giftAmount.Name = "giftAmount";
            this.giftAmount.Size = new System.Drawing.Size(43, 13);
            this.giftAmount.TabIndex = 28;
            this.giftAmount.Text = "Amount";
            // 
            // giftDateIssued
            // 
            this.giftDateIssued.AutoSize = true;
            this.giftDateIssued.Location = new System.Drawing.Point(138, 178);
            this.giftDateIssued.Name = "giftDateIssued";
            this.giftDateIssued.Size = new System.Drawing.Size(64, 13);
            this.giftDateIssued.TabIndex = 29;
            this.giftDateIssued.Text = "Date Issued";
            // 
            // GiftCardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 291);
            this.Controls.Add(this.giftDateIssued);
            this.Controls.Add(this.giftAmount);
            this.Controls.Add(this.giftFirstName);
            this.Controls.Add(this.giftLastName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.giftCardName);
            this.Name = "GiftCardDisplay";
            this.Text = "Gift Card";
            this.Load += new System.EventHandler(this.GiftCardDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label giftCardName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label giftLastName;
        private System.Windows.Forms.Label giftFirstName;
        private System.Windows.Forms.Label giftAmount;
        private System.Windows.Forms.Label giftDateIssued;
    }
}