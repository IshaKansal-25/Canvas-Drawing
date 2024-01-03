namespace Canvas_Drawing
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.drawRect = new System.Windows.Forms.Button();
            this.drawCircle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drawText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1141, 509);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(539, 558);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(408, 40);
            this.textBox.TabIndex = 1;
            // 
            // drawRect
            // 
            this.drawRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawRect.Location = new System.Drawing.Point(33, 558);
            this.drawRect.Name = "drawRect";
            this.drawRect.Size = new System.Drawing.Size(141, 40);
            this.drawRect.TabIndex = 2;
            this.drawRect.Text = "Rectangle";
            this.drawRect.UseVisualStyleBackColor = true;
            this.drawRect.Click += new System.EventHandler(this.drawRect_Click);
            // 
            // drawCircle
            // 
            this.drawCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawCircle.Location = new System.Drawing.Point(199, 558);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(128, 40);
            this.drawCircle.TabIndex = 3;
            this.drawCircle.Text = "Circle";
            this.drawCircle.UseVisualStyleBackColor = true;
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter text :";
            // 
            // drawText
            // 
            this.drawText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawText.Location = new System.Drawing.Point(967, 558);
            this.drawText.Name = "drawText";
            this.drawText.Size = new System.Drawing.Size(161, 38);
            this.drawText.TabIndex = 5;
            this.drawText.Text = "Display Text";
            this.drawText.UseVisualStyleBackColor = true;
            this.drawText.Click += new System.EventHandler(this.drawText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1165, 653);
            this.Controls.Add(this.drawText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawCircle);
            this.Controls.Add(this.drawRect);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Canvas Drawing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button drawRect;
        private System.Windows.Forms.Button drawCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawText;
    }
}

