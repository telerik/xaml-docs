Public Class Default_Vb

	' #region gridview-filtering-custom-filtering-controls_0
	''' <summary>
	''' Provides functionality required by all filtering components.
	''' </summary>
	Public Interface IFilteringControl
		''' <summary>
		''' Prepares the component for the column it will service.
		''' </summary>
		''' <param name="column">The column to prepare for.</param>
		Sub Prepare(column As GridViewColumn)

		''' <summary>
		''' Gets a value indicating whether the filtering is active.
		''' </summary>
		Property IsActive() As Boolean
	End Interface
	' #endregion

	' #region gridview-filtering-custom-filtering-controls_1
	Partial Public Class FromDateToDateFilterControl
		Inherits UserControl
		Implements IFilteringControl
		Private column As GridViewBoundColumnBase
		Private compositeFilter As CompositeFilterDescriptor
		Private fromFilter As Telerik.Windows.Data.FilterDescriptor
		Private toFilter As Telerik.Windows.Data.FilterDescriptor

		''' <summary>
		''' Gets or sets a value indicating whether the filtering is active.
		''' </summary>
		Public Property IsActive As Boolean Implements Telerik.Windows.Controls.GridView.IFilteringControl.IsActive
			Get
				Return CBool(GetValue(IsActiveProperty))
			End Get
			Set(value As Boolean)
				SetValue(IsActiveProperty, value)
			End Set
		End Property

		''' <summary>
		''' Identifies the <see cref="IsActive"/> dependency property.
		''' </summary>
		Public Shared ReadOnly IsActiveProperty As DependencyProperty = DependencyProperty.Register("IsActive", GetType(Boolean), GetType(FromDateToDateFilterControl), New System.Windows.PropertyMetadata(False))

		<TypeConverter(GetType(DateTimeTypeConverter))> _
		Public Property FromDate() As DateTime
			Get
				Return Me.fromDatePicker.SelectedDate.GetValueOrDefault(DateTime.MinValue)
			End Get
			Set(value As DateTime)
				Me.fromDatePicker.SelectedDate = value
			End Set
		End Property

		<TypeConverter(GetType(DateTimeTypeConverter))> _
		Public Property ToDate() As DateTime
			Get
				Return Me.toDatePicker.SelectedDate.GetValueOrDefault(DateTime.MaxValue)
			End Get
			Set(value As DateTime)
				Me.toDatePicker.SelectedDate = value
			End Set
		End Property

		Public ReadOnly Property FromPicker() As RadDatePicker
			Get
				Return Me.fromDatePicker
			End Get
		End Property

		Public ReadOnly Property ToPicker() As RadDatePicker
			Get
				Return Me.toDatePicker
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub Prepare(column As Telerik.Windows.Controls.GridViewColumn) Implements Telerik.Windows.Controls.GridView.IFilteringControl.Prepare
			Me.column = TryCast(column, GridViewBoundColumnBase)
			If Me.column Is Nothing Then
				Return
			End If

			If Me.compositeFilter Is Nothing Then
				Me.CreateFilters()
			End If

			Me.fromFilter.Value = Me.FromDate
			Me.toFilter.Value = Me.ToDate
		End Sub

		Private Sub CreateFilters()
			Dim dataMember As String = Me.column.DataMemberBinding.Path.Path

			Me.compositeFilter = New CompositeFilterDescriptor()

			Me.fromFilter = New Telerik.Windows.Data.FilterDescriptor(dataMember, Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo, Nothing)
			Me.compositeFilter.FilterDescriptors.Add(Me.fromFilter)

			Me.toFilter = New Telerik.Windows.Data.FilterDescriptor(dataMember, Telerik.Windows.Data.FilterOperator.IsLessThanOrEqualTo, Nothing)
			Me.compositeFilter.FilterDescriptors.Add(Me.toFilter)
		End Sub

		Private Sub OnFilter(sender As Object, e As RoutedEventArgs)
			Me.fromFilter.Value = Me.FromDate
			Me.toFilter.Value = Me.ToDate

			If Not Me.column.DataControl.FilterDescriptors.Contains(Me.compositeFilter) Then
				Me.column.DataControl.FilterDescriptors.Add(Me.compositeFilter)
			End If

			Me.IsActive = True
		End Sub

		Private Sub OnClear(sender As Object, e As RoutedEventArgs)
			If Me.column.DataControl.FilterDescriptors.Contains(Me.compositeFilter) Then
				Me.column.DataControl.FilterDescriptors.Remove(Me.compositeFilter)
			End If

			Me.FromDate = New DateTime(1990, 1, 1)
			Me.ToDate = New DateTime(1995, 1, 1)

			Me.IsActive = False
		End Sub
	End Class

	' #endregion
End Class
