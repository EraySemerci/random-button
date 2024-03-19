using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class kremit : Form
    {
        public kremit()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int satir = 1, sayac = 0, sbx = 9/*sonraki buton x */, sby = 12/*sonraki buton y */;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            sayac = 0;
            panel1.Controls.Clear();
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Width = rnd.Next(15, 100);
            if (sbx + btn.Width >= 598)
            {
                btn.Width = 598 - sbx;
            }
            if (satir == 24)
            {
                timer1.Stop();
                button1.Text = "Yeniden";
                button1.Enabled = true;
                satir = 1;
                sbx = 9;
                sby = 12;
            }
            btn.Height = 27;
            if (sayac == 0)
            {
                btn.Location = new Point(12, 12);
            }
            else
            {
                btn.Location = new Point(sbx, sby);
            }
            btn.BackColor = Color.FromArgb(rnd.Next(0, 255), 0, 0);
            if (satir != 24)
            {
                panel1.Controls.Add(btn);
            }
            sayac++;
            if (sbx + btn.Width >= 598)
            {
                sby = sby + 26;
                satir++;
                sbx = 12;
            }
            else
            {
                sbx = btn.Width + btn.Location.X;
            }
            label1.Text = sayac + " kremit";
           
        }
    }
}
