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

#region dragdrompmanager-howto-set-drag-visual_1
public MainPage()
{
      InitializeComponent();
      this.DataContext = new ObservableCollection<string>(from c in Enumerable.Range(0, 10) select "Item" + c);
      DragDropManager.AddDragInitializeHandler(SampleListBox, OnDragInitialize);
}
#endregion

#region dragdrompmanager-howto-set-drag-visual_3
private void OnDragInitialize(object sender, DragInitializeEventArgs args)
{
    args.Data = ((FrameworkElement)args.OriginalSource).DataContext;
    args.DragVisual = new ContentControl { ContentTemplate = this.LayoutRoot.Resources["ItemTemplate"] as DataTemplate, Content = args.Data };
    args.AllowedEffects = DragDropEffects.All;
    args.Handled = true;
}
#endregion
}
