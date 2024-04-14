using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public List<Document> documents = new List<Document>();
        public ISortStrategy sortStrategy;
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Document doc;
            string title = titleTextBox.Text;
            string author = authorTextBox.Text; 
            
            if(issueTextBox.Text.Equals(""))
            {
             
                doc = DocumentFactory.CreateDocument<Book>(title, author);

            }
            else
            {
                int issueNumber = int.Parse(issueTextBox.Text); 
                doc = DocumentFactory.CreateDocument<Magazine>(title, null, issueNumber);
            }
            documents.Add(doc);
            UpdateListBox();
            ClearTextBox();

        }


        public void button2_Click(object sender, EventArgs e)
        {
            if (titleRadioButton.Checked)
                sortStrategy = new SortByTitle();
            else if (authorRadioButton.Checked)
                sortStrategy = new SortByAuthor();

            sortStrategy.Sort(documents);
            UpdateListBox();
        }
        public void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var doc in documents)
            {
                if (doc is Book book)
                {
                    listBox1.Items.Add($"Title: {book.Title}, Author: {book.Author}");
                }
                else if (doc is Magazine magazine)
                {
                    listBox1.Items.Add($"Title: {magazine.Title}, Issue Number: {magazine.IssueNumber}");
                }
            }
        }
        public void ClearTextBox()
        {
            titleTextBox.Clear();
            authorTextBox.Clear();
            issueTextBox.Clear();
        }
    }
}
