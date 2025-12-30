---
title: Set CharacterCasing Property of the Input Area
page_title: Set CharacterCasing Property of the Input Area
description: Check our &quot;Set CharacterCasing Property of the Input Area&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-howto-set-character-casing
tags: set,charactercasing,property,of,the,input,area
published: True
position: 8
site_name: WPF
---

# Set CharacterCasing Property of the Input Area

The purpose of this tutorial is to show you how to set the __CharacterCasing__ property of the [InputArea]({%slug radcombobox-general-information-visual-structure%}) of an [editable]({%slug radcombobox-features-edit-modes%}) __RadComboBox__(__RadComboBox__'s __IsEditable__ property is set to __True__).

The idea in this case is to create a new __Attached Property__ in a helper class.



```C#
	public class EditableComboBox
	{
	    public static int GetCharacterCasing( DependencyObject obj )
	    {
	        return ( int )obj.GetValue( CharacterCasingProperty );
	    }
	
	    public static void SetCharacterCasing( DependencyObject obj, int value )
	    {
	        obj.SetValue( CharacterCasingProperty, value );
	    }
	
	    public static readonly DependencyProperty CharacterCasingProperty =
	        DependencyProperty.RegisterAttached( "CharacterCasing", typeof( int ), typeof( EditableComboBox ), new UIPropertyMetadata( OnCharacterCasingChanged ) );
	
	    private static void OnCharacterCasingChanged( DependencyObject obj, DependencyPropertyChangedEventArgs e )
	    {
	    }
	}
```
```VB.NET
	Public Class EditableComboBox
	    Public Shared Function GetCharacterCasing(ByVal obj As DependencyObject) As Integer
	        Return CInt(obj.GetValue(CharacterCasingProperty))
	    End Function
	    Public Shared Sub SetCharacterCasing(ByVal obj As DependencyObject, ByVal value As Integer)
	        obj.SetValue(CharacterCasingProperty, value)
	    End Sub
	    Public Shared ReadOnly CharacterCasingProperty As DependencyProperty = DependencyProperty.RegisterAttached("CharacterCasing", GetType(Integer), GetType(EditableComboBox), New UIPropertyMetadata(OnCharacterCasingChanged))
	    Private Shared Sub OnCharacterCasingChanged(ByVal obj As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
	    End Sub
	End Class
```

In the __OnCharacterCasingChanged()__ event handler you should perform the following step.

* Get the target combobox.

* Get the __PART_EditableTextBox__ element from its template.

* The __PART_EditableTextBox__ is a __TextBox__ and you can easily set its __CharacterCasing__ property.



```C#
	public class EditableComboBox
	{
	    public static int GetCharacterCasing( DependencyObject obj )
	    {
	        return ( int )obj.GetValue( CharacterCasingProperty );
	    }
	    public static void SetCharacterCasing( DependencyObject obj, int value )
	    {
	        obj.SetValue( CharacterCasingProperty, value );
	    }
	    public static readonly DependencyProperty CharacterCasingProperty =
	        DependencyProperty.RegisterAttached( "CharacterCasing", typeof( int ), typeof( EditableComboBox ), new UIPropertyMetadata( OnCharacterCasingChanged ) );
	    private static void OnCharacterCasingChanged( DependencyObject obj, DependencyPropertyChangedEventArgs e )
	    {
	        var comboBox = obj as Telerik.Windows.Controls.RadComboBox;
	        if ( comboBox == null )
	        {
	            return;
	        }
	        comboBox.Dispatcher.BeginInvoke( DispatcherPriority.Loaded,
	            ( DispatcherOperationCallback )delegate
	            {
	                var childrenCount = VisualTreeHelper.GetChildrenCount( comboBox );
	                if ( childrenCount > 0 )
	                {
	                    var rootElement = VisualTreeHelper.GetChild( comboBox, 0 ) as FrameworkElement;
	                    TextBox textBox = ( TextBox )rootElement.FindName( "PART_EditableTextBox" );
	                    if ( textBox != null )
	                        textBox.SetValue( TextBox.CharacterCasingProperty, ( CharacterCasing )e.NewValue );
	                }
	                return null;
	            }
	            , null );
	    }
	}
```

Finally set the property in XAML.



```XAML
	<telerik:RadComboBox IsEditable="True" example:EditableComboBox.CharacterCasingProperty="1"/>
```

>tip Note that you have to set the __RadComboBox__'s __IsEditable__ property to __True__.
