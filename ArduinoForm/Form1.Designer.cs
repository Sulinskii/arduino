namespace ArduinoForm
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.onButton = new System.Windows.Forms.Button();
            this.v2OffButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.v1OffButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.v1PlusButton = new System.Windows.Forms.Button();
            this.v2PlusButton = new System.Windows.Forms.Button();
            this.v3PlusButton = new System.Windows.Forms.Button();
            this.v4PlusButton = new System.Windows.Forms.Button();
            this.v3OffButton = new System.Windows.Forms.Button();
            this.v4OffButton = new System.Windows.Forms.Button();
            this.v1MinusButton = new System.Windows.Forms.Button();
            this.v2MinusButton = new System.Windows.Forms.Button();
            this.v3MinusButton = new System.Windows.Forms.Button();
            this.v4MinusButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.workPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.portSelectionButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.calibrationPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.workPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "-";
            // 
            // onButton
            // 
            this.onButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.onButton.FlatAppearance.BorderSize = 8;
            this.onButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.onButton.Location = new System.Drawing.Point(697, 476);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(186, 92);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "Rozpocznij pracę / zaktualizuj prędkość";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // v2OffButton
            // 
            this.v2OffButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v2OffButton.Location = new System.Drawing.Point(432, 138);
            this.v2OffButton.Name = "v2OffButton";
            this.v2OffButton.Size = new System.Drawing.Size(100, 40);
            this.v2OffButton.TabIndex = 1;
            this.v2OffButton.Text = "Wyłącz";
            this.v2OffButton.UseVisualStyleBackColor = true;
            this.v2OffButton.Click += new System.EventHandler(this.v2OffButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(179, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // v1OffButton
            // 
            this.v1OffButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v1OffButton.Location = new System.Drawing.Point(432, 58);
            this.v1OffButton.Name = "v1OffButton";
            this.v1OffButton.Size = new System.Drawing.Size(100, 40);
            this.v1OffButton.TabIndex = 3;
            this.v1OffButton.Text = "Wyłącz";
            this.v1OffButton.UseMnemonic = false;
            this.v1OffButton.UseVisualStyleBackColor = true;
            this.v1OffButton.Click += new System.EventHandler(this.v1OffButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(179, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(179, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(179, 305);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(153, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "podajnik 1, obr/min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(153, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "podajnik 2, obr/min";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(136, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "ślimak pionowy, obr/min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(135, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "ślimak poziomy, obr/min";
            // 
            // v1PlusButton
            // 
            this.v1PlusButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v1PlusButton.Location = new System.Drawing.Point(331, 58);
            this.v1PlusButton.Name = "v1PlusButton";
            this.v1PlusButton.Size = new System.Drawing.Size(40, 40);
            this.v1PlusButton.TabIndex = 11;
            this.v1PlusButton.Text = "+";
            this.v1PlusButton.UseVisualStyleBackColor = true;
            this.v1PlusButton.Click += new System.EventHandler(this.v1PlusButton_Click);
            // 
            // v2PlusButton
            // 
            this.v2PlusButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v2PlusButton.Location = new System.Drawing.Point(331, 138);
            this.v2PlusButton.Name = "v2PlusButton";
            this.v2PlusButton.Size = new System.Drawing.Size(40, 40);
            this.v2PlusButton.TabIndex = 12;
            this.v2PlusButton.Text = "+";
            this.v2PlusButton.UseVisualStyleBackColor = true;
            this.v2PlusButton.Click += new System.EventHandler(this.v2PlusButton_Click);
            // 
            // v3PlusButton
            // 
            this.v3PlusButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v3PlusButton.Location = new System.Drawing.Point(331, 218);
            this.v3PlusButton.Name = "v3PlusButton";
            this.v3PlusButton.Size = new System.Drawing.Size(40, 40);
            this.v3PlusButton.TabIndex = 13;
            this.v3PlusButton.Text = "+";
            this.v3PlusButton.UseVisualStyleBackColor = true;
            this.v3PlusButton.Click += new System.EventHandler(this.v3PlusButton_Click);
            // 
            // v4PlusButton
            // 
            this.v4PlusButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v4PlusButton.Location = new System.Drawing.Point(331, 298);
            this.v4PlusButton.Name = "v4PlusButton";
            this.v4PlusButton.Size = new System.Drawing.Size(40, 40);
            this.v4PlusButton.TabIndex = 14;
            this.v4PlusButton.Text = "+";
            this.v4PlusButton.UseVisualStyleBackColor = true;
            this.v4PlusButton.Click += new System.EventHandler(this.v4PlusButton_Click);
            // 
            // v3OffButton
            // 
            this.v3OffButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v3OffButton.Location = new System.Drawing.Point(432, 218);
            this.v3OffButton.Name = "v3OffButton";
            this.v3OffButton.Size = new System.Drawing.Size(100, 40);
            this.v3OffButton.TabIndex = 15;
            this.v3OffButton.Text = "Wyłącz";
            this.v3OffButton.UseVisualStyleBackColor = true;
            this.v3OffButton.Click += new System.EventHandler(this.v3OffButton_Click);
            // 
            // v4OffButton
            // 
            this.v4OffButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v4OffButton.Location = new System.Drawing.Point(432, 298);
            this.v4OffButton.Name = "v4OffButton";
            this.v4OffButton.Size = new System.Drawing.Size(100, 40);
            this.v4OffButton.TabIndex = 16;
            this.v4OffButton.Text = "Wyłącz";
            this.v4OffButton.UseVisualStyleBackColor = true;
            this.v4OffButton.Click += new System.EventHandler(this.v4OffButton_Click);
            // 
            // v1MinusButton
            // 
            this.v1MinusButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v1MinusButton.Location = new System.Drawing.Point(87, 58);
            this.v1MinusButton.Margin = new System.Windows.Forms.Padding(0);
            this.v1MinusButton.Name = "v1MinusButton";
            this.v1MinusButton.Size = new System.Drawing.Size(40, 40);
            this.v1MinusButton.TabIndex = 17;
            this.v1MinusButton.Text = "-";
            this.v1MinusButton.UseVisualStyleBackColor = true;
            this.v1MinusButton.Click += new System.EventHandler(this.v1MinusButton_Click);
            // 
            // v2MinusButton
            // 
            this.v2MinusButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v2MinusButton.Location = new System.Drawing.Point(87, 138);
            this.v2MinusButton.Name = "v2MinusButton";
            this.v2MinusButton.Size = new System.Drawing.Size(40, 40);
            this.v2MinusButton.TabIndex = 18;
            this.v2MinusButton.Text = "-";
            this.v2MinusButton.UseVisualStyleBackColor = true;
            this.v2MinusButton.Click += new System.EventHandler(this.v2MinusButton_Click);
            // 
            // v3MinusButton
            // 
            this.v3MinusButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v3MinusButton.Location = new System.Drawing.Point(87, 218);
            this.v3MinusButton.Name = "v3MinusButton";
            this.v3MinusButton.Size = new System.Drawing.Size(40, 40);
            this.v3MinusButton.TabIndex = 19;
            this.v3MinusButton.Text = "-";
            this.v3MinusButton.UseVisualStyleBackColor = true;
            this.v3MinusButton.Click += new System.EventHandler(this.v3MinusButton_Click);
            // 
            // v4MinusButton
            // 
            this.v4MinusButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v4MinusButton.Location = new System.Drawing.Point(87, 298);
            this.v4MinusButton.Name = "v4MinusButton";
            this.v4MinusButton.Size = new System.Drawing.Size(40, 40);
            this.v4MinusButton.TabIndex = 20;
            this.v4MinusButton.Text = "-";
            this.v4MinusButton.UseVisualStyleBackColor = true;
            this.v4MinusButton.Click += new System.EventHandler(this.v4MinusButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.workPage);
            this.tabControl1.Controls.Add(this.calibrationPage);
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 617);
            this.tabControl1.TabIndex = 21;
            // 
            // workPage
            // 
            this.workPage.BackColor = System.Drawing.Color.OldLace;
            this.workPage.Controls.Add(this.button6);
            this.workPage.Controls.Add(this.button5);
            this.workPage.Controls.Add(this.label7);
            this.workPage.Controls.Add(this.button4);
            this.workPage.Controls.Add(this.button3);
            this.workPage.Controls.Add(this.label6);
            this.workPage.Controls.Add(this.button1);
            this.workPage.Controls.Add(this.button2);
            this.workPage.Controls.Add(this.label5);
            this.workPage.Controls.Add(this.panel1);
            this.workPage.Controls.Add(this.onButton);
            this.workPage.Controls.Add(this.v1OffButton);
            this.workPage.Controls.Add(this.v3OffButton);
            this.workPage.Controls.Add(this.v2OffButton);
            this.workPage.Controls.Add(this.v1MinusButton);
            this.workPage.Controls.Add(this.v3PlusButton);
            this.workPage.Controls.Add(this.v2MinusButton);
            this.workPage.Controls.Add(this.v2PlusButton);
            this.workPage.Controls.Add(this.v3MinusButton);
            this.workPage.Controls.Add(this.v1PlusButton);
            this.workPage.Controls.Add(this.v4MinusButton);
            this.workPage.Controls.Add(this.portSelectionButton);
            this.workPage.Controls.Add(this.comboBox1);
            this.workPage.Controls.Add(this.v4OffButton);
            this.workPage.Controls.Add(this.label2);
            this.workPage.Controls.Add(this.textBox4);
            this.workPage.Controls.Add(this.v4PlusButton);
            this.workPage.Controls.Add(this.label1);
            this.workPage.Controls.Add(this.label3);
            this.workPage.Controls.Add(this.textBox2);
            this.workPage.Controls.Add(this.textBox1);
            this.workPage.Controls.Add(this.label4);
            this.workPage.Controls.Add(this.textBox3);
            this.workPage.Location = new System.Drawing.Point(4, 22);
            this.workPage.Name = "workPage";
            this.workPage.Padding = new System.Windows.Forms.Padding(3);
            this.workPage.Size = new System.Drawing.Size(925, 591);
            this.workPage.TabIndex = 0;
            this.workPage.Text = "praca";
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(37, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 516);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // portSelectionButton
            // 
            this.portSelectionButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portSelectionButton.Location = new System.Drawing.Point(697, 138);
            this.portSelectionButton.Name = "portSelectionButton";
            this.portSelectionButton.Size = new System.Drawing.Size(186, 62);
            this.portSelectionButton.TabIndex = 9;
            this.portSelectionButton.Text = "Wybierz port";
            this.portSelectionButton.UseVisualStyleBackColor = true;
            this.portSelectionButton.Click += new System.EventHandler(this.portSelectionButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(697, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 29);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // calibrationPage
            // 
            this.calibrationPage.BackColor = System.Drawing.Color.OldLace;
            this.calibrationPage.Location = new System.Drawing.Point(4, 22);
            this.calibrationPage.Name = "calibrationPage";
            this.calibrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.calibrationPage.Size = new System.Drawing.Size(505, 260);
            this.calibrationPage.TabIndex = 1;
            this.calibrationPage.Text = "kalibracja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(214, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Generator wibracji 1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(432, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 24;
            this.button2.Text = "Wyłącz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(87, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 25;
            this.button1.Text = "Włącz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(214, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Generator wibracji 2";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(87, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 27;
            this.button3.Text = "Włącz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(432, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 28;
            this.button4.Text = "Wyłącz";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(214, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Generator wibracji 3";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(87, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 40);
            this.button5.TabIndex = 30;
            this.button5.Text = "Włącz";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(432, 535);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 40);
            this.button6.TabIndex = 31;
            this.button6.Text = "Wyłącz";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.workPage.ResumeLayout(false);
            this.workPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button v2OffButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button v1OffButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button v1PlusButton;
        private System.Windows.Forms.Button v2PlusButton;
        private System.Windows.Forms.Button v3PlusButton;
        private System.Windows.Forms.Button v4PlusButton;
        private System.Windows.Forms.Button v3OffButton;
        private System.Windows.Forms.Button v4OffButton;
        private System.Windows.Forms.Button v1MinusButton;
        private System.Windows.Forms.Button v2MinusButton;
        private System.Windows.Forms.Button v3MinusButton;
        private System.Windows.Forms.Button v4MinusButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage workPage;
        private System.Windows.Forms.TabPage calibrationPage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button portSelectionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}

