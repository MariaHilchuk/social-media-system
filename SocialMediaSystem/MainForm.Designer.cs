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

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600,
                Primary.Blue700,
                Primary.Blue200,
                Accent.LightBlue200,
                TextShade.WHITE);
        }
        private ListView postsListView;
        private ColumnHeader Author;
        private ColumnHeader Likes;
        private ColumnHeader Description;
        private ColumnHeader Views;
        private ColumnHeader PublishedDate;
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
    }
}