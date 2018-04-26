namespace Crazy8
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
            this.components = new System.ComponentModel.Container();
            this.qBTN = new System.Windows.Forms.Button();
            this.aLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // qBTN
            // 
            this.qBTN.BackColor = System.Drawing.SystemColors.MenuBar;
            this.qBTN.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qBTN.Location = new System.Drawing.Point(85, 232);
            this.qBTN.Name = "qBTN";
            this.qBTN.Size = new System.Drawing.Size(443, 144);
            this.qBTN.TabIndex = 0;
            this.qBTN.Text = "I HAVE A QUESTION";
            this.qBTN.UseVisualStyleBackColor = false;
            this.qBTN.MouseEnter += new System.EventHandler(this.qBTN_MouseEnter);
            this.qBTN.MouseLeave += new System.EventHandler(this.qBTN_MouseLeave);
            // 
            // aLBL
            // 
            this.aLBL.AutoSize = true;
            this.aLBL.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLBL.Location = new System.Drawing.Point(36, 78);
            this.aLBL.Name = "aLBL";
            this.aLBL.Size = new System.Drawing.Size(515, 65);
            this.aLBL.TabIndex = 1;
            this.aLBL.Text = "I HAVE AN ANSWER";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 388);
            this.Controls.Add(this.aLBL);
            this.Controls.Add(this.qBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button qBTN;
        private System.Windows.Forms.Label aLBL;
        private System.Windows.Forms.Timer timer1;
    }
}

