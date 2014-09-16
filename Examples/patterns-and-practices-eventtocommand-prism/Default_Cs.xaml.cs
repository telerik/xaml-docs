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

#region patterns-and-practices-eventtocommand-prism_3
private void xGridPrismCommand_Click(object sender, RoutedEventArgs e)
{
    xContentBorder.Child = new GridPrismAttachedBehavior();
}
#endregion

#region patterns-and-practices-eventtocommand-prism_4
public class RowEditEndedCommandBehavior : CommandBehaviorBase<RadGridView>
{
	public RowEditEndedCommandBehavior(RadGridView gridView)
		: base(gridView)
	{
		gridView.RowEditEnded += new EventHandler<GridViewRowEditEndedEventArgs>(gridView_RowEditEnded);
	}

	void gridView_RowEditEnded(object sender, GridViewRowEditEndedEventArgs e)
	{
		CommandParameter = e;

		ExecuteCommand();
	}
}
#endregion


#region patterns-and-practices-eventtocommand-prism_5
public static class RowEditEndedCommand
{
	private static readonly DependencyProperty RowEditEndedCommandBehaviorProperty
		= DependencyProperty.RegisterAttached(
		"RowEditEndedCommandBehavior",
		typeof(RowEditEndedCommandBehavior),
		typeof(RowEditEndedCommand),
		null);

	public static readonly DependencyProperty CommandProperty
		= DependencyProperty.RegisterAttached(
		"Command",
		typeof(ICommand),
		typeof(RowEditEndedCommand),
		new PropertyMetadata(OnSetCommandCallback));

	public static readonly DependencyProperty CommandParameterProperty
		= DependencyProperty.RegisterAttached(
	   "CommandParameter",
	   typeof(object),
	   typeof(RowEditEndedCommand),
	   new PropertyMetadata(OnSetCommandParameterCallback));

	public static ICommand GetCommand(RadGridView gridView)
	{
		return gridView.GetValue(CommandProperty) as ICommand;
	}

    public static void SetCommand(RadGridView gridView, object parameter)
    {
        gridView.SetValue(CommandProperty, parameter);
    }

	public static void SetCommandParameter(RadGridView gridView, object parameter)
	{
		gridView.SetValue(CommandParameterProperty, parameter);
	}

	public static object GetCommandParameter(RadGridView gridView)
	{
		return gridView.GetValue(CommandParameterProperty);
	}

	private static void OnSetCommandCallback
		(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
	{
		RadGridView gridView = dependencyObject as RadGridView;
		if (gridView != null)
		{
			RowEditEndedCommandBehavior behavior = GetOrCreateBehavior(gridView);
			behavior.Command = e.NewValue as ICommand;
		}
	}

	private static void OnSetCommandParameterCallback
		(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
	{
		RadGridView gridView = dependencyObject as RadGridView;
		if (gridView != null)
		{
			RowEditEndedCommandBehavior behavior = GetOrCreateBehavior(gridView);
			behavior.CommandParameter = e.NewValue;
		}
	}

	private static RowEditEndedCommandBehavior GetOrCreateBehavior(RadGridView gridView)
	{
		RowEditEndedCommandBehavior behavior =
			gridView.GetValue(RowEditEndedCommandBehaviorProperty) as RowEditEndedCommandBehavior;
		if (behavior == null)
		{
			behavior = new RowEditEndedCommandBehavior(gridView);
			gridView.SetValue(RowEditEndedCommandBehaviorProperty, behavior);
		}
		return behavior;
	}
}
#endregion

}