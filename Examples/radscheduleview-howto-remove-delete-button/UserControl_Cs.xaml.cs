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

#region radscheduleview-howto-remove-delete-button_1
public class CustomAppointmentStyleSelector : OrientedAppointmentItemStyleSelector
{
    public Style CustomHorizontalStyle { get; set; }

    public Style CustomVerticalStyle { get; set; }

    public override Style SelectStyle(object item, DependencyObject container, ViewDefinitionBase activeViewDefinition)
    {
        if (activeViewDefinition.GetOrientation() == Orientation.Horizontal)
        {
            return this.CustomHorizontalStyle;
        }
        else if (activeViewDefinition.GetOrientation() == Orientation.Vertical)
        {
            return this.CustomVerticalStyle;
        }

        return base.SelectStyle(item, container, activeViewDefinition);
    }
}
#endregion

#region radscheduleview-howto-remove-delete-button_2
private void ScheduleView_ShowDialog(object sender, Telerik.Windows.Controls.ShowDialogEventArgs e)
{
    if (e.DialogViewModel is ConfirmDialogViewModel)
    {
        e.DefaultDialogResult = false;
        e.Cancel = true;
    }
}
#endregion
}
