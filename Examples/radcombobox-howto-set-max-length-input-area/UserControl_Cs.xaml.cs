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

#region radcombobox-howto-set-max-length-input-area_0
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
#endregion

#region radcombobox-howto-set-max-length-input-area_2
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
#endregion
}
