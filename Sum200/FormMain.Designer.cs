namespace Sum200
{
    partial class frmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHalfway = new System.Windows.Forms.Label();
            this.txtHalfway = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblHalfway
            // 
            this.lblHalfway.AutoSize = true;
            this.lblHalfway.Location = new System.Drawing.Point(226, 103);
            this.lblHalfway.Name = "lblHalfway";
            this.lblHalfway.Size = new System.Drawing.Size(187, 32);
            this.lblHalfway.TabIndex = 1;
            this.lblHalfway.Text = "Halfway Total";
            // 
            // txtHalfway
            // 
            this.txtHalfway.Location = new System.Drawing.Point(25, 97);
            this.txtHalfway.Name = "txtHalfway";
            this.txtHalfway.ReadOnly = true;
            this.txtHalfway.Size = new System.Drawing.Size(175, 38);
            this.txtHalfway.TabIndex = 2;
            this.txtHalfway.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(25, 151);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(175, 38);
            this.txtSum.TabIndex = 4;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(226, 157);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(73, 32);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "Sum";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtHalfway);
            this.Controls.Add(this.lblHalfway);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Sum 200";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHalfway;
        private System.Windows.Forms.TextBox txtHalfway;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
    }
}

