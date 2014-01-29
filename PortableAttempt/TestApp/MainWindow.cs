using System;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Media.Imaging;

namespace TestApp
{
    public partial class MainWindow
    {
        private ObservableCollection<ViewModel> items = new ObservableCollection<ViewModel>
        {
            new ViewModel { Name = "Item", Description = "1" },
            new ViewModel { Name = "Item", Description = "2" },
            new ViewModel { Name = "Item", Description = "3" },
        };

        private TextBox textBox;
        private Popup popup;
        int index = 1;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = items;

            var decoder = BitmapDecoder.Create(
               new Uri("/TestApp;component/github_icon.png", UriKind.Relative),
               BitmapCreateOptions.None,
               BitmapCacheOption.None);

            int width = decoder.Frames[0].PixelWidth;
            int height = decoder.Frames[0].PixelHeight;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            Grid templateRoot = (Grid)this.FindName("templateRoot");
            Border checkBoxBorder = (Border)this.FindName("checkBoxBorder");
            Grid markGrid = (Grid)this.FindName("markGrid");
        }

        //private void InitializeComponent()
        //{
        //    Application.LoadComponent(this, new Uri("/Test;component/MainWindow.xaml", UriKind.Relative));
        //    this.textBox = (TextBox)this.FindName("textBox");
        //    this.popup = (Popup)this.FindName("popup");
        //}

        private void add_Click(object sender, RoutedEventArgs e)
        {
            this.items.Add(new ViewModel
            {
                Name = textBox.Text,
                Description = index++.ToString(),
            });
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            this.items.RemoveAt(0);
        }

        private void showPopupButton_Click(object sender, RoutedEventArgs e)
        {
            this.popup.IsOpen = !this.popup.IsOpen;
        }
    }
}
