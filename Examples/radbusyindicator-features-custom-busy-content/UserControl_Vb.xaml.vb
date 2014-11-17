Public Class Default_Vb


' #region radbusyindicator-features-custom-busy-content_3
Public Partial Class BusyContentTemplateSample
 Inherits UserControl
 Implements INotifyPropertyChanged
 Private m_progressValue As Integer
 Private progressTimer As DispatcherTimer
 Public Event PropertyChanged As PropertyChangedEventHandler
 Public Sub New()
  InitializeComponent()
  Me.DataContext = Me
  Me.progressTimer = New DispatcherTimer()
  Me.progressTimer.Interval = TimeSpan.FromSeconds(1)
  Me.progressTimer.Tick += New EventHandler(Me.progressTimer_Tick)
 End Sub
 Public Property ProgressValue() As Integer
  Get
   Return Me.m_progressValue
  End Get
  Set
   If Me.m_progressValue = value Then
    Return
   End If
   Me.m_progressValue = value
   RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("ProgressValue"))
  End Set
 End Property
 Private Sub showIndicatorButton_Click(sender As Object, e As RoutedEventArgs)
  Me.progressTimer.Start()
  Me.ProgressValue = 100
  Me.radBusyIndicator.IsBusy = True
 End Sub
 Private Sub progressTimer_Tick(sender As Object, e As EventArgs)
  Me.ProgressValue -= 1
  If Me.ProgressValue = 0 Then
   Me.progressTimer.[Stop]()
   Me.radBusyIndicator.IsBusy = False
  End If
 End Sub
End Class
' #endregion
End Class
