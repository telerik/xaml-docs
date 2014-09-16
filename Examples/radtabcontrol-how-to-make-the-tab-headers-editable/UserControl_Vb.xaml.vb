Public Class Default_Vb
	' #region radtabcontrol-how-to-make-the-tab-headers-editable_1
Public Class EditableTabHeader
    Inherits ContentControl
    Public Sub New() 
      Me.DefaultStyleKey = GetType(EditableTabHeader)
    End Sub
End Class
' #endregion

' #region radtabcontrol-how-to-make-the-tab-headers-editable_4
	<TemplateVisualState(GroupName:="EditStates", Name:="EditMode")>
	<TemplateVisualState(GroupName:="EditStates", Name:="ViewMode")>
	Public Class EditableTabHeader
		Inherits ContentControl
		Private textBox As TextBox
		Private previosLeftClickTime As DateTime = DateTime.Now
		Private previosLeftClickPoint As Point
		Private doubleClickSpan As TimeSpan = TimeSpan.FromSeconds(0.4)

		Public Shared ReadOnly IsInEditModeProperty As DependencyProperty = DependencyProperty.Register("IsInEditMode", GetType(Boolean), GetType(EditableTabHeader), New PropertyMetadata(AddressOf OnIsInEditModeChanged))

		Public Sub New()
			DefaultStyleKey = GetType(EditableTabHeader)
		End Sub

		Public Overloads Overrides Sub OnApplyTemplate()
			MyBase.OnApplyTemplate()

			Me.textBox = TryCast(Me.GetTemplateChild("TextBox"), TextBox)

			AddHandler Me.textBox.LostFocus, AddressOf textBox_LostFocus
		End Sub

		Private Sub textBox_LostFocus(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.IsInEditMode = False
		End Sub

		Protected Overloads Overrides Sub OnMouseLeftButtonDown(ByVal e As MouseButtonEventArgs)
			MyBase.OnMouseLeftButtonDown(e)

			Dim currentTime = DateTime.Now
			Dim currentPoint = e.GetPosition(Me)
			Dim durationBetweenClicks = currentTime - previosLeftClickTime

			If currentPoint = previosLeftClickPoint AndAlso durationBetweenClicks < Me.doubleClickSpan Then
				e.Handled = True
				Me.IsInEditMode = Not Me.IsInEditMode
			End If

			Me.previosLeftClickTime = DateTime.Now
			Me.previosLeftClickPoint = e.GetPosition(Me)
		End Sub

		Public Property IsInEditMode() As Boolean
			Get
				Return CBool(GetValue(IsInEditModeProperty))
			End Get
			Set(ByVal value As Boolean)
				SetValue(IsInEditModeProperty, value)
			End Set
		End Property

		Private Shared Sub OnIsInEditModeChanged(ByVal sender As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			Dim editableContentControl = TryCast(sender, EditableTabHeader)
			Dim newValue = CBool(e.NewValue)

			If Not newValue Then
				editableContentControl.Content = editableContentControl.textBox.Text
			End If

			editableContentControl.ChangeVisualStates()
		End Sub

		Public Sub ChangeVisualStates()
			If Me.IsInEditMode Then
				VisualStateManager.GoToState(Me, "EditMode", True)
			Else
				VisualStateManager.GoToState(Me, "ViewMode", True)
			End If
		End Sub
	End Class
	' #endregion

	' #region radtabcontrol-how-to-make-the-tab-headers-editable_7
Imports Telerik.Windows.Controls

	Partial Public Class MainPage
		Inherits UserControl

		Public Sub New()
			InitializeComponent()

			radTabControl.ItemsSource = Enumerable.Range(1, 5).[Select](Function(num) New TabItemModel() With
			  {
			 .Name = [String].Format("Header {0}", num),
			 .Content = [String].Format("Content {0}", num)
			})
		End Sub
	End Class
	Public Class TabItemModel
		Inherits ViewModelBase
		Private _name As [String]
		Private _content As [String]

		Public Property Name() As [String]
			Get
				Return Me._name
			End Get
			Set(value As [String])
				If Me._name <> value Then
					Me._name = value
					OnPropertyChanged("Name")
				End If
			End Set
		End Property

		Public Property Content() As [String]
			Get
				Return Me._content
			End Get
			Set(value As [String])
				If Me._content <> value Then
					Me._content = value
					OnPropertyChanged("Content")
				End If
			End Set
		End Property
	End Class
' #endregion
End Class
