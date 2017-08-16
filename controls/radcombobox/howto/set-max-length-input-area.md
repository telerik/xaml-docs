---
title: Set MaxLength Property of the Input Area
page_title: Set MaxLength Property of the Input Area
description: Set MaxLength Property of the Input Area
slug: radcombobox-howto-set-max-length-input-area
tags: set,maxlength,property,of,the,input,area
published: True
position: 7
---

# Set MaxLength Property of the Input Area

The purpose of this tutorial is to show you how to set the __MaxLength__ property of the [InputArea]({%slug radcombobox-general-information-visual-structure%}) of [editable]({%slug radcombobox-features-edit-modes%}) __RadComboBox__ (__RadComboBox__'s __IsEditable__ property is set to __True__).

It is possible to set the MaxLength property of the InputArea using the following approaches: 

* [By using the TextBoxStyle property](#using-the-textboxstyle-property)

* [By using the controls resources](#using-the-control-resources)

* [By using an attached property](#using-an-attached-property)

## Using the TextBoxStyle property

As of Q2 2014 release __RadComboBox__ provides [TextBoxStyle property]({%slug radcombobox-features-textboxstyle%}) which makes it easy to customize the TextBox part of the control. Just create a custom Style with TargetType set to TextBox and set the MaxLength to the needed value as shown below:

#### __XAML__
 
{{region radcombobox-howto-set-max-length-input-area_6}}
	<UserControl.Resources>
		<Style TargetType="TextBox" x:Key="CustomComboTextBoxStyle">
			<Setter Property="MaxLength" Value="5" />
		</Style>
	</UserControl.Resources>
{{endregion}}

If you are using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) to style the controls, you would need to base that Style to the default __TextBoxStyle__ of __RadComboBox__ named _ComboBoxTextBoxStyle_.

#### __XAML__

{{region radcombobox-howto-set-max-length-input-area_8}}
	<Style TargetType="TextBox" x:Key="CustomComboTextBoxStyle" BasedOn="{StaticResource ComboBoxTextBoxStyle}">
		...
	</Style>
{{endregion}}

Then, set the created Style as __TextBoxStyle__ of __RadComboBox__:

#### __XAML__
 
{{region radcombobox-howto-set-max-length-input-area_7}}
	<telerik:RadComboBox 		
		IsEditable="True" 
		TextBoxStyle="{StaticResource CustomComboTextBoxStyle}" />
{{endregion}}

## Using the control Resources

By accessing the ComboBox resources it is possible to modify the Style of the TextBox in the control and set its MaxLength property.

The next code snippet shows how to set the MaxLength property of the TextBox in the control using its resources:

#### __XAML__

{{region radcombobox-howto-set-max-length-input-area_5}}
	<telerik:RadComboBox IsEditable="True">
	    <telerik:RadComboBox.Resources>
	        <Style TargetType="TextBox">
	            <Setter Property="MaxLength" Value="5" />
	        </Style>
	    </telerik:RadComboBox.Resources>
	</telerik:RadComboBox>
{{endregion}}

## Using an Attached property

The idea in this case is to create a new __Attached Property__ in a helper class.

#### __C#__

{{region radcombobox-howto-set-max-length-input-area_0}}
	public class EditableComboBox
	{
	    public static readonly DependencyProperty MaxLengthProperty =
	        DependencyProperty.RegisterAttached( "MaxLength", typeof( int ), typeof( EditableComboBox ), new PropertyMetadata( OnMaxLengthChanged ) );
	
	    public static int GetMaxLength( DependencyObject obj )
	    {
	        return ( int )obj.GetValue( MaxLengthProperty );
	    }
	
	    public static void SetMaxLength( DependencyObject obj, int value )
	    {
	        obj.SetValue( MaxLengthProperty, value );
	    }
	
	    private static void OnMaxLengthChanged( DependencyObject obj, DependencyPropertyChangedEventArgs e )
	    {
	    }
	}
{{endregion}}

#### __VB.NET__

{{region radcombobox-howto-set-max-length-input-area_1}}
	Public Class EditableComboBox
	    Public Shared ReadOnly MaxLengthProperty As DependencyProperty = DependencyProperty.RegisterAttached("MaxLength", GetType(Integer), GetType(EditableComboBox), New PropertyMetadata(OnMaxLengthChanged))
	
	    Public Shared Function GetMaxLength(ByVal obj As DependencyObject) As Integer
	        Return CInt(obj.GetValue(MaxLengthProperty))
	    End Function
	
	    Public Shared Sub SetMaxLength(ByVal obj As DependencyObject, ByVal value As Integer)
	        obj.SetValue(MaxLengthProperty, value)
	    End Sub
	
	    Private Shared Sub OnMaxLengthChanged(ByVal obj As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
	    End Sub
	End Class
{{endregion}}

In the __OnMaxLengthChanged()__ event handler you should perform the following step.

* Get the target combobox.

* Get the __PART_EditableTextBox__ element from its template.

* The __PART_EditableTextBox__ is a __TextBox__ and you can easily set its __MaxLength__ property.

#### __C#__

{{region radcombobox-howto-set-max-length-input-area_2}}
	public class EditableComboBox
	{
	    public static readonly DependencyProperty MaxLengthProperty =
	        DependencyProperty.RegisterAttached( "MaxLength", typeof( int ), typeof( EditableComboBox ), new PropertyMetadata( OnMaxLengthChanged ) );
	
	    public static int GetMaxLength( DependencyObject obj )
	    {
	        return ( int )obj.GetValue( MaxLengthProperty );
	    }
	
	    public static void SetMaxLength( DependencyObject obj, int value )
	    {
	        obj.SetValue( MaxLengthProperty, value );
	    }
	
	    private static void OnMaxLengthChanged( DependencyObject obj, DependencyPropertyChangedEventArgs e )
	    {
	        var comboBox = obj as Telerik.Windows.Controls.RadComboBox;
	        if ( comboBox == null )
	            return;
	
	        comboBox.Dispatcher.BeginInvoke(
	            delegate()
	            {
	                var rootElement = VisualTreeHelper.GetChild( comboBox, 0 ) as FrameworkElement;
	                TextBox textBox = ( TextBox )rootElement.FindName( "PART_EditableTextBox" );
	                if ( textBox != null )
	                     textBox.SetValue( TextBox.MaxLengthProperty, e.NewValue );
	            } );
	    }
	}
{{endregion}}



#### __VB.NET__

{{region radcombobox-howto-set-max-length-input-area_3}}
	Public Class EditableComboBox
	    Public Shared ReadOnly MaxLengthProperty As DependencyProperty = DependencyProperty.RegisterAttached("MaxLength", GetType(Integer), GetType(EditableComboBox), New PropertyMetadata(OnMaxLengthChanged))
	    Public Shared Function GetMaxLength(ByVal obj As DependencyObject) As Integer
	        Return CInt(obj.GetValue(MaxLengthProperty))
	    End Function
	    Public Shared Sub SetMaxLength(ByVal obj As DependencyObject, ByVal value As Integer)
	        obj.SetValue(MaxLengthProperty, value)
	    End Sub
	    Private Shared Sub OnMaxLengthChanged(ByVal obj As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
	        Dim comboBox = TryCast(obj, Telerik.Windows.Controls.RadComboBox)
	        If comboBox Is Nothing Then
	            Exit Sub
	        End If
	        comboBox.Dispatcher.BeginInvoke(Function() Do
	            Dim rootElement = TryCast(VisualTreeHelper.GetChild(comboBox, 0), FrameworkElement)
	            Dim textBox As TextBox = DirectCast(rootElement.FindName("PART_EditableTextBox"), TextBox)
	            If textBox IsNot Nothing Then
	                textBox.SetValue(TextBox.MaxLengthProperty, e.NewValue)
	            End If 
	       End Function)
	    End Sub
	End Class
{{endregion}}

Finally set the property in XAML:

#### __XAML__

{{region radcombobox-howto-set-max-length-input-area_4}}
	<telerik:RadComboBox IsEditable="True" example:EditableComboBox.MaxLength="20"/>
{{endregion}}

>tipNote that you have to set the __RadComboBox__'s __IsEditable__ property to __True__.

## See Also

 * [Enable\Disable RadComboBoxItems]({%slug radcombobox-howto-enable-disable-radcombobox-items%})

 * [Open the DropDown When the Control Gets Focus]({%slug radcombobox-howto-open-dropdown-get-focus%})

 * [Get a Grid Like Dropdown]({%slug radcombobox-grid-like-dropdown%})
