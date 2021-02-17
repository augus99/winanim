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
            this.Name = "Winanim";
            this.Text = "Winanim";

            // Title
            this.Controls.Add(new Label() {
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 13.25f),
                Location = new Point(0, 0),
                Size = new Size(this.Width, 99),
                Text = "Winanim",
                TabIndex = 5,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            });

            this.ResumeLayout(false);
        }
    }
}