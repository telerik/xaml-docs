Public Class Default_Vb


' #region radtileview-howto-use-fluidcontentcontrol-in-tileview_1
Public Class MyViewModel
Implements INotifyPropertyChanged
 Public Sub New()
  Me.SmallImage = New Uri("Images/SmallImage.png", UriKind.Relative)
  Me.Image = New Uri("Images/Image.png", UriKind.Relative)
  Me.LargeImage = New Uri("Images/LargeImage.png", UriKind.Relative)
 End Sub
 Public Property Header() As String
 Public Property SmallImage() As Uri
 Public Property Image() As Uri
 Public Property LargeImage() As Uri
 Private _contentState As ContentState
 ''' <summary>
 '''     Gets or sets the name.
 ''' </summary>
 Public Property ContentState() As ContentState
  Get
   Return Me._contentState
  End Get
  Set(ByVal value As ContentState)
   If Me._contentState <> value Then
    Me._contentState = value
    OnPropertyChanged("ContentState")
   End If
  End Set
 End Property
 ''' <summary>
 '''     Event for INotifyPropertyChanged.
 ''' </summary>
 Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
 ''' <summary>
 '''     Raises the INotifyPropertyChanged event.
 ''' </summary>
 ''' <param name="propertyName">The property to be included in the INotifyPropertyChanged EventArgs.</param>
 Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
  RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
 End Sub
End Class
Public Enum ContentState
 SmallContent = 1
 NormalContent = 0
 LargeContent = 2
End Enum
' #endregion

' #region radtileview-howto-use-fluidcontentcontrol-in-tileview_3
Public Shared Function GenerateItems() As IList(Of Object)
 Dim result = New ObservableCollection(Of Object)()
 For Each num In Enumerable.Range(1, 12)
  result.Add(New MyViewModel() With {.Header = String.Format("Item {0}", num)})
 Next num
 Return result
End Function
' #endregion

' #region radtileview-howto-use-fluidcontentcontrol-in-tileview_7
Public Class FluidContentStateConverter
Implements IValueConverter
 Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
  Dim contentState = CType(value, ContentState)
  Select Case contentState
   Case contentState.SmallContent
    Return FluidContentControlState.Small
   Case contentState.NormalContent
    Return FluidContentControlState.Normal
   Case contentState.LargeContent
    Return FluidContentControlState.Large
   Case Else
    Return FluidContentControlState.Normal
  End Select
 End Function
 Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
  Dim fluidState = CType(value, FluidContentControlState)
  Select Case fluidState
   Case FluidContentControlState.Small
    Return ContentState.SmallContent
   Case FluidContentControlState.Normal
    Return ContentState.NormalContent
   Case FluidContentControlState.Large
    Return ContentState.LargeContent
   Case Else
    Return ContentState.NormalContent
  End Select
 End Function
End Class
' #endregion

' #region radtileview-howto-use-fluidcontentcontrol-in-tileview_11
Public Class TileStateConverter
Implements IValueConverter
 #Region "IValueConverter Members"
 Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
  Dim contentState = CType(value, ContentState)
  Select Case contentState
   Case contentState.SmallContent
    Return TileViewItemState.Minimized
   Case contentState.NormalContent
    Return TileViewItemState.Restored
   Case contentState.LargeContent
    Return TileViewItemState.Maximized
   Case Else
    Return TileViewItemState.Restored
  End Select
 End Function
 Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
  Dim tileState = CType(value, TileViewItemState)
  Select Case tileState
   Case TileViewItemState.Minimized
    Return ContentState.SmallContent
   Case TileViewItemState.Restored
    Return ContentState.NormalContent
   Case TileViewItemState.Maximized
    Return ContentState.LargeContent
   Case Else
    Return ContentState.NormalContent
  End Select
 End Function
 #End Region
End Class
' #endregion

' #region radtileview-howto-use-fluidcontentcontrol-in-tileview_15
Public Partial Class MainPage
	Inherits UserControl
	Public Sub New()
		InitializeComponent()
		Me.radTileView.ItemsSource = MyViewModel.GenerateItems()
	End Sub
End Class
' #endregion

' #region radtileview-howto-use-fluidcontentcontrol-in-tileview_17
Public Partial Class MainWindow
	Inherits Window
	Public Sub New()
		InitializeComponent()
		Me.radTileView.ItemsSource = MyViewModel.GenerateItems()
	End Sub
End Class
' #endregion
End Class
