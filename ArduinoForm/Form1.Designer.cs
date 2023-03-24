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
            this.calibrationPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // onButton
            // 
            this.onButton.Location = new System.Drawing.Point(399, 222);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(75, 23);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "Wyślij";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // v2OffButton
            // 
            this.v2OffButton.Location = new System.Drawing.Point(230, 110);
            this.v2OffButton.Name = "v2OffButton";
            this.v2OffButton.Size = new System.Drawing.Size(75, 20);
            this.v2OffButton.TabIndex = 1;
            this.v2OffButton.Text = "Wyłącz";
            this.v2OffButton.UseVisualStyleBackColor = true;
            this.v2OffButton.Click += new System.EventHandler(this.v2OffButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // v1OffButton
            // 
            this.v1OffButton.Location = new System.Drawing.Point(230, 49);
            this.v1OffButton.Name = "v1OffButton";
            this.v1OffButton.Size = new System.Drawing.Size(75, 20);
            this.v1OffButton.TabIndex = 3;
            this.v1OffButton.Text = "Wyłącz";
            this.v1OffButton.UseMnemonic = false;
            this.v1OffButton.UseVisualStyleBackColor = true;
            this.v1OffButton.Click += new System.EventHandler(this.v1OffButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(53, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "v1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "v2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "v3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "v4";
            // 
            // v1PlusButton
            // 
            this.v1PlusButton.Location = new System.Drawing.Point(183, 49);
            this.v1PlusButton.Name = "v1PlusButton";
            this.v1PlusButton.Size = new System.Drawing.Size(25, 20);
            this.v1PlusButton.TabIndex = 11;
            this.v1PlusButton.Text = "+";
            this.v1PlusButton.UseVisualStyleBackColor = true;
            this.v1PlusButton.Click += new System.EventHandler(this.v1PlusButton_Click);
            // 
            // v2PlusButton
            // 
            this.v2PlusButton.Location = new System.Drawing.Point(183, 110);
            this.v2PlusButton.Name = "v2PlusButton";
            this.v2PlusButton.Size = new System.Drawing.Size(25, 20);
            this.v2PlusButton.TabIndex = 12;
            this.v2PlusButton.Text = "+";
            this.v2PlusButton.UseVisualStyleBackColor = true;
            this.v2PlusButton.Click += new System.EventHandler(this.v2PlusButton_Click);
            // 
            // v3PlusButton
            // 
            this.v3PlusButton.Location = new System.Drawing.Point(183, 163);
            this.v3PlusButton.Name = "v3PlusButton";
            this.v3PlusButton.Size = new System.Drawing.Size(25, 20);
            this.v3PlusButton.TabIndex = 13;
            this.v3PlusButton.Text = "+";
            this.v3PlusButton.UseVisualStyleBackColor = true;
            this.v3PlusButton.Click += new System.EventHandler(this.v3PlusButton_Click);
            // 
            // v4PlusButton
            // 
            this.v4PlusButton.Location = new System.Drawing.Point(183, 224);
            this.v4PlusButton.Name = "v4PlusButton";
            this.v4PlusButton.Size = new System.Drawing.Size(25, 20);
            this.v4PlusButton.TabIndex = 14;
            this.v4PlusButton.Text = "+";
            this.v4PlusButton.UseVisualStyleBackColor = true;
            this.v4PlusButton.Click += new System.EventHandler(this.v4PlusButton_Click);
            // 
            // v3OffButton
            // 
            this.v3OffButton.Location = new System.Drawing.Point(230, 163);
            this.v3OffButton.Name = "v3OffButton";
            this.v3OffButton.Size = new System.Drawing.Size(75, 20);
            this.v3OffButton.TabIndex = 15;
            this.v3OffButton.Text = "Wyłącz";
            this.v3OffButton.UseVisualStyleBackColor = true;
            this.v3OffButton.Click += new System.EventHandler(this.v3OffButton_Click);
            // 
            // v4OffButton
            // 
            this.v4OffButton.Location = new System.Drawing.Point(230, 224);
            this.v4OffButton.Name = "v4OffButton";
            this.v4OffButton.Size = new System.Drawing.Size(75, 20);
            this.v4OffButton.TabIndex = 16;
            this.v4OffButton.Text = "Wyłącz";
            this.v4OffButton.UseVisualStyleBackColor = true;
            this.v4OffButton.Click += new System.EventHandler(this.v4OffButton_Click);
            // 
            // v1MinusButton
            // 
            this.v1MinusButton.Location = new System.Drawing.Point(73, 49);
            this.v1MinusButton.Name = "v1MinusButton";
            this.v1MinusButton.Size = new System.Drawing.Size(24, 20);
            this.v1MinusButton.TabIndex = 17;
            this.v1MinusButton.Text = "-";
            this.v1MinusButton.UseVisualStyleBackColor = true;
            // 
            // v2MinusButton
            // 
            this.v2MinusButton.Location = new System.Drawing.Point(73, 110);
            this.v2MinusButton.Name = "v2MinusButton";
            this.v2MinusButton.Size = new System.Drawing.Size(24, 20);
            this.v2MinusButton.TabIndex = 18;
            this.v2MinusButton.Text = "-";
            this.v2MinusButton.UseVisualStyleBackColor = true;
            // 
            // v3MinusButton
            // 
            this.v3MinusButton.Location = new System.Drawing.Point(73, 163);
            this.v3MinusButton.Name = "v3MinusButton";
            this.v3MinusButton.Size = new System.Drawing.Size(24, 20);
            this.v3MinusButton.TabIndex = 19;
            this.v3MinusButton.Text = "-";
            this.v3MinusButton.UseVisualStyleBackColor = true;
            // 
            // v4MinusButton
            // 
            this.v4MinusButton.Location = new System.Drawing.Point(73, 224);
            this.v4MinusButton.Name = "v4MinusButton";
            this.v4MinusButton.Size = new System.Drawing.Size(24, 20);
            this.v4MinusButton.TabIndex = 20;
            this.v4MinusButton.Text = "-";
            this.v4MinusButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.workPage);
            this.tabControl1.Controls.Add(this.calibrationPage);
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 263);
            this.tabControl1.TabIndex = 21;
            // 
            // workPage
            // 
            this.workPage.Location = new System.Drawing.Point(4, 22);
            this.workPage.Name = "workPage";
            this.workPage.Padding = new System.Windows.Forms.Padding(3);
            this.workPage.Size = new System.Drawing.Size(490, 237);
            this.workPage.TabIndex = 0;
            this.workPage.Text = "praca";
            this.workPage.UseVisualStyleBackColor = true;
            // 
            // calibrationPage
            // 
            this.calibrationPage.Location = new System.Drawing.Point(4, 22);
            this.calibrationPage.Name = "calibrationPage";
            this.calibrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.calibrationPage.Size = new System.Drawing.Size(490, 237);
            this.calibrationPage.TabIndex = 1;
            this.calibrationPage.Text = "kalibracja";
            this.calibrationPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 259);
            this.Controls.Add(this.v4MinusButton);
            this.Controls.Add(this.v3MinusButton);
            this.Controls.Add(this.v2MinusButton);
            this.Controls.Add(this.v1MinusButton);
            this.Controls.Add(this.v4OffButton);
            this.Controls.Add(this.v3OffButton);
            this.Controls.Add(this.v4PlusButton);
            this.Controls.Add(this.v3PlusButton);
            this.Controls.Add(this.v2PlusButton);
            this.Controls.Add(this.v1PlusButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.v1OffButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.v2OffButton);
            this.Controls.Add(this.onButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

