Public Class Default_Vb
    ' #region radtreemap-styles-and-templates_2
  Public Sub New()
	InitializeComponent()
	pivotMap.ItemsSource = Me.GetData()
End Sub

Public Class GdpInfo
	Public Property Continent() As String
	Public Property Country() As String
	Public Property City() As String
	Public Property Gdp() As Double
End Class

Public Function GetData() As List(Of GdpInfo)
	Dim data As New List(Of GdpInfo)() From {New GdpInfo() With {.Country = "Australia", .Gdp = 1146},
	New GdpInfo() With {.Country = "Austria", .Gdp = 385.1},
	New GdpInfo() With {.Country = "Belgium", .Gdp = 468.6},
	New GdpInfo() With {.Country = "Brazil", .Gdp = 1749}, 
	New GdpInfo() With {.Country = "Canada", .Gdp = 1565},
	New GdpInfo() With {.Country = "China", .Gdp = 1700}, 
	New GdpInfo() With {.Country = "Denmark", .Gdp = 318.1},
	New GdpInfo() With {.Country = "France", .Gdp = 2669},
	New GdpInfo() With {.Country = "Germany", .Gdp = 3402}, New GdpInfo() With {.Country = "Greece", .Gdp = 329},
	New GdpInfo() With {.Country = "India", .Gdp = 1290}, New GdpInfo() With {.Country = "USA", .City = "NY which is in the NY state ", .Gdp = 3000},
	New GdpInfo() With {.Country = "USA", .City = "Columbus which is in the Ohio state", .Gdp = 2000},
	New GdpInfo() With {.Country = "USA", .City = "Los Angeles which is in the California state", .Gdp = 5000},
	New GdpInfo() With {.Country = "USA", .City = "Austin which is in the Texas state", .Gdp = 4600}}
	Return data
End Function
    ' #endregion
End Class
