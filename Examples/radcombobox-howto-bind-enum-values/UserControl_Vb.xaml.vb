Public Class Default_Vb


' #region radcombobox-howto-bind-enum-values_1
Public Class EnumViewModel
    Private m_enumType As Type
Private _Values As IEnumerable
    Public Property Values() As IEnumerable
        Get
            Return _Values
        End Get
        Private Set(ByVal value As IEnumerable)
            _Values = value
        End Set
    End Property
    <TypeConverter(GetType(TypeTypeConverter))> _
    Public Property EnumType() As Type
        Get
            Return Me.m_enumType
        End Get
        Set(ByVal value As Type)
            Me.m_enumType = value
            Me.InitValues()
        End Set
    End Property
    Private Sub InitValues()
        Me.Values = Me.EnumType.GetFields(System.Reflection.BindingFlags.[Public] Or System.Reflection.BindingFlags.[Static]).[Select](Of FieldInfo, Object)(Function(ByVal x As FieldInfo) x.GetValue(Me.EnumType))
    End Sub
End Class
' #endregion

' #region radcombobox-howto-bind-enum-values_4
Public Class TypeTypeConverter
    Inherits TypeConverter
    Public Overloads Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
        Return sourceType.IsAssignableFrom(GetType(String))
    End Function
    Public Overloads Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
        ' Try to load the type from the current assembly (EnumValuesInCombo.dll)
        Dim t As Type = Type.[GetType](DirectCast(value, String), False)
        ' If the type is from a different known assembly, try to load it from there
        If t Is Nothing Then
            ' Try to load the type from Telerik.Windows.Controls.dll
            t = Me.GetTypeFromAssembly(value.ToString(), GetType(Telerik.Windows.Controls.ItemsControl))
        End If
        If t Is Nothing Then
            ' Try to load the type from System.Windows.dll
            t = Me.GetTypeFromAssembly(value.ToString(), GetType(System.Windows.Controls.ItemsControl))
        End If
        ' You can also try with other known assemblies.
        'if (t == null)
        '{
        '    t = GetTypeFromAssembly(value.ToString(), typeof(a type that is in the assembly, containing the enum));
        '}
        Return t
    End Function
    Private Function GetTypeFromAssembly(ByVal typeName As String, ByVal knownType As Type) As Type
        Dim assemblyName As String = knownType.AssemblyQualifiedName
        Return Type.[GetType](assemblyName.Replace(knownType.FullName, typeName), False)
    End Function
End Class
' #endregion
End Class
