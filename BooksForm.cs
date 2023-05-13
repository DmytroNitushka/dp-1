using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class BooksForm : Form
    {
        DataTable dataTable = new DataTable();
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-S6TP83P\MSSQLSERVER2019;Initial Catalog=Library;Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        string command = "SELECT * FROM Books";

        public BooksForm()
        {
            InitializeComponent();
            sqlDataAdapter.SelectCommand = new SqlCommand(command, sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void refreshDgv()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(command, sqlConnection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
            }
            searchbox.Text = string.Empty;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                string title = dataGridView.SelectedCells[0].OwningRow.Cells["Title"].Value.ToString();

                sqlConnection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Books WHERE Title = @Title", sqlConnection);
                command.Parameters.AddWithValue("@Title", title);

                int result = command.ExecuteNonQuery();

                sqlConnection.Close();
                if (result > 0)
                {
                    MessageBox.Show("Запис успішно видалено.", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Помилка при видаленні запису.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                refreshDgv();
            }
            else
            {
                MessageBox.Show("Запис для видалення не вибрано!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_Book add_Book = new add_Book();
            add_Book.Show();
            this.Hide();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Отримати вибрану книгу з DataGridView
                string isbn = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                // Отримати книгу з бази даних
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE ISBN=@isbn", sqlConnection);
                command.Parameters.AddWithValue("@isbn", isbn);

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string title = reader["Title"].ToString();
                string author = reader["Author"].ToString();
                string publisher = reader["Publisher"].ToString();
                int yearOfPublication = (int)reader["Year_of_publication"];
                int numberOfPages = (int)reader["Number_of_pages"];
                string literaryDirection = reader["Literary_direction"].ToString();
                string genre = reader["Genre"].ToString();
                string originalLanguage = reader["Original_language"].ToString();
                sqlConnection.Close();

                // Відкрити форму редагування з заповненими полями
                EditBookForm editForm = new EditBookForm(title, author, publisher, yearOfPublication, numberOfPages, literaryDirection, genre, originalLanguage, isbn);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Виберіть рядок для редагування.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.Columns["Title"].HeaderText = "Назва";
            dataGridView.Columns["Author"].HeaderText = "Автор";
            dataGridView.Columns["Publisher"].HeaderText = "Видавництво";
            dataGridView.Columns["Year_of_publication"].HeaderText = "Рік видання";
            dataGridView.Columns["Number_of_pages"].HeaderText = "Кількість сторінок";
            dataGridView.Columns["Literary_direction"].HeaderText = "Літературний напрям";
            dataGridView.Columns["Genre"].HeaderText = "Жанр";
            dataGridView.Columns["Original_language"].HeaderText = "Мова оригіналу";
            dataGridView.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView.Columns["Reservation"].HeaderText = "Резервація";
            dataGridView.Columns["Condition"].HeaderText = "Стан книги";

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = searchbox.Text;
            string command;
            switch (groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name)
            {
                case "all_rbtn":
                    {
                        command = "SELECT * FROM Books WHERE " +
                       "LOWER(Title) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER(Author) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER(Publisher) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER(CONVERT(varchar(4), Year_of_publication)) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER(CONVERT(varchar(10), Number_of_pages)) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER(Literary_direction) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER(Genre) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER(Original_language) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER(ISBN) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER(Reservation) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                       "LOWER([Condition]) LIKE '%' + LOWER(@searchKeyword) + '%';";
                    }
                    break;

                case "title_rbtn":
                    { command = "SELECT * FROM Books WHERE LOWER(Title) LIKE '%' + LOWER(@searchKeyword) + '%'"; }
                    break;
                case "author_rbtn":
                    { command = "SELECT * FROM Books WHERE LOWER(Author) LIKE '%' + LOWER(@searchKeyword) + '%'"; }
                    break;
                case "pub_rbtn":
                    { command = "SELECT * FROM Books WHERE LOWER(Publisher) LIKE '%' + LOWER(@searchKeyword) + '%'"; }
                    break;
                case "year_rbtn":
                    { command = "SELECT * FROM Books WHERE CONVERT(varchar(4), Year_of_publication) COLLATE Latin1_General_CI_AI LIKE '%' + @searchKeyword + '%'"; }
                    break;
                case "pages_rbtn":
                    { command = "SELECT * FROM Books WHERE CONVERT(varchar(10), Number_of_pages) COLLATE Latin1_General_CI_AI LIKE '%' + @searchKeyword + '%'"; }
                    break;
                case "litDir_rbtn":
                    { command = "SELECT * FROM Books WHERE LOWER(Literary_direction) LIKE '%' + LOWER(@searchKeyword) + '%'"; }
                    break;
                case "genre_rbtn":
                    { command = "SELECT * FROM Books WHERE LOWER(Genre) LIKE '%' + LOWER(@searchKeyword) + '%'"; }
                    break;
                case "lang_rbtn":
                    { command = "SELECT * FROM Books WHERE LOWER(Original_language) LIKE '%' + LOWER(@searchKeyword) + '%'"; }
                    break;
                default:
                    {
                        command = "SELECT * FROM Books WHERE " +
                           "LOWER(Title) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER(Author) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER(Publisher) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER(CONVERT(varchar(4), Year_of_publication)) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER(CONVERT(varchar(10), Number_of_pages)) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER(Literary_direction) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER(Genre) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER(Original_language) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER(ISBN) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER(Reservation) LIKE '%' + LOWER(@searchKeyword) + '%' OR " +
                           "LOWER([Condition]) LIKE '%' + LOWER(@searchKeyword) + '%';";
                    }
                    break;
            }

            using (SqlCommand cmd = new SqlCommand(command, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@searchKeyword", searchKeyword);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Display the results in your DataGridView
                    dataGridView.DataSource = dataTable;
                }
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            refreshDgv();
        }
    }
}
