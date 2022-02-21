using Algorithmes;
using SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Visualization
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox1.Text, out int value))
            {
                var item = new SortedItem(value);
                items.Add(item);

                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }
            AddTextBox1.Clear();
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (int.TryParse(FillTextBox1.Text, out int value))
            {
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(random.Next(0, 100));
                    items.Add(item);

                    panel3.Controls.Add(item.ProgressBar);
                    panel3.Controls.Add(item.Label);
                }
            }
            FillTextBox1.Clear();
        }
    }
}
