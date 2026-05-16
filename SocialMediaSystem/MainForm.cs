using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.CompilerServices;

namespace SocialMediaSystem
{
    public partial class MainForm : MaterialForm
    {
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            FromTextBox = new MaskedTextBox();
            ToTextBox = new MaskedTextBox();
            FilterButton = new Button();
            label4 = new Label();
            ViewsTextBox = new TextBox();
            label5 = new Label();
            postsListView = new ListView();
            id = new ColumnHeader();
            Author = new ColumnHeader();
            Views = new ColumnHeader();
            Description = new ColumnHeader();
            Likes = new ColumnHeader();
            PublishedDate = new ColumnHeader();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaptionText;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.Control;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(985, 445);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2026, 5, 16, 13, 39, 14, 0);
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
            DescriptionTextBox.Location = new Point(985, 212);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(250, 121);
            DescriptionTextBox.TabIndex = 2;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // authorTextBox
            // 
            authorTextBox.BackColor = SystemColors.InactiveCaptionText;
            authorTextBox.ForeColor = SystemColors.Window;
            authorTextBox.Location = new Point(985, 136);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(250, 27);
            authorTextBox.TabIndex = 3;
            authorTextBox.TextChanged += authorTextBox_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Chartreuse;
            buttonAdd.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdd.ForeColor = SystemColors.ButtonHighlight;
            buttonAdd.Location = new Point(1051, 494);
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
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(972, 132);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(985, 110);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 6;
            label2.Text = "Author";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(985, 411);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 7;
            label3.Text = "Published  date";
            label3.Click += label3_Click;
            // 
            // PostSearch
            // 
            PostSearch.BackColor = SystemColors.InactiveCaptionText;
            PostSearch.BorderStyle = BorderStyle.FixedSingle;
            PostSearch.ForeColor = SystemColors.Window;
            PostSearch.Location = new Point(22, 90);
            PostSearch.Name = "PostSearch";
            PostSearch.Size = new Size(316, 27);
            PostSearch.TabIndex = 8;
            PostSearch.TextChanged += textBox1_TextChanged;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Chartreuse;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.ForeColor = Color.White;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(338, 90);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(58, 27);
            SearchButton.TabIndex = 9;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += button1_Click;
            // 
            // FromTextBox
            // 
            FromTextBox.BackColor = SystemColors.MenuText;
            FromTextBox.BorderStyle = BorderStyle.FixedSingle;
            FromTextBox.ForeColor = SystemColors.Window;
            FromTextBox.Location = new Point(415, 90);
            FromTextBox.Name = "FromTextBox";
            FromTextBox.Size = new Size(80, 27);
            FromTextBox.TabIndex = 10;
            FromTextBox.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // ToTextBox
            // 
            ToTextBox.BackColor = SystemColors.MenuText;
            ToTextBox.BorderStyle = BorderStyle.FixedSingle;
            ToTextBox.ForeColor = SystemColors.Window;
            ToTextBox.Location = new Point(514, 90);
            ToTextBox.Name = "ToTextBox";
            ToTextBox.Size = new Size(74, 27);
            ToTextBox.TabIndex = 11;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.Chartreuse;
            FilterButton.FlatStyle = FlatStyle.Flat;
            FilterButton.ForeColor = SystemColors.ButtonFace;
            FilterButton.Image = (Image)resources.GetObject("FilterButton.Image");
            FilterButton.Location = new Point(587, 90);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(40, 27);
            FilterButton.TabIndex = 12;
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(985, 345);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 14;
            label4.Text = "Views";
            // 
            // ViewsTextBox
            // 
            ViewsTextBox.BackColor = SystemColors.InactiveCaptionText;
            ViewsTextBox.ForeColor = SystemColors.Window;
            ViewsTextBox.Location = new Point(985, 371);
            ViewsTextBox.Name = "ViewsTextBox";
            ViewsTextBox.Size = new Size(250, 27);
            ViewsTextBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(985, 186);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 15;
            label5.Text = "Description";
            // 
            // postsListView
            // 
            postsListView.BackColor = SystemColors.InfoText;
            postsListView.Columns.AddRange(new ColumnHeader[] { id, Author, Views, Description, Likes, PublishedDate });
            postsListView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            postsListView.ForeColor = SystemColors.Window;
            postsListView.Location = new Point(22, 123);
            postsListView.Name = "postsListView";
            postsListView.Size = new Size(942, 480);
            postsListView.TabIndex = 16;
            postsListView.UseCompatibleStateImageBehavior = false;
            postsListView.View = View.Details;
            // 
            // id
            // 
            id.Text = "#";
            id.Width = 100;
            // 
            // Author
            // 
            Author.Text = "Author";
            Author.Width = 150;
            // 
            // Views
            // 
            Views.Text = "Views";
            Views.Width = 100;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 330;
            // 
            // Likes
            // 
            Likes.Text = "Likes";
            Likes.Width = 100;
            // 
            // PublishedDate
            // 
            PublishedDate.Text = "Published date";
            PublishedDate.Width = 160;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(495, 93);
            label6.Name = "label6";
            label6.Size = new Size(13, 20);
            label6.TabIndex = 17;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(415, 67);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 18;
            label7.Text = "Date";
            // 
            // MainForm
            // 
            BackColor = Color.Black;
            ClientSize = new Size(1295, 615);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(postsListView);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ViewsTextBox);
            Controls.Add(FilterButton);
            Controls.Add(ToTextBox);
            Controls.Add(FromTextBox);
            Controls.Add(SearchButton);
            Controls.Add(PostSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(authorTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(dateTimePicker1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            Text = "Social Media";
            Load += MainForm_Load;
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
                string viewsText = ViewsTextBox.Text;

                var user = new User(Guid.NewGuid(), authorName, "test@mail.com", "1234");
                DateTime publishDate = dateTimePicker1.Value;

                int.TryParse(viewsText, out int viewsCount);

                var viewsList = new List<User>();
                for (int i = 0; i < viewsCount; i++)
                {
                    viewsList.Add(new User());
                }

                var post = new Post(
                    Guid.NewGuid(),
                    user,
                    description,
                    viewsList,
                    publishDate,
                    new List<User>()
                );

                FileManager.Add(post);
                DataManager.Add(post);

                var item = new ListViewItem((postsListView.Items.Count + 1).ToString());
                item.SubItems.Add(authorName);
                item.SubItems.Add(post.Views.Count.ToString());
                item.SubItems.Add(description);
                item.SubItems.Add(post.Likes.Count.ToString());
                item.SubItems.Add(publishDate.ToString("dd.MM.yyyy HH:mm"));

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

                        item.SubItems.Add(postEntity["author", true] ?? "Unknown");
                        item.SubItems.Add(postEntity.Views?.Count.ToString() ?? "0");
                        item.SubItems.Add(postEntity["description", true] ?? "");
                        item.SubItems.Add(postEntity.Likes?.Count.ToString() ?? "0");
                        item.SubItems.Add(postEntity["date", true] ?? "");

                        postsListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private bool FilterPostsByDate(IEntity entity)
        {
            DateTime? dateFrom = null;
            if (DateTime.TryParseExact(FromTextBox.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out var dateFromResult))
                dateFrom = dateFromResult;

            DateTime? dateTo = null;
            if (DateTime.TryParseExact(ToTextBox.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out var dateToResult))
                dateTo = dateToResult;

            if (entity is Post post)
            {
                if (dateFrom != null && dateTo != null)
                {
                    return post.PublishedDate.Value.Date >= dateFrom.Value.Date && post.PublishedDate.Value.Date <= dateTo.Value.Date;
                }
                if (dateFrom != null) return post.PublishedDate.Value.Date >= dateFrom.Value.Date;
                if (dateTo != null) return post.PublishedDate.Value.Date <= dateTo.Value.Date;
                return true;
            }
            return false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!DataManager.Entities.Any())
                {
                    return;
                }
                postsListView.Items.Clear();
                IEnumerable<IEntity> filteredEntities = new List<IEntity>();
                if (string.IsNullOrEmpty(FromTextBox.Text) && string.IsNullOrEmpty(ToTextBox.Text))
                {
                    filteredEntities = DataManager.Entities;
                }
                else
                {
                    filteredEntities = DataManager.Filter(entity =>
                    {
                        DateTime? dateFrom = null;
                        if (DateTime.TryParseExact(FromTextBox.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out var dateFromResult))
                            dateFrom = dateFromResult;

                        DateTime? dateTo = null;
                        if (DateTime.TryParseExact(ToTextBox.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out var dateToResult))
                            dateTo = dateToResult;

                        if (entity is Post post && post.PublishedDate.HasValue)
                        {
                            if (dateFrom != null && dateTo != null)
                            {
                                return post.PublishedDate.Value.Date >= dateFrom.Value.Date && post.PublishedDate.Value.Date <= dateTo.Value.Date;
                            }
                            if (dateFrom != null) return post.PublishedDate.Value.Date >= dateFrom.Value.Date;

                            if (dateTo != null) return post.PublishedDate.Value.Date <= dateTo.Value.Date;

                            return true;
                        }

                        return false;
                    });
                }

                foreach (IEntity entity in filteredEntities)
                {
                    if (entity is Post postEntity)
                    {
                        var item = new ListViewItem((postsListView.Items.Count + 1).ToString());
                        item.SubItems.Add(postEntity["author", true] ?? "Unknown");
                        item.SubItems.Add(postEntity.Views?.Count.ToString() ?? "0");
                        item.SubItems.Add(postEntity["description", true] ?? "");
                        item.SubItems.Add(postEntity.Likes?.Count.ToString() ?? "0");
                        item.SubItems.Add(postEntity.PublishedDate.HasValue
                            ? postEntity.PublishedDate.Value.ToString("dd.MM.yyyy HH:mm")
                            : string.Empty);

                        postsListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}