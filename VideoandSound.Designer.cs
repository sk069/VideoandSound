namespace VideoandSound
{
    partial class VideoandSound
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
            this.Load_button = new System.Windows.Forms.Button();
            this.Spin_button = new System.Windows.Forms.Button();
            this.Image_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_button
            // 
            this.Load_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Load_button.Location = new System.Drawing.Point(288, 251);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(88, 42);
            this.Load_button.TabIndex = 0;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = false;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Spin_button
            // 
            this.Spin_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Spin_button.Location = new System.Drawing.Point(452, 251);
            this.Spin_button.Name = "Spin_button";
            this.Spin_button.Size = new System.Drawing.Size(85, 42);
            this.Spin_button.TabIndex = 1;
            this.Spin_button.Text = "Spin";
            this.Spin_button.UseVisualStyleBackColor = false;
            // 
            // Image_box
            // 
            this.Image_box.BackColor = System.Drawing.SystemColors.Highlight;
            this.Image_box.Location = new System.Drawing.Point(234, 53);
            this.Image_box.Name = "Image_box";
            this.Image_box.Size = new System.Drawing.Size(348, 160);
            this.Image_box.TabIndex = 2;
            this.Image_box.TabStop = false;
            // 
            // VideoandSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Image_box);
            this.Controls.Add(this.Spin_button);
            this.Controls.Add(this.Load_button);
            this.Name = "VideoandSound";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button Spin_button;
        private System.Windows.Forms.PictureBox Image_box;
    }
}

