
namespace Blast_trainer
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
            this.lives = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lives
            // 
            this.lives.AutoSize = true;
            this.lives.Checked = true;
            this.lives.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lives.Location = new System.Drawing.Point(52, 57);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(110, 21);
            this.lives.TabIndex = 0;
            this.lives.Text = "Aspect Ratio";
            this.lives.UseVisualStyleBackColor = true;
            this.lives.CheckedChanged += new System.EventHandler(this.lives_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 132);
            this.Controls.Add(this.lives);
            this.Name = "Form1";
            this.Text = "Earthworm Jim 3D ZTrainer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lives;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

