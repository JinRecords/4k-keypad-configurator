namespace Jin_s_4k_keypad_configurator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.consoleInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnclear2 = new System.Windows.Forms.Button();
            this.consoleOutput2 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Configurator = new System.Windows.Forms.TabPage();
            this.textboxKey4 = new System.Windows.Forms.TextBox();
            this.textboxKey2 = new System.Windows.Forms.TextBox();
            this.textboxKey3 = new System.Windows.Forms.TextBox();
            this.textboxKey1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsole = new System.Windows.Forms.Button();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxTest = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labletitle = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.lableOutput = new System.Windows.Forms.Label();
            this.keyLable = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnflash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Console.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Configurator.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.PortName = " ";
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // consoleInput
            // 
            this.consoleInput.Location = new System.Drawing.Point(140, 394);
            this.consoleInput.Name = "consoleInput";
            this.consoleInput.Size = new System.Drawing.Size(336, 20);
            this.consoleInput.TabIndex = 1;
            this.consoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.consoleInput_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(482, 392);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(72, 22);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Console.Controls.Add(this.btnBack);
            this.Console.Controls.Add(this.btnclear2);
            this.Console.Controls.Add(this.consoleOutput2);
            this.Console.Controls.Add(this.btnSend);
            this.Console.Controls.Add(this.consoleInput);
            this.Console.Location = new System.Drawing.Point(4, 22);
            this.Console.Name = "Console";
            this.Console.Padding = new System.Windows.Forms.Padding(3);
            this.Console.Size = new System.Drawing.Size(560, 430);
            this.Console.TabIndex = 1;
            this.Console.Text = "Console";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(6, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 22);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnclear2
            // 
            this.btnclear2.BackColor = System.Drawing.Color.White;
            this.btnclear2.Location = new System.Drawing.Point(72, 392);
            this.btnclear2.Name = "btnclear2";
            this.btnclear2.Size = new System.Drawing.Size(62, 22);
            this.btnclear2.TabIndex = 4;
            this.btnclear2.Text = "Clear";
            this.btnclear2.UseVisualStyleBackColor = false;
            this.btnclear2.Click += new System.EventHandler(this.btnclear2_Click);
            // 
            // consoleOutput2
            // 
            this.consoleOutput2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consoleOutput2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleOutput2.ForeColor = System.Drawing.SystemColors.Info;
            this.consoleOutput2.Location = new System.Drawing.Point(6, 6);
            this.consoleOutput2.Name = "consoleOutput2";
            this.consoleOutput2.ReadOnly = true;
            this.consoleOutput2.Size = new System.Drawing.Size(548, 377);
            this.consoleOutput2.TabIndex = 3;
            this.consoleOutput2.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Configurator);
            this.tabControl1.Controls.Add(this.Console);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(-5, -23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 456);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // Configurator
            // 
            this.Configurator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Configurator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Configurator.BackgroundImage")));
            this.Configurator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Configurator.Controls.Add(this.label5);
            this.Configurator.Controls.Add(this.label4);
            this.Configurator.Controls.Add(this.textboxKey4);
            this.Configurator.Controls.Add(this.textboxKey2);
            this.Configurator.Controls.Add(this.textboxKey3);
            this.Configurator.Controls.Add(this.textboxKey1);
            this.Configurator.Controls.Add(this.label3);
            this.Configurator.Controls.Add(this.btnConsole);
            this.Configurator.Controls.Add(this.cboPort);
            this.Configurator.Controls.Add(this.buttonClear);
            this.Configurator.Controls.Add(this.label2);
            this.Configurator.Controls.Add(this.textboxTest);
            this.Configurator.Controls.Add(this.progressBar1);
            this.Configurator.Controls.Add(this.label1);
            this.Configurator.Controls.Add(this.labletitle);
            this.Configurator.Controls.Add(this.labelPort);
            this.Configurator.Controls.Add(this.lableOutput);
            this.Configurator.Controls.Add(this.keyLable);
            this.Configurator.Controls.Add(this.btnClose);
            this.Configurator.Controls.Add(this.btnOpen);
            this.Configurator.Controls.Add(this.btnflash);
            this.Configurator.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Configurator.Location = new System.Drawing.Point(4, 22);
            this.Configurator.Name = "Configurator";
            this.Configurator.Padding = new System.Windows.Forms.Padding(3);
            this.Configurator.Size = new System.Drawing.Size(560, 430);
            this.Configurator.TabIndex = 0;
            this.Configurator.Text = "Configurator";
            // 
            // textboxKey4
            // 
            this.textboxKey4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxKey4.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxKey4.Location = new System.Drawing.Point(460, 185);
            this.textboxKey4.MaxLength = 3;
            this.textboxKey4.Name = "textboxKey4";
            this.textboxKey4.Size = new System.Drawing.Size(59, 60);
            this.textboxKey4.TabIndex = 27;
            this.textboxKey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxKey2
            // 
            this.textboxKey2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxKey2.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxKey2.Location = new System.Drawing.Point(193, 186);
            this.textboxKey2.MaxLength = 3;
            this.textboxKey2.Name = "textboxKey2";
            this.textboxKey2.Size = new System.Drawing.Size(59, 60);
            this.textboxKey2.TabIndex = 26;
            this.textboxKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxKey3
            // 
            this.textboxKey3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxKey3.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxKey3.Location = new System.Drawing.Point(356, 186);
            this.textboxKey3.MaxLength = 3;
            this.textboxKey3.Name = "textboxKey3";
            this.textboxKey3.Size = new System.Drawing.Size(59, 60);
            this.textboxKey3.TabIndex = 25;
            this.textboxKey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxKey1
            // 
            this.textboxKey1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxKey1.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxKey1.Location = new System.Drawing.Point(90, 186);
            this.textboxKey1.MaxLength = 3;
            this.textboxKey1.Name = "textboxKey1";
            this.textboxKey1.Size = new System.Drawing.Size(59, 60);
            this.textboxKey1.TabIndex = 24;
            this.textboxKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(359, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Jin\'s 4K keypad Configurator Ver 0.11";
            // 
            // btnConsole
            // 
            this.btnConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsole.Location = new System.Drawing.Point(467, 121);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(86, 22);
            this.btnConsole.TabIndex = 22;
            this.btnConsole.Text = "Console";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboPort
            // 
            this.cboPort.BackColor = System.Drawing.Color.DarkGray;
            this.cboPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPort.ForeColor = System.Drawing.Color.Black;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(468, 36);
            this.cboPort.Name = "cboPort";
            this.cboPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboPort.Size = new System.Drawing.Size(85, 21);
            this.cboPort.TabIndex = 15;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(306, 356);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(59, 55);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(52, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Test Here:";
            // 
            // textboxTest
            // 
            this.textboxTest.Location = new System.Drawing.Point(55, 356);
            this.textboxTest.Name = "textboxTest";
            this.textboxTest.Size = new System.Drawing.Size(245, 55);
            this.textboxTest.TabIndex = 15;
            this.textboxTest.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(55, 308);
            this.progressBar1.Maximum = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(498, 24);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 13;
            // 
            // labletitle
            // 
            this.labletitle.AutoSize = true;
            this.labletitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labletitle.Location = new System.Drawing.Point(11, 9);
            this.labletitle.Name = "labletitle";
            this.labletitle.Size = new System.Drawing.Size(0, 55);
            this.labletitle.TabIndex = 12;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPort.Location = new System.Drawing.Point(465, 4);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(93, 29);
            this.labelPort.TabIndex = 11;
            this.labelPort.Text = "Device:";
            // 
            // lableOutput
            // 
            this.lableOutput.AutoSize = true;
            this.lableOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lableOutput.Location = new System.Drawing.Point(52, 291);
            this.lableOutput.Name = "lableOutput";
            this.lableOutput.Size = new System.Drawing.Size(51, 13);
            this.lableOutput.TabIndex = 10;
            this.lableOutput.Text = "Progress:";
            // 
            // keyLable
            // 
            this.keyLable.AutoSize = true;
            this.keyLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLable.Location = new System.Drawing.Point(6, 174);
            this.keyLable.Name = "keyLable";
            this.keyLable.Size = new System.Drawing.Size(0, 33);
            this.keyLable.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(467, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Disconnect";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(468, 65);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 22);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Connect";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // btnflash
            // 
            this.btnflash.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnflash.Location = new System.Drawing.Point(370, 356);
            this.btnflash.Name = "btnflash";
            this.btnflash.Size = new System.Drawing.Size(183, 55);
            this.btnflash.TabIndex = 0;
            this.btnflash.Text = "Flash!";
            this.btnflash.UseVisualStyleBackColor = true;
            this.btnflash.Click += new System.EventHandler(this.btnflash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "For special keys, please use console instead, type 0 in console to begin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 112);
            this.label5.TabIndex = 29;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(558, 428);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Console.ResumeLayout(false);
            this.Console.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Configurator.ResumeLayout(false);
            this.Configurator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox consoleInput;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textboxTest;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labletitle;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label lableOutput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabPage Console;
        private System.Windows.Forms.Label keyLable;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnflash;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Configurator;
        private System.Windows.Forms.RichTextBox consoleOutput2;
        private System.Windows.Forms.Button btnclear2;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxKey1;
        private System.Windows.Forms.TextBox textboxKey4;
        private System.Windows.Forms.TextBox textboxKey2;
        private System.Windows.Forms.TextBox textboxKey3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

