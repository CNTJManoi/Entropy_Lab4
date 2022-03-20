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
        }
    }
}
