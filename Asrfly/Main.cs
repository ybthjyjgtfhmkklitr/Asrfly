using Asrfly.Code;

namespace Asrfly
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);

            // Load Home Page
            pageManager.Loadpage(Gui.GuiHome.HomeUserControl.Instance());

        }
        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            // Load Home Page

            pageManager.Loadpage(Gui.GuiHome.HomeUserControl.Instance());
        }
        #endregion
    }
}