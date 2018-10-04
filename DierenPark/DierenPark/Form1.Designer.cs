namespace DierenPark
{
    partial class frmUI
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chbEchtpaar = new System.Windows.Forms.CheckBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbKinderen = new System.Windows.Forms.TextBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // chbEchtpaar
            // 
            this.chbEchtpaar.AutoSize = true;
            this.chbEchtpaar.Location = new System.Drawing.Point(12, 12);
            this.chbEchtpaar.Name = "chbEchtpaar";
            this.chbEchtpaar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbEchtpaar.Size = new System.Drawing.Size(78, 17);
            this.chbEchtpaar.TabIndex = 2;
            this.chbEchtpaar.Text = "? Echtpaar";
            this.chbEchtpaar.UseVisualStyleBackColor = true;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(218, 85);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 5;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aantal kinderen: ";
            // 
            // txbKinderen
            // 
            this.txbKinderen.Location = new System.Drawing.Point(159, 87);
            this.txbKinderen.Name = "txbKinderen";
            this.txbKinderen.Size = new System.Drawing.Size(53, 20);
            this.txbKinderen.TabIndex = 7;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(18, 120);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(107, 13);
            this.lblOut.TabIndex = 8;
            this.lblOut.Text = "De te betalen kost is:";
            // 
            // frmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 178);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txbKinderen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.chbEchtpaar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmUI";
            this.Text = "Abonnement aanvraag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox chbEchtpaar;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbKinderen;
        private System.Windows.Forms.Label lblOut;
    }
}

