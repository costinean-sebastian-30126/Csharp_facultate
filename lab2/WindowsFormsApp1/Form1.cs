using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;

        public Form1()
        {
            InitializeComponent1();
        }

        private void InitializeComponent1()
        {
            this.usernameTextBox = new TextBox();
            this.passwordTextBox = new TextBox();
            this.loginButton = new Button();

            // Configurați proprietățile controalelor
            this.SuspendLayout();

            this.usernameTextBox.Location = new System.Drawing.Point(50, 50);
            this.usernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.usernameTextBox);

            this.passwordTextBox.Location = new System.Drawing.Point(50, 100);
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.PasswordChar = '*';
            this.Controls.Add(this.passwordTextBox);

            this.loginButton.Location = new System.Drawing.Point(100, 150);
            this.loginButton.Text = "Login";
            this.loginButton.Click += new EventHandler(loginButton_Click);
            this.Controls.Add(this.loginButton);

            this.ResumeLayout(false);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Verificați dacă utilizatorul și parola sunt corecte citind dintr-un fișier
            string[] lines = File.ReadAllLines("users.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                {
                    Form2 form2 = new Form2(username);
                    form2.Show();
                    return;
                }
            }

            MessageBox.Show("Utilizator sau parolă incorectă.");
        }

    }

    public partial class Form2 : Form
    {
        private Label helloLabel;
        private Button exitButton;

        public Form2(string username)
        {
            InitializeComponent2();
            helloLabel.Text = "Hello " + username;
        }

        private void InitializeComponent2()
        {
            this.helloLabel = new Label();
            this.exitButton = new Button();

            // Configurați proprietățile controalelor
            this.SuspendLayout();

            this.helloLabel.Location = new System.Drawing.Point(50, 50);
            this.helloLabel.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.helloLabel);

            this.exitButton.Location = new System.Drawing.Point(100, 100);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new EventHandler(exitButton_Click);
            this.Controls.Add(this.exitButton);

            this.ResumeLayout(false);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
