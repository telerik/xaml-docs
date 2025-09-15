---
title: CustomPropertyProviders
page_title: CustomPropertyProviders
description: Check our &quot;CustomPropertyProviders&quot; documentation article for the RadPersistenceFramework {{ site.framework_name }} control.
slug: persistence-framework-custom-property-provider
tags: custompropertyproviders
published: True
position: 3
---

# CustomPropertyProviders

This tutorial describes how to use a custom property provider to define the properties that should be persisted by the __PersistenceFramework__.	  

The __PersistenceFramework__ exposes an extension method that allows you to register a class to act as a property provider and define which properties of a persisted control should be saved and how. The method has the following syntax:	  

__Example 1: Register Custom Provider__
```C#
    ServiceProvider.RegisterPersistenceProvider<ICustomPropertyProvider>(System.Type type, Telerik.Windows.Persistence.Services.IPersistenceProvider provider);
```

You need to pass as arguments the type of the component that will use the custom property provider and an instance of the custom property provider class.  

>A custom property provider should be used if:
>	* You need to persist more complex controls with complex properties such as the __RadGridView__.
>	* You need to have more control over the persistence process and specifically over the list of persisted properties and how they are provided to the __PersistenceFramework__ for serialization.			

The PersistenceFramework provides several providers which can be used to persist specific properties.

* [ICustomPropertyProvider](#icustompropertyprovider)
* [IAttachedPropertyProvider](#iattachedpropertyprovider)
* [IPropertyProvider](#ipropertyprovider)
* [IPropertyValidatorProvider](#ipropertyvalidatorprovider)
* [ITypeConverterProvider](#itypeconverterprovider)

## ICustomPropertyProvider

The __PersistenceFramework__ provides an __ICustomPropertyProvider__ interface which you should implement in order to create a custom property provider. It exposes the following methods:		

* __GetCustomProperties()__ - this method should return an array of {% if site.site_name == 'Silverlight' %}[CustomPropertyInfo](http://www.telerik.com/help/silverlight/t_telerik_windows_persistence_services_custompropertyinfo.html){% endif %}{% if site.site_name == 'WPF' %}[CustomPropertyInfo](http://www.telerik.com/help/wpf/t_telerik_windows_persistence_services_custompropertyinfo.html){% endif %} objects to represent the list of properties that have to be persisted by the __PersistenceFramework__.
 
* __InitializeObject(object__ - this method is intended to place the __context__ object (the control being persisted) in an appropriate state, before the __PersistenceFramework__ starts loading the persisted settings.			

* __InitializeValue(CustomPropertyInfo__ - this method is invoked to provide a valid value for a property when the deserialization fails to recreate the property's saved value (for example if it can't create a new instance of the class or the persisted value is null).			

* __ProvideValue(CustomPropertyInfo__ - this method is invoked for each property from the array returned by the __GetCustomProperties()__ method. It should return a proper value, which the __PersistenceFramework__ can persist.			

* __RestoreValue(CustomPropertyInfo__ - this method is invoked for each persisted property to restore its persisted value and load it.			

## Creating a custom property provider

You can implement the above methods in a custom property provider class as follows:		

__Example 2: Implement ICustomPropertyProvider interface__

```C#
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
```
```VB.NET
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
```

Next, you need to register the __SampleCustomPropertyProvider__ in the application.		

__Example 3: Register the SampleCustomPropertyProvider class__
```C#
    ServiceProvider.RegisterPersistenceProvider<ICustomPropertyProvider>(typeof(SampleControl), new SampleCustomPropertyProvider());
```
```VB.NET
    ServiceProvider.RegisterPersistenceProvider(Of ICustomPropertyProvider)(GetType(SampleControl), New SampleCustomPropertyProvider())
```

>Please note that the __SampleControl__ type is simply an example and instead you need to define the type of the component for which the __SampleCustomPropertyProvider__ is built.

{% if site.site_name == 'Silverlight' %}
You can find examples of __ICustomPropertyProvider__ implementations in the following demos:
* [GridView Serializaiton](https://demos.telerik.com/silverlight/#PersistenceFramework/GridViewCustomSerialization)
* [Docking Serializaiton](https://demos.telerik.com/silverlight/#PersistenceFramework/DockingCustomSerialization)
{% endif %}

{% if site.site_name == 'WPF' %}
You can find examples of __ICustomPropertyProvider__ implementations in the __PersistenceFramework__ demos. Open the  [UI for WPF demos](https://demos.telerik.com/wpf/) and search for the following examples:
* __GridView Serializaiton__
* __Docking Serializaiton__
{% endif %}

## IAttachedPropertyProvider

This __IAttachedPropertyProvider__ interface should be implement when you want to persist custom attached properties. It exposes the following method:

* __GetAttachedPropertyTypeProviders():__ This method should return an array of Type objects to represent the list of attached properties that have to be persisted by the __PersistenceFramework__.

__Example 4: Implement IAttachedPropertyProvider interface__
```C#   
	public class CustomAttachedProvider : IAttachedPropertyProvider
    {
        public Type[] GetAttachedPropertyTypeProviders()
        {
            return new Type[]
			{
			};
        }
    }
```

## IPropertyProvider

This __IPropertyProvider__ interface should be implement when you want to control which properties should be saved.

* __GetProperties():__ this method should return an array of __PropertyInfo__ objects to represent the list of properties that have to be persisted by the __PersistenceFramework__.

__Example 5: Implement IPropertyProvider interface__
```C#   
	public class CustomPropertyProvider : IPropertyProvider
    {
        public PropertyInfo[] GetProperties()
        {
		List<PropertyInfo> properties = new List<PropertyInfo>();
		var allProperties = typeof(RadGridView).GetProperties();
		foreach (PropertyInfo item in allProperties)
		{
			if (item.Name == "Width" || item.Name == "Height")
			{
				properties.Add(item);
			}
		}
		return properties.ToArray();
	}
    }
```

## IPropertyValidatorProvider

By implementing this interface you can validate if a property should be saved or not. 

* __IsValid():__ This method return true or false if a property should be persist.

__Example 6: Implement IPropertyValidatorProvider interface__
```C#   
	public class PropertyValidatorProvider : IPropertyValidatorProvider
    {
        public bool IsValid(string propertyName, Type propertyType, object context, object value)
        {
           return true;
        }
    }
```

>Only one validator for given type should be register.

## ITypeConverterProvider

The __ITypeConverterProvider__ interface should be implement in order to convert a values or properties.	

* __GetTypeConverterType():__ This method return the type of the __TypeConverter__.

__Example 7: Implement ITypeConverterProvider interface__
```C#   
	public class TypeProvider : ITypeConverterProvider
    {
        public Type GetTypeConverterType()
        {
            return typeof(CustomTypeConverter);
        }
    }
    public class CustomTypeConverter : TypeConverter
    {        
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return base.CanConvertFrom(context, sourceType);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return base.ConvertFrom(context, culture, value);
        }
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return base.CanConvertTo(context, destinationType);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
```

## See Also
 * [Isolated Storage]({%slug persistence-framework-isolated-storage%})
 * [Save in a Stream]({%slug persistence-framework-save-stream%})
 * [Serialization Options]({%slug persistence-framework-defining-properties%})
