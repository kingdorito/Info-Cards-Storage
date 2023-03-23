
using System;

namespace Assignment
{
    partial class GiftCardEdit
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this._giftCardName = new System.Windows.Forms.TextBox();
            this._giftCardLastName = new System.Windows.Forms.TextBox();
            this._giftCardAmount = new System.Windows.Forms.TextBox();
            this._giftCardFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._giftCardDateIssued = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(33, 206);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 31);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(151, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 31);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // _giftCardName
            // 
            this._giftCardName.Location = new System.Drawing.Point(109, 33);
            this._giftCardName.MaxLength = 20;
            this._giftCardName.Name = "_giftCardName";
            this._giftCardName.Size = new System.Drawing.Size(100, 20);
            this._giftCardName.TabIndex = 0;
            this._giftCardName.TextChanged += new System.EventHandler(this._giftCardName_TextChanged);
            // 
            // _giftCardLastName
            // 
            this._giftCardLastName.Location = new System.Drawing.Point(108, 101);
            this._giftCardLastName.MaxLength = 10;
            this._giftCardLastName.Name = "_giftCardLastName";
            this._giftCardLastName.Size = new System.Drawing.Size(100, 20);
            this._giftCardLastName.TabIndex = 2;
            this._giftCardLastName.TextChanged += new System.EventHandler(this._giftCardLastName_TextChanged);
            this._giftCardLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._giftCardLastName_KeyPress);
            // 
            // _giftCardAmount
            // 
            this._giftCardAmount.Location = new System.Drawing.Point(108, 127);
            this._giftCardAmount.MaxLength = 10;
            this._giftCardAmount.Name = "_giftCardAmount";
            this._giftCardAmount.Size = new System.Drawing.Size(100, 20);
            this._giftCardAmount.TabIndex = 3;
            this._giftCardAmount.TextChanged += new System.EventHandler(this._giftCardAmount_TextChanged);
            this._giftCardAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._giftCardAmount_KeyPress);
            // 
            // _giftCardFirstName
            // 
            this._giftCardFirstName.Location = new System.Drawing.Point(109, 75);
            this._giftCardFirstName.MaxLength = 10;
            this._giftCardFirstName.Name = "_giftCardFirstName";
            this._giftCardFirstName.Size = new System.Drawing.Size(100, 20);
            this._giftCardFirstName.TabIndex = 1;
            this._giftCardFirstName.TextChanged += new System.EventHandler(this._giftCardFirstName_TextChanged);
            this._giftCardFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._giftCardFirstName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Card Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Issued:";
            // 
            // _giftCardDateIssued
            // 
            this._giftCardDateIssued.Location = new System.Drawing.Point(109, 157);
            this._giftCardDateIssued.MaxLength = 10;
            this._giftCardDateIssued.Name = "_giftCardDateIssued";
            this._giftCardDateIssued.Size = new System.Drawing.Size(100, 20);
            this._giftCardDateIssued.TabIndex = 4;
            this._giftCardDateIssued.TextChanged += new System.EventHandler(this._giftCardDateIssued_TextChanged);
            this._giftCardDateIssued.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._giftCardDateIssued_KeyPress);
            // 
            // GiftCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 285);
            this.Controls.Add(this._giftCardDateIssued);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._giftCardFirstName);
            this.Controls.Add(this._giftCardAmount);
            this.Controls.Add(this._giftCardLastName);
            this.Controls.Add(this._giftCardName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Name = "GiftCardEdit";
            this.Text = "Gift Edit";
            this.Load += new System.EventHandler(this.GiftCardEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox _giftCardName;
        public System.Windows.Forms.TextBox _giftCardLastName;
        public System.Windows.Forms.TextBox _giftCardAmount;
        public System.Windows.Forms.TextBox _giftCardFirstName;
        public System.Windows.Forms.TextBox _giftCardDateIssued;
    }
}