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

#region radcombobox-howto-bind-enum-values_0
public class EnumViewModel
{
    private Type enumType;
    public IEnumerable Values
    {
        get;
        private set;
    }
    [TypeConverter( typeof( TypeTypeConverter ) )]
    public Type EnumType
    {
        get
        {
            return this.enumType;
        }
        set
        {
            this.enumType = value;
            this.InitValues();
        }
    }
    private void InitValues()
    {
        this.Values = this.EnumType.GetFields( System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static )
                        .Select<FieldInfo, object>( ( FieldInfo x ) => x.GetValue( this.EnumType ) );
    }
}
#endregion

#region radcombobox-howto-bind-enum-values_3
public class TypeTypeConverter : TypeConverter
{
    public override bool CanConvertFrom( ITypeDescriptorContext context, Type sourceType )
    {
        return sourceType.IsAssignableFrom( typeof( string ) );
    }
    public override object ConvertFrom( ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value )
    {
        // Try to load the type from the current assembly (EnumValuesInCombo.dll)
        Type t = Type.GetType( ( string )value, false );
        // If the type is from a different known assembly, try to load it from there
        if ( t == null )
        {
            // Try to load the type from Telerik.Windows.Controls.dll
            t = this.GetTypeFromAssembly( value.ToString(), typeof( Telerik.Windows.Controls.ItemsControl ) );
        }
        if ( t == null )
        {
            // Try to load the type from System.Windows.dll
            t = this.GetTypeFromAssembly( value.ToString(), typeof( System.Windows.Controls.ItemsControl ) );
        }
        // You can also try with other known assemblies.
        //if (t == null)
        //{
        //    t = GetTypeFromAssembly(value.ToString(), typeof(a type that is in the assembly, containing the enum));
        //}
        return t;
    }
    private Type GetTypeFromAssembly( string typeName, Type knownType )
    {
        string assemblyName = knownType.AssemblyQualifiedName;
        return Type.GetType( assemblyName.Replace( knownType.FullName, typeName ), false );
    }
}
#endregion
}
