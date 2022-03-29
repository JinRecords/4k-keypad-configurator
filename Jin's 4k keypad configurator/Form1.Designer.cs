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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.consoleInput = new System.Windows.Forms.TextBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxTest = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labletitle = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.lableOutput = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.Consolexxx = new System.Windows.Forms.TabPage();
            this.btnclear2 = new System.Windows.Forms.Button();
            this.consoleOutput2 = new System.Windows.Forms.RichTextBox();
            this.textboxKey4 = new System.Windows.Forms.TextBox();
            this.textboxKey3 = new System.Windows.Forms.TextBox();
            this.textboxKey1 = new System.Windows.Forms.TextBox();
            this.keyLable = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnflash = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Configurator = new System.Windows.Forms.TabPage();
            this.textboxKey2 = new System.Windows.Forms.TextBox();
            this.Consolexxx.SuspendLayout();
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
            this.consoleInput.Location = new System.Drawing.Point(110, 393);
            this.consoleInput.Name = "consoleInput";
            this.consoleInput.Size = new System.Drawing.Size(338, 20);
            this.consoleInput.TabIndex = 1;
            this.consoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.consoleInput_KeyDown);
            // 
            // cboPort
            // 
            this.cboPort.BackColor = System.Drawing.Color.DarkGray;
            this.cboPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPort.ForeColor = System.Drawing.Color.DarkGray;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(475, 9);
            this.cboPort.Name = "cboPort";
            this.cboPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboPort.Size = new System.Drawing.Size(75, 21);
            this.cboPort.TabIndex = 15;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(279, 300);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Test Here:";
            // 
            // textboxTest
            // 
            this.textboxTest.Location = new System.Drawing.Point(12, 325);
            this.textboxTest.Name = "textboxTest";
            this.textboxTest.Size = new System.Drawing.Size(342, 91);
            this.textboxTest.TabIndex = 15;
            this.textboxTest.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 264);
            this.progressBar1.Maximum = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 34);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Still in development!!!";
            // 
            // labletitle
            // 
            this.labletitle.AutoSize = true;
            this.labletitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labletitle.Location = new System.Drawing.Point(11, 9);
            this.labletitle.Name = "labletitle";
            this.labletitle.Size = new System.Drawing.Size(404, 55);
            this.labletitle.TabIndex = 12;
            this.labletitle.Text = "4k Keypad Config";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(440, 12);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 11;
            this.labelPort.Text = "Port:";
            // 
            // lableOutput
            // 
            this.lableOutput.AutoSize = true;
            this.lableOutput.Location = new System.Drawing.Point(9, 248);
            this.lableOutput.Name = "lableOutput";
            this.lableOutput.Size = new System.Drawing.Size(51, 13);
            this.lableOutput.TabIndex = 10;
            this.lableOutput.Text = "Progress:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(454, 392);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(93, 22);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // Consolexxx
            // 
            this.Consolexxx.Controls.Add(this.btnclear2);
            this.Consolexxx.Controls.Add(this.consoleOutput2);
            this.Consolexxx.Controls.Add(this.btnSend);
            this.Consolexxx.Controls.Add(this.consoleInput);
            this.Consolexxx.Location = new System.Drawing.Point(4, 22);
            this.Consolexxx.Name = "Consolexxx";
            this.Consolexxx.Padding = new System.Windows.Forms.Padding(3);
            this.Consolexxx.Size = new System.Drawing.Size(560, 425);
            this.Consolexxx.TabIndex = 1;
            this.Consolexxx.Text = "Console";
            this.Consolexxx.UseVisualStyleBackColor = true;
            // 
            // btnclear2
            // 
            this.btnclear2.Location = new System.Drawing.Point(11, 392);
            this.btnclear2.Name = "btnclear2";
            this.btnclear2.Size = new System.Drawing.Size(93, 22);
            this.btnclear2.TabIndex = 4;
            this.btnclear2.Text = "Clear";
            this.btnclear2.UseVisualStyleBackColor = false;
            this.btnclear2.Click += new System.EventHandler(this.btnclear2_Click);
            // 
            // consoleOutput2
            // 
            this.consoleOutput2.Location = new System.Drawing.Point(11, 6);
            this.consoleOutput2.Name = "consoleOutput2";
            this.consoleOutput2.ReadOnly = true;
            this.consoleOutput2.Size = new System.Drawing.Size(536, 377);
            this.consoleOutput2.TabIndex = 3;
            this.consoleOutput2.Text = "";
            // 
            // textboxKey4
            // 
            this.textboxKey4.Location = new System.Drawing.Point(285, 221);
            this.textboxKey4.MaxLength = 3;
            this.textboxKey4.Name = "textboxKey4";
            this.textboxKey4.Size = new System.Drawing.Size(69, 20);
            this.textboxKey4.TabIndex = 8;
            // 
            // textboxKey3
            // 
            this.textboxKey3.Location = new System.Drawing.Point(194, 221);
            this.textboxKey3.MaxLength = 3;
            this.textboxKey3.Name = "textboxKey3";
            this.textboxKey3.Size = new System.Drawing.Size(69, 20);
            this.textboxKey3.TabIndex = 7;
            // 
            // textboxKey1
            // 
            this.textboxKey1.Location = new System.Drawing.Point(12, 221);
            this.textboxKey1.MaxLength = 3;
            this.textboxKey1.Name = "textboxKey1";
            this.textboxKey1.Size = new System.Drawing.Size(69, 20);
            this.textboxKey1.TabIndex = 5;
            // 
            // keyLable
            // 
            this.keyLable.AutoSize = true;
            this.keyLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLable.Location = new System.Drawing.Point(6, 174);
            this.keyLable.Name = "keyLable";
            this.keyLable.Size = new System.Drawing.Size(359, 33);
            this.keyLable.TabIndex = 4;
            this.keyLable.Text = "Key 1  Key 2  Key 3  Key 4";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(475, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Disconnect";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(475, 36);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Connect";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // btnflash
            // 
            this.btnflash.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnflash.Location = new System.Drawing.Point(395, 363);
            this.btnflash.Name = "btnflash";
            this.btnflash.Size = new System.Drawing.Size(155, 53);
            this.btnflash.TabIndex = 0;
            this.btnflash.Text = "Flash!";
            this.btnflash.UseVisualStyleBackColor = true;
            this.btnflash.Click += new System.EventHandler(this.btnflash_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Configurator);
            this.tabControl1.Controls.Add(this.Consolexxx);
            this.tabControl1.Location = new System.Drawing.Point(-5, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 451);
            this.tabControl1.TabIndex = 1;
            // 
            // Configurator
            // 
            this.Configurator.Controls.Add(this.cboPort);
            this.Configurator.Controls.Add(this.buttonClear);
            this.Configurator.Controls.Add(this.label2);
            this.Configurator.Controls.Add(this.textboxTest);
            this.Configurator.Controls.Add(this.progressBar1);
            this.Configurator.Controls.Add(this.label1);
            this.Configurator.Controls.Add(this.labletitle);
            this.Configurator.Controls.Add(this.labelPort);
            this.Configurator.Controls.Add(this.lableOutput);
            this.Configurator.Controls.Add(this.textboxKey4);
            this.Configurator.Controls.Add(this.textboxKey3);
            this.Configurator.Controls.Add(this.textboxKey2);
            this.Configurator.Controls.Add(this.textboxKey1);
            this.Configurator.Controls.Add(this.keyLable);
            this.Configurator.Controls.Add(this.btnClose);
            this.Configurator.Controls.Add(this.btnOpen);
            this.Configurator.Controls.Add(this.btnflash);
            this.Configurator.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Configurator.Location = new System.Drawing.Point(4, 22);
            this.Configurator.Name = "Configurator";
            this.Configurator.Padding = new System.Windows.Forms.Padding(3);
            this.Configurator.Size = new System.Drawing.Size(560, 425);
            this.Configurator.TabIndex = 0;
            this.Configurator.Text = "Configurator";
            this.Configurator.UseVisualStyleBackColor = true;
            // 
            // textboxKey2
            // 
            this.textboxKey2.Location = new System.Drawing.Point(103, 221);
            this.textboxKey2.MaxLength = 3;
            this.textboxKey2.Name = "textboxKey2";
            this.textboxKey2.Size = new System.Drawing.Size(69, 20);
            this.textboxKey2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(558, 447);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Consolexxx.ResumeLayout(false);
            this.Consolexxx.PerformLayout();
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
        private System.Windows.Forms.TabPage Consolexxx;
        private System.Windows.Forms.TextBox textboxKey4;
        private System.Windows.Forms.TextBox textboxKey3;
        private System.Windows.Forms.TextBox textboxKey1;
        private System.Windows.Forms.Label keyLable;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnflash;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Configurator;
        private System.Windows.Forms.TextBox textboxKey2;
        private System.Windows.Forms.RichTextBox consoleOutput2;
        private System.Windows.Forms.Button btnclear2;
    }
}

