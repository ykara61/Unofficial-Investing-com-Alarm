namespace Investing_Alarm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyValueTxt = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkTxt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxValueTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minValueTxt = new System.Windows.Forms.TextBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CurrencyTitle = new System.Windows.Forms.TextBox();
            this.lastUpdateTimeTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // currencyValueTxt
            // 
            this.currencyValueTxt.BackColor = System.Drawing.SystemColors.Info;
            this.currencyValueTxt.Enabled = false;
            this.currencyValueTxt.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currencyValueTxt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.currencyValueTxt.Location = new System.Drawing.Point(12, 6);
            this.currencyValueTxt.Multiline = true;
            this.currencyValueTxt.Name = "currencyValueTxt";
            this.currencyValueTxt.Size = new System.Drawing.Size(191, 38);
            this.currencyValueTxt.TabIndex = 0;
            this.currencyValueTxt.Text = "000.000";
            this.currencyValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(12, 56);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(101, 72);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.linkTxt);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.currencyComboBox);
            this.groupBox1.Location = new System.Drawing.Point(119, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "or Paste Investing Link";
            // 
            // linkTxt
            // 
            this.linkTxt.BackColor = System.Drawing.SystemColors.Info;
            this.linkTxt.Location = new System.Drawing.Point(6, 74);
            this.linkTxt.Name = "linkTxt";
            this.linkTxt.Size = new System.Drawing.Size(167, 20);
            this.linkTxt.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(129, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 22);
            this.button4.TabIndex = 5;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select The Currency";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(6, 30);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(117, 21);
            this.currencyComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxValueTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.minValueTxt);
            this.groupBox2.Location = new System.Drawing.Point(119, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // maxValueTxt
            // 
            this.maxValueTxt.BackColor = System.Drawing.SystemColors.Info;
            this.maxValueTxt.Location = new System.Drawing.Point(105, 29);
            this.maxValueTxt.Name = "maxValueTxt";
            this.maxValueTxt.Size = new System.Drawing.Size(78, 20);
            this.maxValueTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Min and Max Alarm Limits";
            // 
            // minValueTxt
            // 
            this.minValueTxt.BackColor = System.Drawing.SystemColors.Info;
            this.minValueTxt.Location = new System.Drawing.Point(6, 29);
            this.minValueTxt.Name = "minValueTxt";
            this.minValueTxt.Size = new System.Drawing.Size(78, 20);
            this.minValueTxt.TabIndex = 8;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.Location = new System.Drawing.Point(12, 132);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(101, 70);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.Text = "Minimize";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(363, 12);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(106, 198);
            this.webView21.Source = new System.Uri("https://www.lipsum.com", System.UriKind.Absolute);
            this.webView21.TabIndex = 8;
            this.webView21.Visible = false;
            this.webView21.ZoomFactor = 1D;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Unofficial Investing Alarm";
            this.notifyIcon1.Visible = true;
            // 
            // CurrencyTitle
            // 
            this.CurrencyTitle.BackColor = System.Drawing.SystemColors.Info;
            this.CurrencyTitle.Enabled = false;
            this.CurrencyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrencyTitle.Location = new System.Drawing.Point(209, 6);
            this.CurrencyTitle.Name = "CurrencyTitle";
            this.CurrencyTitle.Size = new System.Drawing.Size(99, 18);
            this.CurrencyTitle.TabIndex = 9;
            this.CurrencyTitle.Text = "-";
            this.CurrencyTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastUpdateTimeTxt
            // 
            this.lastUpdateTimeTxt.BackColor = System.Drawing.SystemColors.Info;
            this.lastUpdateTimeTxt.Enabled = false;
            this.lastUpdateTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastUpdateTimeTxt.Location = new System.Drawing.Point(209, 26);
            this.lastUpdateTimeTxt.Name = "lastUpdateTimeTxt";
            this.lastUpdateTimeTxt.Size = new System.Drawing.Size(99, 18);
            this.lastUpdateTimeTxt.TabIndex = 10;
            this.lastUpdateTimeTxt.Text = "-";
            this.lastUpdateTimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(311, 208);
            this.Controls.Add(this.lastUpdateTimeTxt);
            this.Controls.Add(this.CurrencyTitle);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.currencyValueTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Unofficial Investing Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private TextBox currencyValueTxt;
        private Button StartButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox linkTxt;
        private Label label1;
        private ComboBox currencyComboBox;
        private GroupBox groupBox2;
        private TextBox maxValueTxt;
        private Label label3;
        private TextBox minValueTxt;
        private Button MinimizeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private NotifyIcon notifyIcon1;
        private Button button4;
        private TextBox CurrencyTitle;
        private TextBox lastUpdateTimeTxt;
    }
}