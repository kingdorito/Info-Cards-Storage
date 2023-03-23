
namespace Assignment
{
    partial class CreditCardEdit
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
            this._cardName = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this._nameOnCard = new System.Windows.Forms.TextBox();
            this._startDate = new System.Windows.Forms.TextBox();
            this._cvc = new System.Windows.Forms.TextBox();
            this._cardNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._expiryDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _cardName
            // 
            this._cardName.Location = new System.Drawing.Point(123, 43);
            this._cardName.MaxLength = 20;
            this._cardName.Name = "_cardName";
            this._cardName.Size = new System.Drawing.Size(100, 20);
            this._cardName.TabIndex = 0;
            this._cardName.TextChanged += new System.EventHandler(this._cardName_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(168, 239);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 35);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(47, 239);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 35);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // _nameOnCard
            // 
            this._nameOnCard.Location = new System.Drawing.Point(123, 159);
            this._nameOnCard.MaxLength = 30;
            this._nameOnCard.Name = "_nameOnCard";
            this._nameOnCard.Size = new System.Drawing.Size(100, 20);
            this._nameOnCard.TabIndex = 4;
            this._nameOnCard.TextChanged += new System.EventHandler(this._nameOnCard_TextChanged);
            this._nameOnCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._nameOnCard_KeyPress);
            // 
            // _startDate
            // 
            this._startDate.Location = new System.Drawing.Point(123, 107);
            this._startDate.MaxLength = 7;
            this._startDate.Name = "_startDate";
            this._startDate.Size = new System.Drawing.Size(100, 20);
            this._startDate.TabIndex = 2;
            this._startDate.TextChanged += new System.EventHandler(this._startDate_TextChanged);
            this._startDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._startDate_KeyPress);
            // 
            // _cvc
            // 
            this._cvc.Location = new System.Drawing.Point(123, 185);
            this._cvc.MaxLength = 3;
            this._cvc.Name = "_cvc";
            this._cvc.Size = new System.Drawing.Size(100, 20);
            this._cvc.TabIndex = 5;
            this._cvc.TextChanged += new System.EventHandler(this._cvc_TextChanged);
            this._cvc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cvc_KeyPress);
            // 
            // _cardNum
            // 
            this._cardNum.Location = new System.Drawing.Point(123, 83);
            this._cardNum.MaxLength = 19;
            this._cardNum.Name = "_cardNum";
            this._cardNum.Size = new System.Drawing.Size(100, 20);
            this._cardNum.TabIndex = 1;
            this._cardNum.TextChanged += new System.EventHandler(this._cardNum_TextChanged);
            this._cardNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cardNum_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "CVC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Name On Card:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Expiry Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Card Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Card Name:";
            // 
            // _expiryDate
            // 
            this._expiryDate.Location = new System.Drawing.Point(123, 133);
            this._expiryDate.MaxLength = 7;
            this._expiryDate.Name = "_expiryDate";
            this._expiryDate.Size = new System.Drawing.Size(100, 20);
            this._expiryDate.TabIndex = 3;
            this._expiryDate.TextChanged += new System.EventHandler(this._expiryDate_TextChanged_1);
            this._expiryDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._expiryDate_KeyPress);
            // 
            // CreditCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 325);
            this.Controls.Add(this._expiryDate);
            this.Controls.Add(this._cardName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this._nameOnCard);
            this.Controls.Add(this._startDate);
            this.Controls.Add(this._cvc);
            this.Controls.Add(this._cardNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreditCardEdit";
            this.Text = "Card Edit";
            this.Load += new System.EventHandler(this.CreditCardEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox _cardName;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TextBox _nameOnCard;
        public System.Windows.Forms.TextBox _startDate;
        public System.Windows.Forms.TextBox _cvc;
        public System.Windows.Forms.TextBox _cardNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox _expiryDate;
    }
}