Public Class Default_Vb

' #region radgauge-features-data-binding_2
Public Sub New()
 InitializeComponent()
 Dim values As New ObservableCollection(Of Double)() From {10, 15, 25, 17, 40, 50, 60, 70, 25, 15, 5, 10, 12, 18, 29, 37, 92}
 Me.radialBar.ValueSource = values
End Sub
' #endregion

' #region radgauge-features-data-binding_4
Private Sub StartPlayback()
 Me.radialBar.StartPlayback()
End Sub
' #endregion

' #region radgauge-features-data-binding_6
Private Sub StopPlayback()
 Me.radialBar.StopPlayback()
End Sub
' #endregion

' #region radgauge-features-data-binding_8
Private Sub MoveNext()
 Me.radialBar.MoveNext()
End Sub
' #endregion

' #region radgauge-features-data-binding_10
Private Sub MovePrevious()
 Me.radialBar.MovePrevious()
End Sub
' #endregion
End Class

' #region radgauge-features-data-binding_12
Public Sub New()
	InitializeComponent()
	Dim values As New List(Of PlaybackData)() From { _
		New PlaybackData() With { _
			Key .Value = 10, _
			Key .Duration = TimeSpan.FromMilliseconds(500.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 15, _
			Key .Duration = TimeSpan.FromMilliseconds(1000.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 25, _
			Key .Duration = TimeSpan.FromMilliseconds(250.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 17, _
			Key .Duration = TimeSpan.FromMilliseconds(250.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 40, _
			Key .Duration = TimeSpan.FromMilliseconds(250.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 50, _
			Key .Duration = TimeSpan.FromMilliseconds(250.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 60, _
			Key .Duration = TimeSpan.FromMilliseconds(500.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 70, _
			Key .Duration = TimeSpan.FromMilliseconds(125.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 25, _
			Key .Duration = TimeSpan.FromMilliseconds(125.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 15, _
			Key .Duration = TimeSpan.FromMilliseconds(500.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 5, _
			Key .Duration = TimeSpan.FromMilliseconds(1000.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 10, _
			Key .Duration = TimeSpan.FromMilliseconds(500.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 12, _
			Key .Duration = TimeSpan.FromMilliseconds(500.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 18, _
			Key .Duration = TimeSpan.FromMilliseconds(250.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 93, _
			Key .Duration = TimeSpan.FromMilliseconds(250.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 66, _
			Key .Duration = TimeSpan.FromMilliseconds(500.0) _
		}, _
		New PlaybackData() With { _
			Key .Value = 30, _
			Key .Duration = TimeSpan.FromMilliseconds(500.0) _
		} _
	}
	Me.radialBar.ValueSource = values
End Sub
' #endregion
