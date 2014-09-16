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

#region radtransition-how-to-no-initial-animation_1
private void RadTransitionControl_TransitionStatusChanged(object sender, TransitionStatusChangedEventArgs e)
{
	if (e.Status == TransitionStatus.Completed)
	{
		this.TransitionControl.Duration = new TimeSpan(0, 0, 1);
	}
}

#endregion


}
