---
title: Filter a Custom Type
page_title: Filter a Custom Type
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to filter a custom type.
slug: gridview-filtering-howto-filter-a-custom-type
tags: filter,a,custom,type
published: True
position: 11
---

# Filter a Custom Type

If you want to filter a column that is data-bound to a custom type, you need to make sure that your custom type meets certain criteria. We will use the type **Person** as an example.

__Example 1: The Person class__

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
```VB.NET
	Public Class Person
	    Private ReadOnly m_name As String
	    Private m_age As Integer
	
	    Public ReadOnly Property Name() As String
	        Get
	            Return Me.m_name
	        End Get
	    End Property
	
	    Public Property Age() As Integer
	        Get
	            Return Me.m_age
	        End Get
	        Set(value As Integer)
	            Me.m_age = value
	        End Set
	    End Property
	
	    Public Sub New(name As String)
	        Me.m_name = name
	    End Sub
	End Class
```

The first thing that you need to do is implement the generic **IEquatable** interface. It has a single method called **Equals**. Next, you need to override **Object.Equals(Object)** and **Object.GetHashCode**. MSDN states that if you implement generic **IEquatable**, you have to also override the base class implementations of Object.Equals(Object) and Object.GetHashCode so that their behavior is consistent with that of the generic IEquatable.Equals method.

## Implement IEquatable

__Example 2: IEquatable implementation__

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
	}
```
```VB.NET
	Public Class Person
	    Implements IEquatable(Of Person)
	    Private ReadOnly m_name As String
	    Private m_age As Integer
	
	    Public ReadOnly Property Name() As String
	        Get
	            Return Me.m_name
	        End Get
	    End Property
	
	    Public Property Age() As Integer
	        Get
	            Return Me.m_age
	        End Get
	        Set(value As Integer)
	            Me.m_age = value
	        End Set
	    End Property
	
	    Public Sub New(name As String)
	        Me.m_name = name
	    End Sub
	
	    Public Function GenericEquals(other As Person) As Boolean Implements IEquatable(Of Person).[Equals]
	        If other Is Nothing Then
	            Return False
	        End If
	
	        Return StringComparer.Ordinal.Equals(Me.Name, other.Name)
	    End Function
	End Class
```

## Override Object.Equals(Object) and Object.GetHashCode

If you do override Object.Equals(Object), your overridden implementation is also called in calls to the static Equals(System.Object, System.Object) method on your class. This ensures that all invocations of the Equals method return consistent results. Furthermore, the GetHashCode method will be used by the framework when the distinct values need to be discovered.

__Example 3: Equals and GetHashCode overrides__

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
```VB.NET	
	Public Overrides Function Equals(obj As Object) As Boolean
		Return DirectCast(Me, IEquatable(Of Person)).Equals(TryCast(obj, Person))
	End Function

	Public Overrides Function GetHashCode() As Integer
		Return Me.Name.GetHashCode() Xor Me.Age.GetHashCode()
	End Function
```

## Override ToString

Next, you need to override the **ToString** method of your type so that distinct values and grid cells display a friendly representation of your class. Here is what the class might look like:

__Example 4: ToString override__

```C#
	public override string ToString()
	{
		return this.Name;
	}
```
```VB.NET	
	Public Overrides Function ToString() As String
		Return Me.Name
	End Function
```

## Define a TypeConverter for String Conversions

Next you will need to define a **TypeConverter** for string conversions. When RadGridView encounters a custom type it will use a plain TextBox for the field filter editors. The strings that user enters have to be converted to your custom type and vice versa. This can be achieved by specifying a TypeConverter on your class.

__Example 5: Custom TypeConverter__

```C#
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
```
```VB.NET
	Public Class PersonConverter
	    Inherits System.ComponentModel.TypeConverter
	    Public Overrides Function CanConvertFrom(context As System.ComponentModel.ITypeDescriptorContext, sourceType As Type) As Boolean
	        If sourceType = GetType(String) Then
	            Return True
	        End If
	
	        Return MyBase.CanConvertFrom(context, sourceType)
	    End Function
	
	    Public Overrides Function ConvertFrom(context As System.ComponentModel.ITypeDescriptorContext, culture As System.Globalization.CultureInfo, value As Object) As Object
	        Dim stringValue = TryCast(value, String)
	        If stringValue IsNot Nothing Then
	            Return New Person(stringValue)
	        End If
	
	        Return MyBase.ConvertFrom(context, culture, value)
	    End Function
	
	    Public Overrides Function CanConvertTo(context As System.ComponentModel.ITypeDescriptorContext, destinationType As Type) As Boolean
	        If destinationType = GetType(String) Then
	            Return True
	        End If
	
	        Return MyBase.CanConvertTo(context, destinationType)
	    End Function
	
	    Public Overrides Function ConvertTo(context As System.ComponentModel.ITypeDescriptorContext, culture As System.Globalization.CultureInfo, value As Object, destinationType As Type) As Object
	        If destinationType = GetType(String) Then
	            Return DirectCast(value, Person).ToString()
	        End If
	
	        Return MyBase.ConvertTo(context, culture, value, destinationType)
	    End Function
	End Class
```

Do not forget to add the **TypeConverter** attribute on your class definition and point it to the custom TypeConverter that you just created.

__Example 6: Adding the TypeConverter attribute__

```C#
	[TypeConverter(typeof(PersonConverter))]
    public class Person : IEquatable<Person>
    {
        // ...
    }
```
```VB.NET
	<TypeConverter(GetType(PersonConverter))>
	Public Class Person
		Implements IEquatable(Of Person)

		' ...
	End Class
```

If the plain TextBox does not suit your needs, you can provide your own field filter editor by overriding the **GridViewDataColumn.CreateFieldFilterEditor** method as described [here]({%slug gridview-filtering-howto-create-a-custom-field-filter-editor%}). You will no longer need a TypeConverter if your custom field filter editor is able to produce instances of your custom type.

## Override the Comparison Operators (Optional)

If you want to see the comparison filter operators (**Is Less Than**, etc.) you should override your custom type's comparison operators.

__Example 7: Comparison operators override__

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
```VB.NET
	Public Shared Operator <(left As Person, right As Person) As Boolean
	    Return left.Age < right.Age
	End Operator
	
	Public Shared Operator <=(left As Person, right As Person) As Boolean
	    Return left.Age <= right.Age
	End Operator
	
	Public Shared Operator >(left As Person, right As Person) As Boolean
	    Return left.Age > right.Age
	End Operator
	
	Public Shared Operator >=(left As Person, right As Person) As Boolean
	    Return left.Age >= right.Age
	End Operator
```

## See Also

* [Basic Filtering]({%slug gridview-filtering-basic%})
* [Create a Custom Field Filter Editor]({%slug gridview-filtering-howto-create-a-custom-field-filter-editor%})
* [Customize the Default Field Filter Editor]({%slug gridview-filtering-howto-customize-the-default-field-filter-editor%})