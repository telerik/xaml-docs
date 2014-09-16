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

#region radtransition-how-to-transition-selection_0
public class BooleanToTransitionConverter : IValueConverter
{
	public TransitionProvider TransitionForward { get; set; }
	public TransitionProvider TransitionBackward { get; set; }

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is bool) || (bool)value)
		{
			return TransitionForward;
		}
		else
		{
			return TransitionBackward;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
#endregion

#region radtransition-how-to-transition-selection_2
public class WizzardPageTransition : TransitionProvider
{
	public TransitionProvider BackTransition { get; set; }
	public TransitionProvider ForwardTransition { get; set; }
	public override Transition CreateTransition(TransitionContext context)
	{
		WizzardPage oldPage = context.OldContent as WizzardPage;
		WizzardPage newPage = context.CurrentContent as WizzardPage;
		if (oldPage == null || newPage == null)
		{
			return null;
		}
		else if (newPage.PageIndex > oldPage.PageIndex)
		{
			return this.ForwardTransition.CreateTransition(context);
		}
		else
		{
			return this.BackTransition.CreateTransition(context);
		}
	}
}
#endregion

}
