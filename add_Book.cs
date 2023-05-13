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
    public partial class add_Book : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-S6TP83P\MSSQLSERVER2019;Initial Catalog=Library;Integrated Security=True");
        public add_Book()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = textBox2.Text;
            string publisher = textBox3.Text;
            int year_of_publication = int.Parse(textBox4.Text);
            int number_of_pages = int.Parse(textBox5.Text);
            string literary_direction = textBox6.Text;
            string genre = textBox7.Text;
            string original_language = textBox8.Text;

            sqlConnection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Books (Title, Author, Publisher, Year_of_publication, Number_of_pages, Literary_direction, Genre, Original_language) " +
                "VALUES (@Title, @Author, @Publisher, @Year_of_publication, @Number_of_pages, @Literary_direction, @Genre, @Original_language); SELECT SCOPE_IDENTITY();", sqlConnection);

            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Author", author);
            command.Parameters.AddWithValue("@Publisher", publisher);
            command.Parameters.AddWithValue("@Year_of_publication", year_of_publication);
            command.Parameters.AddWithValue("@Number_of_pages", number_of_pages);
            command.Parameters.AddWithValue("@Literary_direction", literary_direction);
            command.Parameters.AddWithValue("@Genre", genre);
            command.Parameters.AddWithValue("@Original_language", original_language);

            int rowsAffected = command.ExecuteNonQuery();
            sqlConnection.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Запис успішно створено в таблиці \"Книги\".", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BooksForm form1 = new BooksForm();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Помилка при створенні запису в таблиці \"Книги\". ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
