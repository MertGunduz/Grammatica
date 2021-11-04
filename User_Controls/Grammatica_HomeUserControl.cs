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
                ShowTable();
            }
        }

        private void EnglishWord_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (EnglishWord_TextBox.Text == "  English Word:")
            {
                EnglishWord_TextBox.Clear();
            }
        }

        private void WordSynonym_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (WordSynonym_TextBox.Text == "  Word Synonym:")
            {
                WordSynonym_TextBox.Clear();
            }
        }

        private void WordOpposite_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (WordOpposite_TextBox.Text == "  Word Opposite:")
            {
                WordOpposite_TextBox.Clear();
            }
        }

        private void WordSentenceExample_RichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (WordSentenceExample_RichTextBox.Text == "  Word Sentence Example:")
            {
                WordSentenceExample_RichTextBox.Clear();
            }
        }

        private void TranslatedWord_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (TranslatedWord_TextBox.Text == "  Translated Word:")
            {
                TranslatedWord_TextBox.Clear();
            }
        }

        private void AddWordToDatabase_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL CONNECTION OPEN
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                // SQL QUERY
                SqlCommand insertWordCommand = new SqlCommand("Insert Into Word_Table (Word_English, Word_Synonym, Word_Opposite, Word_Sentence, Word_YourLanguage) Values (@p1, @p2, @p3, @p4, @p5)", sqlConnection);

                // PARAMETERS & OBJECTS
                insertWordCommand.Parameters.AddWithValue("@p1", EnglishWord_TextBox.Text);
                insertWordCommand.Parameters.AddWithValue("@p2", WordSynonym_TextBox.Text);
                insertWordCommand.Parameters.AddWithValue("@p3", WordOpposite_TextBox.Text);
                insertWordCommand.Parameters.AddWithValue("@p4", WordSentenceExample_RichTextBox.Text);
                insertWordCommand.Parameters.AddWithValue("@p5", TranslatedWord_TextBox.Text);

                // EXECUTE QUERY
                insertWordCommand.ExecuteNonQuery();

                // SQL CONNECTION CLOSE
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

                // SHOWS TABLE AFTER INSERTING DATA 
                ShowTable();
            }
            catch (Exception exception)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

                MessageBox.Show(exception.Message + "\n" + exception.Data.ToString(), "Information - Exception Handled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowTable()
        {
            try
            {
                // DATABASE INITIALIZATION
                sqlConnection = new SqlConnection(Classes.Database.databaseConnectionString);

                // OPEN SQL SERVER CONNECTION
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

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
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            catch (Exception exception)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

                MessageBox.Show(exception.Message + "\n" + exception.Data.ToString(), "Information - Exception Handled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}