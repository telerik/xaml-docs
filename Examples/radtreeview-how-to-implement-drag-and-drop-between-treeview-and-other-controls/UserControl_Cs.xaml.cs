using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-0
 public class GridViewDragDropBehavior
    {
        private RadGridView _associatedObject;
        /// <summary>
        /// object that will be associated with the RadGridView instance that enables the behavior
        /// </summary>
        public RadGridView AssociatedObject
        {
            get
            {
                return _associatedObject;
            }
            set
            {
                _associatedObject = value;
            }
        }

        private static Dictionary<RadGridView, GridViewDragDropBehavior> instances;

        static GridViewDragDropBehavior()
        {
            instances = new Dictionary<RadGridView, GridViewDragDropBehavior>();
        }

        public static bool GetIsEnabled(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsEnabledProperty);
        }

        public static void SetIsEnabled(DependencyObject obj, bool value)
        {
            GridViewDragDropBehavior behavior = GetAttachedBehavior(obj as RadGridView);

            behavior.AssociatedObject = obj as RadGridView;
            
            if (value)
            {
                behavior.Initialize();
            }
            else
            {
                behavior.CleanUp();
            }
            obj.SetValue(IsEnabledProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsEnabled state of the behavior
        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(GridViewDragDropBehavior),
                new PropertyMetadata(new PropertyChangedCallback(OnIsEnabledPropertyChanged)));

        public static void OnIsEnabledPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            SetIsEnabled(dependencyObject, (bool)e.NewValue);
        }

        private static GridViewDragDropBehavior GetAttachedBehavior(RadGridView gridview)
        {
            if (!instances.ContainsKey(gridview))
            {
                instances[gridview] = new GridViewDragDropBehavior();
                instances[gridview].AssociatedObject = gridview;
            }

            return instances[gridview];
        }

     //initializes the behavior by detaching from any existing DragDropManager event handlers and attaching new DragDropManager event handlers
        protected virtual void Initialize()
        {
            this.UnsubscribeFromDragDropEvents();
            this.SubscribeToDragDropEvents();
        }
     //cleans up after disabling the behavior by detaching from the DragDropManager event handlers
        protected virtual void CleanUp()
        {
            this.UnsubscribeFromDragDropEvents();
        }
     //attaching new DragDropManager event handlers
        private void SubscribeToDragDropEvents()
        {

        }
     //unsubscribing from the DragDropManager event handlers
        private void UnsubscribeFromDragDropEvents()
        {

        }
    }
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-1
        private void SubscribeToDragDropEvents()
        {
            DragDropManager.AddDragInitializeHandler(this.AssociatedObject, OnDragInitialize);
            DragDropManager.AddGiveFeedbackHandler(this.AssociatedObject, OnGiveFeedback);
            DragDropManager.AddDropHandler(this.AssociatedObject, OnDrop);
            DragDropManager.AddDragDropCompletedHandler(this.AssociatedObject, OnDragDropCompleted);
            DragDropManager.AddDragOverHandler(this.AssociatedObject, OnDragOver);
        }

        private void UnsubscribeFromDragDropEvents()
        {
            DragDropManager.RemoveDragInitializeHandler(this.AssociatedObject, OnDragInitialize);
            DragDropManager.RemoveGiveFeedbackHandler(this.AssociatedObject, OnGiveFeedback);
            DragDropManager.RemoveDropHandler(this.AssociatedObject, OnDrop);
            DragDropManager.RemoveDragDropCompletedHandler(this.AssociatedObject, OnDragDropCompleted);
            DragDropManager.RemoveDragOverHandler(this.AssociatedObject, OnDragOver);
        }
        private void OnDragInitialize(object sender, DragInitializeEventArgs e)
        {
        }

        private void OnGiveFeedback(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs e)
        {
        }

        private void OnDragDropCompleted(object sender, DragDropCompletedEventArgs e)
        {
        }

        private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
        {
        }

        private void OnDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
        {
        }
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-2
public class DropIndicationDetails : ViewModelBase
{
    private object currentDraggedItem;
    private DropPosition currentDropPosition;
    private object currentDraggedOverItem;

    public object CurrentDraggedOverItem
    {
        get
        {
            return currentDraggedOverItem;
        }
        set
        {
            if (this.currentDraggedOverItem != value)
            {
                currentDraggedOverItem = value;
                OnPropertyChanged("CurrentDraggedOverItem");
            }
        }
    }

    public int DropIndex { get; set; }

    public DropPosition CurrentDropPosition
    {
        get
        {
            return this.currentDropPosition;
        }
        set
        {
            if (this.currentDropPosition != value)
            {
                this.currentDropPosition = value;
                OnPropertyChanged("CurrentDropPosition");
            }
        }
    }

