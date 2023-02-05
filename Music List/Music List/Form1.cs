using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_List
{
    public partial class Form1 : Form
    {
        public class music
        {
            public int time;
            public string name;
            public music after;
            public music before;
        }
        music first = null;
        music end = null;
        music pass = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void print(music first)
        {
            richTextBox1.Text = null;
            while (first != null)
            {
                richTextBox1.Text += first.name + " : " + first.time.ToString();
                richTextBox1.Text += " , ";
                first = first.after;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            print(first);
        }
        private void buttonAddBeginning_Click(object sender, EventArgs e)
        {
            music newly = new music();
            newly.time = Convert.ToInt32(textBox2.Text);
            newly.name = textBox1.Text;
            if (first==null)
            {
                first = newly;
                end = first;
                first.before = null;
                end.after = null;
            }
            else
            {
                first.before = newly;
                newly.after = first;
                first = newly;
            }
        }

        private void buttonAddEnd_Click(object sender, EventArgs e)
        {
            music newly = new music();
            newly.time = Convert.ToInt32(textBox2.Text);
            newly.name = textBox1.Text;
            if (first == null)
            {
                first = newly;
                end = first;
                first.before = null;
                end.after = null;
            }
            else
            {
                end.after = newly;
                newly.before = end;
                end = newly;
                end.after = null;
            }
        }

        private void buttonAddMiddle_Click(object sender, EventArgs e)
        {
            music newly = new music();
            newly.time = Convert.ToInt32(textBox2.Text);
            newly.name = textBox1.Text;
            if (first == null)
            {
                first = newly;
                end = first;
                first.before = null;
                end.after = null;
            }
            else
            {
                pass = first;
                pass.after.before = newly;
                newly.after = pass.after;
                pass.after = newly;
                newly.before = pass;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (first==null)
            {
                MessageBox.Show("Silinecek değer bulunmamaktadır, tekrar deneyiniz");
            }
            else
            {
                first = first.after;
                first.before = null;
            }
        }

        private void buttonDeleteEnd_Click(object sender, EventArgs e)
        {
            if (first == null)
            {
                MessageBox.Show("Silinecek değer bulunmamaktadır, tekrar deneyiniz");
            }
            else
            {
                end = end.before;
                end.after = null;
            }
        }

        private void buttonDeleteMiddle_Click(object sender, EventArgs e)
        {
            music pass = new music();
            if (first == null)
            {
                MessageBox.Show("Silinecek değer bulunmamaktadır, tekrar deneyiniz");
            }
            else
            {
                pass = first.after;
                pass.before.after = pass.after;
                pass.after.before = pass.before;
            }
        }
    }
}

