namespace WindowsFormsApp1
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
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.trkRed = new System.Windows.Forms.Label();
            this.trkGreen = new System.Windows.Forms.Label();
            this.trkBlue = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.ListView();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // trackRed
            // 
            this.trackRed.Location = new System.Drawing.Point(12, 35);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(238, 56);
            this.trackRed.TabIndex = 0;
            this.trackRed.ValueChanged += new System.EventHandler(this.trackRed_ValueChanged);
            // 
            // trackGreen
            // 
            this.trackGreen.Location = new System.Drawing.Point(12, 107);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(238, 56);
            this.trackGreen.TabIndex = 1;
            this.trackGreen.ValueChanged += new System.EventHandler(this.trackGreen_ValueChanged);
            // 
            // trackBlue
            // 
            this.trackBlue.Location = new System.Drawing.Point(12, 185);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(238, 56);
            this.trackBlue.TabIndex = 2;
            this.trackBlue.ValueChanged += new System.EventHandler(this.trackBlue_ValueChanged);
            // 
            // trkRed
            // 
            this.trkRed.AutoSize = true;
            this.trkRed.Location = new System.Drawing.Point(9, 16);
            this.trkRed.Name = "trkRed";
            this.trkRed.Size = new System.Drawing.Size(33, 16);
            this.trkRed.TabIndex = 3;
            this.trkRed.Text = "Red";
            // 
            // trkGreen
            // 
            this.trkGreen.AutoSize = true;
            this.trkGreen.Location = new System.Drawing.Point(9, 88);
            this.trkGreen.Name = "trkGreen";
            this.trkGreen.Size = new System.Drawing.Size(44, 16);
            this.trkGreen.TabIndex = 4;
            this.trkGreen.Text = "Green";
            // 
            // trkBlue
            // 
            this.trkBlue.AutoSize = true;
            this.trkBlue.Location = new System.Drawing.Point(9, 163);
            this.trkBlue.Name = "trkBlue";
            this.trkBlue.Size = new System.Drawing.Size(34, 16);
            this.trkBlue.TabIndex = 5;
            this.trkBlue.Text = "Blue";
            // 
            // output
            // 
            this.output.HideSelection = false;
            this.output.Location = new System.Drawing.Point(307, 35);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(205, 180);
            this.output.TabIndex = 6;
            this.output.UseCompatibleStateImageBehavior = false;
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(59, 12);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(74, 22);
            this.txtRed.TabIndex = 7;
            this.txtRed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRed_KeyDown);
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(59, 82);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(74, 22);
            this.txtGreen.TabIndex = 8;
            this.txtGreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGreen_KeyDown);
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(59, 157);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(74, 22);
            this.txtBlue.TabIndex = 9;
            this.txtBlue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBlue_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(536, 253);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.output);
            this.Controls.Add(this.trkBlue);
            this.Controls.Add(this.trkGreen);
            this.Controls.Add(this.trkRed);
            this.Controls.Add(this.trackBlue);
            this.Controls.Add(this.trackGreen);
            this.Controls.Add(this.trackRed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.Label trkRed;
        private System.Windows.Forms.Label trkGreen;
        private System.Windows.Forms.Label trkBlue;
        private System.Windows.Forms.ListView output;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
    }
}

