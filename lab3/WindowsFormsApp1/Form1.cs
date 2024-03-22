using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;
        private void PopulateDataGridView()
        {
            SqlDataAdapter daFac1 = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            DataTable dtFac = new DataTable();
            daFac1.Fill(dtFac);
            dataGridView1.DataSource = dtFac;
        }
        private void ListBox_Fill()
        {
            dsUniv.Clear();
            dsFac.Clear();
            listBox_Univ.Items.Clear();

            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");

            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");

            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name);
            }
        }
        public Form1()
        {
            InitializeComponent();
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; 
AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True";

            myCon.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name);

            }
            myCon.Close();
        }

        private void listBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Fac.Items.Clear();
            textBox_City.Clear();
            int code = 0;
            String UnivSelected = listBox_Univ.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    textBox_City.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBox_CodeUniv.Text = code.ToString();
                }
            }

            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {

                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBox_Fac.Items.Add(nameFac);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Facultati' table. You can move, or remove it, as needed.
            this.facultatiTableAdapter.Fill(this.database2DataSet.Facultati);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection myCon = new SqlConnection())
                {

                    myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; 
AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True";
                    myCon.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Universitati (Id, NameUniv, City) VALUES (@Id, @Name, @City)", myCon);
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBox_IdUniv.Text);
                    command.Parameters.Add("@Name", SqlDbType.Text).Value = textBox_NameUniv.Text;
                    command.Parameters.Add("@City", SqlDbType.Text).Value = textBox_City.Text;
                    command.ExecuteNonQuery();

                    ListBox_Fill();
                    textBox_IdUniv.Clear();
                    textBox_NameUniv.Clear();
                    textBox_City.Clear();
                    textBox_CodeUniv.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("UPDATE Universitati SET NameUniv = @Name, City = @City, Id=@Id WHERE Code=@Code", myCon);
                command.Parameters.Add("@Name", SqlDbType.Text).Value = textBox_NameUniv.Text;
                command.Parameters.Add("@City", SqlDbType.Text).Value = textBox_City.Text;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBox_IdUniv.Text);
                command.Parameters.Add("@Code", SqlDbType.Int).Value = int.Parse(textBox_CodeUniv.Text);
                command.ExecuteNonQuery();

                ListBox_Fill();
                textBox_IdUniv.Clear();
                textBox_NameUniv.Clear();
                textBox_City.Clear();
                textBox_CodeUniv.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            myCon.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("SELECT COUNT(*) FROM Facultati WHERE Code = @Code", myCon);
                command1.Parameters.Add("@Code", SqlDbType.Int).Value = Convert.ToInt32(textBox_CodeUniv.Text);
                int n = Convert.ToInt32(command1.ExecuteScalar());
                if (n == 0)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM Universitati WHERE Code=@Code", myCon);
                    command.Parameters.Add("@Code", SqlDbType.Int).Value = Convert.ToInt32(textBox_CodeUniv.Text);
                    command.ExecuteNonQuery();

                    ListBox_Fill();
                    textBox_IdUniv.Clear();
                    textBox_NameUniv.Clear();
                    textBox_City.Clear();
                    textBox_CodeUniv.Clear();
                }
                else
                {
                    MessageBox.Show("Universitatea are facultati");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                myCon.Open();
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells["Column1"].Value == DBNull.Value) //insert
                {
                    SqlCommand sqlcom1 = new SqlCommand("InsertFac", myCon);
                    sqlcom1.CommandType = CommandType.StoredProcedure;
                    sqlcom1.Parameters.AddWithValue("@Code", Convert.ToInt32(row.Cells["Column2"].Value == DBNull.Value ?
                        "1" : row.Cells["Column2"].Value.ToString()));
                    sqlcom1.Parameters.AddWithValue("@NameFac", row.Cells["Column3"].Value == DBNull.Value ?
                        "" : row.Cells["Column3"].Value.ToString());
                    sqlcom1.ExecuteNonQuery();
                    PopulateDataGridView();
                }
                else //update
                {
                    SqlCommand sqlcom2 = new SqlCommand("UpdateFac", myCon);
                    sqlcom2.CommandType = CommandType.StoredProcedure;
                    sqlcom2.Parameters.AddWithValue("@Id", Convert.ToInt32(row.Cells["Column1"].Value == DBNull.Value ?
                        "0" : row.Cells["Column1"].Value.ToString()));
                    sqlcom2.Parameters.AddWithValue("@Code", Convert.ToInt32(row.Cells["Column2"].Value == DBNull.Value ?
                        "0" : row.Cells["Column2"].Value.ToString()));
                    sqlcom2.Parameters.AddWithValue("@NameFac", row.Cells["Column3"].Value == DBNull.Value ?
                        "" : row.Cells["Column3"].Value.ToString());
                    sqlcom2.ExecuteNonQuery();
                }
                myCon.Close();
            }
        }



        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["Column1"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Doriti sa stergeti linia?", "Stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    myCon.Open();
                    SqlCommand sqlcom = new SqlCommand("DeleteFac", myCon);
                    sqlcom.CommandType = CommandType.StoredProcedure;
                    sqlcom.Parameters.AddWithValue("@Id", Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value));
                    sqlcom.ExecuteNonQuery();
                    myCon.Close();
                }
                else e.Cancel = true;
            }
            else e.Cancel = true;
        }
    }
}