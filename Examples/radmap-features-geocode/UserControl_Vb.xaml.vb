Public Class Default_Vb


' #region radmap-features-geocode_1
Private geocodeProvider As BingGeocodeProvider
Public Sub New()
 InitializeComponent()
 Me.geocodeProvider = New BingGeocodeProvider()
 Me.geocodeProvider.ApplicationId = "key"
 AddHandler Me.geocodeProvider.GeocodeCompleted, AddressOf Me.geocodeProvider_GeocodeCompleted
End Sub
Private Sub geocodeProvider_GeocodeCompleted(sender As Object, e As GeocodeCompletedEventArgs)
End Sub
' #endregion

' #region radmap-features-geocode_4
Private Sub GeocodeButton_Click(sender As Object, e As RoutedEventArgs)
 Dim request As New GeocodeRequest()
 request.Query = Me.InputBox.Text
 Me.geocodeProvider.GeocodeAsync(request)
End Sub
' #endregion

' #region radmap-features-geocode_7
Private Sub radMap_MapMouseDoubleClick(sender As Object, e As MapMouseRoutedEventArgs)
 Dim reverseRequest As New ReverseGeocodeRequest()
 reverseRequest.Location = e.Location
 Me.geocodeProvider.ReverseGeocodeAsync(reverseRequest)
End Sub
' #endregion

' #region radmap-features-geocode_9
Private Sub geocodeProvider_GeocodeCompleted(sender As Object, e As GeocodeCompletedEventArgs)
 For Each result As GeocodeResult In e.Response.Results
  MessageBox.Show(String.Format("Longitude: {0}, Latitude: {1}, Address: {2}", result.Locations.First().Longitude, result.Locations.First().Latitude, result.DisplayName))
 Next
End Sub
' #endregion
End Class
