using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "#include<avr/io.h>\n#include<util/delay.h>\nint main(void)\n{\n\tDDRB=0b11111111;\n\twhile(1)\n\t{\n\t\tPORTB=0b";
            if (checkBox1.Checked == true)
                str += "1";
            if (checkBox1.Checked == false)
                str += "0";
            if (checkBox2.Checked == true)
                str += "1";
            if (checkBox2.Checked == false)
                str += "0";
            if (checkBox3.Checked == true)
                str += "1";
            if (checkBox3.Checked == false)
                str += "0";
            if (checkBox4.Checked == true)
                str += "1";
            if (checkBox4.Checked == false)
                str += "0";
            if (checkBox5.Checked == true)
                str += "1";
            if (checkBox5.Checked == false)
                str += "0";
            if (checkBox6.Checked == true)
                str += "1";
            if (checkBox6.Checked == false)
                str += "0";
            if (checkBox7.Checked == true)
                str += "1";
            if (checkBox7.Checked == false)
                str += "0";
            if (checkBox8.Checked == true)
                str += "1";
            if (checkBox8.Checked == false)
                str += "0";
            str = str + ";\n\t\t_delay_ms("+textBox2.Text+");\n\t}\n}";
            richTextBox1.Text = str;
            }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            string mytooltip;
            mytooltip = toolTip1.GetToolTip(checkBox1);
            toolTip1.SetToolTip(checkBox1, "LED 1 is on");
        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {
            string s;
            s = toolTip1.GetToolTip(button1);
            toolTip1.SetToolTip(button1,"Click to generate code");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:\atmel\atmel.txt", RichTextBoxStreamType.PlainText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:\atmel\atmel.txt", RichTextBoxStreamType.PlainText);
        }

      
      

       
        }
    }

