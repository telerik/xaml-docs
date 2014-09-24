Public Class Default_Vb


#Region "gridview-how-to-create-date-time-picker-column_0"
	Public Class Club
		Public Sub New(name As String, established As DateTime, stadiumCapacity As Integer)
			Me.Name = name
			Me.Established = established
			Me.StadiumCapacity = stadiumCapacity
		End Sub
		Public Property Name() As String
			Get
			End Get
			Set(value As String)
			End Set
		End Property
		Public Property Established() As System.Nullable(Of DateTime)
			Get
			End Get
			Set(value As System.Nullable(Of DateTime))
			End Set
		End Property
		Public Property StadiumCapacity() As Integer
			Get
			End Get
			Set(value As Integer)
			End Set
		End Property
		Public Shared Function GetClubs() As IEnumerable(Of Club)
			Dim clubs As New ObservableCollection(Of Club)()
			clubs.Add(New Club("Liverpool", New DateTime(1892, 1, 1), 45362))
			clubs.Add(New Club("Manchester Utd.", New DateTime(1878, 1, 1), 76212))
			clubs.Add(New Club("Chelsea", New DateTime(1905, 1, 1), 42055))
			clubs.Add(New Club("Arsenal", New DateTime(1886, 1, 1), 60355))
			Return clubs
		End Function
	End Class
#End Region

#Region "gridview-how-to-create-date-time-picker-column_1"
	Me.radGridView.ItemsSource = Club.GetClubs()
#End Region

#Region "gridview-how-to-create-date-time-picker-column_2"
	Partial Public Class DateTimePicker
		Inherits UserControl

		Public Shared ReadOnly SelectedDateProperty As DependencyProperty = DependencyProperty.Register("SelectedDate", GetType(Date?), GetType(DateTimePicker), New PropertyMetadata(Nothing))

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Property SelectedDate() As Date?
			Get
				Return CType(Me.GetValue(SelectedDateProperty), Date?)
			End Get
			Set(ByVal value As Date?)
				Me.SetValue(SelectedDateProperty, value)
			End Set
		End Property

		Private Sub HandlePickersSelectionChanged()
			If Me.Calendar.SelectedDate IsNot Nothing AndAlso Me.TimePicker.SelectedTime IsNot Nothing Then
				Me.SelectedDate = Me.Calendar.SelectedDate + Me.TimePicker.SelectedTime
			End If
		End Sub

		Private Sub OnTimePickerSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs)
			Me.HandlePickersSelectionChanged()
		End Sub

		Private Sub OnCalendarSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs)
			Me.HandlePickersSelectionChanged()
		End Sub
	End Class
#End Region

#Region "gridview-how-to-create-date-time-picker-column_3"
	Partial Public Class DateTimePicker
		Inherits UserControl

		Public Shared ReadOnly SelectedDateProperty As DependencyProperty = DependencyProperty.Register("SelectedDate", GetType(Date?), GetType(DateTimePicker), New PropertyMetadata(Nothing))

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Property SelectedDate() As Date?
			Get
				Return CType(Me.GetValue(SelectedDateProperty), Date?)
			End Get
			Set(ByVal value As Date?)
				Me.SetValue(SelectedDateProperty, value)
			End Set
		End Property

		Private Sub HandlePickersSelectionChanged()
			If Me.Calendar.SelectedDate IsNot Nothing AndAlso Me.TimePicker.SelectedTime IsNot Nothing Then
				Me.SelectedDate = Me.Calendar.SelectedDate + Me.TimePicker.SelectedTime
			End If
		End Sub

		Private Sub OnTimePickerSelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
			Me.HandlePickersSelectionChanged()
		End Sub

		Private Sub OnCalendarSelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
			Me.HandlePickersSelectionChanged()
		End Sub
	End Class
#End Region

#Region "gridview-how-to-create-date-time-picker-column_4"
	Public Class DateTimePickerColumn
		Inherits GridViewBoundColumnBase

		Public Overrides Function CreateCellEditElement(ByVal cell As GridViewCell, ByVal dataItem As Object) As FrameworkElement
			Me.BindingTarget = DateTimePicker.SelectedDateProperty
			Dim picker = New DateTimePicker()
			picker.SetBinding(Me.BindingTarget, Me.CreateValueBinding())
			Return picker
		End Function

		Private Function CreateValueBinding() As Binding
			Dim valueBinding = New Binding()
			valueBinding.Mode = BindingMode.TwoWay
			valueBinding.NotifyOnValidationError = True
			valueBinding.ValidatesOnExceptions = True
			valueBinding.UpdateSourceTrigger = UpdateSourceTrigger.Explicit
			valueBinding.Path = New PropertyPath(Me.DataMemberBinding.Path.Path)
			Return valueBinding
		End Function
	End Class
#End Region

End Class
