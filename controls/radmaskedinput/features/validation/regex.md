---
title: Using DataAnnotation Attributes
page_title: Using DataAnnotation Attributes
description: Check our &quot;Using DataAnnotation Attributes&quot; documentation article for the RadMaskedInput {{ site.framework_name }} control.
slug: radmaskedinput-validation-regex
tags: using,dataannotation,attributes
published: True
position: 1
---

# Using DataAnnotation Attributes

## Validating Input Through Data Annotations

With the {{ site.framework_name }} framework you can take advantage of the __System.ComponentModel.DataAnnotations__ assembly. The following code snippet demonstrates how to use data annotation attributes to validate a property value. It is even better when you use __RIA services__, since this code will be automatically added for you by the __RIA Service's__ code generator.		

__Example 1: Creating DataAnnotationAttributesValidationViewModel class__
```C#
	public class DataAnnotationAttributesValidationViewModel : ViewModelBase
    {
        private double doubleValue;
        private string stringValue;
        private decimal decimalValue;
        private DateTime dateTimeValue;
        [Range(-100d, 100d)]
        public double DoubleValue
        {
            get { return doubleValue; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "DoubleValue" });
                doubleValue = value;
                this.OnPropertyChanged("DoubleValue");
            }
        }
        [Range(typeof(decimal), "-100", "100")]
        public decimal DecimalValue
        {
            get { return decimalValue; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "DecimalValue" });
                decimalValue = value;
                this.OnPropertyChanged("DecimalValue");
            }
        }
        [Range(typeof(DateTime), "01.01.1900", "01.01.2099")]
        public DateTime DateTimeValue
        {
            get { return dateTimeValue; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "DateTimeValue" });
                dateTimeValue = value;
                this.OnPropertyChanged("DateTimeValue");
            }
        }
        [StringLength(6)]
        [Required()]
        public string StringValue
        {
            get { return stringValue; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "StringValue" });
                stringValue = value;
                this.OnPropertyChanged("StringValue");
            }
        }
    }
```
```VB.NET
	Public Class DataAnnotationAttributesValidationViewModel
		Inherits ViewModelBase
		Private m_doubleValue As Double
		Private m_stringValue As String
		Private m_decimalValue As Decimal
		Private m_dateTimeValue As Date
		<Range(-100.0, 100.0)>
		Public Property DoubleValue() As Double
			Get
				Return m_doubleValue
			End Get
			Set(value As Double)
				Validator.ValidateProperty(Value, New ValidationContext(Me, Nothing, Nothing) With {.MemberName = "DateTimeValue"})
				m_doubleValue = Value
				Me.OnPropertyChanged("DoubleValue")
			End Set
		End Property
		<Range(GetType(Decimal), "-100", "100")>
		Public Property DecimalValue() As Decimal
			Get
				Return m_decimalValue
			End Get
			Set(value As Decimal)
				Validator.ValidateProperty(Value, New ValidationContext(Me, Nothing, Nothing) With {.MemberName = "DecimalValue"})
				m_decimalValue = Value
				Me.OnPropertyChanged("DecimalValue")
			End Set
		End Property
		<Range(GetType(Date), "01.01.1900", "01.01.2099")>
		Public Property DateTimeValue() As Date
			Get
				Return m_dateTimeValue
			End Get
			Set(value As Date)
				Validator.ValidateProperty(Value, New ValidationContext(Me, Nothing, Nothing) With {.MemberName = "DateTimeValue"})
				m_dateTimeValue = Value
				Me.OnPropertyChanged("DateTimeValue")
			End Set
		End Property
		<StringLength(6)>
		<Required>
		Public Property StringValue() As String
			Get
				Return m_stringValue
			End Get
			Set(value As String)
				Validator.ValidateProperty(Value, New ValidationContext(Me, Nothing, Nothing) With {.MemberName = "StringValue"})
				m_stringValue = Value
				Me.OnPropertyChanged("StringValue")
			End Set
		End Property
	End Class
```

>In order to use DataAnnotations you should add a reference to the __System.ComponentModel.DataAnnotations__ assembly.		  

