using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Form1 : Form
    {
        private List<string> contacts;

        public Form1()
        {
            InitializeComponent(); // This line is necessary to initialize the form components
            contacts = new List<string>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Contact Manager App!");
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            string newContact = contactTextBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(newContact))
            {
                contacts.Add(newContact);
                RefreshContactsListBox();
                contactTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Introduceți un nume de contact valid.");
            }
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedIndex != -1)
            {
                contacts.RemoveAt(contactsListBox.SelectedIndex);
                RefreshContactsListBox();
            }
            else
            {
                MessageBox.Show("Selectați un contact de șters.");
            }
        }

        private void SortContactsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = sortContactsComboBox.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Alfabetic":
                    contacts.Sort();
                    break;
                case "Invers alfabetic":
                    contacts.Sort();
                    contacts.Reverse();
                    break;
                default:
                    break;
            }
            RefreshContactsListBox();
        }

        private void RefreshContactsListBox()
        {
            contactsListBox.Items.Clear();
            foreach (string contact in contacts)
            {
                contactsListBox.Items.Add(contact);
            }
        }

       

        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button removeContactButton;
        private System.Windows.Forms.ComboBox sortContactsComboBox;
        private System.Windows.Forms.ListBox contactsListBox;

        private void contactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedContact = contactsListBox.SelectedItem as string;
            if (selectedContact != null)
    {
        MessageBox.Show($"Selected contact: {selectedContact}");
    }
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {
            addContactButton.Enabled = !string.IsNullOrWhiteSpace(contactTextBox.Text);
        }
    }
}
