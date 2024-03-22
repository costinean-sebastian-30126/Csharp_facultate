using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1: Form
    {
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;

        public Form1()
        {
            InitializeComponent();
        }

      
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implementați logica pentru afișarea imaginii corespunzătoare numelui selectat din listă
            string selectedItem = listBox.SelectedItem.ToString();
            MessageBox.Show("Imaginea pentru " + selectedItem);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Implementați logica pentru afișarea rezultatului într-un MessageBox
            RadioButton selectedRadioButton1 = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton selectedRadioButton2 = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (selectedRadioButton1 != null && selectedRadioButton2 != null)
            {
                string result = selectedRadioButton1.Text + " " + selectedRadioButton2.Text;
                MessageBox.Show("Rezultat: " + result);
            }
        }
    }
}
