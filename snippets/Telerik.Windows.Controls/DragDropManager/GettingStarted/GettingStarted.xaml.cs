using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Telerik.Windows.DragDrop;

namespace DragDropManagerExample
{
    public partial class GettingStarted : UserControl
    {
        public GettingStarted()
        {
            InitializeComponent();

            // >> dragdropmanager-getting-started-setting-itemssource
            this.ApplicationList.ItemsSource = ApplicationInfo.GenerateApplicationInfos();
            this.MyAppList.ItemsSource = new ObservableCollection<ApplicationInfo>();
            // << dragdropmanager-getting-started-setting-itemssource

            // >> dragdropmanager-getting-started-dnd-events-subscribing
            DragDropManager.AddDragInitializeHandler(ApplicationList, OnDragInitialize);
            DragDropManager.AddDragInitializeHandler(MyAppList, OnDragInitialize);

            DragDropManager.AddGiveFeedbackHandler(ApplicationList, OnGiveFeedback);
            DragDropManager.AddGiveFeedbackHandler(MyAppList, OnGiveFeedback);

            DragDropManager.AddDragDropCompletedHandler(ApplicationList, OnDragCompleted);
            DragDropManager.AddDragDropCompletedHandler(MyAppList, OnDragCompleted);

            DragDropManager.AddDropHandler(ApplicationList, OnDrop);
            DragDropManager.AddDropHandler(MyAppList, OnDrop);
            // << dragdropmanager-getting-started-dnd-events-subscribing
        }

        // >> dragdropmanager-getting-started-draginitialize
        private void OnDragInitialize(object sender, DragInitializeEventArgs args)
        {
            args.AllowedEffects = DragDropEffects.All;
            var payload = DragDropPayloadManager.GeneratePayload(null);
            var data = ((FrameworkElement)args.OriginalSource).DataContext;
            payload.SetData("DragData", data);
            args.Data = payload;
            args.DragVisual = new ContentControl { Content = data, ContentTemplate = LayoutRoot.Resources["ApplicationTemplate"] as DataTemplate };
        }
        // << dragdropmanager-getting-started-draginitialize

        // >> dragdropmanager-getting-started-givefeedback
        private void OnGiveFeedback(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
        {
            args.SetCursor(Cursors.Arrow);
            args.Handled = true;
        }
        // << dragdropmanager-getting-started-givefeedback

        // >> dragdropmanager-getting-started-drop
        private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
        {
            var data = ((DataObject)args.Data).GetData("DragData");
            ((IList)(sender as ListBox).ItemsSource).Add(data);
        }

        public void OnDragCompleted(object sender, Telerik.Windows.DragDrop.DragDropCompletedEventArgs args)
        {
            var data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData");
            ((IList)(sender as ListBox).ItemsSource).Remove(data);
        }
        // << dragdropmanager-getting-started-drop
    }
}
