using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace SamplePanel
{
    public class MainWindowVM : ObservableObject
    {
        #region CmdShowPanels
        private RelayCommand _CmdShowPanels;
        public RelayCommand CmdShowPanels
        {
            get
            {
                if (_CmdShowPanels == null)
                    _CmdShowPanels = new RelayCommand(this.ExecuteShowPanels);

                return _CmdShowPanels;
            }
        }

        private void ExecuteShowPanels()
        {
            new Window { Content = new PanelMain() }.ShowDialog();
        }
        #endregion

        #region CmdShowDynamicGrid
        private RelayCommand _CmdShowDynamicGrid;
        public RelayCommand CmdShowDynamicGrid
        {
            get
            {
                if (_CmdShowDynamicGrid == null)
                    _CmdShowDynamicGrid = new RelayCommand(this.ExecuteShowDynamicGrid);

                return _CmdShowDynamicGrid;
            }
        }

        private void ExecuteShowDynamicGrid()
        {
            new Window { Content = new DynamicGridView() }.ShowDialog();

        }
        #endregion
    }
}
