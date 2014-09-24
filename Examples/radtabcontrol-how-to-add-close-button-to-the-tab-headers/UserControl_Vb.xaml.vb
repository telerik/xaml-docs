Public Class Default_Vb


' #region radtabcontrol-how-to-add-close-button-to-the-tab-headers_1
Public Class RoutedEventHelper
    'Create the routed event:
		Public Shared ReadOnly CloseTabEvent As RoutedEvent = EventManager.RegisterRoutedEvent("CloseTab", RoutingStrategy.Bubble, GetType(RoutedEventHandler), GetType(RoutedEventHelper))
    'Add an atached property:
    Public Shared Function GetEnableRoutedClick(ByVal obj As DependencyObject) As Boolean
        Return CBool(obj.GetValue(EnableRoutedClickProperty))
    End Function
    Public Shared Sub SetEnableRoutedClick(ByVal obj As DependencyObject, ByVal value As Boolean)
        obj.SetValue(EnableRoutedClickProperty, value)
    End Sub
    ' Using a DependencyProperty as the backing store for EnableRoutedClick. This enables animation, styling, binding, etc...
    Public Shared ReadOnly EnableRoutedClickProperty As DependencyProperty = DependencyProperty.RegisterAttached("EnableRoutedClick", GetType(Boolean), GetType(RoutedEventHelper), New System.Windows.PropertyMetadata(New PropertyChangedCallback(AddressOf OnEnableRoutedClickChanged)))
    Private Shared Sub OnEnableRoutedClickChanged(ByVal sender As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
        Dim newValue = CBool(e.NewValue)
        Dim button = TryCast(sender, Button)
        If button Is Nothing Then
            Exit Sub
        End If
        If newValue Then
            AddHandler button.Click, AddressOf OnButtonClick
        End If
    End Sub
    Private Shared Sub OnButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim control = TryCast(sender, Control)
        If control IsNot Nothing Then
            control.[RaiseEvent](New RadRoutedEventArgs(RoutedEventHelper.CloseTabEvent, control))
        End If
    End Sub
End Class
' #endregion

' #region radtabcontrol-how-to-add-close-button-to-the-tab-headers_4
Partial Public Class Page
    Inherits UserControl
    Private tabItemsModel As New ObservableCollection(Of TabItemModel)()
    Public Sub New()
        InitializeComponent()
        Me.CreateTabItems()
        EventManager.RegisterClassHandler(GetType(RadTabItem), RoutedEventHelper.CloseTabEvent, New RoutedEventHandler(AddressOf OnCloseClicked))
    End Sub
    Public Sub OnCloseClicked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim tabItem = TryCast(sender, RadTabItem)
        ' Remove the item from the collection the control is bound to
        tabItemsModel.Remove(TryCast(tabItem.DataContext, TabItemModel))
    End Sub
    Private Sub CreateTabItems()
        ' Create items:
        For num As Integer = 0 To 4
            Dim itemModel = New TabItemModel()
            itemModel.Content = String.Format("Item Content {0}", num)
            itemModel.Title = String.Format("Item {0}", num)
            tabItemsModel.Add(itemModel)
        Next
        ' Attach the items:
        tabControl.ItemsSource = tabItemsModel
    End Sub
End Class
Public Class TabItemModel
    Private _Title As [String]
    Public Property Title() As [String]
        Get
            Return _Title
        End Get
        Set(ByVal value As [String])
            _Title = value
        End Set
    End Property
    Private _Content As [String]
    Public Property Content() As [String]
        Get
            Return _Content
        End Get
        Set(ByVal value As [String])
            _Content = value
        End Set
    End Property
End Class
' #endregion
End Class
