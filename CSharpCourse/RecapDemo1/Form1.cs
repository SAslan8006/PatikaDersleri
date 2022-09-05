using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DamaTahtasi();
        }

        private void DamaTahtasi()
        {
            Button[,] buttons = new Button[8, 8];
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = 50 * j;
                    buttons[i, j].Top = 50 * i;
                    this.Controls.Add(buttons[i, j]);
                    if ((i + j) % 2 == 0)
                        buttons[i, j].BackColor = Color.Black;
                }
            }
        }
    }
}
