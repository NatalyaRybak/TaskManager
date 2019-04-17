using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Views;

namespace TaskManager.Tools
{
    public enum ModesEnum
    {
        Main,
    }

    class NavigationModel
    {
        private MainWindow _contentWindow;
        private ProcessListView _mainView;

        public NavigationModel(MainWindow contentWindow)
        {
            _contentWindow = contentWindow;
            _mainView = new ProcessListView();
        }

        public void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Main:
                    _contentWindow.ContentControl.Content = _mainView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
    }
}
