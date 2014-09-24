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

#region radbusyindicator-how-to-restore-the-focus_0
public class FocusHelper
{
    private static void OnEnsureFocusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (!(bool)e.NewValue)
        {
			var control = d as Control;
			control.Dispatcher.BeginInvoke(new Action(() =>
				{
					control.Focus();
				}));
        }
    }

    public static bool GetEnsureFocus(DependencyObject obj)
    {
        return (bool)obj.GetValue(EnsureFocusProperty);
    }

    public static void SetEnsureFocus(DependencyObject obj, bool value)
    {
        obj.SetValue(EnsureFocusProperty, value);
    }
        
    public static readonly DependencyProperty EnsureFocusProperty =
		DependencyProperty.RegisterAttached(
		"EnsureFocus", 
		typeof(bool),
		typeof(FocusHelper), 
		new PropertyMetadata(OnEnsureFocusChanged));
}
#endregion

#region radbusyindicator-how-to-restore-the-focus_1
private Control focusedElement { get; set; }
#endregion

#region radbusyindicator-how-to-restore-the-focus_2
private DispatcherTimer dispatcherTimer { get; set; }

public Example()
{
	InitializeComponent();

	this.dispatcherTimer = new DispatcherTimer();
	dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
	dispatcherTimer.Tick += new EventHandler(timerTick);
	dispatcherTimer.Start();
}
private void timerTick(object sender, EventArgs e)
{
	var isBusy = this.BusyIndicator.IsBusy;
	if (!isBusy)
	{
		this.focusedElement = FocusManagerHelper.GetFocusedElement(this.StackPanel) as Control;
		this.BusyIndicator.IsBusy = true;
	}
	else
	{
		this.BusyIndicator.IsBusy = false;
		if (this.focusedElement != null)
		{
			this.focusedElement.IsEnabledChanged += focusedElement_IsEnabledChanged;
		}
	}
}

private void focusedElement_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
{
	this.focusedElement.Focus();
	this.focusedElement.IsEnabledChanged -= focusedElement_IsEnabledChanged;
}
#endregion

}
