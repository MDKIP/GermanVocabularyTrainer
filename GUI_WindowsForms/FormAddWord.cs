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

namespace GUI_WindowsForms
{
    public partial class FormAddWord : Form
    {
        public FormAddWord(string path)
        {
            InitializeComponent();
            
            _path = path;
            lblPath.Text = "Ścieżka słownika: " + _path;
        }

        private string _path;

        private void btnChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                _path = d.FileName;
                lblPath.Text = "Ścieżka słownika: " + _path;
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_path) || Uri.IsWellFormedUriString(_path, UriKind.RelativeOrAbsolute) || !File.Exists(_path))
            {
                MessageBox.Show("Podano nieprawidłową ścieżkę", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (File.ReadAllLines(_path).Length != 0)
            {
                File.AppendAllText(_path, $"\n{txtPLVal.Text};{txtDEVal.Text}");
            }
            else
            {
                File.AppendAllText(_path, $"{txtPLVal.Text};{txtDEVal.Text}");
            }
            
            Close();
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDEVal.Text += btn.Text;
        }
    }
}
