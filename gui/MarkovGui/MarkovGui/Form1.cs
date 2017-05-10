using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkovGui
{
    public partial class Form1 : Form
    {

        private MarkovApiService _api = new MarkovApiService();

        public Form1()
        {
            InitializeComponent();
        }

        private void SendButtonClick(object sender, EventArgs e)
        {
            int maxLength = 100;
            try
            {
                maxLength = Convert.ToInt32(maxLengthTb.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter the max length");
                return;
            }
            string text = richTextBox1.Text;
            foreach (string path in fileDataSet.Items)
            {
                using (StreamReader stream = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    text += stream.ReadToEnd();
                }
            }
            try
            {
                text = text.Replace("\n", " ");
                text += " ";
                string response = _api.SendRequest(maxLength, text);
                statusLabel.Text = "OK";
                respLengthLabel.Text = response.Length.ToString();
                richTextBox2.Text = response;
            }
            catch (WebException ex)
            {
                statusLabel.Text = "FAILED";
                MessageBox.Show("Server is not available" + ex.StackTrace + ex.Message + ex.ToString());
            }
        }

        private void addFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileDataSet.Items.Add(fileDialog.FileName);
            }
        }

        private void removeFileBtn_Click(object sender, EventArgs e)
        {
            fileDataSet.Items.Remove(fileDataSet.SelectedItem);
        }
    }
}
