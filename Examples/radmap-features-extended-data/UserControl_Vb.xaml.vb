Public Class Default_Vb


' #region radmap-features-extended-data_2
' Create extended property set.
' It can be shared between the number
' of the map shapes.
Dim propertySet As New ExtendedPropertySet()
propertySet.RegisterProperty("Name", "City Name", GetType(String), String.Empty)
propertySet.RegisterProperty("Population", "Population", GetType(Integer), 0)
Dim sofiaEllipse As New MapEllipse() With {.ShapeFill = New MapShapeFill() With {.Stroke = New SolidColorBrush(Colors.Red), .StrokeThickness = 2, .Fill = New SolidColorBrush(Colors.Transparent)}, .Width = 20, .Height = 20, .Location = New Location(42.6957539183824, 23.3327663758679)}
' Create extended data for the ellipse
' using existing property set.
Dim sofiaData As New ExtendedData(propertySet)
' Set the extended properties.
sofiaData.SetValue("Name", "Sofia")
sofiaData.SetValue("Population", 1300000)
' Assign extended data to the map shape.
sofiaEllipse.ExtendedData = sofiaData
Me.informationLayer.Items.Add(sofiaEllipse)
' #endregion

' #region radmap-features-extended-data_5
Dim propertySet As New ExtendedPropertySet()
propertySet.RegisterProperty("Name", "City Name", GetType(String), String.Empty)
propertySet.RegisterProperty("Population", "Population", GetType(Integer), 0)
Dim sofiaEllipse As New MapEllipse() With {.ShapeFill = New MapShapeFill() With {.Stroke = New SolidColorBrush(Colors.Red), .StrokeThickness = 2, .Fill = New SolidColorBrush(Colors.Transparent)}, .Width = 20, .Height = 20, .Location = New Location(42.6957539183824, 23.3327663758679)}
Dim sofiaData As New ExtendedData(propertySet)
sofiaData.SetValue("Name", "Sofia")
sofiaData.SetValue("Population", 1300000)
sofiaEllipse.ExtendedData = sofiaData
' Assign tooltip which uses the extended properties.
Dim _tooltip As New ToolTip()
Dim tooltipBinding As New Binding() With {.Converter = New ExtendedDataConverter(), .ConverterParameter = "{Name}: {Population} people", .Source = sofiaEllipse.ExtendedData}
_tooltip.SetBinding(ToolTip.ContentProperty, tooltipBinding)
ToolTipService.SetToolTip(sofiaEllipse, _tooltip)
Me.informationLayer.Items.Add(sofiaEllipse)
' #endregion
End Class
