Public Class Default_Vb


' #region raddocking-features-compass_1
Dim compass As Compass = New Compass()
compass.IsBottomIndicatorVisible = False
compass.IsCenterIndicatorVisible = False
' #endregion

' #region raddocking-features-compass_3
Dim rootCompass As RootCompass = New RootCompass()
rootCompass.IsLeftIndicatorVisible = False
rootCompass.IsRightIndicatorVisible = False
' #endregion

' #region raddocking-features-compass_5
Public Partial Class CompassSample
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
        AddHandler radDocking.PreviewShowCompass, AddressOf radDocking_PreviewShowCompass
    End Sub
    Private Sub radDocking_PreviewShowCompass(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs)
        e.Compass.Background = New SolidColorBrush(Colors.Red)
    End Sub
End Class
' #endregion
End Class
