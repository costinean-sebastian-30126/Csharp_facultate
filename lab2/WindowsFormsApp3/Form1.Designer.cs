using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    partial class MainForm : Form
    {
        // Declarațiile de controale UI
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;

        // Constructorul formularului
        public MainForm()
        {
            InitializeComponent();
        }

        // Metoda de inițializare a componentelor formularului
        private void InitializeComponent()
        {
            // Configurare proprietăți pentru formular
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Calculator App";

            // Inițializare controale UI
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();

            // Configurare proprietăți pentru controale
            this.textBox1.Location = new System.Drawing.Point(120, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;

            this.textBox2.Location = new System.Drawing.Point(495, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;

            this.button1.Location = new System.Drawing.Point(120, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adunare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addButton_Click);

            this.button2.Location = new System.Drawing.Point(495, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Scădere";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.subtractButton_Click);

            this.textBox3.Location = new System.Drawing.Point(688, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;

            // Adăugare controale în formular
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);

            // Adăugare eveniment pentru încărcarea formularului
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Eveniment pentru încărcarea formularului
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Codul care se execută la încărcarea formularului
            // Aici puteți adăuga cod pentru inițializarea aplicației
        }

        // Metoda pentru adunare
        private void addButton_Click(object sender, EventArgs e)
        {
            // Verificăm dacă cele două TextBox-uri pentru numere conțin valori valide
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                // Calculăm suma și o afișăm în al treilea TextBox
                double result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Introduceți numere valide în câmpurile de intrare.");
            }
        }

        // Metoda pentru scădere
        private void subtractButton_Click(object sender, EventArgs e)
        {
            // Verificăm dacă cele două TextBox-uri pentru numere conțin valori valide
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                // Calculăm diferența și o afișăm în al treilea TextBox
                double result = num1 - num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Introduceți numere valide în câmpurile de intrare.");
            }
        }
    }
}
