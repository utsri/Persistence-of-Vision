using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str = "PORTB=0b";
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
           // str = str + ";\n\t\t_delay_ms("+textBox2.Text+");\n\t}\n}";
            //richTextBox1.Text = str;
            s = str;
            MessageBox.Show("GENERATED");
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
            //.SaveFile(@"C:\atmel\atmel.txt", RichTextBoxStreamType.PlainText);

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // richTextBox1.LoadFile(@"C:\atmel\atmel.txt", RichTextBoxStreamType.PlainText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhos;port=306;username=roo;password=Mahanagard70";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("selct *database.code;", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                //richTextBox1.Text = "CONNECTED";
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=mukabhisrk";
            string query = "insert into code.codedata(port,delay) values('" + this.s + "','" + this.textBox2.Text + "');";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("SAVED");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=mukabhisrk";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from code.codedata ;" ,conDataBase);
            try
            {
                MySqlDataAdapter sda=new MySqlDataAdapter();
                sda.SelectCommand=cmdDataBase;
                DataTable dbdataset=new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource=new BindingSource();
                bSource.DataSource=dbdataset;
                dataGridView1.DataSource=bSource;
                sda.Update(dbdataset);
                MessageBox.Show("LOADED");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
      

       
        }
    }

