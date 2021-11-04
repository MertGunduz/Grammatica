using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grammatica.User_Controls
{
    public partial class Grammatica_HomeUserControl : UserControl
    {
        SqlConnection sqlConnection;

        public Grammatica_HomeUserControl()
        {
            InitializeComponent();
        }

        private void Grammatica_HomeUserControl_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                // DATABASE INITIALIZATION
                sqlConnection = new SqlConnection(Classes.Database.databaseConnectionString);

                // OPEN SQL SERVER CONNECTION
                sqlConnection.Open();

                // SQL COMMAND
                SqlCommand readCommand = new SqlCommand("Select Word_ID As 'ID', Word_English As 'English', Word_Synonym As 'Synonym', Word_Opposite As 'Opposite', Word_Sentence As 'Sentence', Word_YourLanguage As 'Your_Language' From Word_Table", sqlConnection);

                // DATA ADAPTER
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = readCommand;

                // DATATABLE
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                // EMBEDDING THE DATA TO DATAGRIDVIEW
                Word_DataGridView.DataSource = dataTable;

                // CLOSE SQL SERVER CONNECTION
                sqlConnection.Close();
            }
        }
    }
}
