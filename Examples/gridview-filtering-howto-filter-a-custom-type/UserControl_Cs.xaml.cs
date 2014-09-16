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

#region gridview-filtering-howto-filter-a-custom-type_0
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

#region gridview-filtering-howto-filter-a-custom-type_1
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

	public override bool Equals(object obj)
	{
		return ((IEquatable<Person>)this).Equals(obj as Person);
	}

	public override int GetHashCode()
	{
		return this.Name.GetHashCode() ^ this.Age.GetHashCode();
	}
}
#endregion

#region gridview-filtering-howto-filter-a-custom-type_2
public class PersonConverter : System.ComponentModel.TypeConverter
{
	public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, Type sourceType)
	{
		if (sourceType == typeof(string))
		{
			return true;
		}

		return base.CanConvertFrom(context, sourceType);
	}

	public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
	{
		var stringValue = value as string;
		if (stringValue != null)
		{
			return new Person(stringValue);
		}

		return base.ConvertFrom(context, culture, value);
	}

	public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, Type destinationType)
	{
		if (destinationType == typeof(string))
		{
			return true;
		}

		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(string))
		{
			return ((Person)value).ToString();
		}

		return base.ConvertTo(context, culture, value, destinationType);
	}
}
#endregion

#region gridview-filtering-howto-filter-a-custom-type_3
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
