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
using System.IO.Ports;

namespace ArduinoForm
{
    public partial class Form1 : Form
    {
        int v1 = 0;
        int v2 = 0;
        int v3 = 0;
        int v4 = 0;

        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        Pen blackPen = new Pen(Color.Black, 2);

        Graphics graphics;
        Graphics graphics2;
        Graphics graphics3;
        Graphics graphics4;

        string selectedPort = "";
        string[] ports = new string[0];

        public Form1()
        { 
            InitializeComponent();

            graphics = panel1.CreateGraphics();
            graphics2 = panel1.CreateGraphics();
            graphics3 = panel1.CreateGraphics();
            graphics4 = panel1.CreateGraphics();

            addPortsToList();
            enterTextboxesInitialValues();
        }

        private void onButton_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == false)
            {
                displayAlert("Błąd", "Przed wysłaniem wartości wybierz port");
                return;
            }

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
                displayAlert("Błąd", "Podane wartości nie są liczbami");
                return;
            }

            if (!validate(v1) || !validate(v2) || !validate(v3) || !validate(v4))
            {
                displayAlert("Błąd", "Podane wartości muszą znajdować się w przedziale od 0 do 190");
                return;
            }

            serialPort1.Write(textBox1Text);
            serialPort1.Write(textBox2Text);
            serialPort1.Write(textBox3Text);
            serialPort1.Write(textBox4Text);

            disposeAllGraphics();
            drawAllGraphics();
        }

        private void drawAllGraphics()
        {
            if (v1 > 0)
            {
                drawGraphics(greenBrush, graphics, 5);
            }
            else
            {
                drawGraphics(redBrush, graphics, 5);
            }

            if (v2 > 0)
            {
                drawGraphics(greenBrush, graphics2, 69);
            }
            else
            {
                drawGraphics(redBrush, graphics2, 69);
            }

            if (v3 > 0)
            {
                drawGraphics(greenBrush, graphics3, 134);
            }
            else
            {
                drawGraphics(redBrush, graphics3, 134);
            }

            if (v4 > 0)
            {
                drawGraphics(greenBrush, graphics4, 191);
            }
            else
            {
                drawGraphics(redBrush, graphics4, 191);
            }
        }

        private void displayAlert(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        private bool validate(int value)
        {
            return value >= 0 && value <= 190;
        }

        private void v1PlusButton_Click(object sender, EventArgs e)
        {
            if (v1 <= 185)
            {
                v1 += 5;
                String v1String = "v1" + v1.ToString();
                textBox1.Text = v1.ToString();
            }
        }

        private void v2PlusButton_Click(object sender, EventArgs e)
        {
            if (v2 <= 185)
            {
                v2 += 5;
                String v2String = "v2" + v2.ToString();
                textBox2.Text = v2.ToString();
            }
        }

        private void v3PlusButton_Click(object sender, EventArgs e)
        {
            if (v3 <= 185)
            {
                v3 += 5;
                String v3String = "v3" + v3.ToString();
                textBox3.Text = v3.ToString();
            }
        }

        private void v4PlusButton_Click(object sender, EventArgs e)
        {
            if (v4 <= 185)
            {
                v4 += 5;
                String v4String = "v4" + v4.ToString();
                textBox4.Text = v4.ToString();
            }
        }

        private void v1MinusButton_Click(object sender, EventArgs e)
        {
            if (v1 >= 5)
            {
                v1 -= 5;
                String v1String = "v1" + v1.ToString();
                textBox1.Text = v1.ToString();
            }
        }

        private void v2MinusButton_Click(object sender, EventArgs e)
        {
            if (v2 >= 5)
            {
                v2 -= 5;
                String v2String = "v2" + v2.ToString();
                textBox2.Text = v2.ToString();
            }
        }

        private void v3MinusButton_Click(object sender, EventArgs e)
        {
            if (v3 >= 5)
            {
                v3 -= 5;
                String v3String = "v3" + v3.ToString();
                textBox3.Text = v3.ToString();
            }
        }

        private void v4MinusButton_Click(object sender, EventArgs e)
        {
            if (v4 >= 5)
            {
                v4 -= 5;
                String v4String = "v4" + v4.ToString();
                textBox4.Text = v4.ToString();
            }
        }

        private void v1OffButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                displayAlert("Błąd", "Przed wysłaniem wartości wybierz port");
                return;
            }

            graphics.Dispose();
            drawGraphics(redBrush, graphics, 5);

            v1 = 0;
            String v1String = "v1" + v1.ToString();
            textBox1.Text = v1.ToString();
            serialPort1.Write(v1String);
        }

        private void v2OffButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                displayAlert("Błąd", "Przed wysłaniem wartości wybierz port");
                return;
            }

            graphics.Dispose();
            drawGraphics(redBrush, graphics, 69);

            v2 = 0;
            String v2String = "v2" + v2.ToString();
            textBox2.Text = v2.ToString();
            serialPort1.Write(v2String);
        }

        private void v3OffButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                displayAlert("Błąd", "Przed wysłaniem wartości wybierz port");
                return;
            }

            graphics3.Dispose();
            drawGraphics(redBrush, graphics3, 134);

            v3 = 0;
            String v3String = "v3" + v3.ToString();
            textBox3.Text = v3.ToString();
            serialPort1.Write(v3String);
        }

        private void v4OffButton_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == false)
            {
                displayAlert("Błąd", "Przed wysłaniem wartości wybierz port");
                return;
            }

            graphics4.Dispose();
            drawGraphics(redBrush, graphics4, 191);

            v4 = 0;
            String v4String = "v4" + v4.ToString();
            textBox4.Text = v4.ToString();
            serialPort1.Write(v4String);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            Console.WriteLine("Selected index changed2: " + selectedIndex);
            Console.WriteLine("Ports length: " + ports.Length);

            if (selectedIndex < ports.Length)
            {
                selectedPort = ports[selectedIndex];
                Console.WriteLine("Selected index changed: " + selectedPort);
            }
        }

        private void addPortsToList()
        {
            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }

            selectedPort = ports[0];
            comboBox1.SelectedText = selectedPort;
        }

        private void portSelectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                Console.WriteLine("Selected port: " + selectedPort);
                serialPort1.PortName = selectedPort;
                serialPort1.Open();

                displayAlert("Sukces!", "Połączenie przebiegło pomyślnie. Upewnij się, że pod wybrany port podłączony jest mikrokontroler");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd" + ex);
                displayAlert("Błąd", "Pod wybranym portem nie jest podłączony mikrokontroler. Wybierz inny port!");
            }

        }

        private void disposeAllGraphics()
        {
            graphics.Dispose();
            graphics2.Dispose();
            graphics3.Dispose();
            graphics4.Dispose();
        }

        private void drawGraphics(SolidBrush brush, Graphics graphics, int y)
        {
            graphics = panel1.CreateGraphics();
            graphics.FillEllipse(brush, 10, y, 15, 15);
            graphics.DrawEllipse(blackPen, 10, y, 15, 15);
        }

        private void enterTextboxesInitialValues()
        {
            textBox1.Text = v1.ToString();
            textBox2.Text = v2.ToString();
            textBox3.Text = v3.ToString();
            textBox4.Text = v4.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            disposeAllGraphics();

            drawGraphics(redBrush, graphics, 5);
            drawGraphics(redBrush, graphics2, 69);
            drawGraphics(redBrush, graphics3, 134);
            drawGraphics(redBrush, graphics4, 191);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

enum Engine
{
    v1,
    v2,
    v3,
    v4
}