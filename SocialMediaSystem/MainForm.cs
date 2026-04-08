using MaterialSkin;
using MaterialSkin.Controls;
namespace SocialMediaSystem
{
    public partial class MainForm : MaterialForm
    {

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            postsListView = new ListView();
            Id = new ColumnHeader();
            Author = new ColumnHeader();
            Likes = new ColumnHeader();
            Description = new ColumnHeader();
            Views = new ColumnHeader();
            PublishedDate = new ColumnHeader();
            dateTimePicker1 = new DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            DescriptionTextBox = new TextBox();
            authorTextBox = new TextBox();
            buttonAdd = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PostSearch = new TextBox();
            SearchButton = new Button();
            SuspendLayout();
            // 
            // postsListView
            // 
            postsListView.BackColor = Color.Black;
            postsListView.Columns.AddRange(new ColumnHeader[] { Id, Author, Likes, Description, Views, PublishedDate });
            postsListView.ForeColor = SystemColors.MenuBar;
            postsListView.FullRowSelect = true;
            postsListView.Location = new Point(23, 132);
            postsListView.Name = "postsListView";
            postsListView.Size = new Size(925, 455);
            postsListView.TabIndex = 0;
            postsListView.UseCompatibleStateImageBehavior = false;
            postsListView.View = View.Details;
            postsListView.SelectedIndexChanged += MateriallistView1_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "#";
            Id.Width = 120;
            // 
            // Author
            // 
            Author.Text = "Author";
            Author.Width = 150;
            // 
            // Likes
            // 
            Likes.Text = "Likes";
            Likes.Width = 120;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 250;
            // 
            // Views
            // 
            Views.Text = "Views";
            Views.Width = 120;
            // 
            // PublishedDate
            // 
            PublishedDate.Text = "Published date";
            PublishedDate.Width = 150;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaptionText;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.Control;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(967, 369);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = SystemColors.InactiveCaptionText;
            DescriptionTextBox.ForeColor = SystemColors.Window;
            DescriptionTextBox.Location = new Point(967, 193);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(250, 27);
            DescriptionTextBox.TabIndex = 2;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // authorTextBox
            // 
            authorTextBox.BackColor = SystemColors.InactiveCaptionText;
            authorTextBox.ForeColor = SystemColors.Window;
            authorTextBox.Location = new Point(967, 286);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(250, 27);
            authorTextBox.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkOrange;
            buttonAdd.ForeColor = SystemColors.ActiveCaptionText;
            buttonAdd.Location = new Point(1030, 421);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 42);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(967, 156);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 5;
            label1.Text = "Description";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(967, 253);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(967, 335);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 7;
            label3.Text = "Published  date";
            // 
            // PostSearch
            // 
            PostSearch.BackColor = SystemColors.InactiveCaptionText;
            PostSearch.ForeColor = SystemColors.Window;
            PostSearch.Location = new Point(23, 83);
            PostSearch.Name = "PostSearch";
            PostSearch.Size = new Size(303, 27);
            PostSearch.TabIndex = 8;
            PostSearch.TextChanged += textBox1_TextChanged;
            // 
            // SearchButton
            // 
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.ForeColor = Color.FromArgb(255, 128, 0);
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(323, 83);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(48, 27);
            SearchButton.TabIndex = 9;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += button1_Click;
            // 
            // MainForm
            // 
            BackColor = Color.Silver;
            ClientSize = new Size(1295, 615);
            Controls.Add(SearchButton);
            Controls.Add(PostSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(authorTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(postsListView);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            Text = "Social Media";
            ResumeLayout(false);
            PerformLayout();

        }

        private void MateriallistView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string authorName = authorTextBox.Text;
                string description = DescriptionTextBox.Text;

                var user = new User(Guid.NewGuid(), authorName, "test@mail.com", "1234");

                DateTime publishDate = dateTimePicker1.Value;

                var post = new Post(
                    Guid.NewGuid(),
                    user,
                    description,
                    new List<User>(),
                    publishDate,
                    new List<User>()
                );

                FileManager.Add(post);
                DataManager.Add(post);

                var item = new ListViewItem(postsListView.Items.Count + 1 + "");
                item.SubItems.Add(authorName);
                item.SubItems.Add("0");
                item.SubItems.Add(description);
                item.SubItems.Add("0");
                item.SubItems.Add(publishDate.ToString());

                postsListView.Items.Add(item);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataManager.Entities.Any())
                {
                    return;
                }

                postsListView.Items.Clear();

                IEnumerable<IEntity> foundEntities = new List<IEntity>();

                if (string.IsNullOrEmpty(PostSearch.Text))
                {
                    foundEntities = DataManager.Entities;
                }
                else
                {
                    foundEntities = DataManager.Search(PostSearch.Text);
                }

                foreach (IEntity entity in foundEntities)
                {
                    var postEntity = entity as Post;

                    if (postEntity != null)
                    {
                        var item = new ListViewItem((postsListView.Items.Count + 1).ToString());
                        item.SubItems.Add(postEntity.Author?.Username ?? "Unknown");
                        item.SubItems.Add(postEntity.Description);
                        item.SubItems.Add(postEntity.PublishedDate?.ToString("dd/MM/yyyy HH:mm") ?? string.Empty);
                        item.SubItems.Add(postEntity.Likes?.Count.ToString() ?? "0");
                        item.SubItems.Add(postEntity.Views?.Count.ToString() ?? "0");

                        postsListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
