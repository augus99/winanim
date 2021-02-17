using System;
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
            this.ClientSize = new Size(287, 139);
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

            // Blend
            this.AddButton("Blend in/out", () => {
                this.AnimateBlend(1000, WindowAnimatorMode.Hide);
                this.AnimateBlend(1000, WindowAnimatorMode.Show);
            });

            // Horizontal
            this.AddButton("Horizontal in/out", () => {
                this.AnimateHorizontal(1000, WindowAnimatorMode.Hide);
                this.AnimateHorizontal(1000, WindowAnimatorMode.Show);
            });

            // Vertical
            this.AddButton("Vertical in/out", () => {
                this.AnimateVertical(1000, WindowAnimatorMode.Hide);
                this.AnimateVertical(1000, WindowAnimatorMode.Show);
            });

            this.ResumeLayout(false);
        }

        private void AddButton(string text, Action callback) {
            this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height + 40);
            
            Button btn = new Button() {
                Text = text,
                Location = new Point(40, this.ClientSize.Height - 80),
                Size = new Size(this.Width - 80, 30),
                BackColor = Color.FromArgb(31, 31, 255),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                UseVisualStyleBackColor = true,
                FlatAppearance = { BorderSize = 0 },
                Cursor = Cursors.Hand
            };

            btn.Click += (sender, args) => {
                callback();
            };

            this.Controls.Add(btn);
        }
    }
}