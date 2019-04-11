using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krestiki
{
    public partial class Form1 : Form
    {
        int cout;
        bool gameStart;
        bool xxx = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;
            if (xxx)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xxx = !xxx;
            senderB.Enabled = false;
            gameStart = true;
            CheckWin(senderB);
        }
        void CheckWin(Button pressedButton)
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button2.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                Application.Restart();
            }

            if (button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                Application.Restart();
            }

            if (button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                Application.Restart();
            }

            if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                Application.Restart();
            }

            if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                Application.Restart();
            }

            if (button3.Text == button6.Text && button6.Text == button9.Text && button6.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                Application.Restart();
            }

            if (button1.Text == button5.Text && button5.Text == button9.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                Application.Restart();
            }

            if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                Application.Restart();
            }
        }

        private void выйтиИзИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                xxx = true;
            }
            
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                xxx = false;
            }
            
        }

        
    }
}
