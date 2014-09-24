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

#region radtabcontrol-item-templates-and-selectors_5
public class ContentSelector : Telerik.Windows.Controls.DataTemplateSelector
{
}
#endregion

#region radtabcontrol-item-templates-and-selectors_7
public class ContentSelector : Telerik.Windows.Controls.DataTemplateSelector
{
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        if (((LifeForm)item).Type == LifeFormTypes.Animal)
        {
            return Application.Current.Resources["AnimalDataTemplate"] as DataTemplate;
        }
        else
        {
            return Application.Current.Resources["PlantDataTemplate"] as DataTemplate;
        }
    }
}
#endregion
}
