using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRFLY.Desktop.Code
{
    public class PageManager
    {
        private readonly frmMain _main;

        public PageManager(frmMain main)
        {
            _main = main;
        }

        public void LoadPage(UserControl pageUserControl)
        {
            var oldPage = _main.pnlContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if(oldPage != null)
            {
                _main.pnlContainer.Controls.Remove(oldPage);
                oldPage.Dispose();
            }

            pageUserControl.Dock = DockStyle.Fill;
            _main.pnlContainer.Controls.Add(pageUserControl);
        }
    }
}
