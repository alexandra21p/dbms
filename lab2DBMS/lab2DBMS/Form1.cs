using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Configuration;

namespace lab2DBMS
{
    public partial class Form1 : Form
    {
        private SqlConnection cs = new SqlConnection("Data Source = ALY-LAPTOP\\SQLEXPRESS; Initial Catalog = MusicFestivals; Integrated Security = True");
        private SqlDataAdapter daFestivals = new SqlDataAdapter();
        private SqlDataAdapter daTickets = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private DataSet ds2 = new DataSet();
        private NameValueCollection sAll = ConfigurationManager.AppSettings;
        private TextBox[] textBoxes = new TextBox[ConfigurationManager.AppSettings["childColumnNames"].Split(',').Length];
        private Label[] labels = new Label[ConfigurationManager.AppSettings["childColumnNames"].Split(',').Length];



        public Form1()
        {
            InitializeComponent();
            addTicketBtn.Hide();
            delTicketBtn.Hide();
            updateTicketBtn.Hide();
            string[] columns = sAll["childColumnNames"].Split(',');
            int columnsNr = columns.Length;
            int height = 30;
            for (int i = 0; i < columnsNr; i++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Name = columns[i] + "Txt";
                textBoxes[i].Location = new Point(480, height);
                textBoxes[i].Size = new Size(100, 20);
                textBoxes[i].Parent = this;

                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Name = columns[i] + "Lbl";
                labels[i].Text = columns[i];
                labels[i].Location = new Point(410, height);
                labels[i].Parent = this;

                textBoxes[i].Hide();
                labels[i].Hide();

                height += 30;
            }

            displayFestBtn.Text = "Display " + sAll["parentTable"];
            addTicketBtn.Text = "Add " + sAll["childTable"];
            delTicketBtn.Text = "Delete " + sAll["childTable"];
            updateTicketBtn.Text = "Update " + sAll["childTable"];
  
        }

        private void displayFestBtn_Click(object sender, EventArgs e)
        {
            daFestivals.SelectCommand = new SqlCommand("SELECT * FROM " + sAll.Get("parentTable"), cs);
            ds.Clear();
            daFestivals.Fill(ds);
            parentGrid.DataSource = ds.Tables[0];
            displayFestBtn.Hide();
        }

        private void delTicketBtn_Click(object sender, EventArgs e)
        {
            string[] cNames = sAll["childColumnNames"].Split(',');
            int selectedRowindex = childrenGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = childrenGrid.Rows[selectedRowindex];
            int id = Convert.ToInt16(selectedRow.Cells[sAll["primaryKeyChild"]].Value);
            daTickets.DeleteCommand = new SqlCommand("DELETE FROM " + sAll["childTable"] + " WHERE " + sAll["primaryKeyChild"] + " = @id", cs);
            daTickets.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cs.Open();
          
            daTickets.DeleteCommand.ExecuteNonQuery();
            daTickets.SelectCommand.ExecuteNonQuery();
            ds2.Clear();
            daTickets.Fill(ds2);
            cs.Close();
        }

        private void updateTicketBtn_Click(object sender, EventArgs e)
        {
            string[] cNames = sAll["childColumnNames"].Split(',');
            int selectedRowindex = childrenGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = childrenGrid.Rows[selectedRowindex];
            int id = Convert.ToInt16(selectedRow.Cells[sAll["primaryKeyChild"]].Value);
            string statement = "UPDATE " + sAll["childTable"] + " SET ";
            for (int i = 0; i < cNames.Length; i++)
            {
                statement += cNames[i] + " = @" + cNames[i] + ", ";
            }
            statement = statement.Remove(statement.Length - 2);
            statement += " WHERE " + sAll["primaryKeyChild"] + " = " + id;
            daTickets.UpdateCommand = new SqlCommand(statement, cs);

            for (int i = 0; i < cNames.Length; i++)
            {
                daTickets.UpdateCommand.Parameters.AddWithValue("@" + cNames[i], textBoxes[i].Text);
            }

            cs.Open();
            daTickets.UpdateCommand.ExecuteNonQuery();
            daTickets.SelectCommand.ExecuteNonQuery();
            ds2.Clear();
            daTickets.Fill(ds2);
            cs.Close();
        }

        private void addTicketBtn_Click(object sender, EventArgs e)
        {
            string[] cNames = sAll["childColumnNames"].Split(',');
            int selectedRowindex = parentGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = parentGrid.Rows[selectedRowindex];
            int group = Convert.ToInt16(selectedRow.Cells[sAll["primaryKeyParent"]].Value);
            string statement = "INSERT INTO " + sAll["childTable"] + "(" + sAll["childColumnNames"] + ") VALUES(";

            for (int i = 0; i < cNames.Length; i++)
            {
                statement += "@" + cNames[i] + ", ";
            }
            statement = statement.Remove(statement.Length - 2);
            statement += ")";

            daTickets.InsertCommand = new SqlCommand(statement, cs);

            for (int i = 0; i < cNames.Length; i++)
            {
                daTickets.InsertCommand.Parameters.AddWithValue("@" + cNames[i], textBoxes[i].Text);
            }
            cs.Open();
            daTickets.InsertCommand.ExecuteNonQuery();
            daTickets.SelectCommand.ExecuteNonQuery();
            ds2.Clear();
            daTickets.Fill(ds2);
            cs.Close();
        }

        private void parentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columns = sAll["childColumnNames"].Split(',').Length;
            delTicketBtn.Hide();
            updateTicketBtn.Hide();
            for (int i = 0; i < columns; i++)
            {
                textBoxes[i].Hide();
                labels[i].Hide();
            }
            int selectedRowindex = parentGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = parentGrid.Rows[selectedRowindex];
            string group = Convert.ToString(selectedRow.Cells[sAll["primaryKeyParent"]].Value);
            daTickets.SelectCommand = new SqlCommand("SELECT * FROM " + sAll["childTable"] + " WHERE " + sAll["foreignKey"] + " = @Id", cs);
            daTickets.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = group;
            ds2.Clear();
            daTickets.Fill(ds2);
            childrenGrid.DataSource = ds2.Tables[0];

            for (int j = 0; j < columns; j++)
            {
                textBoxes[j].Show();
                labels[j].Show();
            }
            addTicketBtn.Show();
        }

        private void childrenGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] cNames = sAll["childColumnNames"].Split(',');
            int selectedRowindex = childrenGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = childrenGrid.Rows[selectedRowindex];
            for (int i = 0; i < cNames.Length; i++)
            {
                textBoxes[i].Text = Convert.ToString(selectedRow.Cells[cNames[i]].Value);
            }

            addTicketBtn.Hide();
            delTicketBtn.Show();
            updateTicketBtn.Show();
        }
    }
}
