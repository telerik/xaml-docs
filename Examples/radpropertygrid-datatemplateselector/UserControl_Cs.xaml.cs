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

    #region radpropertygrid-datatemplateselector_1
    
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Department Department { get; set; }
    }
 
    public class FieldTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            PropertyDefinition propDef = item as PropertyDefinition;
            if (propDef.DisplayName == "PhoneNumber")
            {
                return this.PhoneNumberDataTemplate;
            }
            if (propDef.SourceProperty.PropertyType == typeof(string))
            {
                return this.StringDataTemplate;
            }
            return null;
        }
 
        public DataTemplate PhoneNumberDataTemplate { get; set; }
        public DataTemplate StringDataTemplate { get; set; }
    }

    #endregion

}
