Public Class Default_Vb

' #region radheatmap-colorizers_1
Partial Public Class MainPage
	Inherits UserControl
	Public Sub New()
		InitializeComponent()
		radHeatMap.Definition.ItemsSource = CreateData()
	End Sub

	Public Function CreateData() As List(Of Car)
		Dim temp = New List(Of Car)()
		From {New Car() With {.Name = "Car 1", .Price = 20590, .HorsePower = 70, .MilesPerGallon = 37, .TopSpeed = 60},
		New Car() With {.Name = "Car 2", .Price = 21990, .HorsePower = 70, .MilesPerGallon = 37, .TopSpeed = 60},
		New Car() With {.Name = "Car 3", .Price = 23200, .HorsePower = 140, .MilesPerGallon = 28, .TopSpeed = 110},
		New Car() With {.Name = "Car 4", .Price = 27500, .HorsePower = 140, .MilesPerGallon = 28, .TopSpeed = 110},
		New Car() With {.Name = "Car 5", .Price = 28200, .HorsePower = 160, .MilesPerGallon = 31, .TopSpeed = 120},
		New Car() With {.Name = "Car 6", .Price = 29500, .HorsePower = 90, .MilesPerGallon = 35, .TopSpeed = 80},
		New Car() With {.Name = "Car 7", .Price = 31200, .HorsePower = 160, .MilesPerGallon = 31, .TopSpeed = 120},
		New Car() With {.Name = "Car 8", .Price = 32200, .HorsePower = 90, .MilesPerGallon = 35, .TopSpeed = 80},
		New Car() With {.Name = "Car 9", .Price = 35200, .HorsePower = 115, .MilesPerGallon = 29, .TopSpeed = 90},
		New Car() With {.Name = "Car 10", .Price = 36700, .HorsePower = 115, .MilesPerGallon = 29, .TopSpeed = 90},
		New Car() With {.Name = "Car 11", .Price = 38200, .HorsePower = 130, .MilesPerGallon = 24, .TopSpeed = 140},
		New Car() With {.Name = "Car 12", .Price = 39700, .HorsePower = 130, .MilesPerGallon = 24, .TopSpeed = 140},
		New Car() With {.Name = "Car 13", .Price = 41500, .HorsePower = 326, .MilesPerGallon = 16, .TopSpeed = 150},
		New Car() With {.Name = "Car 14", .Price = 42200, .HorsePower = 326, .MilesPerGallon = 16, .TopSpeed = 150},
		New Car() With {.Name = "Car 15", .Price = 43500, .HorsePower = 276, .MilesPerGallon = 25, .TopSpeed = 162},
		New Car() With {.Name = "Car 16", .Price = 43500, .HorsePower = 276, .MilesPerGallon = 25, .TopSpeed = 162}}
		
		Return temp
	End Function
End Class

Public Class Car
	Public Property Name() As String
	Public Property MilesPerGallon() As Integer
	Public Property TopSpeed() As Integer
	Public Property Price() As Integer
	Public Property HorsePower() As Integer
End Class
' #endregion
		
' #region radheatmap-colorizers_2
Dim ValueGradientColorizer1 As New HeatMapValueGradientColorizer()
ValueGradientColorizer1.GradientStops.Add(New GradientStop() With { _
	Key .Color = New Color() With { _
		Key .R = 217, _
		Key .G = 231, _
		Key .B = 241 _
	}, _
	Key .Offset = 0 _
})
ValueGradientColorizer1.GradientStops.Add(New GradientStop() With { _
	Key .Color = New Color() With { _
		Key .R = 1, _
		Key .G = 81, _
		Key .B = 140 _
	}, _
	Key .Offset = 1 _
})
memberMapping1.Colorizer = ValueGradientColorizer1
' #endregion

    ' #region radheatmap-colorizers_3
Dim RangeColorizer1 As New HeatMapRangeColorizer() With { _
	Key .IsAbsolute = True _
}
RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
	Key .Color = New Color() With { _
		Key .R = 217, _
		Key .G = 231, _
		Key .B = 241 _
	}, _
	Key .From = 19, _
	Key .[To] = 2224 _
})
RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
	Key .Color = New Color() With { _
		Key .R = 164, _
		Key .G = 194, _
		Key .B = 216 _
	}, _
	Key .From = 23, _
	Key .[To] = 26 _
})
RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
	Key .Color = New Color() With { _
		Key .R = 110, _
		Key .G = 156, _
		Key .B = 191 _
	}, _
	Key .From = 27, _
	Key .[To] = 30 _
})
RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
	Key .Color = New Color() With { _
		Key .R = 55, _
		Key .G = 118, _
		Key .B = 165 _
	}, _
	Key .From = 31, _
	Key .[To] = 34 _
})
RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
	Key .Color = New Color() With { _
		Key .R = 1, _
		Key .G = 81, _
		Key .B = 140 _
	}, _
	Key .From = 35, _
	Key .[To] = 40 _
})
memberMapping2.Colorizer = RangeColorizer1
' #endregion
	
