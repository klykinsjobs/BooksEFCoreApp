using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BooksEFCoreApp
{
    public partial class MainForm : Form
    {
        private BooksContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dbContext = new BooksContext();

            dbContext.Database.EnsureCreated();

            dbContext.Authors.Load();

            authorBindingSource.DataSource = dbContext.Authors.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            dbContext?.Dispose();
            dbContext = null;
        }

        private void AuthorsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (dbContext != null && AuthorsDGV.CurrentRow != null && AuthorsDGV.CurrentRow.DataBoundItem != null)
            {
                var author = (Author)AuthorsDGV.CurrentRow.DataBoundItem;
                if (author != null)
                {
                    dbContext.Entry(author).Collection(e => e.Books).Load();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dbContext!.SaveChanges();

            AuthorsDGV.Refresh();
            BooksDGV.Refresh();
        }
    }
}