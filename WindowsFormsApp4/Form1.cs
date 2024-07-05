using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            button1.Visible = false;
            chart1.Visible = false;
            

        }
        public string getPath() //вернуть путь для фото
        {
            string path = Environment.CurrentDirectory;
            string[] words = path.Split(new char[] { '\\' });
            var result = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                result.Append(words[i] + "/");
            }
            result.Append("images");

            return result.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            if (selectedState == "Ti-46")
            {
                pictureBox1.Image = Image.FromFile($"{getPath()}/Ti-46.png"); 
            }
            if (selectedState == "Ti-47")
            {
                pictureBox1.Image = Image.FromFile($"{getPath()}/Ti-47.png");
            }
            if (selectedState == "Ti-48")
            {
                pictureBox1.Image = Image.FromFile($"{getPath()}/Ti-48.png");
            }
            if (selectedState == "Ti-49")
            {
                pictureBox1.Image = Image.FromFile($"{getPath()}/Ti-49.png");
            }
            if (selectedState == "Ti-50")
            {
                pictureBox1.Image = Image.FromFile($"{getPath()}/Ti-50.png");
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            string selectedState1 = comboBox2.SelectedItem.ToString();
            if (selectedState == "Ti-46" && selectedState1 == "(n,2n)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/2Ti-46.png");
                button1.Visible = true;
            }
            if (selectedState == "Ti-47" && selectedState1 == "(n,2n)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/2Ti-47.png");
                button1.Visible = true;
            }
            if (selectedState == "Ti-48" && selectedState1 == "(n,2n)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/2Ti-48.png"); ;
                button1.Visible = true;
            }
            if (selectedState == "Ti-49" && selectedState1 == "(n,2n)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/2Ti-49.png");
                button1.Visible = true;
            }
            if (selectedState == "Ti-50" && selectedState1 == "(n,2n)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/2Ti-50.png");
                button1.Visible = true;
            }
            if (selectedState == "Ti-46" && selectedState1 == "(n,y)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/yTi-46.png");
                button1.Visible = true;
            }
            if (selectedState == "Ti-47" && selectedState1 == "(n,y)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/yTi-47.png");
                button1.Visible = true;
            }
            if (selectedState == "Ti-48" && selectedState1 == "(n,y)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/yTi-48.png");
                button1.Visible = true;
            }
            if (selectedState == "Ti-49" && selectedState1 == "(n,y)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/yTi-49.png");
                button1.Visible = true;
            }
            if (selectedState == "Ti-50" && selectedState1 == "(n,y)")
            {
                pictureBox2.Image = Image.FromFile($"{getPath()}/yTi-50.png");
                button1.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            string selectedState1 = comboBox2.SelectedItem.ToString();
            string title = "Скорости";
            chart1.Visible = true;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[1].Points.Clear();
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            double t1 = Math.Pow(10, -14);
            double t2 = Math.Pow(10, -6);
            double k1 = 3.19 * t1;
            double k2 = 4.41 * t2;
            if (selectedState == "Ti-46" && selectedState1 == "(n,2n)")
            {
                t1 = Math.Pow(10, 0);
                t2 = Math.Pow(10, -6);
                k1 = 0 * t1;
                k2 = 4.41 * t2;
                MessageBox.Show(k1+ Environment.NewLine + k2,title);
            }
            if (selectedState == "Ti-47" && selectedState1 == "(n,2n)")
            {
                t1 = Math.Pow(10, -13);
                t2 = Math.Pow(10, -11);
                k1 = 2.46 * t1;
                k2 = 6.02 * t2;
                MessageBox.Show(k1 + Environment.NewLine + k2, title);
            }
            if (selectedState == "Ti-48" && selectedState1 == "(n,2n)")
            {
                t1 = Math.Pow(10, 0);
                t2 = Math.Pow(10, -13);
                k1 = 0 * t1;
                k2 = 1.72 * t2;
                MessageBox.Show(k1 + Environment.NewLine + k2, title);
            }
            if (selectedState == "Ti-49" && selectedState1 == "(n,2n)")
            {
                t1 = Math.Pow(10, -13);
                t2 = Math.Pow(10, -11);
                k1 = 7.62* t1;
                k2 = 2.88 * t2;
                MessageBox.Show(k1 + Environment.NewLine + k2, title);
            }
            if (selectedState == "Ti-50" && selectedState1 == "(n,2n)")
            {
                t1 = Math.Pow(10, 0);
                t2 = Math.Pow(10, -15);
                k1 = 0 * t1;
                k2 = 4.89 * t2;
                MessageBox.Show(k1 + Environment.NewLine + k2, title);
            }
            if (selectedState == "Ti-46" && selectedState1 == "(n,y)")
            {
                t2 = Math.Pow(10, -13);
                t1 = Math.Pow(10, -11);
                k2 = 2.46 * t2;
                k1 = 6.02 * t1;
                MessageBox.Show(k1 + Environment.NewLine + k2, title);
            }
            if (selectedState == "Ti-47" && selectedState1 == "(n,y)")
            {
                t2 = Math.Pow(10, 0);
                t1 = Math.Pow(10, -13);
                k2 = 0 * t2;
                k1 = 1.72 * t1;
                MessageBox.Show(k1 + Environment.NewLine + k2, title);
            }
            if (selectedState == "Ti-48" && selectedState1 == "(n,y)")
            {
                t2 = Math.Pow(10, -13);
                t1 = Math.Pow(10, -11);
                k2 = 7.62 * t2;
                k1 = 2.88 * t1;
                MessageBox.Show(k1 + Environment.NewLine + k2, title);
            }
            if (selectedState == "Ti-49" && selectedState1 == "(n,y)")
            {
                t2 = Math.Pow(10, 0);
                t1 = Math.Pow(10, -14);
                k2 = 0 * t2;
                k1 = 4.89 * t1;
                MessageBox.Show(k1 + Environment.NewLine + k2, title);
            }
            if (selectedState == "Ti-50" && selectedState1 == "(n,y)")
            {
                t2 = Math.Pow(10, 0);
                t1 = Math.Pow(10, -12);
                k2 = 0 * t2;
                k1 = 6.51 * t1;
                MessageBox.Show(k1 + Environment.NewLine + k2, title);
            }
            double t = 1;
            double x = 0;
            double y = 1000000;
            double kr;
            double l;
            chart1.Series[0].Points.AddXY(x, y);
            chart1.Series[1].Points.AddXY(x, 0);
            for (int i = 0; i < 10; i++)
            {
                kr = ((y * k1) / (k1 + k2)) + ((y * k2) / (k1 + k2)) * Math.Exp((-(k1 + k2)) * (t * 24 * 60 * 60));
                x++;
                l = y - kr;
                chart1.Series[0].Points.AddXY(x, kr);
                chart1.Series[1].Points.AddXY(x, l);
                t++;
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
