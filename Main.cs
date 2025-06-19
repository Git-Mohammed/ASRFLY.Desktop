using ASRFLY.Desktop.Code;
using ASRFLY.Desktop.GUI.GuiCategories;
using ASRFLY.Desktop.GUI.GuiHome;

namespace ASRFLY.Desktop
{
    public partial class frmMain : Form
    {
        // «·Õ·›… —ﬁ„ 12
        private readonly PageManager _pageManager;
        public frmMain()
        {
            InitializeComponent();
            _pageManager = new PageManager(this);

            _pageManager.LoadPage(HomeUserControl.Instance);
        }

        #region Events
        private void btnHome_Click(object sender, EventArgs e)
        {
            _pageManager.LoadPage(HomeUserControl.Instance);
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            _pageManager.LoadPage(CategoryUserControl.Instance);
        }
        #endregion


    }
}
