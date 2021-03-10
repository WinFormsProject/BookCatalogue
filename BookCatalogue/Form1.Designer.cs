
namespace BookCatalogue
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader columnHeader4;
            System.Windows.Forms.ColumnHeader columnHeader5;
            System.Windows.Forms.ColumnHeader columnHeader6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bookTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.genresList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.authorsList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboAuthor = new System.Windows.Forms.ComboBox();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.addBook = new System.Windows.Forms.Button();
            this.delBook = new System.Windows.Forms.Button();
            this.saveBook = new System.Windows.Forms.Button();
            this.genreName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.TextBox();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.showAllBooks = new System.Windows.Forms.Button();
            this.saveCover = new System.Windows.Forms.Button();
            this.changeCover = new System.Windows.Forms.Button();
            this.bookCover = new System.Windows.Forms.PictureBox();
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ImagePath";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1364, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(389, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book catalogue management system";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookCatalogue.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bookTable);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.genresList);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.authorsList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 533);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authors";
            // 
            // bookTable
            // 
            this.bookTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            columnHeader4,
            columnHeader5,
            columnHeader6});
            this.bookTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.bookTable.HideSelection = false;
            this.bookTable.Location = new System.Drawing.Point(0, 177);
            this.bookTable.Name = "bookTable";
            this.bookTable.Size = new System.Drawing.Size(543, 339);
            this.bookTable.TabIndex = 4;
            this.bookTable.UseCompatibleStateImageBehavior = false;
            this.bookTable.View = System.Windows.Forms.View.Details;
            this.bookTable.SelectedIndexChanged += new System.EventHandler(this.bookTable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book Title";
            this.columnHeader1.Width = 228;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 193;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Genre";
            this.columnHeader3.Width = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Books";
            // 
            // genresList
            // 
            this.genresList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genresList.FormattingEnabled = true;
            this.genresList.Location = new System.Drawing.Point(4, 104);
            this.genresList.Name = "genresList";
            this.genresList.Size = new System.Drawing.Size(543, 28);
            this.genresList.TabIndex = 2;
            this.genresList.SelectedIndexChanged += new System.EventHandler(this.genresList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Genres";
            // 
            // authorsList
            // 
            this.authorsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorsList.FormattingEnabled = true;
            this.authorsList.Location = new System.Drawing.Point(3, 23);
            this.authorsList.Name = "authorsList";
            this.authorsList.Size = new System.Drawing.Size(543, 28);
            this.authorsList.TabIndex = 0;
            this.authorsList.SelectedIndexChanged += new System.EventHandler(this.authorsList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboAuthor);
            this.groupBox3.Controls.Add(this.comboGenre);
            this.groupBox3.Controls.Add(this.addBook);
            this.groupBox3.Controls.Add(this.delBook);
            this.groupBox3.Controls.Add(this.saveBook);
            this.groupBox3.Controls.Add(this.genreName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.authorName);
            this.groupBox3.Controls.Add(this.bookTitle);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(999, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 533);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book Title";
            // 
            // comboAuthor
            // 
            this.comboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuthor.FormattingEnabled = true;
            this.comboAuthor.Location = new System.Drawing.Point(7, 104);
            this.comboAuthor.Name = "comboAuthor";
            this.comboAuthor.Size = new System.Drawing.Size(352, 28);
            this.comboAuthor.TabIndex = 11;
            this.comboAuthor.SelectedIndexChanged += new System.EventHandler(this.comboAuthor_SelectedIndexChanged);
            // 
            // comboGenre
            // 
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(7, 226);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(352, 28);
            this.comboGenre.TabIndex = 10;
            this.comboGenre.SelectedIndexChanged += new System.EventHandler(this.comboGenre_SelectedIndexChanged);
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(64, 345);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(243, 45);
            this.addBook.TabIndex = 9;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // delBook
            // 
            this.delBook.Location = new System.Drawing.Point(64, 465);
            this.delBook.Name = "delBook";
            this.delBook.Size = new System.Drawing.Size(243, 45);
            this.delBook.TabIndex = 8;
            this.delBook.Text = "Delete Book";
            this.delBook.UseVisualStyleBackColor = true;
            // 
            // saveBook
            // 
            this.saveBook.Location = new System.Drawing.Point(64, 406);
            this.saveBook.Name = "saveBook";
            this.saveBook.Size = new System.Drawing.Size(243, 45);
            this.saveBook.TabIndex = 7;
            this.saveBook.Text = "Save Book";
            this.saveBook.UseVisualStyleBackColor = true;
            this.saveBook.Click += new System.EventHandler(this.saveBook_Click);
            // 
            // genreName
            // 
            this.genreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreName.Location = new System.Drawing.Point(7, 267);
            this.genreName.Name = "genreName";
            this.genreName.Size = new System.Drawing.Size(352, 30);
            this.genreName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genre";
            // 
            // authorName
            // 
            this.authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorName.Location = new System.Drawing.Point(7, 143);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(352, 30);
            this.authorName.TabIndex = 2;
            // 
            // bookTitle
            // 
            this.bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookTitle.Location = new System.Drawing.Point(7, 29);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(352, 30);
            this.bookTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.showAllBooks);
            this.groupBox4.Controls.Add(this.saveCover);
            this.groupBox4.Controls.Add(this.changeCover);
            this.groupBox4.Controls.Add(this.bookCover);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(549, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 533);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book Сover";
            // 
            // showAllBooks
            // 
            this.showAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAllBooks.ForeColor = System.Drawing.Color.Black;
            this.showAllBooks.Location = new System.Drawing.Point(77, 465);
            this.showAllBooks.Name = "showAllBooks";
            this.showAllBooks.Size = new System.Drawing.Size(291, 51);
            this.showAllBooks.TabIndex = 3;
            this.showAllBooks.Text = "Show All Books";
            this.showAllBooks.UseVisualStyleBackColor = true;
            this.showAllBooks.Click += new System.EventHandler(this.showAllBooks_Click);
            // 
            // saveCover
            // 
            this.saveCover.Location = new System.Drawing.Point(230, 379);
            this.saveCover.Name = "saveCover";
            this.saveCover.Size = new System.Drawing.Size(207, 45);
            this.saveCover.TabIndex = 2;
            this.saveCover.Text = "Save cover";
            this.saveCover.UseVisualStyleBackColor = true;
            // 
            // changeCover
            // 
            this.changeCover.Location = new System.Drawing.Point(11, 379);
            this.changeCover.Name = "changeCover";
            this.changeCover.Size = new System.Drawing.Size(207, 45);
            this.changeCover.TabIndex = 1;
            this.changeCover.Text = "Change cover";
            this.changeCover.UseVisualStyleBackColor = true;
            this.changeCover.Click += new System.EventHandler(this.changeCover_Click);
            // 
            // bookCover
            // 
            this.bookCover.Image = global::BookCatalogue.Properties.Resources.BookCover;
            this.bookCover.Location = new System.Drawing.Point(5, 27);
            this.bookCover.Name = "bookCover";
            this.bookCover.Size = new System.Drawing.Size(439, 323);
            this.bookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookCover.TabIndex = 0;
            this.bookCover.TabStop = false;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "AuthorId";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "GenreId";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 666);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book catalogue management system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button delBook;
        private System.Windows.Forms.Button saveBook;
        private System.Windows.Forms.TextBox genreName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorName;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button saveCover;
        private System.Windows.Forms.Button changeCover;
        private System.Windows.Forms.PictureBox bookCover;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox genresList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox authorsList;
        private System.Windows.Forms.ListView bookTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button showAllBooks;
        private System.Windows.Forms.ComboBox comboAuthor;
        private System.Windows.Forms.ComboBox comboGenre;
    }
}

