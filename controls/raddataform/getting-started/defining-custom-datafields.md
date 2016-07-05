---
title: Defining Custom DataFields
page_title: Defining Custom DataFields
description: Defining Custom DataFields
slug: raddataform-defining-custom-datafields
tags: defining,custom,datafields
published: True
position: 3
---

# Defining Custom DataFields

This help article illustrates how to define your own DataField type.

For this purpose you need to create a class which inherits from **DataFormDataField** and overrides its **GetControl()** and **GetControlBindingProperty()** methods:

#### __[C#] Example 1: Creating the DataFormNumericUpDownField class__

	{{region cs-raddataform-defining-custom-datafields_0}}
	    public class DataFormNumericUpDownField : DataFormDataField
	    {
	        protected override DependencyProperty GetControlBindingProperty()
	        {
	            return RadNumericUpDown.ValueProperty;
	        }
	
	        protected override Control GetControl()
	        {
	            DependencyProperty dependencyProperty = this.GetControlBindingProperty();
	            RadNumericUpDown numericUpDown = new RadNumericUpDown();
	            if (this.DataMemberBinding != null)
	            {
	                var binding = this.DataMemberBinding;
	                numericUpDown.SetBinding(dependencyProperty, binding);
	            }
	            numericUpDown.SetBinding(RadNumericUpDown.IsEnabledProperty, new Binding("IsReadOnly") { Source = this, Converter = new InvertedBooleanConverter() });
	
	            return numericUpDown;
	        }
	    }
	{{endregion}}

#### __[VB.NET] Example 1: Creating the DataFormNumericUpDownField class__

	{{region vb-raddataform-defining-custom-datafields_0}}
	    Public Class DataFormNumericUpDownField
	        Inherits DataFormDataField
	        Protected Overrides Function GetControlBindingProperty() As DependencyProperty
	            Return RadNumericUpDown.ValueProperty
	        End Function
	        Protected Overrides Function GetControl() As Control
	            Dim dependencyProperty As DependencyProperty = Me.GetControlBindingProperty()
	            Dim numericUpDown As New RadNumericUpDown()
	            If Me.DataMemberBinding IsNot Nothing Then
	                Dim binding = Me.DataMemberBinding
	                numericUpDown.SetBinding(dependencyProperty, binding)
	            End If
	            numericUpDown.SetBinding(RadNumericUpDown.IsEnabledProperty, New Binding("IsReadOnly") With {
	                .Source = Me,
	                .Converter = New InvertedBooleanConverter()
	            })
	            Return numericUpDown
	        End Function
	    End Class
{{endregion}}

The next step is to handle RadDataForm's **AutoGeneratingField** event and set the **DataField** to the new **DataFormNumericUpDownField**:

#### __[XAML] Example 2: Initializing a RadDataForm__

	{{region xaml-raddataform-defining-custom-datafields_2}}
	<telerik:RadDataForm x:Name="DataForm1" AutoGeneratingField="RadDataForm_AutoGeneratingField" />
	{{endregion}}

#### __[C#] Example 3: Handling the AutoGeneratingField event__

	{{region cs-raddataform-defining-custom-datafields_1}}
	        private void RadDataForm_AutoGeneratingField(object sender, Telerik.Windows.Controls.Data.DataForm.AutoGeneratingFieldEventArgs e)
	        {
	            if (e.DataField.Label.Equals("Number"))
	            {
	                e.DataField = new DataFormNumericUpDownField() { Label = e.DataField.Label, DataMemberBinding = e.DataField.DataMemberBinding };
	            }
	        }
{{endregion}}

#### __[VB.NET] Example 3: Handling the AutoGeneratingField event__

	{{region vb-raddataform-defining-custom-datafields_1}}
		        Private Sub RadDataForm_AutoGeneratingField(sender As Object, e As Telerik.Windows.Controls.Data.DataForm.AutoGeneratingFieldEventArgs)
		            If e.DataField.Label.Equals("Number") Then
		                e.DataField = New DataFormNumericUpDownField() With {
		                    .Label = e.DataField.Label,
		                    .DataMemberBinding = e.DataField.DataMemberBinding
		                }
		            End If
		        End Sub
	{{endregion}}

And here's how you can use the DataFormNumericUpDownField in XAML:
          
#### __[XAML] Example 4: Using the DataFormNumericUpDownField in a Custom DataTemplate__

	{{region xaml-raddataform-defining-custom-datafields_3}}
	<Grid>
	        <Grid.Resources>
	            <DataTemplate x:Key="MyTemplate">
	                <StackPanel>
	                    <telerik:DataFormDataField  Label="First Name" DataMemberBinding="{Binding FirstName, Mode=TwoWay}" />
	                    <telerik:DataFormDataField  Label="Last Name" DataMemberBinding="{Binding LastName, Mode=TwoWay}" />
	                    <my:DataFormNumericUpDownField Label="Age" DataMemberBinding="{Binding Age, Mode=TwoWay}" />
	                </StackPanel>
	            </DataTemplate>
	        </Grid.Resources>
	        <telerik:RadDataForm AutoGenerateFields="False"
	                             ReadOnlyTemplate="{StaticResource MyTemplate}"
	                             EditTemplate="{StaticResource MyTemplate}"
	                             NewItemTemplate="{StaticResource MyTemplate}">
	        </telerik:RadDataForm>
	    </Grid>
	{{endregion}}

## See Also

* [Customized Fields]({%slug raddataform-customized-fields%})

* [Autogenerated Fields]({%slug raddataform-autogenerated-fields%})

* [Handling SelectionChanged event for DataFormComboBoxField]({%slug raddataform-howto-selectionchanged-comboboxfield%})