>important Note that you have to invoke the __Validator.ValidateProperty__ method before setting a new value in the property setter.		  

Now we need to define several __RadMaskedInput__ controls in XAML for displaying the sample data:		

__Example 2: Defining several RadMaskedInput controls__
```XAML
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinition Height="Auto" />
			<RowDefinition Height="Auto" />
			<RowDefinition Height="Auto" />
			<RowDefinition Height="Auto" />
		</Grid.RowDefinitions>
		<telerik:RadMaskedNumericInput Grid.Row="0" Width="200" AllowInvalidValues="True"
				Margin="10, 10, 10, 0" ErrorMessage="{Binding Path=Text, ElementName=customErrorMessage}"
				InputBehavior="Insert"
				Value="{Binding Path=DoubleValue, Mode=TwoWay, ValidatesOnExceptions=True}" />
		<telerik:RadMaskedCurrencyInput  Grid.Row="1" Width="200" AllowInvalidValues="True"
				Margin="10, 10, 10, 0" ErrorMessage="{Binding Path=Text, ElementName=customErrorMessage}"
				InputBehavior="Insert"
				Value="{Binding Path=DecimalValue, Mode=TwoWay, ValidatesOnExceptions=True}" />
		<telerik:RadMaskedDateTimeInput  Grid.Row="2" Width="200" AllowInvalidValues="True"
				Margin="10, 10, 10, 0" ErrorMessage="{Binding Path=Text, ElementName=customErrorMessage}"
				Value="{Binding Path=DateTimeValue, Mode=TwoWay, ValidatesOnExceptions=True}" />
		<telerik:RadMaskedTextInput  Grid.Row="3" Width="200" Margin="10"
				ErrorMessage="{Binding Path=Text, ElementName=customErrorMessage}" AllowInvalidValues="True"
				Value="{Binding Path=StringValue, Mode=TwoWay,ValidatesOnExceptions=True}" />
	</Grid>
```

>important Note that you have set __AllowInvalidValues__ to True. This ensures that the Setter of the properties will be fired even if the DataAnnotaion Validation does not succeed.		  

And finally we need to set the __DataContext__ accordingly:		

__Example 3: Setting the DataContext to the view model__
```C#
	this.DataContext = new DataAnnotationAttributesValidationViewModel();
```
```VB.NET
	Me.DataContext = New DataAnnotationAttributesValidationViewModel()
```

Below you can see how the MaskedInputs are being validated:		  

![Rad Masked Input-Validation-Data AnnotationsWPF](images/radmaskedinput_validation_data_annotations_01-wpf.png)

## Regular Expressions

The __MaskedInput__ suite of controls allow validation through __Regular Expressions__. In order to implement __regex__ validation you will need a view model implementing the __INotifyPropertyChanged__ interface. For the purpose of this tutorial we will define a ViewModel that contains Email and WebAddress properties. For each property we will apply a regular expression to validate the user's input in the __MaskedInput__ control that will display the property accordingly.		

First, we need a view model:

