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
    #region persistence-framework-custom-property-provider-1
    public class SampleCustomPropertyProvider : ICustomPropertyProvider
    {
        #region ICustomPropertyProvider Members

        public CustomPropertyInfo[] GetCustomProperties()
        {
            // Create an array of CustomPropertyInfo objects to describe which properties should be persisted 
            return new CustomPropertyInfo[]
            {
                //Add CustomPropertyInfo objects
            };
        }

        public void InitializeObject(object context)
        {
            //Set the persisted component in a state such that it is ready to take the persisted settings
        }

        public object InitializeValue(CustomPropertyInfo customPropertyInfo, object context)
        {
            //Return a default value for the properties which the PersistenceFramework failed to restore
        }

        public object ProvideValue(CustomPropertyInfo customPropertyInfo, object context)
        {
            //Implement a logic that returns an object describing a property. 
            //Note that this event is fired once for each property from the array returned by the GetCustomProperties() method. 
            //Therefore you need to implement a logic that returns a separate object for each property.
        }

        public void RestoreValue(CustomPropertyInfo customPropertyInfo, object context, object value)
        {
            //Use the value argument to get the persisted settings.
            //Apply these settings on the context object as it represents the persisted component
        }

        #endregion
}
    #endregion
    #region persistence-framework-custom-property-provider-2
     ServiceProvider.RegisterPersistenceProvider<ICustomPropertyProvider>(typeof(SampleControl), new SampleCustomPropertyProvider());
    #endregion
}