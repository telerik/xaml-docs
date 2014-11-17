Public Class Default_Vb
' #region radtimeline-customizing_items_2
    Dim dataSource As New List(Of Item)()
	Dim startDate = New Date(2011, 1, 1)
	Dim endDate = New Date(2011, 6, 1)

	Dim r As New Random()
	Dim i As Date = startDate
	Do While i < endDate
		dataSource.Add(New Item() With {.Date = i, .Duration = TimeSpan.FromDays(r.Next(50, 100))})
		i = i.AddMonths(1)
	Loop

	For i As Integer = 0 To 14
		dataSource.Add(New Item() With {.Date = startDate.AddMonths(r.Next(0, 5)).AddDays(15)})
	Next i
	RadTimeline1.ItemsSource = dataSource

	public class Item
	public TimeSpan Duration {get;set;}
	public Date Date {get;set;}
' #endregion

' #region radtimeline-customizing_items_4
 Public Class CustomItemTemplateSelector
 Inherits DataTemplateSelector
	Public Property InstantItemTemplate() As DataTemplate
	Public Property ItemWithDurationTemplate() As DataTemplate

	Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
		Dim data As TimelineDataItem = TryCast(item, TimelineDataItem)
		Dim productItem As Product

		If data Is Nothing Then
			productItem = TryCast(item, Product)
		Else
			productItem = TryCast(data.DataItem, Product)
		End If

		If productItem Is Nothing Then
			Return MyBase.SelectTemplate(item, container)
		End If

		If productItem.Duration.Days <> 0 Then
			Return Me.ItemWithDurationTemplate
		Else
			Return Me.InstantItemTemplate
		End If
	End Function
 End Class
' #endregion

' #region radtimeline-customizing_items_6
Private customItemTemplateSelector_Renamed As DataTemplateSelector
Public Property CustomItemTemplateSelector() As DataTemplateSelector
	Get
		Return Me.customItemTemplateSelector_Renamed
	End Get
	Set(ByVal value As DataTemplateSelector)
		Me.customItemTemplateSelector_Renamed = value
	End Set
End Property
' #endregion
End Class
