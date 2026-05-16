using MaterialSkin;
using MaterialSkin.Controls;

namespace SocialMediaSystem
{
    public partial class MainForm : MaterialForm
    { 
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green300,
                Primary.Grey900,
                Primary.Green600,
                Accent.Green700,
                TextShade.BLACK);
        }
        private ListView postsListView;
        private DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox DescriptionTextBox;
        private TextBox authorTextBox;
        private Button buttonAdd;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private ColumnHeader Id;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox PostSearch;
        private Button SearchButton;
        private MaskedTextBox FromTextBox;
        private MaskedTextBox ToTextBox;
        private Button FilterButton;
        private Label label4;
        private TextBox ViewsTextBox;
        private Label label5;
        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader Author;
        private ColumnHeader Views;
        private ColumnHeader Description;
        private ColumnHeader Likes;
        private ColumnHeader PublishedDate;
        private Label label6;
        private Label label7;
    }
}