    public object CurrentDraggedItem
    {
        get
        {
            return this.currentDraggedItem;
        }
        set
        {
            if (this.currentDraggedItem != value)
            {
                this.currentDraggedItem = value;
                OnPropertyChanged("CurrentDraggedItem");
            }
        }
    }
}
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-3
private void OnDragInitialize(object sender, DragInitializeEventArgs e)
{
    DropIndicationDetails details = new DropIndicationDetails();
    var row = e.OriginalSource as GridViewRow ?? (e.OriginalSource as FrameworkElement).ParentOfType<GridViewRow>();

    var item = row != null ? row.Item : (sender as RadGridView).SelectedItem;
    details.CurrentDraggedItem = item;

    IDragPayload dragPayload = DragDropPayloadManager.GeneratePayload(null);

    dragPayload.SetData("DraggedData", item);
    dragPayload.SetData("DropDetails", details);

    e.Data = dragPayload;

    e.DragVisual = new DragVisual()
    {
        Content = details,
        ContentTemplate = this.AssociatedObject.Resources["DraggedItemTemplate"] as DataTemplate
    };
    e.DragVisualOffset = e.RelativeStartPoint;
    e.AllowedEffects = DragDropEffects.All;
}
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-4
private void OnGiveFeedback(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs e)
{
    e.SetCursor(Cursors.Arrow);
    e.Handled = true;
}
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-5
private void OnDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    TreeViewDragDropOptions options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options == null)
    {
        e.Effects = DragDropEffects.None;
        e.Handled = true;
        return;
    }
    var draggedItem = options.DraggedItems.FirstOrDefault();
    var itemsType = (this.AssociatedObject.ItemsSource as IList).AsQueryable().ElementType;


    if (draggedItem.GetType() != itemsType)
    {
        e.Effects = DragDropEffects.None;
    }
    else
    {
        (options.DragVisual as TreeViewDragVisual).IsDropPossible = true;
        options.DropAction = DropAction.Move;
        options.UpdateDragVisual();
    }
    e.Handled = true;
}
#endregion
#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-6
private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{

    TreeViewDragDropOptions options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options == null)
        return;
    var draggedItem = options.DraggedItems.FirstOrDefault();

    if (draggedItem == null)
    {
        return;
    }

    if (e.Effects != DragDropEffects.None)
    {
        var collection = (sender as RadGridView).ItemsSource as IList;
        collection.Add(draggedItem);
    }
    e.Handled = true;
}

private void OnDragDropCompleted(object sender, DragDropCompletedEventArgs e)
{
    var draggedItem = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedData");

    if (e.Effects != DragDropEffects.None)
    {
        var collection = (sender as RadGridView).ItemsSource as IList;
        collection.Remove(draggedItem);
    }
}
#endregion
#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-7
DragDropManager.AddDropHandler(allProductsView, OnDrop);
#endregion
#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-8
IList destinationItems = null;
private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var data = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedData");
    if (data == null) return;
    if (e.Effects != DragDropEffects.None)
    {
        var destinationItem = (e.OriginalSource as FrameworkElement).ParentOfType<RadTreeViewItem>();
        var dropDetails = DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails") as DropIndicationDetails;

        if (destinationItems != null)
        {
            int dropIndex = dropDetails.DropIndex >= destinationItems.Count ? destinationItems.Count : dropDetails.DropIndex < 0 ? 0 : dropDetails.DropIndex;
            this.destinationItems.Insert(dropIndex, data);
        }
    }
}
#endregion
#region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-9
private void OnItemDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var item = (e.OriginalSource as FrameworkElement).ParentOfType<RadTreeViewItem>();
    if (item == null)
    {
        e.Effects = DragDropEffects.None;
        e.Handled = true;
        return;
    }
    var position = GetPosition(item, e.GetPosition(item));
    if (item.Level == 0 && position != DropPosition.Inside)
    {
        e.Effects = DragDropEffects.None;
        e.Handled = true;
        return;
    }
    RadTreeView tree = sender as RadTreeView;
    var draggedData = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedData");
    var dropDetails = DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails") as DropIndicationDetails;

    if ((draggedData == null && dropDetails == null))
    {
        return;
    }
    if (position != DropPosition.Inside)
    {
        e.Effects = DragDropEffects.All;

        destinationItems = item.Level > 0 ? (IList)item.ParentItem.ItemsSource : (IList)tree.ItemsSource;
        int index = destinationItems.IndexOf(item.Item);
        dropDetails.DropIndex = position == DropPosition.Before ? index : index + 1;
    }
    else
    {
        destinationItems = (IList)item.ItemsSource;
        int index = 0;

        if (destinationItems == null)
        {
            e.Effects = DragDropEffects.None;
        }
        else
        {
            e.Effects = DragDropEffects.All;
            dropDetails.DropIndex = index;
        }
    }

    dropDetails.CurrentDraggedOverItem = item.Item;
    dropDetails.CurrentDropPosition = position;

    e.Handled = true;
}



private DropPosition GetPosition(RadTreeViewItem item, Point point)
{
    double treeViewItemHeight = 24;
    if (point.Y < treeViewItemHeight / 4)
    {
        return DropPosition.Before;
    }
    else if (point.Y > treeViewItemHeight * 3 / 4)
    {
        return DropPosition.After;
    }

    return DropPosition.Inside;
}
#endregion

}
