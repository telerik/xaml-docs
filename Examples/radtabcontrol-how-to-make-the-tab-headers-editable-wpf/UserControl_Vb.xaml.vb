Public Class Default_Vb

' #region radtabcontrol-how-to-make-the-tab-headers-editable-wpf_1
Public Class EditableTabHeaderControl
	Inherits ContentControl
	Shared Sub New()
		DefaultStyleKeyProperty.OverrideMetadata(GetType(EditableTabHeaderControl), New FrameworkPropertyMetadata(GetType(EditableTabHeaderControl)))
	End Sub
End Class
' #endregion

' #region radtabcontrol-how-to-make-the-tab-headers-editable-wpf_4
	<TemplatePart(Name:="PART_EditArea", Type:=GetType(TextBox))>
	Public Class EditableTabHeaderControl
		Inherits ContentControl
		Shared Sub New()
			DefaultStyleKeyProperty.OverrideMetadata(GetType(EditableTabHeaderControl), New FrameworkPropertyMetadata(GetType(EditableTabHeaderControl)))
		End Sub

		Private textBox As TextBox

		Public Shared IsInEditModeProperty As DependencyProperty = DependencyProperty.Register("IsInEditMode", GetType([Boolean]), GetType(EditableTabHeaderControl))

		Public Property IsInEditMode() As Boolean
			Get
				Return CBool(Me.GetValue(IsInEditModeProperty))
			End Get
			Set(value As Boolean)
				Me.SetValue(IsInEditModeProperty, value)
			End Set
		End Property

		Public Overrides Sub OnApplyTemplate()
			MyBase.OnApplyTemplate()

			Me.textBox = TryCast(Me.Template.FindName("PART_EditArea", Me), TextBox)
			AddHandler Me.textBox.LostFocus, AddressOf textBox_LostFocus
			AddHandler Me.MouseDoubleClick, AddressOf EditableTabHeaderControl_MouseDoubleClick
		End Sub

		Private Sub textBox_LostFocus(sender As Object, e As RoutedEventArgs)
			Me.IsInEditMode = False
		End Sub

		Private Sub EditableTabHeaderControl_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
			If e.LeftButton = MouseButtonState.Pressed Then
				Me.IsInEditMode = True
			End If
		End Sub

	End Class
	' #endregion

	' #region radtabcontrol-how-to-make-the-tab-headers-editable-wpf_7
	Imports Telerik.Windows.Controls

	Class MainWindow
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
