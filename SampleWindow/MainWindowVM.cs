using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Windows;

namespace SampleWindow
{
    public class MainWindowVM : ObservableObject
    {
        public static Array WindowStyleValues { get; } = Enum.GetValues(typeof(WindowStyle));
        public static Array WindowStateValues { get; } = Enum.GetValues(typeof(WindowState));
        public static Array ResizeModeValues { get; } = Enum.GetValues(typeof(ResizeMode));



        #region MainWindowTitle
        private string _MainWindowTitle = "Hello World";
        public string MainWindowTitle
        {
            get { return _MainWindowTitle; }
            set { SetProperty(ref _MainWindowTitle, value); }
        }
        #endregion

        #region SelectedWindowStyle
        private WindowStyle _SelectedWindowStyle = WindowStyle.SingleBorderWindow;
        public WindowStyle SelectedWindowStyle
        {
            get { return _SelectedWindowStyle; }
            set { SetProperty(ref _SelectedWindowStyle, value); }
        }
        #endregion

        #region SelectedWindowState
        private WindowState _SelectedWindowState;
        public WindowState SelectedWindowState
        {
            get { return _SelectedWindowState; }
            set { SetProperty(ref _SelectedWindowState, value); }
        }
        #endregion

        #region SelectedResizeMode
        private ResizeMode _SelectedResizeMode = ResizeMode.CanResize;
        public ResizeMode SelectedResizeMode
        {
            get { return _SelectedResizeMode; }
            set { SetProperty(ref _SelectedResizeMode, value); }
        }
        #endregion

        #region Topmost
        private bool _Topmost;
        public bool Topmost
        {
            get { return _Topmost; }
            set { SetProperty(ref _Topmost, value); }
        }
        #endregion

        #region ShowInTaskbar
        private bool _ShowInTaskbar = true;
        public bool ShowInTaskbar
        {
            get { return _ShowInTaskbar; }
            set { SetProperty(ref _ShowInTaskbar, value); }
        }
        #endregion
    }
}
