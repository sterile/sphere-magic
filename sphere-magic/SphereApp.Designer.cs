namespace sphere_magic
{
    partial class SphereApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SphereApp));
            this.spherePhoto1 = new System.Windows.Forms.PictureBox();
            this.spherePhoto2 = new System.Windows.Forms.PictureBox();
            this.sphereLbl = new System.Windows.Forms.Label();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.surfaceLbl = new System.Windows.Forms.Label();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.radiusTBox = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.calcDiameterLabel = new System.Windows.Forms.Label();
            this.calcSurfaceLbl = new System.Windows.Forms.Label();
            this.calcVolumeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spherePhoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spherePhoto2)).BeginInit();
            this.SuspendLayout();
            // 
            // spherePhoto1
            // 
            this.spherePhoto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spherePhoto1.Image = ((System.Drawing.Image)(resources.GetObject("spherePhoto1.Image")));
            this.spherePhoto1.Location = new System.Drawing.Point(12, 12);
            this.spherePhoto1.Name = "spherePhoto1";
            this.spherePhoto1.Size = new System.Drawing.Size(150, 150);
            this.spherePhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spherePhoto1.TabIndex = 0;
            this.spherePhoto1.TabStop = false;
            // 
            // spherePhoto2
            // 
            this.spherePhoto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spherePhoto2.Image = ((System.Drawing.Image)(resources.GetObject("spherePhoto2.Image")));
            this.spherePhoto2.Location = new System.Drawing.Point(222, 199);
            this.spherePhoto2.Name = "spherePhoto2";
            this.spherePhoto2.Size = new System.Drawing.Size(150, 150);
            this.spherePhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spherePhoto2.TabIndex = 1;
            this.spherePhoto2.TabStop = false;
            // 
            // sphereLbl
            // 
            this.sphereLbl.AutoSize = true;
            this.sphereLbl.Location = new System.Drawing.Point(168, 76);
            this.sphereLbl.Name = "sphereLbl";
            this.sphereLbl.Size = new System.Drawing.Size(90, 13);
            this.sphereLbl.TabIndex = 2;
            this.sphereLbl.Text = "Radius of sphere:";
            // 
            // diameterLbl
            // 
            this.diameterLbl.AutoSize = true;
            this.diameterLbl.Location = new System.Drawing.Point(34, 187);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(49, 13);
            this.diameterLbl.TabIndex = 3;
            this.diameterLbl.Text = "Diameter";
            // 
            // surfaceLbl
            // 
            this.surfaceLbl.AutoSize = true;
            this.surfaceLbl.Location = new System.Drawing.Point(14, 238);
            this.surfaceLbl.Name = "surfaceLbl";
            this.surfaceLbl.Size = new System.Drawing.Size(69, 13);
            this.surfaceLbl.TabIndex = 4;
            this.surfaceLbl.Text = "Surface Area";
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(41, 289);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(42, 13);
            this.volumeLbl.TabIndex = 5;
            this.volumeLbl.Text = "Volume";
            // 
            // radiusTBox
            // 
            this.radiusTBox.Location = new System.Drawing.Point(265, 76);
            this.radiusTBox.Name = "radiusTBox";
            this.radiusTBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTBox.TabIndex = 6;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(280, 102);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            // 
            // calcDiameterLabel
            // 
            this.calcDiameterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcDiameterLabel.Location = new System.Drawing.Point(89, 187);
            this.calcDiameterLabel.Name = "calcDiameterLabel";
            this.calcDiameterLabel.Size = new System.Drawing.Size(100, 23);
            this.calcDiameterLabel.TabIndex = 8;
            this.calcDiameterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calcSurfaceLbl
            // 
            this.calcSurfaceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcSurfaceLbl.Location = new System.Drawing.Point(92, 238);
            this.calcSurfaceLbl.Name = "calcSurfaceLbl";
            this.calcSurfaceLbl.Size = new System.Drawing.Size(100, 23);
            this.calcSurfaceLbl.TabIndex = 9;
            this.calcSurfaceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calcVolumeLbl
            // 
            this.calcVolumeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcVolumeLbl.Location = new System.Drawing.Point(92, 288);
            this.calcVolumeLbl.Name = "calcVolumeLbl";
            this.calcVolumeLbl.Size = new System.Drawing.Size(100, 23);
            this.calcVolumeLbl.TabIndex = 10;
            this.calcVolumeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SphereApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.calcVolumeLbl);
            this.Controls.Add(this.calcSurfaceLbl);
            this.Controls.Add(this.calcDiameterLabel);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.radiusTBox);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.surfaceLbl);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.sphereLbl);
            this.Controls.Add(this.spherePhoto2);
            this.Controls.Add(this.spherePhoto1);
            this.Name = "SphereApp";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.spherePhoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spherePhoto2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spherePhoto1;
        private System.Windows.Forms.PictureBox spherePhoto2;
        private System.Windows.Forms.Label sphereLbl;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label surfaceLbl;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.TextBox radiusTBox;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label calcDiameterLabel;
        private System.Windows.Forms.Label calcSurfaceLbl;
        private System.Windows.Forms.Label calcVolumeLbl;
    }
}

