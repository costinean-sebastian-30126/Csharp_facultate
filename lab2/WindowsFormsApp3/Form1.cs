using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.menuStrip1 = new MenuStrip();
            this.adunareToolStripMenuItem = new ToolStripMenuItem();
            this.scadereToolStripMenuItem = new ToolStripMenuItem();
            this.inmultireToolStripMenuItem = new ToolStripMenuItem();
            this.impartireToolStripMenuItem = new ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.adunareToolStripMenuItem,
            this.scadereToolStripMenuItem,
            this.inmultireToolStripMenuItem,
            this.impartireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adunareToolStripMenuItem
            // 
            this.adunareToolStripMenuItem.Name = "adunareToolStripMenuItem";
            this.adunareToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.adunareToolStripMenuItem.Text = "Adunare";
            this.adunareToolStripMenuItem.Click += new System.EventHandler(this.adunareToolStripMenuItem_Click);
            // 
            // scadereToolStripMenuItem
            // 
            this.scadereToolStripMenuItem.Name = "scadereToolStripMenuItem";
            this.scadereToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.scadereToolStripMenuItem.Text = "Scadere";
            this.scadereToolStripMenuItem.Click += new System.EventHandler(this.scadereToolStripMenuItem_Click);
            // 
            // inmultireToolStripMenuItem
            // 
            this.inmultireToolStripMenuItem.Name = "inmultireToolStripMenuItem";
            this.inmultireToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.inmultireToolStripMenuItem.Text = "Inmultire";
            this.inmultireToolStripMenuItem.Click += new System.EventHandler(this.inmultireToolStripMenuItem_Click);
            // 
            // impartireToolStripMenuItem
            // 
            this.impartireToolStripMenuItem.Name = "impartireToolStripMenuItem";
            this.impartireToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.impartireToolStripMenuItem.Text = "Impartire";
            this.impartireToolStripMenuItem.Click += new System.EventHandler(this.impartireToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void adunareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate('+');
        }

        private void scadereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate('-');
        }

        private void inmultireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate('*');
        }

        private void impartireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate('/');
        }

        private void Calculate(char operation)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                switch (operation)
                {
                    case '+':
                        textBox3.Text = (num1 + num2).ToString();
                        break;
                    case '-':
                        textBox3.Text = (num1 - num2).ToString();
                        break;
                    case '*':
                        textBox3.Text = (num1 * num2).ToString();
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            textBox3.Text = (num1 / num2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Nu se poate împărți la zero.");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Introduceți numere valide în câmpurile de intrare.");
            }
        }

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adunareToolStripMenuItem;
        private ToolStripMenuItem scadereToolStripMenuItem;
        private ToolStripMenuItem inmultireToolStripMenuItem;
        private ToolStripMenuItem impartireToolStripMenuItem;
    }
}
