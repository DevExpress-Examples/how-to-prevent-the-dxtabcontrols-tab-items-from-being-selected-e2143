using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Core;
using DXExample.DemoData;

namespace TabControl_RestrictingSelection {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e) {
            tabControl.ItemsSource = Invoice.GetData();
        }
        private void tabControl_SelectionChanging(object sender,
            TabControlSelectionChangingEventArgs e) {
                if (!((Invoice)tabControl.Items[tabControl.SelectedIndex]).IsUrgent)
                    e.Cancel = true;
        }
    }
}
