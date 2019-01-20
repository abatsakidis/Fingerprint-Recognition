namespace Fingerprint_Recognition_Project
{
    partial class frmFingerprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFingerprint));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btFingerprint1 = new System.Windows.Forms.Button();
            this.btFingerprint2 = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(237, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btFingerprint1
            // 
            this.btFingerprint1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFingerprint1.Location = new System.Drawing.Point(23, 247);
            this.btFingerprint1.Name = "btFingerprint1";
            this.btFingerprint1.Size = new System.Drawing.Size(117, 23);
            this.btFingerprint1.TabIndex = 2;
            this.btFingerprint1.Text = "Load Fingerprint";
            this.btFingerprint1.UseVisualStyleBackColor = true;
            this.btFingerprint1.Click += new System.EventHandler(this.btFingerprint1_Click);
            // 
            // btFingerprint2
            // 
            this.btFingerprint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFingerprint2.Location = new System.Drawing.Point(287, 247);
            this.btFingerprint2.Name = "btFingerprint2";
            this.btFingerprint2.Size = new System.Drawing.Size(119, 23);
            this.btFingerprint2.TabIndex = 3;
            this.btFingerprint2.Text = "Load Fingerprint";
            this.btFingerprint2.UseVisualStyleBackColor = true;
            this.btFingerprint2.Click += new System.EventHandler(this.btFingerprint2_Click);
            // 
            // btCheck
            // 
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheck.Location = new System.Drawing.Point(168, 247);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(96, 23);
            this.btCheck.TabIndex = 4;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // frmFingerprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 282);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btFingerprint2);
            this.Controls.Add(this.btFingerprint1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFingerprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fingerprint Recognition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFingerprint_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btFingerprint1;
        private System.Windows.Forms.Button btFingerprint2;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

