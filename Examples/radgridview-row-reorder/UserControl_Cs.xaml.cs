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

#region radgridview-row-reorder_0
public partial class RowReorderBehavior
    {
        private TreeViewDragCue dragCue;
        private object currentDropItem;
        private DropPosition currentDropPosition;
        private RadGridView associatedObject;
        /// <summary>
        /// AssociatedObject Property
        /// </summary>
        public RadGridView AssociatedObject
        {
            get
            {
                return associatedObject;
            }
            set
            {
                associatedObject = value;
            }
        }
        private static Dictionary<RadGridView, RowReorderBehavior> instances;
        public static event EventHandler<BeginningDragEventArgs> BeginningDrag;
        public static event EventHandler<DragStartedEventArgs> DragStarted;
        public static event EventHandler<CancelEventArgs> EndingDrag;
        public static event EventHandler<EventArgs> DragEnded;
        static RowReorderBehavior()
        {
            instances = new Dictionary<RadGridView, RowReorderBehavior>();
        }
        public static bool GetIsEnabled(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsEnabledProperty);
        }
        public static void SetIsEnabled(DependencyObject obj, bool value)
        {
            RowReorderBehavior behavior = GetAttachedBehavior(obj as RadGridView);
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
        // Using a DependencyProperty as the backing store for IsEnabled.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(RowReorderBehavior), new PropertyMetadata(false));
        private static RowReorderBehavior GetAttachedBehavior(RadGridView gridview)
        {
            if (!instances.ContainsKey(gridview))
            {
                instances[gridview] = new RowReorderBehavior();
                instances[gridview].AssociatedObject = gridview;
            }
            return instances[gridview];
        }
        protected virtual void Initialize()
        {
            this.AssociatedObject.RowLoaded +=
                new EventHandler<Telerik.Windows.Controls.GridView.RowLoadedEventArgs>(AssociatedObject_RowLoaded);
            this.AssociatedObject.SetValue(RadDragAndDropManager.AllowDropProperty, true);
            this.SubscribeToDragDropEvents();
        }     
        void AssociatedObject_RowLoaded(object sender, Telerik.Windows.Controls.GridView.RowLoadedEventArgs e)
        {
            if (e.Row is GridViewHeaderRow || e.Row is GridViewNewRow || e.Row is GridViewFooterRow)
                return;
            GridViewRow row = e.Row as GridViewRow;
            this.InitializeRowDragAndDrop(row);
        }
        private void InitializeRowDragAndDrop(GridViewRow row)
        {
            if (row == null)
                return;
            row.SetValue(RadDragAndDropManager.AllowDragProperty, true);
            row.SetValue(RadDragAndDropManager.AllowDropProperty, true);
            RadDragAndDropManager.RemoveDropQueryHandler(row, OnGridViewRowDropQuery);
            RadDragAndDropManager.AddDropQueryHandler(row, OnGridViewRowDropQuery);
        }
    }
}
#endregion

#region radgridview-row-reorder_1
public MainPage()
        {
            InitializeComponent();
            RowReorderBehavior.SetIsEnabled(RadGridView1, true);
            RowReorderBehavior.SetIsEnabled(RadGridView2, true);
        }
#endregion

#region radgridview-row-reorder_2
public MainWindow()
        {
            InitializeComponent();
            RowReorderBehavior.SetIsEnabled(RadGridView1, true);
            RowReorderBehavior.SetIsEnabled(RadGridView2, true);
        }
#endregion
}
