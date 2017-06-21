using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamDBMS
{
    public partial class Form1 : Form
    {
        private static string connectionString = "Data Source = ALY-LAPTOP\\SQLEXPRESS;  Initial Catalog = examDBMS; Integrated Security = TRUE";
        private SqlDataAdapter parentsDataAdapter = new SqlDataAdapter();
        private SqlDataAdapter childrenDataAdapter = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
            this.Text = "COMPANIES AND GAMES";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDataParents("select * from company");

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            childrenDataAdapter.Update((DataTable)gameBindingSource.DataSource);
        }

        private void childrenGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void parentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = parentGrid.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = parentGrid.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells["id"].Value);



            string sqlPopulateChildren = "select * from game where companyID =" + a;

            GetDataChildren(sqlPopulateChildren);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = childrenGrid.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = childrenGrid.Rows[selectedrowindex];


            string a = Convert.ToString(selectedRow.Cells["idGame"].Value);

            string sqlDeleteChild = "delete from game where id = " + a;


            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            childrenDataAdapter.DeleteCommand = connection.CreateCommand();
            childrenDataAdapter.DeleteCommand.CommandText = sqlDeleteChild;
            childrenDataAdapter.DeleteCommand.ExecuteNonQuery();
            connection.Close();


            string b = Convert.ToString(selectedRow.Cells["companyID"].Value);
            string sqlPopulateChildren = "select * from game where companyID =" + b;

            GetDataChildren(sqlPopulateChildren);
        }

        private void updateGame_Click(object sender, EventArgs e)
        {
            childrenDataAdapter.Update((DataTable)gameBindingSource.DataSource);
        }


        private void GetDataParents(string selectCommand)
        {
            try
            {

                // Create a new data adapter based on the specified query.
                parentsDataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(parentsDataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                parentsDataAdapter.Fill(table);
                companyBindingSource.DataSource = table;
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void GetDataChildren(string selectCommand)
        {
            try
            {

                // Create a new data adapter based on the specified query.
                childrenDataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(childrenDataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                childrenDataAdapter.Fill(table);
                gameBindingSource.DataSource = table;

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
    }
}
