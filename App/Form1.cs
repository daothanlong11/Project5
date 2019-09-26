using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;





namespace App
{
    public partial class Form1 : Form
    {

        static string path1 = @"C:\\Users\\L\\source\\repos\\Project5\\control\\start\\start";
        static string path2 = @"C:\\Users\\L\\source\\repos\\Project5\\control\\close\\close";
        static string path3 = @"C:\\Users\\L\\source\\repos\\Project5\\control\\state\\state";
        static string path4 = @"C:\\Users\\L\\source\\repos\\Project5\\control\\manual\\manual";
        static string path5 = @"C:\\Users\\L\\source\\repos\\Project5\\control\\auto\\auto";
        static string duoi = ".txt";
        int i1 = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number3 = i3.ToString();
            string diachi3 = path3 + number3 + duoi;
            File.CreateText(diachi3);
            //pictureBox1.Image = Image.FromFile(@"E:\\picture\\robot_icon.png");
            string line1;
            string line2;            
            // Read the file and display it line by line. 
            var delay = Task.Delay(300);
            delay.Wait();
            System.IO.StreamReader file1 = new System.IO.StreamReader(@"C:\\Users\\L\\source\\repos\\Project6\\Project6\\distance1.txt");
            System.IO.StreamReader file2 = new System.IO.StreamReader(@"C:\\Users\\L\\source\\repos\\Project6\\Project6\\distance2.txt");
            line1 = file1.ReadLine();
            line2 = file2.ReadLine();
            textBox1.Text = line1;
            textBox3.Text = line2;
            file1.Close();
            file2.Close();
            i3++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string number1 = i1.ToString();
            string diachi1 = path1 + number1 + duoi; ;
            File.CreateText(diachi1);
            i1++;
            //File.Delete(path1);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            string number2 = i2.ToString();
            string diachi2 = path2 + number2 + duoi;
            File.CreateText(diachi2);
            i2++;

            //File.Delete(path1);
            //File.Delete(path2);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var delay = Task.Delay(3000);
            delay.Wait();
            textBox2.Text = "READY TO START!!!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var delay = Task.Delay(2000);
            //delay.Wait();
            //textBox2.Text = "READY TO START!!!";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            string number4 = i4.ToString();
            string diachi4 = path4 + number4 + duoi;
            File.CreateText(diachi4);
            textBox4.Text = "MANUAL";
            i4++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            string number5 = i5.ToString();
            string diachi5 = path5 + number5 + duoi;
            File.CreateText(diachi5);
            textBox4.Text = "AUTO";
            i5++;
        }
    }
}
