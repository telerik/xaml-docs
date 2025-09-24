---
title: Filtering Custom Types
page_title: Filtering Custom Types
description: Check out this step-by-step tutorial for Telerik's {{ site.framework_name }} DataGrid showing how to implement your own filtering to a column that is data-bound to a custom type.  
slug: radgridview-filtering-custom-types
tags: filtering,custom,types
published: False
position: 7
---

# Filtering Custom Types

If you want to filter a column that is __data-bound to a custom type__, you need to make sure that your custom type meets certain criteria. This article is a step-by-step tutorial on how to implement your __own filtering__ for the custom type.

## Define a sample data

Add one or more sections with content



```C#
	public class Person
	{
	    private readonly string name;
	    private int age;
	
	    public string Name
	    {
	        get { return this.name; }
	    }
	
	    public int Age
	    {
	        get { return this.age; }
	        set { this.age = value; }
	    }
	
	    public Person(string name)
	    {
	        this.name = name;
	    }
	}
```

## Implement IEquatable
      

The first thing that you need to do is implement the IEquatable interface. It has a single method called Equals.



```C#
	public class Person : IEquatable<Person>
	{
	    private readonly string name;
	    private int age;
	
	    public string Name
	    {
	        get { return this.name; }
	    }
	
	    public int Age
	    {
	        get { return this.age; }
	        set { this.age = value; }
	    }
	
	    public Person(string name)
	    {
	        this.name = name;
	    }
	
	    bool IEquatable<Person>.Equals(Person other)
	    {
	        if (other == null)
	        {
	            return false;
	        }
	
	        return StringComparer.Ordinal.Equals(this.Name, other.Name);
	    }
```

## Override Object.Equals(Object) and Object.GetHashCode

Next, you need to override Object.Equals(Object) and Object.GetHashCode. MSDN states that if you implement IEquatable, you should also override the base class implementations of Object.Equals(Object) and Object.GetHashCode so that their behavior is consistent with that of the IEquatable.Equals method. If you do override Object.Equals(Object), your overridden implementation is also called in calls to the static Equals(System.Object, System.Object) method on your class. This ensures that all invocations of the Equals method return consistent results. Furthermore, the GetHashCode method will be used by the framework when the distinct values need to be discovered.



```C#
	public override bool Equals(object obj)
	{
	    return ((IEquatable<Person>)this).Equals(obj as Person);
	}
	
	public override int GetHashCode()
	{
	    return this.Name.GetHashCode() ^ this.Age.GetHashCode();
	}
```

## Override ToString

You need to override the ToString method of your type so that distinct values and grid cells display a friendly representation of your class.



```C#
	public override string ToString()
	{
	    return this.Name;
	}
```

## Define a TypeConverter for string conversions

When RadGridView encounters a custom type it will use a plain TextBox for the field filter editors. The strings that user enters have to be converted to your custom type and vice versa. This can be achieved by specifying a TypeConverter on your class.
        


```C#
	public class PersonConverter : TypeConverter
	{
	    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	    {
	        if (sourceType == typeof(string))
	        {
	            return true;
	        }
	
	        return base.CanConvertFrom(context, sourceType);
	    }
	
	    public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
	    {
	        var stringValue = value as string;
	        if (stringValue != null)
	        {
	            return new Person(stringValue);
	        }
	
	        return base.ConvertFrom(context, culture, value);
	    }
	
	    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	    {
	        if (destinationType == typeof(string))
	        {
	            return true;
	        }
	
	        return base.CanConvertTo(context, destinationType);
	    }
	
	    public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
	    {
	        if (destinationType == typeof(string))
	        {
	            return ((Person)value).ToString();
	        }
	
	        return base.ConvertTo(context, culture, value, destinationType);
	    }
	}
	
	[TypeConverter(typeof(PersonConverter))]
	public class Person : IEquatable<Person>
```

If the plain TextBox does not suit your needs, you can provide your own field filter editor by overriding the GridViewColumn.CreateFieldFilterEditor method. You will no longer need a TypeConverter if your custom field filter editor is able to produce instances of your custom type. You only need to data-bind your editor’s significant property to a property called Value residing on its DataContext. The UnsetValue singleton is used for deactivating a filter. Here is what a custom field filter editor may look like:
        


```C#
	public class MyDateTimeColumn : GridViewColumn
	{
	    public override FrameworkElement CreateFieldFilterEditor()
	    {
	        var dateTimePicker = new RadDateTimePicker();
	        dateTimePicker.InputMode = InputMode.DatePicker;
	        dateTimePicker.IsTooltipEnabled = false;
	
	        var selectedValueBinding = new Binding("Value")
	        {
	            Mode = BindingMode.TwoWay,
	            FallbackValue = null,
	            Converter = new DateTimeFilterEditorConverter()
	        };
	        dateTimePicker.SetBinding(RadDateTimePicker.SelectedValueProperty, selectedValueBinding);
	
	        return dateTimePicker;
	    }
	
	    private class DateTimeFilterEditorConverter : IValueConverter
	    {
	        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	        {
	            if (value == FilterDescriptor.UnsetValue)
	            {
	                return null;
	            }
	
	            return value;
	        }
	
	        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	        {
	            if (value == null)
	            {
	                return FilterDescriptor.UnsetValue;
	            }
	
	            return value;
	        }
	    }
	}
```

Of course, you don’t need to do that for a DateTime column, since RadGridView does it out-of-the-box. This is just an illustration of how to wire your custom field filter editor.

## Override the Comparison Operators (Optional)

If you want to see the comparison filter operators (Is Less Than, etc.) you should override your custom type’s comparison operators.



```C#
	public static bool operator <(Person left, Person right)
	{
	    return left.Age < right.Age;
	}
	
	public static bool operator <=(Person left, Person right)
	{
	    return left.Age <= right.Age;
	}
	
	public static bool operator >(Person left, Person right)
	{
	    return left.Age > right.Age;
	}
	
	public static bool operator >=(Person left, Person right)
	{
	    return left.Age >= right.Age;
	}
```

This is all you need to do in order to enable filtering for your custom type.
        
