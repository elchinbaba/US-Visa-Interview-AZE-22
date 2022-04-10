
namespace VisaInterviewUS
{
    partial class app
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
            this.playbtn = new System.Windows.Forms.Button();
            this.questionlbl = new System.Windows.Forms.Label();
            this.addquestbtn = new System.Windows.Forms.Button();
            this.restartbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playbtn
            // 
            this.playbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbtn.Location = new System.Drawing.Point(214, 132);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(108, 46);
            this.playbtn.TabIndex = 0;
            this.playbtn.Text = "play";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // questionlbl
            // 
            this.questionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionlbl.Location = new System.Drawing.Point(12, 9);
            this.questionlbl.Name = "questionlbl";
            this.questionlbl.Size = new System.Drawing.Size(502, 120);
            this.questionlbl.TabIndex = 1;
            this.questionlbl.Text = "question";
            this.questionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addquestbtn
            // 
            this.addquestbtn.Location = new System.Drawing.Point(439, 143);
            this.addquestbtn.Name = "addquestbtn";
            this.addquestbtn.Size = new System.Drawing.Size(75, 35);
            this.addquestbtn.TabIndex = 2;
            this.addquestbtn.Text = "Add your questions";
            this.addquestbtn.UseVisualStyleBackColor = true;
            this.addquestbtn.Click += new System.EventHandler(this.addquestbtn_Click);
            // 
            // restartbtn
            // 
            this.restartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartbtn.Location = new System.Drawing.Point(107, 140);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(81, 35);
            this.restartbtn.TabIndex = 3;
            this.restartbtn.Text = "Restart";
            this.restartbtn.UseVisualStyleBackColor = true;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 190);
            this.Controls.Add(this.restartbtn);
            this.Controls.Add(this.addquestbtn);
            this.Controls.Add(this.questionlbl);
            this.Controls.Add(this.playbtn);
            this.Name = "app";
            this.Text = "US Visa Interview Trainer AZE 22";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Label questionlbl;
        private System.Windows.Forms.Button addquestbtn;
        private System.Windows.Forms.Button restartbtn;
    }
}