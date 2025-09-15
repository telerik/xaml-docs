---
title: RadNumericUpDown Validation Using IDataErrorInfo Interface
page_title: Validation for RadNumericUpDown Using the IDataErrorInfo Interface
description: This article shows how to achieve validation for the RadNumericUpDown control using the IDataErrorInfo interface.
type: how-to
slug: kb-numericupdown-validation-idataerrorinfo
position: 0
tags: numericupdown, validation, idataerrorinfo
ticketid: 1592516
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.3.1109</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadNumericUpDown for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to validate the `Value` property of the `RadNumericUpDown` control on custom criteria.

## Solution

To achieve this functionality, you can implement the [IDataErrorInfo](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.idataerrorinfo?view=net-7.0) interface in your view model. 

__Implementing IDataErrorInfo interface__
```C#
    public class NumericUpDownViewModel : ViewModelBase, IDataErrorInfo
    {
    	private double numericUpDownValue;

        public NumericUpDownViewModel()
        {
            this.NumericUpDownValue = -5;
        }

        public double NumericUpDownValue
        {
            get { return this.numericUpDownValue; }
            set
            {
                this.numericUpDownValue = value;
                this.OnPropertyChanged(nameof(this.NumericUpDownValue));
            }
        }

        public string Error
        {
            get { return this[string.Empty]; }
        }

        public string this[string name]
        {
            get
            {
                string result = null;

                if (name == "NumericUpDownValue")
                {
                    return this.ValidateValue();
                }

                return result;
            }
        }

        private string ValidateValue()
        {
            if (this.NumericUpDownValue < 0)
            {
                return "Value cannot be a negative number";
            }

            return null;
        }
    }
```
```VB.NET
    Public Class NumericUpDownViewModel
        Inherits ViewModelBase
        Implements IDataErrorInfo
        Private numericUpDownValueField As Double

        Public Sub New()
            NumericUpDownValue = -5
        End Sub

        Public Property NumericUpDownValue As Double
            Get
                Return numericUpDownValueField
            End Get
            Set(ByVal value As Double)
                numericUpDownValueField = value
                Me.OnPropertyChanged(NameOf(Me.NumericUpDownValue))
            End Set
        End Property

        Public ReadOnly Property [Error] As String
            Get
                Return Me(String.Empty)
            End Get
        End Property

        Default Public ReadOnly Property Item(ByVal name As String) As String
            Get
                Dim result As String = Nothing

                If Equals(name, "NumericUpDownValue") Then
                    Return ValidateValue()
                End If

                Return result
            End Get
        End Property

        Private Function ValidateValue() As String
            If NumericUpDownValue < 0 Then
                Return "Value cannot be a negative number"
            End If

            Return Nothing
        End Function
    End Class
```

__Binding the Value property of RadNumericUpDown__
```XAML
    <telerik:RadNumericUpDown Value="{Binding NumericUpDownValue, Mode=TwoWay, ValidatesOnDataErrors=True}" UpdateValueEvent="PropertyChanged"/>
```

>important In order for the RadNumericUpDown control to show its `Validation.ErrorTemplate` when an error occurs, set the `ValidatesOnDataErrors` property of the `Binding` instance to __True__.

__RadNumericUpDown with a validation error and error message__

![RadNumericUpDown with a validation error and error message](images/kb-numericupdown-validation-idataerrorinfo-0.png)