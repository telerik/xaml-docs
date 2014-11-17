'#region "radpivotgrid-features-annotations_1"
Public Class Order
	Public Property [Date]() As Date
	Public Property Product() As String
	Public Property Quantity() As Integer
	Public Property Net() As Double
	Public Property Promotion() As String
	Public Property Advertisement() As String
End Class
'#endregion

'#region radpivotgrid-features-annotations_2
<Display(Name:="Month")> _
Public Property [Date]() As Date

'Hide Product from the UI
<Display(AutoGenerateField:=False)> _
Public Property Product() As String
'#endregion

' #region radpivotgrid-features-annotations_3
'Hide Product from the UI
<Browsable(False)> _
Public Property Product() As String
' #endregion

' #region radpivotgrid-features-annotations_4
'Rename the Date property to Month in the UI
<DisplayName("Month")> _
Public Property [Date]() As Date
' #endregion

' #region radpivotgrid-features-annotations_5
Public Class Order
	'Rename the Date property to Month in the UI
	<Display(Name:="Month")> _
	Public Property [Date]() As Date

	Public Property Product() As String

	'Hide Quantiy from the UI
	<Display(AutoGenerateField:=False)> _
	Public Property Quantity() As Integer

	Public Property Net() As Double

	Public Property Promotion() As String

	'Hide Product from the UI
	<Browsable(False)> _
	Public Property Advertisement() As String
End Class
' #endregion