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
    public partial class EditBookForm : Form
    {
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int yearOfPublication;
        private int numberOfPages;
        private string literaryDirection;
        private string genre;
        private string originalLanguage;

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-S6TP83P\MSSQLSERVER2019;Initial Catalog=Library;Integrated Security=True");
        public EditBookForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public EditBookForm(string title, string author, string publisher, int yearOfPublication, int numberOfPages, string literaryDirection, string genre, string originalLanguage, string isbn)
        {
            InitializeComponent();
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.yearOfPublication = yearOfPublication;
            this.numberOfPages = numberOfPages;
            this.literaryDirection = literaryDirection;
            this.genre = genre;
            this.originalLanguage = originalLanguage;
            this.isbn = isbn;

            textBoxTitle.Text = title;
            textBoxAuthor.Text = author;
            textBoxPublisher.Text = publisher;
            textBoxYearOfPub.Text = yearOfPublication.ToString();
            textBoxNumOfPag.Text = numberOfPages.ToString();
            textBoxLitDir.Text = literaryDirection;
            textBoxGenre.Text = genre;
            textBoxOrigLang.Text = originalLanguage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Books SET Title=@title, Author=@author, Publisher = @publisher, Year_of_publication = " +
                    "@yearOfPublication,Number_of_pages = @numberOfPages, Literary_direction = @literaryDirection," +
                    "Genre = @genre, Original_language = @originalLanguage WHERE ISBN = @isbn", sqlConnection);

                cmd.Parameters.AddWithValue("@title", textBoxTitle.Text);
                cmd.Parameters.AddWithValue("@author", textBoxAuthor.Text);
                cmd.Parameters.AddWithValue("@publisher", textBoxPublisher.Text);
                cmd.Parameters.AddWithValue("@yearOfPublication", textBoxYearOfPub.Text);
                cmd.Parameters.AddWithValue("@numberOfPages", textBoxNumOfPag.Text);
                cmd.Parameters.AddWithValue("@literaryDirection", textBoxLitDir.Text);
                cmd.Parameters.AddWithValue("@genre", textBoxGenre.Text);
                cmd.Parameters.AddWithValue("@originalLanguage", textBoxOrigLang.Text);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Запис успішно оновлено!");
                    this.Close(); // закриваємо форму
                }
                else
                {
                    MessageBox.Show("Помилка оновлення запису.");
                }
                sqlConnection.Close();
            }
        }
    }
}
