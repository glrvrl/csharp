using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];

            int top = 0;
            int left = 0;
            for (int i = 0; i < 8; i++)
            {
                left = 0;
                for (int x = 0; x < 8; x++)
                {
                    buttons[i, x] = new Button { BackColor = (i + x) % 2 == 0 ? Color.Blue : Color.Red, Text = $"{i + 1}x{x + 1}", Width = 50, Height = 50, Top = top, Left = left};
                    buttons[i, x].Click += (s, EventArgs) => { int ii = i; int xx = x; MessageBox.Show($"{ii} x {xx}"); };
                    this.Controls.Add(buttons[i, x]);
                    left += 50;
                }
                top += 50;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show((Button) sender.);
        }
    }
}
