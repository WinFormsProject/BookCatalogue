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
using BookCatalogue.Models;
using System.Configuration;
using System.IO;

namespace BookCatalogue
{
    public partial class Form1 : Form
    {
        string conn_str;
        SqlConnection conn;
        List<Author> authors;
        List<Genre> genres;
        string imagePath;
        int authorId;
        int genreId;
        public Form1()
        {
            InitializeComponent();
            conn_str = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            conn = new SqlConnection(conn_str);
            authors = new List<Author>();
            genres = new List<Genre>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetAllAuthors", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                authors.Add(new Author()
                {
                    Id = (int)reader["Id"],
                    A_Name = reader["A_Name"].ToString()
                });
            }
            conn.Close();
            authorsList.DataSource = null;
            authorsList.DataSource = authors;
            authorsList.DisplayMember = "A_Name";
            authorsList.SelectedIndex = 0;

            conn.Open();
            cmd = new SqlCommand("GetAllGenres", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                genres.Add(new Genre()
                {
                    Id = (int)reader["Id"],
                    G_Name = reader["G_Name"].ToString()
                });
            }
            conn.Close();
            genresList.DataSource = null;
            genresList.DataSource = genres;
            genresList.DisplayMember = "G_Name";
            genresList.SelectedIndex = 0;
        }

        private void showAllBooks_Click(object sender, EventArgs e)
        {
            authorsList.SelectedIndex = -1;
            genresList.SelectedIndex = -1;
            conn.Open();
            bookTable.Items.Clear();
            SqlCommand cmd = new SqlCommand("GetAllBooks", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(new string[] { Convert.ToString(reader["Title"]),
                Convert.ToString(reader["A_Name"]), Convert.ToString(reader["G_Name"]), Convert.ToString(reader["ImagePath"]),
                Convert.ToString(reader["AuthorId"]), Convert.ToString(reader["GenreId"])});
                bookTable.Items.Add(item);
            }
            conn.Close();
        }
        private void LoadBooksByAuthors(int author_id)
        {
            genresList.SelectedIndex = -1;
            conn.Open();
            bookTable.Items.Clear();
            SqlCommand cmd = new SqlCommand("GetBooksByAuthor @authorId", conn);
            cmd.Parameters.Add("authorId", SqlDbType.Int).Value = author_id;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(new string[] { Convert.ToString(reader["Title"]),
                Convert.ToString(reader["A_Name"]), Convert.ToString(reader["G_Name"]), Convert.ToString(reader["ImagePath"]),
                Convert.ToString(reader["AuthorId"]), Convert.ToString(reader["GenreId"])});
                bookTable.Items.Add(item);
            }
            conn.Close();
        }
        private void LoadBooksByGenres(int genre_id)
        {
            authorsList.SelectedIndex = -1;
            conn.Open();
            bookTable.Items.Clear();
            SqlCommand cmd = new SqlCommand("GetBooksByGenre @genreId", conn);
            cmd.Parameters.Add("genreId", SqlDbType.Int).Value = genre_id;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(new string[] { Convert.ToString(reader["Title"]),
                Convert.ToString(reader["A_Name"]), Convert.ToString(reader["G_Name"]), Convert.ToString(reader["ImagePath"]),
                Convert.ToString(reader["AuthorId"]), Convert.ToString(reader["GenreId"])});
                bookTable.Items.Add(item);
            }
            conn.Close();      
        }

        private void authorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authorsList.SelectedIndex != -1)
            {
                var selectedAuthor = authorsList.SelectedItem as Author;
                authorId = selectedAuthor.Id;
                LoadBooksByAuthors(authorId);
            }
        }

        private void genresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genresList.SelectedIndex != -1)
            {
                var selectedGenre = genresList.SelectedItem as Genre;
                genreId = selectedGenre.Id;
                LoadBooksByGenres(genreId);
            }
        }

        private void bookTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookTitle.Text = bookTable.FocusedItem.SubItems[0].Text;
            authorName.Text = bookTable.FocusedItem.SubItems[1].Text;
            genreName.Text = bookTable.FocusedItem.SubItems[2].Text;
            imagePath = @"..\..\Images\" + bookTable.FocusedItem.SubItems[3].Text;
            bookCover.Image = Image.FromFile(imagePath);
            authorId = Convert.ToInt32(bookTable.FocusedItem.SubItems[4].Text);
            genreId = Convert.ToInt32(bookTable.FocusedItem.SubItems[5].Text);
        }
        private void ClearFields()
        {
            bookTitle.Clear();
            authorName.Clear();
            genreName.Clear();
            comboAuthor.Items.Clear();
            comboGenre.Items.Clear();
            imagePath = @"..\..\Images\BookCover.png";
            bookCover.Image = Image.FromFile(imagePath);
            authorsList.SelectedIndex = -1;
            genresList.SelectedIndex = -1;
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            ClearFields();
            MessageBox.Show("Fill all data about book and add photo for the book cover\nAfter that click 'Save book'", 
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboAuthor.Items.AddRange(authorsList.Items.Cast<Author>().ToArray());
            comboAuthor.DisplayMember = "A_Name";
            comboGenre.Items.AddRange(genresList.Items.Cast<Genre>().ToArray());
            comboGenre.DisplayMember = "G_Name";
        }
        private void SaveBook()
        {
            try
            {
                string title = bookTitle.Text;
                if (string.IsNullOrWhiteSpace(title))
                    throw new Exception("Book title has not been entered!");
                string author_name = authorName.Text;
                if (string.IsNullOrWhiteSpace(author_name))
                    throw new Exception("Author's name has not been entered!");
                string genre_name = genreName.Text;
                if (string.IsNullOrWhiteSpace(genre_name))
                    throw new Exception("Genre has not been entered!");
                if (imagePath.IndexOf("profile2") > 0)
                    throw new Exception("No cover image has been selected!");
   
                string query = "insert into Books values " +
                    "(@pTitle,@pAuthorId,@pGenreId,@pPath)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@pTitle", SqlDbType.NVarChar).Value = title;
                cmd.Parameters.Add("@pAuthorId", SqlDbType.Int).Value = authorId;
                cmd.Parameters.Add("@pGenreId", SqlDbType.Int).Value = genreId;
                cmd.Parameters.Add("@pPath", SqlDbType.NVarChar).Value = imagePath.Split("\\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Last();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Book was added succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveBook_Click(object sender, EventArgs e)
        {
            SaveBook();
        }

        private void changeCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = @"..\..\Images\" + ofd.SafeFileName;
                string path = ofd.FileName;
                if (File.Exists(imagePath))
                {
                    MessageBox.Show("A file with the same name already exists", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    File.Copy(path, imagePath);
                    bookCover.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void comboAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAuthor.SelectedIndex != -1)
            {
                var selectedAuthor = comboAuthor.SelectedItem as Author;
                authorId = selectedAuthor.Id;
            }
            authorName.Text = comboAuthor.Text;
        }

        private void comboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGenre.SelectedIndex != -1)
            {
                var selectedGenre = comboGenre.SelectedItem as Genre;
                genreId = selectedGenre.Id;
            }
            genreName.Text = comboGenre.Text;
        }
    }
}
