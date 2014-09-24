Public Class UserControl_Vb


#region radchart-chartdatasource_3
	Public Class SimpleViewModel
	 Inherits DependencyObject
		   Private r As New Random()
		''' <summary>
		''' Identifies the <see cref="Data"/> dependency property.
		''' </summary>
		Public Shared ReadOnly DataProperty As DependencyProperty = DependencyProperty.Register("Data", GetType(ObservableCollection(Of SalesInfo)), GetType(SimpleViewModel), New PropertyMetadata(Nothing))

		Public Property Data() As RadObservableCollection(Of SalesInfo)
			Get
				Return CType(Me.GetValue(DataProperty), RadObservableCollection(Of SalesInfo))
			End Get
			Set(ByVal value As RadObservableCollection(Of SalesInfo))
				Me.SetValue(DataProperty, value)
			End Set
		End Property

		Public Sub New()
			Dim data = New RadObservableCollection(Of SalesInfo)()

			Dim startDate As New DateTime(2013, 5, 1)

			For i As Integer = 0 To 19
				data.Add(New SalesInfo() With {.Time = startDate.AddDays(i), .Value = i })
			Next

			Me.Data = data
		End Sub
 End Class
	
	Public Class SalesInfo
    Dim _time As Date
    Dim _value As Int

    Public Property [Time]() As DateTime
        Get
            Return Me._time
        End Get
        Set(value As DateTime)
            Me._time = value
        End Set
    End Property

    Public Property Value() As Int
        Get
            Return Me._value
        End Get
        Set(value As Double)
            Me._value = value
        End Set
    End Property
End Class
#endregion

#region radchart-chartdatasource_6
Public Class MyBarSeries
	Inherits BarSeries
	Protected Overrides Function GetValueAggregateFunction() As ChartAggregateFunction
		Return New ChartMinFunction()
	End Function
End Class
#endregion
End Class
