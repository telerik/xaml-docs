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

    #region radtabcontrol-templating-custom-header-template_0
    public class HeaderSelector : Telerik.Windows.Controls.DataTemplateSelector
    {
    }
    #endregion

    #region radtabcontrol-templating-custom-header-template_2
    public class HeaderSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Animal)
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
