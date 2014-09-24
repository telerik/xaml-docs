Public Class UserControl_Vb

#region radchartview-populating-with-data-binding-to-data-table_1
Dim dt As New DataTable()
dt.Columns.Add("Expected", GetType(Double))
dt.Columns.Add("Actual", GetType(Double))
dt.Columns.Add("Month", GetType(DateTime))

dt.Rows.Add(30, 28, New DateTime(2013, 1, 1))
dt.Rows.Add(45, 32, New DateTime(2013, 3, 1))
dt.Rows.Add(5, 23, New DateTime(2013, 5, 1))
dt.Rows.Add(10, 7, New DateTime(2013, 7, 1))
dt.Rows.Add(3, 2, New DateTime(2013, 11, 1))
dt.Rows.Add(7, 10, New DateTime(2013, 12, 1))

Me.DataContext = dt.Rows
#endregion

#region radchartview-populating-with-data-binding-to-data-table_3
Me.barSeries1.ValueBinding = New Telerik.Windows.Controls.ChartView.GenericDataPointBinding(Of DataRow, Double)() With { _
	.ValueSelector = Function(row) CDbl(row("Actual")) _
}

Me.barSeries1.CategoryBinding = New Telerik.Windows.Controls.ChartView.GenericDataPointBinding(Of DataRow, DateTime)() With { _
	.ValueSelector = Function(row) DirectCast(row("Month"), DateTime) _
}

Me.barSeries2.ValueBinding = New Telerik.Windows.Controls.ChartView.GenericDataPointBinding(Of DataRow, Double)() With { _
	.ValueSelector = Function(row) CDbl(row("Expected")) _
}

Me.barSeries2.CategoryBinding = New Telerik.Windows.Controls.ChartView.GenericDataPointBinding(Of DataRow, DateTime)() With { _
	.ValueSelector = Function(row) DirectCast(row("Month"), DateTime) _
}
#endregion


End Class