' #region radheatmap-colorizers_4
Dim DesaturationColorizer1 As New HeatMapDesaturationColorizer() With { _
	Key .StartColor = New Color() With { _
		Key .R = 1, _
		Key .G = 81, _
		Key .B = 140 _
	}, _
	Key .[To] = 0.1 _
}
memberMapping3.Colorizer = DesaturationColorizer1
' #endregion

' #region radheatmap-colorizers_5
Partial Public Class MainPage
	Inherits UserControl
	Public Sub New()
		InitializeComponent()
		radHeatMap.Definition.ItemsSource = CreateData()
	End Sub

	Public Function CreateData() As List(Of Car)
		Dim temp = New List(Of Car)()
		From {New Car() With {.Name = "Car 1", .Price = 20590, .HorsePower = 70, .MilesPerGallon = 37, .TopSpeed = 60},
		New Car() With {.Name = "Car 2", .Price = 21990, .HorsePower = 70, .MilesPerGallon = 37, .TopSpeed = 60},
		New Car() With {.Name = "Car 3", .Price = 23200, .HorsePower = 140, .MilesPerGallon = 28, .TopSpeed = 110},
		New Car() With {.Name = "Car 4", .Price = 27500, .HorsePower = 140, .MilesPerGallon = 28, .TopSpeed = 110},
		New Car() With {.Name = "Car 5", .Price = 28200, .HorsePower = 160, .MilesPerGallon = 31, .TopSpeed = 120},
		New Car() With {.Name = "Car 6", .Price = 29500, .HorsePower = 90, .MilesPerGallon = 35, .TopSpeed = 80},
		New Car() With {.Name = "Car 7", .Price = 31200, .HorsePower = 160, .MilesPerGallon = 31, .TopSpeed = 120},
		New Car() With {.Name = "Car 8", .Price = 32200, .HorsePower = 90, .MilesPerGallon = 35, .TopSpeed = 80},
		New Car() With {.Name = "Car 9", .Price = 35200, .HorsePower = 115, .MilesPerGallon = 29, .TopSpeed = 90},
		New Car() With {.Name = "Car 10", .Price = 36700, .HorsePower = 115, .MilesPerGallon = 29, .TopSpeed = 90},
		New Car() With {.Name = "Car 11", .Price = 38200, .HorsePower = 130, .MilesPerGallon = 24, .TopSpeed = 140},
		New Car() With {.Name = "Car 12", .Price = 39700, .HorsePower = 130, .MilesPerGallon = 24, .TopSpeed = 140},
		New Car() With {.Name = "Car 13", .Price = 41500, .HorsePower = 326, .MilesPerGallon = 16, .TopSpeed = 150},
		New Car() With {.Name = "Car 14", .Price = 42200, .HorsePower = 326, .MilesPerGallon = 16, .TopSpeed = 150},
		New Car() With {.Name = "Car 15", .Price = 43500, .HorsePower = 276, .MilesPerGallon = 25, .TopSpeed = 162},
		New Car() With {.Name = "Car 16", .Price = 43500, .HorsePower = 276, .MilesPerGallon = 25, .TopSpeed = 162}}
		
		Return temp
	End Function
End Class

Public Class Car
	Public Property Name() As String
	Public Property MilesPerGallon() As Integer
	Public Property TopSpeed() As Integer
	Public Property Price() As Integer
	Public Property HorsePower() As Integer
End Class
' #endregion

' #region radheatmap-colorizers_6	
Public Function CreateWeatherData() As List(Of MonthlyTemp)
	Dim time = New Date(2004, 1, 1)
	Dim data = New List(Of MonthlyTemp)()
	Dim r As New Random()

	For i As Integer = 0 To 4
		For a As Integer = 0 To 2
			data.Add(New MonthlyTemp(time, r.Next(0, 10)))
			time = time.AddMonths(1)
		Next a
		For a As Integer = 0 To 2
			data.Add(New MonthlyTemp(time, r.Next(10, 20)))
			time = time.AddMonths(1)
		Next a
		For a As Integer = 0 To 2
			data.Add(New MonthlyTemp(time, r.Next(20, 30)))
			time = time.AddMonths(1)
		Next a
		For a As Integer = 0 To 2
			data.Add(New MonthlyTemp(time, r.Next(10, 20)))
			time = time.AddMonths(1)
		Next a
	Next i
	Return data
End Function
' #endregion
	
End Class
