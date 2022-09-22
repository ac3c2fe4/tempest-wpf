using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SamplePanel
{
    public class DynamicGridVM : ObservableObject
    {
        #region RowCount
        private int _RowCount = 3;
        public int RowCount
        {
            get { return _RowCount; }
            set { SetProperty(ref _RowCount, value); }
        }
        #endregion

        #region ColumnCount
        private int _ColumnCount = 3;
        public int ColumnCount
        {
            get { return _ColumnCount; }
            set { SetProperty(ref _ColumnCount, value); }
        }
        #endregion

        #region Items
        private ObservableCollection<int> _Items;
        public ObservableCollection<int> Items
        {
            get { return _Items; }
            set { SetProperty(ref _Items, value); }
        }
        #endregion

        #region RowIndex
        private int _RowIndex;
        public int RowIndex
        {
            get { return _RowIndex; }
            set { SetProperty(ref _RowIndex, value); }
        }
        #endregion

        #region ColumnIndex
        private int _ColumnIndex;
        public int ColumnIndex
        {
            get { return _ColumnIndex; }
            set { SetProperty(ref _ColumnIndex, value); }
        }
        #endregion
    }
}
