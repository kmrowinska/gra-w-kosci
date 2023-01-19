using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosci
{
    public partial class Form1 : Form
    {
        int val_2;
        int val_4;
        int val_6;
        int val_8;
        int val_10;
        int val_12;
        int val_20;
        int val_100;
        Random random= new Random();
        

        public Form1()
        {
            InitializeComponent();
            label10.Visible= false;
            label11.Visible=false;
            label12.Visible=false;
            label13.Visible=false;
            label14.Visible=false;
            label15.Visible=false;
            label16.Visible=false;
            label17.Visible=false;
        }

        /*rzuć*/
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder v2 = new StringBuilder();
            StringBuilder v4 = new StringBuilder();
            StringBuilder v6 = new StringBuilder();
            StringBuilder v8 = new StringBuilder();
            StringBuilder v10 = new StringBuilder();
            StringBuilder v12 = new StringBuilder();
            StringBuilder v20 = new StringBuilder();
            StringBuilder v100 = new StringBuilder();


            for (int i = 0; i < val_2; i++)
            {
                int r2 = random.Next(1, 3);
                v2.Append(r2 + ",");
            }

            for (int i = 0; i < val_4; i++)
            {
                int r4 = random.Next(1, 5);
                v4.Append(r4 + ",");
            }

            for (int i = 0; i < val_6; i++)
            {
                int r6 = random.Next(1, 5);
                v6.Append(r6 + ",");
            }


            for (int i = 0; i < val_8; i++)
            {
                int r8 = random.Next(1, 9);
                v8.Append(r8 + ",");
            }

            for (int i = 0; i < val_10; i++)
            {
                int r10 = random.Next(1, 11);
                v10.Append(r10 + ",");
            }

            for (int i = 0; i < val_12; i++)
            {
                int r12 = random.Next(1, 13);
                v12.Append(r12 + ",");
            }

            for (int i = 0; i < val_20; i++)
            {
                int r20 = random.Next(1, 21);
                v20.Append(r20 + ",");
            }

            for (int i = 0; i < val_100; i++)
            {
                int r100 = random.Next(1, 101);
                v100.Append(r100 + ",");
            }

            label10.Text = v2.ToString();
            label11.Text = v4.ToString();
            label12.Text = v6.ToString();
            label13.Text = v8.ToString();
            label14.Text = v10.ToString();
            label15.Text = v12.ToString();
            label16.Text = v20.ToString();
            label17.Text = v100.ToString();

            label10.Visible= true;
            label11.Visible= true;
            label12.Visible= true;
            label13.Visible= true;
            label14.Visible= true;
            label15.Visible= true;
            label16.Visible= true;
            label17.Visible= true;





        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            val_2 = (int)num.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            val_4 = (int)num.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            val_6 = (int)num.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            val_8 = (int)num.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            val_10 = (int)num.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            val_12 = (int)num.Value;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            val_20 = (int)num.Value;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            val_100 = (int)num.Value;
        }
    }
}
