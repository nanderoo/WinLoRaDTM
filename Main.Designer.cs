namespace WinLoRaDTM
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxComPortSelectionTX = new ComboBox();
            labelComPortSelectionTX = new Label();
            groupBoxTX = new GroupBox();
            buttonTX = new Button();
            buttonTXOpenClose = new Button();
            textBoxTX = new TextBox();
            statusStrip = new StatusStrip();
            toolStripStatusLabelTX = new ToolStripStatusLabel();
            toolStripStatusLabelRX = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            buttonRXOpenClose = new Button();
            textBoxRX = new TextBox();
            comboBoxComPortSelectionRX = new ComboBox();
            labelComPortSelectionRX = new Label();
            groupBoxRX = new GroupBox();
            textBoxMessage = new TextBox();
            groupBoxTX.SuspendLayout();
            statusStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBoxRX.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxComPortSelectionTX
            // 
            comboBoxComPortSelectionTX.FormattingEnabled = true;
            comboBoxComPortSelectionTX.Location = new Point(88, 23);
            comboBoxComPortSelectionTX.Name = "comboBoxComPortSelectionTX";
            comboBoxComPortSelectionTX.Size = new Size(121, 23);
            comboBoxComPortSelectionTX.TabIndex = 0;
            comboBoxComPortSelectionTX.SelectedIndexChanged += comboBoxComPortSelectionTX_SelectedIndexChanged;
            // 
            // labelComPortSelectionTX
            // 
            labelComPortSelectionTX.AutoSize = true;
            labelComPortSelectionTX.Location = new Point(22, 26);
            labelComPortSelectionTX.Name = "labelComPortSelectionTX";
            labelComPortSelectionTX.Size = new Size(60, 15);
            labelComPortSelectionTX.TabIndex = 1;
            labelComPortSelectionTX.Text = "COM Port";
            // 
            // groupBoxTX
            // 
            groupBoxTX.Controls.Add(textBoxMessage);
            groupBoxTX.Controls.Add(buttonTX);
            groupBoxTX.Controls.Add(buttonTXOpenClose);
            groupBoxTX.Controls.Add(textBoxTX);
            groupBoxTX.Controls.Add(comboBoxComPortSelectionTX);
            groupBoxTX.Controls.Add(labelComPortSelectionTX);
            groupBoxTX.Location = new Point(12, 27);
            groupBoxTX.Name = "groupBoxTX";
            groupBoxTX.Size = new Size(361, 375);
            groupBoxTX.TabIndex = 2;
            groupBoxTX.TabStop = false;
            groupBoxTX.Text = "Transmit";
            // 
            // buttonTX
            // 
            buttonTX.Location = new Point(266, 323);
            buttonTX.Name = "buttonTX";
            buttonTX.Size = new Size(75, 23);
            buttonTX.TabIndex = 4;
            buttonTX.Text = "Transmit";
            buttonTX.UseVisualStyleBackColor = true;
            buttonTX.Click += buttonTX_Click;
            // 
            // buttonTXOpenClose
            // 
            buttonTXOpenClose.Location = new Point(224, 23);
            buttonTXOpenClose.Name = "buttonTXOpenClose";
            buttonTXOpenClose.Size = new Size(117, 23);
            buttonTXOpenClose.TabIndex = 3;
            buttonTXOpenClose.Text = "Open Port";
            buttonTXOpenClose.UseVisualStyleBackColor = true;
            buttonTXOpenClose.Click += buttonTXOpenClose_Click;
            // 
            // textBoxTX
            // 
            textBoxTX.Location = new Point(22, 52);
            textBoxTX.Multiline = true;
            textBoxTX.Name = "textBoxTX";
            textBoxTX.ScrollBars = ScrollBars.Both;
            textBoxTX.Size = new Size(319, 266);
            textBoxTX.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTX, toolStripStatusLabelRX });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTX
            // 
            toolStripStatusLabelTX.Name = "toolStripStatusLabelTX";
            toolStripStatusLabelTX.Size = new Size(392, 17);
            toolStripStatusLabelTX.Spring = true;
            toolStripStatusLabelTX.Text = "TX Status - Closed";
            // 
            // toolStripStatusLabelRX
            // 
            toolStripStatusLabelRX.Name = "toolStripStatusLabelRX";
            toolStripStatusLabelRX.Size = new Size(392, 17);
            toolStripStatusLabelRX.Spring = true;
            toolStripStatusLabelRX.Text = "RX Status - Closed";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // buttonRXOpenClose
            // 
            buttonRXOpenClose.Location = new Point(224, 23);
            buttonRXOpenClose.Name = "buttonRXOpenClose";
            buttonRXOpenClose.Size = new Size(117, 23);
            buttonRXOpenClose.TabIndex = 3;
            buttonRXOpenClose.Text = "Open Port";
            buttonRXOpenClose.UseVisualStyleBackColor = true;
            buttonRXOpenClose.Click += buttonRXOpenClose_Click;
            // 
            // textBoxRX
            // 
            textBoxRX.Location = new Point(22, 52);
            textBoxRX.Multiline = true;
            textBoxRX.Name = "textBoxRX";
            textBoxRX.ScrollBars = ScrollBars.Both;
            textBoxRX.Size = new Size(319, 305);
            textBoxRX.TabIndex = 2;
            // 
            // comboBoxComPortSelectionRX
            // 
            comboBoxComPortSelectionRX.FormattingEnabled = true;
            comboBoxComPortSelectionRX.Location = new Point(88, 23);
            comboBoxComPortSelectionRX.Name = "comboBoxComPortSelectionRX";
            comboBoxComPortSelectionRX.Size = new Size(121, 23);
            comboBoxComPortSelectionRX.TabIndex = 0;
            comboBoxComPortSelectionRX.SelectedIndexChanged += comboBoxComPortSelectionRX_SelectedIndexChanged;
            // 
            // labelComPortSelectionRX
            // 
            labelComPortSelectionRX.AutoSize = true;
            labelComPortSelectionRX.Location = new Point(22, 26);
            labelComPortSelectionRX.Name = "labelComPortSelectionRX";
            labelComPortSelectionRX.Size = new Size(60, 15);
            labelComPortSelectionRX.TabIndex = 1;
            labelComPortSelectionRX.Text = "COM Port";
            // 
            // groupBoxRX
            // 
            groupBoxRX.Controls.Add(buttonRXOpenClose);
            groupBoxRX.Controls.Add(textBoxRX);
            groupBoxRX.Controls.Add(comboBoxComPortSelectionRX);
            groupBoxRX.Controls.Add(labelComPortSelectionRX);
            groupBoxRX.Location = new Point(427, 27);
            groupBoxRX.Name = "groupBoxRX";
            groupBoxRX.Size = new Size(361, 375);
            groupBoxRX.TabIndex = 5;
            groupBoxRX.TabStop = false;
            groupBoxRX.Text = "Receive";
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(22, 324);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(238, 23);
            textBoxMessage.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRX);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            Controls.Add(groupBoxTX);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "WinLoRaDTM";
            Load += Main_Load;
            groupBoxTX.ResumeLayout(false);
            groupBoxTX.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxRX.ResumeLayout(false);
            groupBoxRX.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxComPortSelectionTX;
        private Label labelComPortSelectionTX;
        private GroupBox groupBoxTX;
        private StatusStrip statusStrip;
        private Button buttonTXOpenClose;
        private TextBox textBoxTX;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabelTX;
        private ToolStripStatusLabel toolStripStatusLabelRX;
        private Button buttonRXOpenClose;
        private TextBox textBoxRX;
        private ComboBox comboBoxComPortSelectionRX;
        private Label labelComPortSelectionRX;
        private GroupBox groupBoxRX;
        private Button buttonTX;
        private TextBox textBoxMessage;
    }
}
