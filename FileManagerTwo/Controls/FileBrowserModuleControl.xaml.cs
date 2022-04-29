using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FileManagerTwo
{
    /// <summary>
    /// Interaction logic for FileBrowserModuleControl.xaml
    /// </summary>
    public partial class FileBrowserModuleControl : UserControl
    {
        public ICommand ItemDoubleClickCommand
        {
            get { return (ICommand)GetValue(ItemDoubleClickCommandProperty); }
            set { SetValue(ItemDoubleClickCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemDoubleClickCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemDoubleClickCommandProperty =
            DependencyProperty.Register("ItemDoubleClickCommand", typeof(ICommand), typeof(FileBrowserModuleControl), new PropertyMetadata(null));


        public FileBrowserModuleControl()
        {
            InitializeComponent();
        }

        private void Item_MouseDoubleClick(object sender, MouseButtonEventArgs e) =>
            ItemDoubleClickCommand?.Execute(activeDirectoryListbox.SelectedItem);
    }
}
