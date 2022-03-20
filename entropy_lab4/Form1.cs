using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entropy_lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Символ";
            column1.Width = 162;
            column1.ReadOnly = true;
            column1.Name = "symbol";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();
            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Вероятность";
            column2.Width = 162;
            column2.Name = "probability";
            column2.CellTemplate = new DataGridViewTextBoxCell();
            EnsembleData.Columns.Add(column1);
            EnsembleData.Columns.Add(column2);
            EnsembleData.AllowUserToAddRows = false;
            EnsembleData.RowHeadersVisible = false;
            var column11 = new DataGridViewColumn();
            column11.HeaderText = "Символ";
            column11.Width = 162;
            column11.ReadOnly = true;
            column11.Name = "symbol";
            column11.Frozen = true;
            column11.CellTemplate = new DataGridViewTextBoxCell();
            var column22 = new DataGridViewColumn();
            column22.HeaderText = "Вероятность";
            column22.Width = 162;
            column22.Name = "probability";
            column22.CellTemplate = new DataGridViewTextBoxCell();
            column11.HeaderText = "Биграмма";
            column22.HeaderText = "Вероятность";
            column11.Width = 125;
            column22.Width = 125;
            digramsData.Columns.Add(column11);
            digramsData.Columns.Add(column22);
            digramsData.AllowUserToAddRows = false;
            digramsData.RowHeadersVisible = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
            EnsembleData.Rows.Clear();
            PowerBox.Clear();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            string message = InputBox.Text;
            string messageNotDuplicate = new string(message.Distinct().ToArray());
            string sortMessage = string.Concat(messageNotDuplicate.OrderBy(x => x).ToList());
            PowerBox.Text = messageNotDuplicate.Length.ToString();
            EnsembleData.Rows.Clear();
            float entropy = 0;
            for (int i = 0; i < sortMessage.Length; i++)
            {
                int count = message.Where(x => x == sortMessage[i]).Count();
                EnsembleData.Rows.Add(sortMessage[i], Math.Round((double)count / message.Length,2));
                entropy += (float)Math.Round(((double)count / message.Length) * Math.Log(((double)count / message.Length), 2), 3);
            }
            entropy *= -1;
            EntropyBox.Text = entropy.ToString();
            MaxEntropyBox.Text = Math.Round(Math.Log(messageNotDuplicate.Length, 2), 3).ToString();
            EnoughBox.Text = Math.Round((float.Parse(MaxEntropyBox.Text) - float.Parse(EntropyBox.Text)), 3).ToString();
            List<string> digrams = new List<string>();
            for (int i = 0; i < message.Length - 1; i++)
            {
                digrams.Add(string.Format("{0}{1}", message[i], message[i + 1]));
            }
            digrams = digrams.Distinct().ToList();
            List<int> countDigrams = new List<int>();
            foreach (var digram in digrams)
            {
                int count = 0;
                for (int i = 0; i < message.Length - 1; i++)
                {
                    string sub = message[i] + "" + message[i+1];
                    if(sub == digram)
                    {
                        count++;
                    }
                }
                digramsData.Rows.Add(digram, count);
            }
        }
    }
}
