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

#region radcombobox-howto-set-character-casing_0
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
#endregion

#region radcombobox-howto-set-character-casing_2
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
#endregion
}