__Example 4: Creating MaskedInputViewModel class__
```C#
	public class MaskedInputViewModel : ViewModelBase
    {
        private string email = "username@email.com";
        /// <summary>
        ///     Gets or sets the email.
        /// </summary>
        [RegularExpression(@"\b[a-z0-9._%-]+@[a-z0-9.-]+\.[a-z]{2,4}\b", ErrorMessage = "Invalid Email Address.")]
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (this.email != value)
                {
                    Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Email" });
                    this.email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        private string webAddress = "http://www.sampleaddress.com";
        /// <summary>
        ///     Gets or sets the webAddress.
        /// </summary>
        [RegularExpression(@"http://www.+\b[a-z0-9._%-]+\.[a-z]{2,4}\b", ErrorMessage = "Invalid Web Address.")]
        public string WebAddress
        {
            get
            {
                return this.webAddress;
            }
            set
            {
                if (this.webAddress != value)
                {
                    Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "WebAddress" });
                    this.webAddress = value;
                    OnPropertyChanged("WebAddress");
                }
            }
        }
    }
```
```VB.NET
	Public Class MaskedInputViewModel
		Inherits ViewModelBase
		Private m_email As String = "username@email.com"
		''' <summary>
		'''     Gets or sets the email.
		''' </summary>
		<RegularExpression("\b[a-z0-9._%-]+@[a-z0-9.-]+\.[a-z]{2,4}\b", ErrorMessage:="Invalid Email Address.")>
		Public Property Email() As String
			Get
				Return Me.m_email
			End Get
			Set
				If Me.m_email <> Value Then
					Validator.ValidateProperty(Value, New ValidationContext(Me, Nothing, Nothing) With {.MemberName = "Email"})
					Me.m_email = Value
					OnPropertyChanged("Email")
				End If
			End Set
		End Property
		Private m_webAddress As String = "http://www.sampleaddress.com"
		''' <summary>
		'''     Gets or sets the webAddress.
		''' </summary>
		<RegularExpression("http://www.+\b[a-z0-9._%-]+\.[a-z]{2,4}\b", ErrorMessage:="Invalid Web Address.")>
		Public Property WebAddress() As String
			Get
				Return Me.m_webAddress
			End Get
			Set
				If Me.m_webAddress <> Value Then
					Validator.ValidateProperty(Value, New ValidationContext(Me, Nothing, Nothing) With {.MemberName = "WebAddress"})
					Me.m_webAddress = Value
					OnPropertyChanged("WebAddress")
				End If
			End Set
		End Property
	End Class
```

>important Note that you have to invoke the __Validator.ValidateProperty__ method before setting a new value in the property setter.

In the above __MaskedInputViewModel__ implementation it is important to note the __regular expressions__ that validate the Email and WebAddress properties, as well as the custom __ErrorMessage__ that is defined for each property. In order to  apply such attributes that specify validation rules, you need to add a reference to the [System.ComponentModel.DataAnnotations](http://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.aspx) namespace.
		
Then you can define the __RadMaskedInput__ controls that will display the Email and WebAddress business properties:		

__Example 5: Defining  RadMaskedInput controls in XAML__
```XAML
	<telerik:RadMaskedTextInput AllowInvalidValues="True" Value="{Binding Path=Email, Mode=TwoWay, ValidatesOnExceptions=True}"/>
	<telerik:RadMaskedTextInput AllowInvalidValues="True" Value="{Binding Path=WebAddress, Mode=TwoWay, ValidatesOnExceptions=True}" Mask="a30" />
```

>important Note that you have set __AllowInvalidValues__ to True. This ensures that the Setter of the properties will be fired even if the DataAnnotaion Validation does not succeed.
		  
And finally you need to set the __MaskedInputViewModel__ as __DataContext__ of the __MaskedTextInput__ controls:		

__Example 6: Setting the DataContext in XAML__
```XAML
	<UserControl  
		 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
		 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
		 xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
		 xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
		 xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
		 xmlns:vm="clr-namespace:MaskedInputValidation"
		 d:DesignHeight="300"
		 d:DesignWidth="400"
		 mc:Ignorable="d">
		<UserControl.DataContext>
			<vm:MaskedInputViewModel />
		</UserControl.DataContext>
		<Grid x:Name="LayoutRoot" Background="White">
			<StackPanel>
				<StackPanel Margin="5" Orientation="Horizontal">
					<TextBlock VerticalAlignment="Center" Text="Enter Email Address: " />
					<telerik:RadMaskedTextInput VerticalAlignment="Center" AllowInvalidValues="True" Value="{Binding Path=Email, Mode=TwoWay, ValidatesOnExceptions=True}" />
				</StackPanel>
				<StackPanel Margin="5" Orientation="Horizontal">
					<TextBlock VerticalAlignment="Center" Text="Enter Web Address: " />
					<telerik:RadMaskedTextInput VerticalAlignment="Center" AllowInvalidValues="True"
										Mask="a30"
										Value="{Binding Path=WebAddress, Mode=TwoWay, ValidatesOnExceptions=True}" />
				</StackPanel>
			</StackPanel>
		</Grid>
	</UserControl>
```
