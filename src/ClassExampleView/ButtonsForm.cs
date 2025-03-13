using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExample
{
    /// <summary>
    /// Form for dynamic buttons generation.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ButtonsForm : Form
    {
        private int XPos = 0;
        private int YPos = 0;
        private int buttonCounter = 0;

        public ButtonsForm()
        {
            InitializeComponent();
        }

        private void InitializeDynamicControls()
        {
            this.SuspendLayout();
            this.XPos = 0;
            for (var i = buttonCounter; i < (buttonCounter + 10); i++)
            {
                var button = new Button();
                button.Text = $"Button {i}";
                button.Location = new Point(XPos, YPos);
                button.Size = new Size(100, 50);
                button.Click += Button_Click;
                this.Controls.Add(button);
                XPos += 100;
            }

            buttonCounter += 10;

            this.ResumeLayout();
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            var button = sender as Button;
            MessageBox.Show($"Button clicked on number {button?.Text}");
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            var controlsToRemove = new List<Control>();
            foreach (Control element in this.Controls)
            {
                if (element is Button && element.Name != this.btn_Next.Name)
                {
                    controlsToRemove.Add(element);
                }
            }

            foreach (Control control in controlsToRemove)
            {
                control.Dispose();
            }

            InitializeDynamicControls();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            InitializeDynamicControls();
        }
    }
}
