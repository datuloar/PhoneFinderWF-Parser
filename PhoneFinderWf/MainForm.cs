using Potapov.PhoneFinder.PhoneFinderLib.Services.Parsers;
using Potapov.PhoneFinder.PhoneFinderLib.Services.Parsers.Neberitrubku;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Potapov.PhoneFinder.PhoneFinderWf
{
    public partial class MainForm : MetroForm
    {
        private ParserWorker<NeberitrubkuPage> _neberitrubkuParser;

        public MainForm()
        {
            InitializeComponent();
            _neberitrubkuParser = new ParserWorker<NeberitrubkuPage>(
                new NeberitrubkuParser());
        }

        private void SyncParser()
        {
            try
            {
                FillSettingsForParsing();
                FillAboutNumberLabels();
                FillReviews();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error {exception.Message}");
                metroProgressBar1.Value = 0;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            metroProgressBar1.Value = 0;

            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    SyncParser();                   
                }));
            });

        }

        private void FillSettingsForParsing()
        {
            var number = UserInputNumber.Text;

            if (IsNumberValide(number))
            {
                _neberitrubkuParser.Settings = new NeberitrubkuSettings(number);
            }
            else
            {
                throw new ArgumentException("The phone number contains an error or the string is empty");
            }

            metroProgressBar1.Value++;
        }

        private bool IsNumberValide(string number)
        {
            return number != string.Empty && number.Length == 11;
        }

        private void FillAboutNumberLabels()
        {
            var aboutNumber = _neberitrubkuParser.GetParsedPage().AboutNumber.Trim();
            label1.Text = aboutNumber;

            metroProgressBar1.Value++;
        }

        private void FillReviews()
        {
            richTextBox1.Clear();

            var reviews = _neberitrubkuParser.GetParsedPage().Reviews;

            foreach (var review in reviews)
            {
                richTextBox1.Text += $"\nТип звонка: {review.CallType.Trim()} \n" +
                    $"Комментарий {review.Comment.Trim()} \n ";
            }

            metroProgressBar1.Value++;
        }
    }
}
