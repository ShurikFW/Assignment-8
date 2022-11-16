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

namespace assignment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                StreamReader boys;
                StreamReader girls;
                string girlNames;
                string boyNames;
                boys = File.OpenText("boys.txt");
                List<string> boyNameList = new List<string>();
                girls = File.OpenText("girls.txt");
                List<string> girlNameList = new List<string>();
                boyNames = textBox1.Text;
                girlNames = textBox2.Text;
                while (!boys.EndOfStream)
                {
                    boyNameList.Add(boys.ReadLine());

                }
                while (!girls.EndOfStream)
                {
                    girlNameList.Add(girls.ReadLine());

                }
                int boysPosition = boyNameList.IndexOf(boyNames);
                int girlsPosition = girlNameList.IndexOf(girlNames);

                if (boysPosition != -1)
                {
                    MessageBox.Show("The boy name you entered is one of the most popular names.");

                }

                if (girlsPosition != -1)
                {
                    MessageBox.Show("The girl name you entered is one of the most popular names.");

                }
                

                if (boysPosition != -1 && girlsPosition != -1)
                {
                    MessageBox.Show("The name you entered was found on both the boys and girls name lists!");
                }
                

                else if (boysPosition == -1)
                {
                    MessageBox.Show("The boy name you have entered is NOT one of the most popular names.");

                }

                else if (girlsPosition == -1)
                {
                    MessageBox.Show("The girl name you have entered is NOT one of the most popular names.");

                }
            }
         
            catch (Exception ex)
            {
            
            MessageBox.Show(ex.Message);

            } 

 
        }
    }
}
