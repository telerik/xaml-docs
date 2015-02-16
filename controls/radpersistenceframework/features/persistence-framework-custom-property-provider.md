---
title: CustomPropertyProviders
page_title: CustomPropertyProviders
description: CustomPropertyProviders
slug: persistence-framework-custom-property-provider
tags: custompropertyproviders
published: True
position: 3
---

# CustomPropertyProviders

This tutorial describes how to use a custom property provider to define the properties that should be persisted by the __PersistenceFramework__.	  

The __PersistenceFramework__ exposes an extension method that allows you to register a class to act as a property provider and define which properties of a persisted control should be saved and how. The method has the following syntax:	  

#### __C#__

    ServiceProvider.RegisterPersistenceProvider<ICustomPropertyProvider>(System.Type type, Telerik.Windows.Persistence.Services.IPersistenceProvider provider);

You need to pass as arguments the type of the component that will use the custom property provider and an instance of the custom property provider class.  

>A custom property provider should be used if:
>	- You need to persist more complex controls with complex properties such as the __RadGridView__.
>	- You need to have more control over the persistence process and specifically over the list of persisted properties and how they are provided to the __PersistenceFramework__ for serialization.			

## ICustomPropertyProvider

The __PersistenceFramework__ provides an __ICustomPropertyProvider__ interface which you should implement in order to create a custom property provider. It exposes the following methods:		

* __GetCustomProperties()__ - this method should return an array of {% if site.site_name == 'Silverlight' %}[CustomPropertyInfo](http://www.telerik.com/help/silverlight/t_telerik_windows_persistence_services_custompropertyinfo.html){% endif %}{% if site.site_name == 'WPF' %}[CustomPropertyInfo](http://www.telerik.com/help/wpf/t_telerik_windows_persistence_services_custompropertyinfo.html){% endif %} objects to represent the list of properties that have to be persisted by the __PersistenceFramework__.
 
* __InitializeObject(object__ - this method is intended to place the __context__ object (the control being persisted) in an appropriate state, before the __PersistenceFramework__ starts loading the persisted settings.			

* __InitializeValue(CustomPropertyInfo__ - this method is invoked to provide a valid value for a property when the deserialization fails to recreate the property's saved value (for example if it can't create a new instance of the class or the persisted value is null).			

* __ProvideValue(CustomPropertyInfo__ - this method is invoked for each property from the array returned by the __GetCustomProperties()__ method. It should return a proper value, which the __PersistenceFramework__ can persist.			

* __RestoreValue(CustomPropertyInfo__ - this method is invoked for each persisted property to restore its persisted value and load it.			

## Creating a custom property provider

You can implement the above methods in a custom property provider class as follows:		

#### __C#__

{{region persistence-framework-custom-property-provider-1}}
    public class SampleCustomPropertyProvider : ICustomPropertyProvider
    {	
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
    }
{{endregion}}

#### __VB.NET__
{{region persistence-framework-custom-property-provider-1}}
    Public Class SampleCustomPropertyProvider
        Implements ICustomPropertyProvider

        Public Function GetCustomProperties() As CustomPropertyInfo()
            ' Create an array of CustomPropertyInfo objects to describe which properties should be persisted '		
            Return New CustomPropertyInfo() {}
        End Function

        Public Sub InitializeObject(context As Object)
            'Set the persisted component in a state such that it is ready to take the persisted settings '
        End Sub

        Public Function InitializeValue(customPropertyInfo As CustomPropertyInfo, context As Object) As Object
            'Return a default value for the properties which the PersistenceFramework failed to restore '
        End Function

        Public Function ProvideValue(customPropertyInfo As CustomPropertyInfo, context As Object) As Object
            'Implement logic that returns an object describing a persisted property. '
            'Note that this event is fired once for each property from the array returned by the GetCustomProperties() method. '
            'Therefore you need to implement a logic that returns a separate object for each property. '
        End Function

        Public Sub RestoreValue(customPropertyInfo As CustomPropertyInfo, context As Object, value As Object)
            'Use the value argument to get the persisted settings. '
            'Apply these settings on the context object as it represents the persisted component '
        End Sub
    End Class
{{endregion}}

Next, you need to register the __SampleCustomPropertyProvider__ in the application.		

#### __C#__
{{region persistence-framework-custom-property-provider-2}}
    ServiceProvider.RegisterPersistenceProvider<ICustomPropertyProvider>(typeof(SampleControl), new SampleCustomPropertyProvider());
{{endregion}}

#### __VB.NET__
{{region persistence-framework-custom-property-provider-2}}
    ServiceProvider.RegisterPersistenceProvider(Of ICustomPropertyProvider)(GetType(SampleControl), New SampleCustomPropertyProvider())
{{endregion}}

>Please note that the __SampleControl__ type is simply an example and instead you need to define the type of the component for which the __SampleCustomPropertyProvider__ is built.

{% if site.site_name == 'Silverlight' %}
You can find examples of __ICustomPropertyProvider__ implementations in the following demos:
* [GridView Serializaiton](http://demos.telerik.com/silverlight/#PersistenceFramework/GridViewCustomSerialization)
* [Docking Serializaiton](http://demos.telerik.com/silverlight/#PersistenceFramework/DockingCustomSerialization)
{% endif %}

{% if site.site_name == 'WPF' %}
You can find examples of __ICustomPropertyProvider__ implementations in the __PersistenceFramework__ demos. Open the  [UI for WPF demos](http://demos.telerik.com/wpf/) and search for the following examples:
* __GridView Serializaiton__
* __Docking Serializaiton__
{% endif %}

# See Also
 * [Isolated Storage]({%slug persistence-framework-isolated-storage%})
 * [Save in a Stream]({%slug persistence-framework-save-stream%})
 * [Serialization Options]({%slug persistence-framework-defining-properties%})