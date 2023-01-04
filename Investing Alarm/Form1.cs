using Investing_Alarm.Helpers;
using Investing_Alarm.Items;
using System.Globalization;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Investing_Alarm
{
    public partial class Form1 : Form
    {
        private int i = 0;
        private float maxTarget;
        private float minTarget;
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BrokerAlert";
        private static string pathTxt = path + "\\keyValue.txt";
        private Uri ur;
        delegate void SetTextCallback(string text);
        private List<Instrument> instruments;
        private WebPageParser wpp;

        private enum State
        {
            Started,
            Idle
        }

        private State state;

        public Form1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            CultureInfo ci = CultureInfo.InstalledUICulture;
            InitializeComponent();

            wpp = new WebPageParser();

            this.notifyIcon1.DoubleClick += NotifyIcon1_DoubleClick;

            state = State.Idle;

            InitializeAsync();

            Helpers.Helper.GetSound();

            RefreshInstrumentList();
        }

        public void RefreshInstrumentList()
        {
            currencyComboBox.Items.Clear();
            
            instruments = Helpers.Helper.GetInstruments();

            foreach (var instrument in instruments)
            {
                currencyComboBox.Items.Add(instrument.Name);
            }
        }

        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.NavigationCompleted += WebView21_NavigationCompleted;
        }

        private async void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Console.WriteLine("navi completed");
            if (e.IsSuccess)
            {
                try
                {
                    var targetElement = await webView21.ExecuteScriptAsync("document.getElementById('__next').outerHTML");
                    wpp.ParseAllHtml(targetElement);
                    Console.WriteLine(wpp.currenyTitleParser(targetElement));
                    try
                    {
                        if (((wpp.value >= maxTarget)) && (maxTarget > 0))
                        {
                            PlaySound();
                        }
                        else if ((minTarget >= wpp.value) && (minTarget > 0))
                        {
                            PlaySound();
                        }
                    }
                    catch (Exception en)
                    {
                        Console.WriteLine(en.Message);
                    }

                    if (wpp.changeInInstrument < 0)
                    {
                        currencyValueTxt.BackColor = Color.LightPink;
                    }
                    else
                    {
                        currencyValueTxt.BackColor = Color.LightGreen;
                    }
                    CurrencyTitle.Text = wpp.title;
                    currencyValueTxt.Text = wpp.value.ToString("N");
                    lastUpdateTimeTxt.Text = DateTime.Now.ToString("hh:mm:ss");
                }
                catch (Exception hata)
                {
                    Console.WriteLine(hata);
                }
            }
        }


        private void PlaySound()
        {
            Helpers.Helper.sound.Play();
            this.Show();
        }

        private void SetText(string text)
        {
            if (this.currencyValueTxt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.currencyValueTxt.Text = text;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (state != State.Started)
            {


                if (currencyComboBox.Text.Length > 0)
                {
                    ur = new Uri(instruments.Where(x=> x.Name == currencyComboBox.Text).LastOrDefault().LinkString);
                }
                else
                {
                    MessageBox.Show("Please select an instrument from the list. If the desired instrument is not available, it can be added using the 'Add' button.");
                    state = State.Idle;
                    return;
                }

                state = State.Started;
                ((Button)sender).Text = "Stop";
                currencyValueTxt.BackColor = Color.LightYellow;

                if ((maxValueTxt.Text.Length < 1) && (minValueTxt.Text.Length < 1))
                {
                    maxTarget = -1;
                    minTarget = -1;
                }
                else if (maxValueTxt.Text.Length < 1)
                {
                    maxTarget = -1;
                    float.TryParse(minValueTxt.Text, out minTarget);

                }
                else if (minValueTxt.Text.Length < 1)
                {
                    float.TryParse(maxValueTxt.Text, out maxTarget);
                    minTarget = -1;

                }
                else
                {
                    float.TryParse(maxValueTxt.Text, out maxTarget);

                    float.TryParse(minValueTxt.Text, out minTarget);

                }

                Task.Run(() =>
                {

                    while (state == State.Started)
                    {
                        StartButton.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                if (webView21 != null && webView21.CoreWebView2 != null)
                                {
                                    webView21.CoreWebView2.Navigate(ur.ToString());
                                }
                            }
                            catch (Exception ec)
                            {

                                Console.WriteLine(ec.Message);
                            }
                        }));
                        Thread.Sleep(10000);
                    }
                });
            }
            else
            {
                
                state = State.Idle;
                ((Button)sender).Text = "Start";
                currencyValueTxt.Text = "000.000";
                currencyValueTxt.BackColor = Color.LightYellow;
                groupBox2.Enabled = true;
                groupBox1.Enabled = true;
                Helpers.Helper.sound.Stop();
            }
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            if (state == State.Started)
            {
                state = State.Idle;
                ((Button)sender).Text = "Start";
                currencyValueTxt.Text = "000.000";
                currencyValueTxt.BackColor = Color.LightYellow;
                groupBox2.Enabled = true;
                groupBox1.Enabled = true;
            }
            Helpers.Helper.sound.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewInstrumentForm newInstrumentForm = new NewInstrumentForm(this);
            newInstrumentForm.StartPosition = FormStartPosition.CenterParent;
            newInstrumentForm.ShowDialog();
        }

    }
}