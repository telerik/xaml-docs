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

#region dragdropmanager-howto-set-cursor-to-arrow-while-dragging_0
//Subscribing to the GiveFeedback event
DragDropManager.AddGiveFeedbackHandler(SampleListBox, OnGiveFeedBack);
//Handling the GiveFeedback event
private void OnGiveFeedBack(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
{
      args.SetCursor(Cursors.Arrow);
      args.Handled = true;
}
#endregion
}
