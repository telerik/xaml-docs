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

#region radslider-tick-templateselector_2
public class TickTemplateSelector : DataTemplateSelector
{
}
#endregion

#region radslider-tick-templateselector_4
public class TickTemplateSelector : DataTemplateSelector
{
  public DataTemplate EllipseTemplate { get; set; }
  public DataTemplate EmptyTemplate { get; set; }
  public override DataTemplate SelectTemplate(object item, DependencyObject container)
  {
    double tick = Convert.ToDouble(item);
    if (tick % 4 == 0.0)
     {
       return EllipseTemplate;
     }
    else
     {
       return EmptyTemplate;
     }
  }
}
#endregion
}
