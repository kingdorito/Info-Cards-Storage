
namespace Assignment
{
    partial class creditCardDisplay
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
            this.lblcardName = new System.Windows.Forms.Label();
            this.labelcvc = new System.Windows.Forms.Label();
            this.lablelnameoncard = new System.Windows.Forms.Label();
            this.labelexpirydate = new System.Windows.Forms.Label();
            this.labelstartdate = new System.Windows.Forms.Label();
            this.labelcardnum = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcardName
            // 
            this.lblcardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblcardName.Location = new System.Drawing.Point(131, 35);
            this.lblcardName.Name = "lblcardName";
            this.lblcardName.Size = new System.Drawing.Size(120, 25);
            this.lblcardName.TabIndex = 23;
            this.lblcardName.Text = "Card Name";
            this.lblcardName.Click += new System.EventHandler(this._cardName_Click);
            // 
            // labelcvc
            // 
            this.labelcvc.AutoSize = true;
            this.labelcvc.Location = new System.Drawing.Point(132, 197);
            this.labelcvc.Name = "labelcvc";
            this.labelcvc.Size = new System.Drawing.Size(28, 13);
            this.labelcvc.TabIndex = 22;
            this.labelcvc.Text = "CVC";
            // 
            // lablelnameoncard
            // 
            this.lablelnameoncard.AutoSize = true;
            this.lablelnameoncard.Location = new System.Drawing.Point(132, 167);
            this.lablelnameoncard.Name = "lablelnameoncard";
            this.lablelnameoncard.Size = new System.Drawing.Size(77, 13);
            this.lablelnameoncard.TabIndex = 21;
            this.lablelnameoncard.Text = "Name On Card";
            // 
            // labelexpirydate
            // 
            this.labelexpirydate.AutoSize = true;
            this.labelexpirydate.Location = new System.Drawing.Point(132, 141);
            this.labelexpirydate.Name = "labelexpirydate";
            this.labelexpirydate.Size = new System.Drawing.Size(61, 13);
            this.labelexpirydate.TabIndex = 20;
            this.labelexpirydate.Text = "Expiry Date";
            // 
            // labelstartdate
            // 
            this.labelstartdate.AutoSize = true;
            this.labelstartdate.Location = new System.Drawing.Point(132, 109);
            this.labelstartdate.Name = "labelstartdate";
            this.labelstartdate.Size = new System.Drawing.Size(60, 13);
            this.labelstartdate.TabIndex = 19;
            this.labelstartdate.Text = "Start Dame";
            // 
            // labelcardnum
            // 
            this.labelcardnum.AutoSize = true;
            this.labelcardnum.Location = new System.Drawing.Point(132, 75);
            this.labelcardnum.Name = "labelcardnum";
            this.labelcardnum.Size = new System.Drawing.Size(69, 13);
            this.labelcardnum.TabIndex = 18;
            this.labelcardnum.Text = "Card Number";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(81, 237);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(92, 37);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "CVC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Name On Card:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Expiry Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Start Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Card Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Card Name:";
            // 
            // creditCardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.lblcardName);
            this.Controls.Add(this.labelcvc);
            this.Controls.Add(this.lablelnameoncard);
            this.Controls.Add(this.labelexpirydate);
            this.Controls.Add(this.labelstartdate);
            this.Controls.Add(this.labelcardnum);
            this.Name = "creditCardDisplay";
            this.Text = "Card Display";
            this.Load += new System.EventHandler(this.CreditCardDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblcardName;
        private System.Windows.Forms.Label labelcvc;
        private System.Windows.Forms.Label lablelnameoncard;
        private System.Windows.Forms.Label labelexpirydate;
        private System.Windows.Forms.Label labelstartdate;
        private System.Windows.Forms.Label labelcardnum;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}