Public Class Default_Vb


' #region radupload-how-to-limit-the-upload-speed_2
Private timer As DispatcherTimer
Private speedLimit As Integer
Private startTime As DateTime
Public ReadOnly Property UploadLimit() As Integer
 Get
  Dim elapsedSeconds As Integer = DirectCast(TimeSpan.FromTicks(DateTime.Now.Ticks - Me.startTime.Ticks).TotalSeconds, Integer)
  Return Me.radUpload.BufferSize * elapsedSeconds
 End Get
End Property
' #endregion

' #region radupload-how-to-limit-the-upload-speed_4
Public Sub New()
 InitializeComponent()
 Me.timer = New DispatcherTimer()
 Me.timer.Interval = New TimeSpan(0, 0, 0, 0, 500)
 timer.Tick += Me.timer_Tick
End Sub
Private Sub timer_Tick(sender As Object, e As EventArgs)
End Sub
' #endregion

' #region radupload-how-to-limit-the-upload-speed_7
Private Sub radUpload_UploadStarted(sender As Object, e As UploadStartedEventArgs)
 Me.startTime = DateTime.Now
 Me.timer.Start()
End Sub
' #endregion

' #region radupload-how-to-limit-the-upload-speed_10
Private Sub radUpload_ProgressChanged(sender As Object, e As RoutedEventArgs)
 If Me.radUpload.CurrentSession.UploadedBytes > Me.UploadLimit Then
  Me.radUpload.PauseUpload()
  If Not Me.timer.IsEnabled Then
   Me.timer.Start()
  End If
 End If
End Sub
' #endregion

' #region radupload-how-to-limit-the-upload-speed_12
Private Sub timer_Tick(sender As Object, e As EventArgs)
 If Me.radUpload.CurrentSession.UploadedBytes < Me.UploadLimit Then
  If Me.timer.IsEnabled Then
   Me.radUpload.ResumeUpload()
   Me.timer.[Stop]()
  End If
 End If
End Sub
' #endregion

' #region radupload-how-to-limit-the-upload-speed_15
Private Sub radUpload_UploadFinished(sender As Object, e As RoutedEventArgs )
 Me.startTime = DateTime.Now
 Me.timer.[Stop]()
End Sub
' #endregion
End Class
