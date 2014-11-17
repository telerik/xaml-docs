'#region radpivotgrid-styles-and-templates-templating-cells_1
Public Class CellTemplateSelector
    Inherits DataTemplateSelector

    Public Property RedTemplate() As DataTemplate
    Public Property GreenTemplate() As DataTemplate

    Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
        Dim cellAggregate = TryCast(item, CellAggregateValue)

        If cellAggregate IsNot Nothing Then
            Dim description = TryCast(cellAggregate.Description, PropertyAggregateDescription)

            If description.PropertyName = "Net" AndAlso cellAggregate.RowGroup.Type = GroupType.BottomLevel AndAlso cellAggregate.ColumnGroup.Type = GroupType.BottomLevel Then
                If Convert.ToDouble(cellAggregate.Value) > 1000.0R Then
                    Return Me.GreenTemplate
                Else
                    Return Me.RedTemplate
                End If
            End If
        End If

        Return MyBase.SelectTemplate(item, container)
    End Function
End Class
'#endregion

'#region radpivotgrid-styles-and-templates-templating-cells_2
Public Class HeaderTemplateSelector
	Inherits DataTemplateSelector

	Public Property ProductTemplate() As DataTemplate

	Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As System.Windows.DependencyObject) As DataTemplate
		Dim element As FrameworkElement = TryCast(container, FrameworkElement)
		Dim data As GroupData = TryCast(element.DataContext, GroupData)
		Dim pgd As PropertyGroupDescriptionBase = TryCast(data.GroupDescription, PropertyGroupDescriptionBase)

		If pgd IsNot Nothing AndAlso pgd.PropertyName = "Product" Then
			Return Me.ProductTemplate
		End If

		Return MyBase.SelectTemplate(item, container)
	End Function
End Class
'#endregion

'#region radpivotgrid-styles-and-templates-templating-cells_3
Public Class ProductToImageConverter
	Implements IValueConverter

	Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
		Dim product As String = System.Convert.ToString(value)
		Return String.Format("/CustomHeaderTemplate;component/ProductImages/{0}.png", product)
	End Function

	Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
		Throw New NotImplementedException()
	End Function
End Class
'#endregion