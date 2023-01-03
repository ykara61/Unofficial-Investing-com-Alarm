namespace Investing_Alarm
{
    partial class NewInstrumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInstrumentForm));
            this.InstrumentLabel = new System.Windows.Forms.TextBox();
            this.InstrumentLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstrumentLabel
            // 
            this.InstrumentLabel.Location = new System.Drawing.Point(12, 26);
            this.InstrumentLabel.Name = "InstrumentLabel";
            this.InstrumentLabel.Size = new System.Drawing.Size(201, 23);
            this.InstrumentLabel.TabIndex = 0;
            // 
            // InstrumentLink
            // 
            this.InstrumentLink.Location = new System.Drawing.Point(12, 70);
            this.InstrumentLink.Name = "InstrumentLink";
            this.InstrumentLink.Size = new System.Drawing.Size(201, 23);
            this.InstrumentLink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instrument\'s Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Instrument\'s Investing Link";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(219, 24);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 67);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NewInstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(306, 103);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InstrumentLink);
            this.Controls.Add(this.InstrumentLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewInstrumentForm";
            this.Text = "Add New Instrument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InstrumentLabel;
        private TextBox InstrumentLink;
        private Label label1;
        private Label label2;
        private Button addButton;
    }
}