Public Class Default_Vb
' #region raddatabar-databinding_0
Public Class Product
		Public Property Value1() As Integer
		Public Property Value2() As Integer

		Public Property Ints() As IEnumerable(Of Integer)
		Public Property Items() As IEnumerable(Of Item)
	End Class

	Public Class Item
		Public Property Val() As Double
		Public Property Name() As String
	End Class
' #endregion

' #region raddatabar-databinding_1
Dim items = New List(Of Item)() From {
	 New Item With {.Val = 9, .Name = "nine"},
	 New Item With {.Val = 10, .Name = "ten"},
	 New Item With {.Val = 11, .Name = "eleven"},
	 New Item With {.Val = 20, .Name = "twenty"},
	 New Item With {.Val = 22, .Name = "twenty two"},
	 New Item With {.Val = 90, .Name = "ninety"},
	 New Item With {.Val = -9, .Name = "-nine"},
	 New Item With {.Val = -10, .Name = "-ten"},
	 New Item With {.Val = -11, .Name = "-eleven"},
	 New Item With {.Val = -20, .Name = "-twenty"},
	 New Item With {.Val = -100, .Name = "-hundred"}}

Dim TempProduct As Product = New Product() With {.Value1 = 20, .Value2 = 30, .Ints = New List(Of Integer)() From {5, 6, 7, 8, 9}, .Items = items}
			Me.DataContext = New Product() With {.Value1 = 20, .Value2 = 30, .Ints = New List(Of Integer)() From {5, 6, 7, 8, 9}, .Items			
' #endregion
			
End Class
