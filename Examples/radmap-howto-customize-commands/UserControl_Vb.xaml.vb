Public Class Default_Vb


' #region radmap-howto-customize-commands_2
Private Const ImagePathFormat As String = "/Map;component/Silverlight/CustomCommands/Images/{0}.png"
Private VEKey As String = "set-your-BingMaps-Key-here"
Private provider As BingMapProvider
Private Sub SetProvider()
 Me.provider = New BingMapProvider(MapMode.Aerial, True, Me.VEKey)
 Me.provider.Commands.Clear()
 Me.AddCustomCommandAction(Me.provider, "Restaurants")
 Me.AddCustomCommandAction(Me.provider, "Bars")
 Me.AddCustomCommandAction(Me.provider, "Museums")
 Me.RadMap1.Provider = provider
End Sub
Private Sub AddCustomCommandAction(provider As BingMapProvider, poi As String)
 Dim commandText As String = String.Format("Find {0}", poi)
 Dim commandName As String = String.Format("Find{0}Command", poi)
 Dim commandDescription As New CommandDescription()
 commandDescription.Command = New RoutedUICommand(commandText, commandName, GetType(BingMapProvider))
 commandDescription.CommandParameter = poi
 commandDescription.DataTemplate = TryCast(Me.LayoutRoot.Resources("CustomCommandDataTemplate"), DataTemplate)
 Dim imagePath As String = String.Format(ImagePathFormat, poi)
 commandDescription.ImageUri = New Uri(imagePath, UriKind.RelativeOrAbsolute)
 Dim commandBinding As New CommandBinding(commandDescription.Command, ExecuteCustomCommand)
 provider.Commands.Add(commandDescription)
 provider.CommandBindingCollection.Add(commandBinding)
End Sub
Private Sub ExecuteCustomCommand(sender As Object, e As ExecutedRoutedEventArgs)
 ' execute custom action here...
End Sub
' #endregion

' #region radmap-howto-customize-commands_4
Public Sub New()
 InitializeComponent()
 ' Call this method if you want to create a brand-new list of custom commands for the provider.
 ' Otherwise the custom command will be appended to the default list.
 Me.radMap.Provider.Commands.Clear()
 Dim commandDescription As New CommandDescription() With { _
  .Command = New DelegateCommand(Me.ExecuteCommand), _
  .CommandParameter = "test", _
  .DataTemplate = TryCast(Me.Resources("CustomTemplate2"), DataTemplate) _
 }
 Me.radMap.Provider.Commands.Add(commandDescription)
End Sub
Private Sub ExecuteCommand(parameter As Object)
 MessageBox.Show(String.Format("My command: {0}", parameter))
End Sub
' #endregion
End Class
