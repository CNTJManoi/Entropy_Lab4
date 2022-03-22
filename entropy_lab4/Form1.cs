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
            GeneralClear();
        }
        private void GeneralClear()
        {
            EnsembleData.Rows.Clear();
            PowerBox.Clear();
            EntropyBox.Clear();
            MaxEntropyBox.Clear();
            EnoughBox.Clear();
            digramsData.Rows.Clear();
            H1Box.Clear();
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            GeneralClear();
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
            for (int i = 0; i < messageNotDuplicate.Length; i++)
            {
                for (int j = 0; j < messageNotDuplicate.Length; j++)
                {
                    digrams.Add(messageNotDuplicate[i] + "" + messageNotDuplicate[j]);
                }
            }
            Queue<float> pDigram = new Queue<float>();
            for (int i = 0; i < digrams.Count; i++)
            {
                int countDigram = 0;
                for (int j = 0; j < message.Length - 1; j++)
                {
                    if (message[j] + "" + message[j + 1] == digrams[i]) countDigram++;
                }
                float p = (float)countDigram / (message.Length - 1);
                digramsData.Rows.Add(digrams[i], p);
                pDigram.Enqueue(p);
            }
            float H1 = 0;
            for (int i = 0; i < messageNotDuplicate.Length; i++)
            {
                float sum = 0;
                for (int j = 0; j < messageNotDuplicate.Length; j++)
                {
                    float p = pDigram.Dequeue();
                    if (p != 0) sum += p * (float)Math.Log(p, 2);
                }
                H1 += sum * float.Parse(EnsembleData.Rows[i].Cells[1].Value.ToString());
            }
            H1Box.Text = (H1 * -1).ToString();
        }
    }
}
