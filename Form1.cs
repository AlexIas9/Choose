using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("Masina");
            listBox1.Items.Add("Motocicleta");
            listBox1.Items.Add("Avioan");
            listBox1.Items.Add("Elicopter");
            listBox1.Items.Add("Oras");
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = listBox1.SelectedItem?.ToString();
            if (selectedName != null)
            {
               
                switch (selectedName)
                {
                    case "Masina":
                        pictureBox1.Image = imageList1.Images[0];
                        break;
                    case "Motocicleta":
                        pictureBox1.Image = imageList1.Images[1];
                        break;
                    case "Avioan":
                        pictureBox1.Image = imageList1.Images[2];
                        break;
                    case "Elicopter":
                        pictureBox1.Image = imageList1.Images[3];
                        break;
                    case "Oras":
                        pictureBox1.Image = imageList1.Images[4];
                        break;
                    default:
                        pictureBox1.Image = null;
                        break;
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string resultGroup2 = groupBox2.Text;
                MessageBox.Show(resultGroup2);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string resultGroup1 = groupBox1.Text;
                MessageBox.Show(resultGroup1);
            }
        }
    }
}

