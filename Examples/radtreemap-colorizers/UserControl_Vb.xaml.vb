Public Class Default_Vb

' #region radtreemap-colorizers_2
  public MainPage()
   Public Sub New()
		InitializeComponent()
		treeMap1.ItemsSource = Me.GetData()
   End Sub

	Public Function GetData() As List(Of GdpInfo)
		Dim data As New List(Of GdpInfo)() From {
		New GdpInfo() With {.Country = "Austria", .Gdp= 385.1},
		New GdpInfo() With {.Country ="Belgium", .Gdp=468.6},
		New GdpInfo() With {.Country ="Brazil", .Gdp=1749},
		New GdpInfo() With {.Country ="Canada", .Gdp=1565},
		New GdpInfo() With {.Country ="China", .Gdp=5308},
		New GdpInfo() With {.Country ="Denmark", .Gdp=318.1},
		New GdpInfo() With {.Country ="France", .Gdp=2669},
		New GdpInfo() With {.Country ="Germany", .Gdp=3402},
		New GdpInfo() With {.Country ="Greece", .Gdp=329},
		New GdpInfo() With {.Country ="India", .Gdp=1290},
		New GdpInfo() With {.Country ="Indonesia", .Gdp=593.3},
		New GdpInfo() With {.Country ="Iran", .Gdp=346.6},
		New GdpInfo() With {.Country ="Italy", .Gdp=2107},
		New GdpInfo() With {.Country ="Japan", .Gdp=5179},
		New GdpInfo() With {.Country ="Mexico", .Gdp=1021},
		New GdpInfo() With {.Country ="Netherlands", .Gdp=804.7},
		New GdpInfo() With {.Country ="Norway", .Gdp=410.3},
		New GdpInfo() With {.Country ="Poland", .Gdp=467.3},
		New GdpInfo() With {.Country ="Russia", .Gdp=1250}}
		Return data
	End Function
  }
	Public Class GdpInfo
		Public Property Country() As String
		Public Property Gdp() As Double
	End Class
    ' #endregion 
End Class
