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

#region radgridview-howto-create-custom-editor_0
public class RadColorPickerColumn : GridViewBoundColumnBase
{
}
#endregion

#region radgridview-howto-create-custom-editor_2
public class RadColorPickerColumn : GridViewBoundColumnBase
{
    public override FrameworkElement CreateCellElement( GridViewCell cell, object dataItem )
    {
        Border cellElement = new Border();
        var valueBinding = new System.Windows.Data.Binding( this.DataMemberBinding.Path.Path )
        {
            Mode = BindingMode.OneTime,
            Converter = new ColorToBrushConverter()
        };
        cellElement.SetBinding( Border.BackgroundProperty, valueBinding );
        cellElement.Width = 45;
        cellElement.Height = 20;
        cellElement.CornerRadius = new CornerRadius( 5 );
        return cellElement;
    }
}
#endregion

#region radgridview-howto-create-custom-editor_4
public class ColorToBrushConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        var color = (Color)value;
        if (color != null)
        {
            return new SolidColorBrush(color);
        }
        return value;
    }
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return value;
    }
}
#endregion

#region radgridview-howto-create-custom-editor_6
public class RadColorPickerColumn : GridViewBoundColumnBase
{
    //public override FrameworkElement CreateCellElement( GridViewCell cell, object dataItem ){...}
    public override FrameworkElement CreateCellEditElement( GridViewCell cell, object dataItem )
    {
        var cellEditElement = new RadColorPicker();
        this.BindingTarget = RadColorPicker.SelectedColorProperty;
        cellEditElement.MainPalette = this.MainPalette;
        Binding valueBinding = this.CreateValueBinding();
        cellEditElement.SetBinding( RadColorPicker.SelectedColorProperty, valueBinding );
        return cellEditElement as FrameworkElement;
    }
}
#endregion

#region radgridview-howto-create-custom-editor_8
private Binding CreateValueBinding()
{
    Binding valueBinding = new Binding();
    valueBinding.Mode = BindingMode.TwoWay;
    valueBinding.NotifyOnValidationError = true;
    valueBinding.ValidatesOnExceptions = true;
    valueBinding.UpdateSourceTrigger = UpdateSourceTrigger.Explicit;
    valueBinding.Path = new PropertyPath( this.DataMemberBinding.Path.Path );
    return valueBinding;
}
#endregion

#region radgridview-howto-create-custom-editor_10
public class RadColorPickerColumn : GridViewBoundColumnBase
{
    public override FrameworkElement CreateCellElement( GridViewCell cell, object dataItem ){...}
    public override FrameworkElement CreateCellEditElement( GridViewCell cell, object dataItem ){...}
    private System.Windows.Data.Binding CreateValueBinding(){...}
    public override void CopyPropertiesFrom( GridViewColumn source )
    {
        base.CopyPropertiesFrom( source );
        var radColorPickerColumn = source as RadColorPickerColumn;
        if ( radColorPickerColumn != null )
        {
            this.MainPalette = radColorPickerColumn.MainPalette;
        }
    }
    public ColorPreset MainPalette
    {
        get
        {
            return ( ColorPreset )GetValue( MainPaletteProperty );
        }
        set
        {
            SetValue( MainPaletteProperty, value );
        }
    }
    public static readonly DependencyProperty MainPaletteProperty = DependencyProperty.Register( "MainPalette",
        typeof( ColorPreset ),
        typeof( RadColorPickerColumn ),
        new PropertyMetadata( null ) );
}
#endregion

#region radgridview-howto-create-custom-editor_12
public class RadColorPickerColumn : GridViewBoundColumnBase
{
    public override FrameworkElement CreateCellElement( GridViewCell cell, object dataItem )
    {
        Border cellElement = new Border();
        var valueBinding = new System.Windows.Data.Binding( this.DataMemberBinding.Path.Path )
        {
            Mode = BindingMode.OneTime,
            Converter = new ColorToBrushConverter()
        };
        cellElement.SetBinding( Border.BackgroundProperty, valueBinding );
        cellElement.Width = 45;
        cellElement.Height = 20;
        cellElement.CornerRadius = new CornerRadius( 5 );
        return cellElement;
    }
    public override FrameworkElement CreateCellEditElement( GridViewCell cell, object dataItem )
    {
        var cellEditElement = new RadColorPicker();
        this.BindingTarget = RadColorPicker.SelectedColorProperty;
        cellEditElement.MainPalette = this.MainPalette;
        System.Windows.Data.Binding valueBinding = this.CreateValueBinding();
        cellEditElement.SetBinding( RadColorPicker.SelectedColorProperty, valueBinding );
        return cellEditElement as FrameworkElement;
    }
    private System.Windows.Data.Binding CreateValueBinding()
    {
        System.Windows.Data.Binding valueBinding = new System.Windows.Data.Binding();
        valueBinding.Mode = BindingMode.TwoWay;
        valueBinding.NotifyOnValidationError = true;
        valueBinding.ValidatesOnExceptions = true;
        valueBinding.UpdateSourceTrigger = UpdateSourceTrigger.Explicit;
        valueBinding.Path = new PropertyPath( this.DataMemberBinding.Path.Path );
        return valueBinding;
    }
    public override void CopyPropertiesFrom( GridViewColumn source )
    {
        base.CopyPropertiesFrom( source );
        var radColorPickerColumn = source as RadColorPickerColumn;
        if ( radColorPickerColumn != null )
        {
            this.MainPalette = radColorPickerColumn.MainPalette;
        }
    }
    public ColorPreset MainPalette
    {
        get
        {
            return ( ColorPreset )GetValue( MainPaletteProperty );
        }
        set
        {
            SetValue( MainPaletteProperty, value );
        }
    }
    public static readonly DependencyProperty MainPaletteProperty = DependencyProperty.Register( "MainPalette",
        typeof( ColorPreset ),
        typeof( RadColorPickerColumn ),
        new PropertyMetadata( null ) );
}
#endregion

#region radgridview-howto-create-custom-editor_15
public override IList<string> UpdateSourceWithEditorValue(GridViewCell gridViewCell)
    {
        List<String> errors = new List<String>();
        RadColorPicker editor = gridViewCell.GetEditingElement() as RadColorPicker;
        BindingExpression bindingExpression = editor.ReadLocalValue(RadColorPicker.SelectedColorProperty) as BindingExpression;
        if (bindingExpression != null)
        {
            bindingExpression.UpdateSource();
            foreach (ValidationError error in Validation.GetErrors(editor))
            {
                errors.Add(error.ErrorContent.ToString());
            }
        }
        return errors.ToList();
    }
#endregion

#region radgridview-howto-create-custom-editor_17
public override object GetNewValueFromEditor( object editor )
{
    RadColorPicker colorPicker = editor as RadColorPicker;
    if ( colorPicker != null )
    {
        return colorPicker.SelectedColor;
    }
    else
    {
        return null;
    }
}
#endregion
}
