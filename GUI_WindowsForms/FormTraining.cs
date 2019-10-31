using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Library;

namespace GUI_WindowsForms
{
    public partial class FormTraining : Form, IAppForm
    {
        public FormTraining()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> Vocabulary { get; private set; }
        public string VocabularyPath { get; private set; }

        private KeyValuePair<string, string> _currentPair;
        private Random _rand;
        private int _iteration;
        private int _correct;

        private void FormTraining_Load(object sender, EventArgs e)
        {
            var menu = new MainMenu();
            var col = new ContextMenu.MenuItemCollection(menu);
            var vocab = new MenuItem("Słownik");
            vocab.MenuItems.Add("Wybierz", vocab_Select);
            vocab.MenuItems.Add("Zobacz", vocab_Show);
            vocab.MenuItems.Add("Dodaj słowo", vocab_AddWord);
            col.Add(vocab);
            Menu = menu;
        }
        private void btnStartTraining_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VocabularyPath))
            {
                MessageBox.Show("Nie wybrano słownika. Wejdź w Słownik\\Wybierz aby wybrać słownik", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _iteration = 0;
                _correct = 0;
                _rand = new Random();
                btnNext.Enabled = true;
                lblCorrect.Text = "Poprawność: 100%";
                Next();
            }
        }
        private void vocab_Select(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                VocabularyPath = d.FileName;
                lblVocPath.Text = VocabularyPath;
                Vocabulary = new Dictionary<string, string>();
                IEnumerable<string> data = File.ReadLines(VocabularyPath);
                foreach (string pair in data)
                {
                    if (string.IsNullOrWhiteSpace(pair))
                    {
                        continue;
                    }
                    string[] words = pair.Split(';');
                    Vocabulary.Add(words[0], words[1]);
                }
            }
        }
        private void vocab_AddWord(object sender, EventArgs e)
        {
            FormAddWord form = new FormAddWord(VocabularyPath);
            form.Show();
        }
        private void vocab_Show(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
                if (sw.BaseStream.CanWrite) { sw.WriteLine($"notepad.exe {VocabularyPath}"); }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            _iteration++;
            if (_iteration > (int)nudTrainingIterations.Value)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(VocabularyPath))
            {
                MessageBox.Show("Nie wybrano słownika. Wejdź w Słownik\\Wybierz aby wybrać słownik", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDE.Text == _currentPair.Value)
            {
                _correct++;
            }
            lblCorrect.Text = $"Poprawność {(float)_correct/_iteration*100}%";
            lblLast.Text = "Ostatni: " + _currentPair.Value;
            Next();
        }
        private void Next()
        {
            _currentPair = Vocabulary.ElementAt(_rand.Next(0, Vocabulary.Count));
            if (_iteration == (int)nudTrainingIterations.Value)
            {
                lblCorrect.Text += " [KONIEC]";
                btnNext.Enabled = false;
                return;
            }
            lblPL.Text = $"[PL]: {_currentPair.Key}";
        }
        private void btnLetter_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDE.Text += btn.Text;
        }
    }
}
