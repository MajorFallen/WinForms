namespace WorkShopRoomPlanner
{
    public partial class MainWindow : Form
    {
        private Blueprint blueprint;
        private Button selectedButton = null;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();

        }

        private void Initialize()
        {
            blueprint = new Blueprint(Canvas.Width, Canvas.Height);
            Canvas.Image = blueprint.Bitmap;

        }

        private void newBlueprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void buttonFurniture_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (selectedButton == null)
            {
                btn.BackColor = Color.AntiqueWhite;
                selectedButton = btn;
            }
            else if (selectedButton == btn)
            {
                btn.BackColor = Color.White;
                selectedButton = null;
            }
            else
            {
                btn.BackColor = Color.AntiqueWhite;
                selectedButton.BackColor = Color.White;
                selectedButton = btn;
            }
        }
    }
}
