Public Class Default_Vb


' #region radgridview-howto-create-custom-editor_1
Public Class RadColorPickerColumn
    Inherits GridViewBoundColumnBase
End Class
' #endregion

' #region radgridview-howto-create-custom-editor_3
Public Class RadColorPickerColumn
    Inherits GridViewBoundColumnBase
    Public Overloads Overrides Function CreateCellElement(ByVal cell As GridViewCell, ByVal dataItem As Object) As FrameworkElement
        Dim cellElement As New Border()
        Dim valueBinding = New System.Windows.Data.Binding(Me.DataMemberBinding.Path.Path)
        cellElement.SetBinding(Border.BackgroundProperty, valueBinding)
        cellElement.Width = 45
        cellElement.Height = 20
        cellElement.CornerRadius = New CornerRadius(5)
        Return cellElement
    End Function
End Class
' #endregion

' #region radgridview-howto-create-custom-editor_5
Public Class ColorToBrushConverter
    Implements IValueConverter
    Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
        Dim color = DirectCast(value, Color)
        If color IsNot Nothing Then
            Return New SolidColorBrush(color)
        End If
        Return value
    End Function
    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
        Return value
    End Function
End Class
' #endregion

' #region radgridview-howto-create-custom-editor_7
Public Class RadColorPickerColumn
    Inherits GridViewBoundColumnBase
    'public override FrameworkElement CreateCellElement( GridViewCell cell, object dataItem ){...}
    Public Overloads Overrides Function CreateCellEditElement(ByVal cell As GridViewCell, ByVal dataItem As Object) As FrameworkElement
        Dim cellEditElement = New RadColorPicker()
        Me.BindingTarget = RadColorPicker.SelectedColorProperty
        cellEditElement.MainPalette = Me.MainPalette
        Dim valueBinding As Binding = Me.CreateValueBinding()
        cellEditElement.SetBinding(RadColorPicker.SelectedColorProperty, valueBinding)
        Return TryCast(cellEditElement, FrameworkElement)
    End Function
End Class
' #endregion

' #region radgridview-howto-create-custom-editor_9
Private Function CreateValueBinding() As Binding
    Dim valueBinding As New Binding()
    valueBinding.Mode = BindingMode.TwoWay
    valueBinding.NotifyOnValidationError = True
    valueBinding.ValidatesOnExceptions = True
    valueBinding.UpdateSourceTrigger = UpdateSourceTrigger.Explicit
    valueBinding.Path = New PropertyPath(Me.DataMemberBinding.Path.Path)
    Return valueBinding
End Function
' #endregion

' #region radgridview-howto-create-custom-editor_11
Public Class RadColorPickerColumn
    Inherits GridViewBoundColumnBase
    public override FrameworkElement CreateCellElement( GridViewCell cell, object dataItem ){...}
    public override FrameworkElement CreateCellEditElement( GridViewCell cell, object dataItem ){...}
    private System.Windows.Data.Binding CreateValueBinding(){...}
    Public Overloads Overrides Sub CopyPropertiesFrom(ByVal source As GridViewColumn)
        MyBase.CopyPropertiesFrom(source)
        Dim radColorPickerColumn = TryCast(source, RadColorPickerColumn)
        If radColorPickerColumn IsNot Nothing Then
            Me.MainPalette = radColorPickerColumn.MainPalette
        End If
    End Sub
    Public Property MainPalette() As ColorPreset
        Get
            Return DirectCast(GetValue(MainPaletteProperty), ColorPreset)
        End Get
        Set(ByVal value As ColorPreset)
            SetValue(MainPaletteProperty, value)
        End Set
    End Property
    Public Shared ReadOnly MainPaletteProperty As DependencyProperty = DependencyProperty.Register("MainPalette", GetType(ColorPreset), GetType(RadColorPickerColumn), New PropertyMetadata(Nothing))
End Class
' #endregion

' #region radgridview-howto-create-custom-editor_13
Public Class RadColorPickerColumn
    Inherits GridViewBoundColumnBase
    Public Overloads Overrides Function CreateCellElement(ByVal cell As GridViewCell, ByVal dataItem As Object) As FrameworkElement
        Dim cellElement As New Border()
        Dim valueBinding = New System.Windows.Data.Binding(Me.DataMemberBinding.Path.Path)
        cellElement.SetBinding(Border.BackgroundProperty, valueBinding)
        cellElement.Width = 45
        cellElement.Height = 20
        cellElement.CornerRadius = New CornerRadius(5)
        Return cellElement
    End Function
    Public Overloads Overrides Function CreateCellEditElement(ByVal cell As GridViewCell, ByVal dataItem As Object) As FrameworkElement
        Dim cellEditElement = New RadColorPicker()
        Me.BindingTarget = RadColorPicker.SelectedColorProperty
        cellEditElement.MainPalette = Me.MainPalette
        Dim valueBinding As System.Windows.Data.Binding = Me.CreateValueBinding()
        cellEditElement.SetBinding(RadColorPicker.SelectedColorProperty, valueBinding)
        Return TryCast(cellEditElement, FrameworkElement)
    End Function
    Private Function CreateValueBinding() As System.Windows.Data.Binding
        Dim valueBinding As New System.Windows.Data.Binding()
        valueBinding.Mode = BindingMode.TwoWay
        valueBinding.NotifyOnValidationError = True
        valueBinding.ValidatesOnExceptions = True
        valueBinding.UpdateSourceTrigger = UpdateSourceTrigger.Explicit
        valueBinding.Path = New PropertyPath(Me.DataMemberBinding.Path.Path)
        Return valueBinding
    End Function
    Public Overloads Overrides Sub CopyPropertiesFrom(ByVal source As GridViewColumn)
        MyBase.CopyPropertiesFrom(source)
        Dim radColorPickerColumn = TryCast(source, RadColorPickerColumn)
        If radColorPickerColumn IsNot Nothing Then
            Me.MainPalette = radColorPickerColumn.MainPalette
        End If
    End Sub
    Public Property MainPalette() As ColorPreset
        Get
            Return DirectCast(GetValue(MainPaletteProperty), ColorPreset)
        End Get
        Set(ByVal value As ColorPreset)
            SetValue(MainPaletteProperty, value)
        End Set
    End Property
    Public Shared ReadOnly MainPaletteProperty As DependencyProperty = DependencyProperty.Register("MainPalette", GetType(ColorPreset), GetType(RadColorPickerColumn), New PropertyMetadata(Nothing))
End Class
    ' #endregion

    ' #region radgridview-howto-create-custom-editor_16
    Public Overrides Function UpdateSourceWithEditorValue(gridViewCell As GridViewCell) As IList(Of String)
        Dim errors As New List(Of [String])()
        Dim editor As RadColorPicker = TryCast(gridViewCell.GetEditingElement(), RadColorPicker)
        Dim bindingExpression As BindingExpression = TryCast(editor.ReadLocalValue(RadColorPicker.SelectedColorProperty), BindingExpression)
        If bindingExpression IsNot Nothing Then
            bindingExpression.UpdateSource()
            For Each [error] As ValidationError In Validation.GetErrors(editor)
                errors.Add([error].ErrorContent.ToString())
            Next
        End If
        Return errors.ToList()
    End Function
}
    '#endregion

    '#region radgridview-howto-create-custom-editor_18
    Public Overrides Function GetNewValueFromEditor(editor As Object) As Object
        Dim colorPicker As RadColorPicker = TryCast(editor, RadColorPicker)
        If colorPicker IsNot Nothing Then
            Return colorPicker.SelectedColor
        Else
            Return Nothing
        End If
    End Function
    '#endregion
End Class
