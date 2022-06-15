
namespace Circles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainCircle = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCircle
            // 
            this.mainCircle.BackColor = System.Drawing.Color.Blue;
            this.mainCircle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainCircle.Location = new System.Drawing.Point(346, 330);
            this.mainCircle.Name = "mainCircle";
            this.mainCircle.Size = new System.Drawing.Size(119, 107);
            this.mainCircle.TabIndex = 3;
            this.mainCircle.TabStop = false;
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 32;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 449);
            this.Controls.Add(this.mainCircle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainCircle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCircle;
        private System.Windows.Forms.Timer mainTimer;
    }
}

