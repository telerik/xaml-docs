Public Class UserControl_Vb
' #region radchartview-features-chartseriesprovider_0
Public Class SalesInfo
	Public Property MonthName() As String
	Public Property Sales() As Double
End Class

Public Class VendorYearlyData
	Public Property VendorName() As String
	Public Property Data() As ObservableCollection(Of SalesInfo)
End Class

Public Class MainViewModel
	Public Property Data() As ObservableCollection(Of VendorYearlyData)

	Public Sub New()
		Me.Data = GetSampleData()
	End Sub

	Private Function GetSampleData() As ObservableCollection(Of VendorYearlyData)
		Dim result = New ObservableCollection(Of VendorYearlyData)()

		result.Add(New VendorYearlyData() With { _
			.VendorName = "Vendor A", _
			.Data = New ObservableCollection(Of SalesInfo)() With { _
				New SalesInfo() With { _
					.MonthName = "Jan", _
					.Sales = 5 _
				}, _
				New SalesInfo() With { _
					.MonthName = "Feb", _
					.Sales = 7 _
				}, _
				New SalesInfo() With { _
					.MonthName = "Mar", _
					.Sales = 6 _
				}, _
				New SalesInfo() With { _
					.MonthName = "Apr", _
					.Sales = 8 _
				} _
			} _
		})

		result.Add(New VendorYearlyData() With { _
			.VendorName = "Vendor B", _
			.Data = New ObservableCollection(Of SalesInfo)() With { _
				New SalesInfo() With { _
					.MonthName = "Jan", _
					.Sales = 15 _
				}, _
				New SalesInfo() With { _
					.MonthName = "Feb", _
					.Sales = 18 _
				}, _
				New SalesInfo() With { _
					.MonthName = "Mar", _
					.Sales = 19 _
				}, _
				New SalesInfo() With { _
					.MonthName = "Apr", _
					.Sales = 23 _
				} _
			} _
		})


		result.Add(New VendorYearlyData() With { _
			.VendorName = "Vendor C", _
			.Data = New ObservableCollection(Of SalesInfo)() With { _
				New SalesInfo() With { _
					.MonthName = "Jan", _
					.Sales = 21 _
				}, _
				New SalesInfo() With { _
					.MonthName = "Feb", _
					.Sales = 25 _
				}, _
				New SalesInfo() With { _
					.MonthName = "Mar", _
					.Sales = 26 _
				}, _
				New SalesInfo() With { _
					.MonthName = "Apr", _
					.Sales = 25 _
				} _
			} _
		})

		Return result
	End Function
End Class
' #endregion


End Class
