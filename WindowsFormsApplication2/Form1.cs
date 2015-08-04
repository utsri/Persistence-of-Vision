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
            
            
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            
                richTextBox1.Text = "#include<avr/io.h>\n#include<util/delay.h>\nint main(void)\n{\n\tDDRB=0b00000111;\n\twhile(1)\n\t{\n\t\tPORTC=0b00000100;\n\t\t_delay_ms(5000);\n\t}\n}";
               
                if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
                
                    richTextBox1.Text = "#include<avr/io.h>\n#include<util/delay.h>\nint main(void)\n{\n\tDDRB=0b00000111;\n\twhile(1)\n\t{\n\t\tPORTC=0b00000101;\n\t\t_delay_ms(5000);\n\t}\n}";
                    
                
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
                    richTextBox1.Text = "#include<avr/io.h>\n#include<util/delay.h>\nint main(void)\n{\n\tDDRB=0b00000111;\n\twhile(1)\n\t{\n\t\tPORTC=0b00000110;\n\t\t_delay_ms(5000);\n\t}\n}";
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                    richTextBox1.Text = "#include<avr/io.h>\n#include<util/delay.h>\nint main(void)\n{\n\tDDRB=0b00000111;\n\twhile(1)\n\t{\n\t\tPORTC=0b00000111;\n\t\t_delay_ms(5000);\n\t}\n}";
                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                    richTextBox1.Text = "#include<avr/io.h>\n#include<util/delay.h>\nint main(void)\n{\n\tDDRB=0b00000111;\n\twhile(1)\n\t{\n\t\tPORTC=0b00000000;\n\t\t_delay_ms(5000);\n\t}\n}";
                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
                    richTextBox1.Text = "#include<avr/io.h>\n#include<util/delay.h>\nint main(void)\n{\n\tDDRB=0b00000111;\n\twhile(1)\n\t{\n\t\tPORTC=0b00000001;\n\t\t_delay_ms(5000);\n\t}\n}";
                if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
                    richTextBox1.Text = "#include<avr/io.h>\n#include<util/delay.h>\nint main(void)\n{\n\tDDRB=0b00000111;\n\twhile(1)\n\t{\n\t\tPORTC=0b00000010;\n\t\t_delay_ms(5000);\n\t}\n}";
                if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
                    richTextBox1.Text = "#include<avr/io.h>\n#include<util/delay.h>\nint main(void)\n{\n\tDDRB=0b00000111;\n\twhile(1)\n\t{\n\t\tPORTC=0b00000011;\n\t\t_delay_ms(5000);\n\t}\n}";



            }
        }
    }

