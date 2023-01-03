using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investing_Alarm
{
    public partial class NewInstrumentForm : Form
    {
        private Form1 MainForm;

        public NewInstrumentForm(Form1 mainForm)
        {
            
            InitializeComponent();
            MainForm = mainForm;
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            Helpers.Helper.AddNewInstrumentIntoJson(new Items.Instrument()
            {
                Name = this.InstrumentLabel.Text,
                LinkString = this.InstrumentLink.Text
            });
            MainForm.RefreshInstrumentList();
            this.Close();
        }

    }
}
