using System.Drawing;
using System.Windows.Forms;

namespace Winanim {
    /// <summary>
    /// Main window that contains all buttons
    /// </summary>
    public class MainWindow: Form {
        public MainWindow() {
            this.SuspendLayout();

            // Setup form
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(287, 405);
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(31, 31, 31);
            this.Name = "AnimateWindowForm";
            this.Text = "Animated Window";

            this.ResumeLayout(false);
        }
    }
}