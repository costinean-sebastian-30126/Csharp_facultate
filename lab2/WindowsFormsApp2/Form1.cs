using System;
using System.IO;
using System.Windows.Forms;

namespace ListBoxProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadItemsFromFile();
        }

        private void LoadItemsFromFile()
        {
            // Citim obiectele din fișier și le adăugăm în primul ListBox
            string[] items = File.ReadAllLines("items.txt");
            foreach (string item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Copiem obiectul selectat din primul ListBox în al doilea ListBox
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Ștergem obiectele selectate din al doilea ListBox
            while (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }
    }
}
