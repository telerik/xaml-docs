Public Class Default_Vb
' #region radheatmap-populating-with-data_0
	Public Class TempInfo
	Public Property Year() As DateTime
		Get
			Return m_Year
		End Get
		Set
			m_Year = Value
		End Set
	End Property
	Private m_Year As DateTime
	Public Property Month() As String
		Get
			Return m_Month
		End Get
		Set
			m_Month = Value
		End Set
	End Property
	Private m_Month As String
	Public Property Temperature() As Double
		Get
			Return m_Temperature
		End Get
		Set
			m_Temperature = Value
		End Set
	End Property
	Private m_Temperature As Double
	Public Property Rain() As Double
		Get
			Return m_Rain
		End Get
		Set
			m_Rain = Value
		End Set
	End Property
	Private m_Rain As Double
End Class
' #endregion

' #region radheatmap-populating-with-data_1
Dim [date] As New DateTime(2010, 1, 1)

Dim infos = New List(Of TempInfo)() From { _
	New TempInfo() With { _
		.Year = [date], _
		.Month = "Apr", _
		.Temperature = 17, _
		.Rain = 8.8 _
	}, _
	New TempInfo() With { _
		.Year = [date], _
		.Month = "May", _
		.Temperature = 20, _
		.Rain = 6.25 _
	}, _
	New TempInfo() With { _
		.Year = [date].AddYears(1), _
		.Month = "Jan", _
		.Temperature = 5, _
		.Rain = 10.3 _
	}, _
	New TempInfo() With { _
		.Year = [date].AddYears(1), _
		.Month = "Feb", _
		.Temperature = 13, _
		.Rain = 9.8 _
	}, _
	New TempInfo() With { _
		.Year = [date].AddYears(1), _
		.Month = "Mar", _
		.Temperature = 21, _
		.Rain = 9.6 _
	}, _
	New TempInfo() With { _
		.Year = [date].AddYears(2), _
		.Month = "Jan", _
		.Temperature = 14, _
		.Rain = 11.5 _
	}, _
	New TempInfo() With { _
		.Year = [date].AddYears(2), _
		.Month = "Feb", _
		.Temperature = 19, _
		.Rain = 7.5 _
	}, _
	New TempInfo() With { _
		.Year = [date].AddYears(2), _
		.Month = "Mar", _
		.Temperature = 17, _
		.Rain = 10.1 _
	} _
}
' #endregion
			
End Class
