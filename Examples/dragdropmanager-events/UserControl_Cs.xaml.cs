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

#region dragdropmanager-events_0

DragDropManager.AddDragInitializeHandler(source, new  Windows.DragDrop.DragInitializeEventHandler(OnDragInitialized));
DragDropManager.AddDragDropCompletedHandler(source, new DragDropCompletedEventHandler(OnDragDropCompleted));
DragDropManager.AddGiveFeedbackHandler(source, new Windows.DragDrop.GiveFeedbackEventHandler(OnGiveFeedBack));
DragDropManager.AddQueryContinueDragHandler(source, new Windows.DragDrop.QueryContinueDragEventHandler(OnQueryContinue));
DragDropManager.AddDragOverHandler(frameworkElement, OnElementDragOver);
DragDropManager.AddDragLeaveHandler(frameworkElement, OnElementDragLeave);
DragDropManager.AddDropHandler(frameworkElement, OnElementDrop);

private void OnDragInitialized(object sender, DragInitializeEventArgs e)
{
}

private void OnDragDropCompleted(object sender, DragDropCompletedEventArgs e)
{
}

private void OnGiveFeedBack(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
{
}

private void OnQueryContinue(object sender, Telerik.Windows.DragDrop.QueryContinueDragEventArgs args)
{
}

private void OnElementDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
}

private void OnElementDragLeave(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
{
}

private void OnElementDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
}

#endregion
}
