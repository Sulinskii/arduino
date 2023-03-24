using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace ArduinoForm
{
    public partial class Form1 : Form
    {
        int v1 = 0;
        int v2 = 0;
        int v3 = 0;
        int v4 = 0;

        string port = "";

        public Form1()
        {
            InitializeComponent();
            //port = autodetectArduinoPort();
            serialPort1.Open();
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            string textBox1Text = "v1" + textBox1.Text;
            string textBox2Text = "v2" + textBox2.Text;
            string textBox3Text = "v3" + textBox3.Text;
            string textBox4Text = "v4" + textBox4.Text;

            try
            {
                v1 = Int32.Parse(textBox1.Text);
                v2 = Int32.Parse(textBox2.Text);
                v3 = Int32.Parse(textBox3.Text);
                v4 = Int32.Parse(textBox4.Text);
            }
            catch
            {
                displayErrorAlert("Podane wartości nie są liczbami");
                return;
            }

            if (!validate(v1) || !validate(v2) || !validate(v3) || !validate(v4))
            {
                displayErrorAlert("Podane wartości muszą znajdować się w przedziale od 0 do 190");
            }

            serialPort1.Write(textBox1Text);
            serialPort1.Write(textBox2Text);
            serialPort1.Write(textBox3Text);
            serialPort1.Write(textBox4Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayErrorAlert(string message)
        {
            string title = "Błąd";
            MessageBox.Show(message, title);
        }

        private bool validate(int value)
        {
            return value >= 0 && value <= 190;
        }

        private void v1PlusButton_Click(object sender, EventArgs e)
        {
            v1 += 5;
            String v1String = "v1" + v1.ToString();
            serialPort1.Write(v1String);
        }

        private void v2PlusButton_Click(object sender, EventArgs e)
        {
            v2 += 5;
            String v2String = "v2" + v2.ToString();
            serialPort1.Write(v2String);
        }

        private void v3PlusButton_Click(object sender, EventArgs e)
        {
            v3 += 5;
            String v3String = "v3" + v3.ToString();
            serialPort1.Write(v3String);
        }

        private void v4PlusButton_Click(object sender, EventArgs e)
        {
            v4 += 5;
            String v4String = "v4" + v4.ToString();
            serialPort1.Write(v4String);
        }


        private void v1OffButton_Click(object sender, EventArgs e)
        {
            v1 = 0;
            String v1String = "v1" + v1.ToString();
            serialPort1.Write(v1String);
        }

        private void v2OffButton_Click(object sender, EventArgs e)
        {
            v2 = 0;
            String v2String = "v2" + v2.ToString();
            serialPort1.Write(v2String);
        }

        private void v3OffButton_Click(object sender, EventArgs e)
        {
            v3 = 0;
            String v3String = "v3" + v3.ToString();
            serialPort1.Write(v3String);
        }

        private void v4OffButton_Click(object sender, EventArgs e)
        {
            v4 = 0;
            String v4String = "v4" + v4.ToString();
            serialPort1.Write(v4String);

           
        }

        private string autodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();
                    Console.WriteLine("PORT DESC:" + desc);
                    Console.WriteLine("PORT DEVICE ID:" + deviceId);
                    if (desc.Contains("USB-SERIAL")) 
                    {
                        return deviceId;
                    }
                }
            }
            catch (ManagementException e)
            {
                /* Do Nothing */
            }

            return null;
        }
    }
}
