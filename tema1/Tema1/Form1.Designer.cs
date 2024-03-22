using System;
using System.Windows.Forms;

namespace Tema1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addContactButton = new System.Windows.Forms.Button();
            this.removeContactButton = new System.Windows.Forms.Button();
            this.sortContactsComboBox = new System.Windows.Forms.ComboBox();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(100, 52);
            this.contactTextBox.Multiline = true;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(200, 22);
            this.contactTextBox.TabIndex = 0;
            this.contactTextBox.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(100, 80);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(100, 23);
            this.addContactButton.TabIndex = 1;
            this.addContactButton.Text = "Add Contact";
            this.addContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // removeContactButton
            // 
            this.removeContactButton.Location = new System.Drawing.Point(210, 80);
            this.removeContactButton.Name = "removeContactButton";
            this.removeContactButton.Size = new System.Drawing.Size(150, 23);
            this.removeContactButton.TabIndex = 2;
            this.removeContactButton.Text = "Remove Selected";
            this.removeContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            // 
            // sortContactsComboBox
            // 
            this.sortContactsComboBox.Items.AddRange(new object[] {
            "Alfabetic",
            "Invers alfabetic"});
            this.sortContactsComboBox.Location = new System.Drawing.Point(100, 120);
            this.sortContactsComboBox.Name = "sortContactsComboBox";
            this.sortContactsComboBox.Size = new System.Drawing.Size(150, 24);
            this.sortContactsComboBox.TabIndex = 3;
            this.sortContactsComboBox.SelectedIndexChanged += new System.EventHandler(this.SortContactsComboBox_SelectedIndexChanged);
            // 
            // contactsListBox
            // 
            this.contactsListBox.ItemHeight = 16;
            this.contactsListBox.Location = new System.Drawing.Point(100, 150);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(200, 196);
            this.contactsListBox.TabIndex = 4;
            this.contactsListBox.SelectedIndexChanged += new System.EventHandler(this.contactsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.removeContactButton);
            this.Controls.Add(this.sortContactsComboBox);
            this.Controls.Add(this.contactsListBox);
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }


        }

        #endregion
    }

