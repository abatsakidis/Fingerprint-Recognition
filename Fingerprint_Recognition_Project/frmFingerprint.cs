using System;
using System.Drawing;
using System.Windows.Forms;
using PatternRecognition.FingerprintRecognition.Core;
using PatternRecognition.FingerprintRecognition.FeatureExtractors;
using PatternRecognition.FingerprintRecognition.Matchers;

namespace Fingerprint_Recognition_Project
{
    public partial class frmFingerprint : Form
    {
     
        public frmFingerprint()
        {
            InitializeComponent();
        }

        public string score;
        public string qry;
        public string temp;

        private Bitmap Change_Resolution(string file)
        {
            using (Bitmap bitmap = (Bitmap)Image.FromFile(file))
            {
                using (Bitmap newBitmap = new Bitmap(bitmap))
                {
                    newBitmap.SetResolution(500,500);
                    return newBitmap;
                }
            }
        }

       private void match(string query, string template)
        {
            Change_Resolution(query);
            Change_Resolution(template);

            var fingerprintImg1 = ImageLoader.LoadImage(query);
            var fingerprintImg2 = ImageLoader.LoadImage(template);

            var featExtractor = new PNFeatureExtractor() { MtiaExtractor = new Ratha1995MinutiaeExtractor() };
            var features1 = featExtractor.ExtractFeatures(fingerprintImg1);
            var features2 = featExtractor.ExtractFeatures(fingerprintImg2);

            var matcher = new PN();
            double similarity = matcher.Match(features1, features2);
            score = similarity.ToString("0.000");
            MessageBox.Show("Similarity " + similarity.ToString("0.000"), "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmFingerprint_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btFingerprint1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = openFileDialog1.FileName;
                qry = fileName;
                pictureBox1.ImageLocation = qry;

            }
        }

        private void btFingerprint2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = openFileDialog2.FileName;
                temp = fileName;
                pictureBox2.ImageLocation = temp;
            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && pictureBox2.Image != null)
            {
                match(qry, temp);
            }
            else
            {
                MessageBox.Show("Please choose two fingerprints!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
