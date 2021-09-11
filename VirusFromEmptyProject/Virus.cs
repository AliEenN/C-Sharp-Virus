using System.Windows.Forms;

namespace VirusFromEmptyProject
{
    class Virus : Form
    {
        public Virus() : base()
        {
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(439, 220);
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.Name = "Virus";
            this.Opacity = 0D;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ResumeLayout(false);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Virus
            // 
            

        }
    }
}
