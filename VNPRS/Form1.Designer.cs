namespace VNPRS
{
    partial class CameraCapture
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
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.grayscaleImageBox = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.ibframe1 = new Emgu.CV.UI.ImageBox();
            this.histogram1 = new AForge.Controls.Histogram();
            this.nudmaxgray = new System.Windows.Forms.NumericUpDown();
            this.nudmingray = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.histogram2 = new AForge.Controls.Histogram();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ibRect = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibframe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmaxgray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmingray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibRect)).BeginInit();
            this.SuspendLayout();
            // 
            // captureImageBox
            // 
            this.captureImageBox.Location = new System.Drawing.Point(336, 8);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(100, 108);
            this.captureImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.captureImageBox.TabIndex = 2;
            this.captureImageBox.TabStop = false;
            // 
            // grayscaleImageBox
            // 
            this.grayscaleImageBox.Location = new System.Drawing.Point(456, 12);
            this.grayscaleImageBox.Name = "grayscaleImageBox";
            this.grayscaleImageBox.Size = new System.Drawing.Size(108, 120);
            this.grayscaleImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grayscaleImageBox.TabIndex = 2;
            this.grayscaleImageBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ibOriginal
            // 
            this.ibOriginal.Location = new System.Drawing.Point(36, 4);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(104, 120);
            this.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // ibframe1
            // 
            this.ibframe1.Location = new System.Drawing.Point(208, 8);
            this.ibframe1.Name = "ibframe1";
            this.ibframe1.Size = new System.Drawing.Size(100, 104);
            this.ibframe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibframe1.TabIndex = 2;
            this.ibframe1.TabStop = false;
            // 
            // histogram1
            // 
            this.histogram1.Location = new System.Drawing.Point(24, 164);
            this.histogram1.Name = "histogram1";
            this.histogram1.Size = new System.Drawing.Size(680, 160);
            this.histogram1.TabIndex = 4;
            this.histogram1.Text = "histogram1";
            this.histogram1.Values = null;
            // 
            // nudmaxgray
            // 
            this.nudmaxgray.Location = new System.Drawing.Point(160, 56);
            this.nudmaxgray.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudmaxgray.Name = "nudmaxgray";
            this.nudmaxgray.Size = new System.Drawing.Size(40, 20);
            this.nudmaxgray.TabIndex = 5;
            this.nudmaxgray.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudmaxgray.ValueChanged += new System.EventHandler(this.nudmaxgray_ValueChanged);
            // 
            // nudmingray
            // 
            this.nudmingray.Location = new System.Drawing.Point(160, 92);
            this.nudmingray.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudmingray.Name = "nudmingray";
            this.nudmingray.Size = new System.Drawing.Size(40, 20);
            this.nudmingray.TabIndex = 6;
            this.nudmingray.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudmingray.ValueChanged += new System.EventHandler(this.nudmingray_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // histogram2
            // 
            this.histogram2.Location = new System.Drawing.Point(20, 332);
            this.histogram2.Name = "histogram2";
            this.histogram2.Size = new System.Drawing.Size(588, 164);
            this.histogram2.TabIndex = 8;
            this.histogram2.Text = "histogram2";
            this.histogram2.Values = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Horizontal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "vertical";
            // 
            // ibRect
            // 
            this.ibRect.Location = new System.Drawing.Point(576, 12);
            this.ibRect.Name = "ibRect";
            this.ibRect.Size = new System.Drawing.Size(88, 116);
            this.ibRect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibRect.TabIndex = 2;
            this.ibRect.TabStop = false;
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 533);
            this.Controls.Add(this.ibRect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.histogram2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudmingray);
            this.Controls.Add(this.nudmaxgray);
            this.Controls.Add(this.histogram1);
            this.Controls.Add(this.ibframe1);
            this.Controls.Add(this.ibOriginal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grayscaleImageBox);
            this.Controls.Add(this.captureImageBox);
            this.Name = "CameraCapture";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibframe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmaxgray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmingray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibRect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox captureImageBox;
        private Emgu.CV.UI.ImageBox grayscaleImageBox;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox ibOriginal;
        private Emgu.CV.UI.ImageBox ibframe1;
        private AForge.Controls.Histogram histogram1;
        private System.Windows.Forms.NumericUpDown nudmaxgray;
        private System.Windows.Forms.NumericUpDown nudmingray;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.Histogram histogram2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox ibRect;
    }
}

