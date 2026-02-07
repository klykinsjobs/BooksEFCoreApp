namespace BooksEFCoreApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BooksTLP = new TableLayoutPanel();
            SaveButton = new Button();
            AuthorsDGV = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorBindingSource = new BindingSource(components);
            BooksDGV = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            booksBindingSource = new BindingSource(components);
            BooksTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AuthorsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BooksDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BooksTLP
            // 
            BooksTLP.ColumnCount = 1;
            BooksTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BooksTLP.Controls.Add(SaveButton, 0, 2);
            BooksTLP.Controls.Add(AuthorsDGV, 0, 0);
            BooksTLP.Controls.Add(BooksDGV, 0, 1);
            BooksTLP.Dock = DockStyle.Fill;
            BooksTLP.Location = new Point(0, 0);
            BooksTLP.Name = "BooksTLP";
            BooksTLP.RowCount = 3;
            BooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            BooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            BooksTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            BooksTLP.Size = new Size(800, 450);
            BooksTLP.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.Dock = DockStyle.Fill;
            SaveButton.Location = new Point(3, 407);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(794, 40);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AuthorsDGV
            // 
            AuthorsDGV.AutoGenerateColumns = false;
            AuthorsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AuthorsDGV.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn });
            AuthorsDGV.DataSource = authorBindingSource;
            AuthorsDGV.Dock = DockStyle.Fill;
            AuthorsDGV.Location = new Point(3, 3);
            AuthorsDGV.Name = "AuthorsDGV";
            AuthorsDGV.Size = new Size(794, 196);
            AuthorsDGV.TabIndex = 1;
            AuthorsDGV.SelectionChanged += AuthorsDGV_SelectionChanged;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Author Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // authorBindingSource
            // 
            authorBindingSource.DataSource = typeof(Author);
            // 
            // BooksDGV
            // 
            BooksDGV.AutoGenerateColumns = false;
            BooksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksDGV.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1 });
            BooksDGV.DataSource = booksBindingSource;
            BooksDGV.Dock = DockStyle.Fill;
            BooksDGV.Location = new Point(3, 205);
            BooksDGV.Name = "BooksDGV";
            BooksDGV.Size = new Size(794, 196);
            BooksDGV.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Book Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // booksBindingSource
            // 
            booksBindingSource.DataMember = "Books";
            booksBindingSource.DataSource = authorBindingSource;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BooksTLP);
            Name = "MainForm";
            Text = "Books - EF Core App";
            BooksTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AuthorsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)BooksDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel BooksTLP;
        private Button SaveButton;
        private DataGridView AuthorsDGV;
        private BindingSource authorBindingSource;
        private DataGridView BooksDGV;
        private BindingSource booksBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}
