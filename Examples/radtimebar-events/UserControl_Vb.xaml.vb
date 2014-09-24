Public Class Default_Vb
' #region radtimebar-events_1
   public MainPage()
   Public Sub New()
	InitializeComponent()
	AddHandler radTimeBar1.ItemIntervalChanged,      AddressOf radTimeBar1_ItemIntervalChanged
   End Sub

Private Sub radTimeBar1_ItemIntervalChanged(ByVal sender As Object, ByVal e As DrillEventArgs)
			If TypeOf  radTimeBar1.CurrentItemInterval Is MonthInterval Then
				 radTimeBar1.SelectionStart = New Date(2012, 05, 1)
				 radTimeBar1.SelectionEnd = New Date(2012, 07, 1)
			End If
End Sub
' #endregion
End Class
