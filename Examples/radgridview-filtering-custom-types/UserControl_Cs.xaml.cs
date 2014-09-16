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

#region radgridview-filtering-custom-types_0

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
#endregion


#region radgridview-filtering-custom-types_2
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
}
#endregion

#region radgridview-filtering-custom-types_4
public override bool Equals(object obj)
{
    return ((IEquatable<Person>)this).Equals(obj as Person);
}

public override int GetHashCode()
{
    return this.Name.GetHashCode() ^ this.Age.GetHashCode();
}
#endregion

#region radgridview-filtering-custom-types_6
public override string ToString()
{
    return this.Name;
}
#endregion

#region radgridview-filtering-custom-types_8
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
#endregion

#region radgridview-filtering-custom-types_10
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
#endregion

#region radgridview-filtering-custom-types_12
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
#endregion


}
