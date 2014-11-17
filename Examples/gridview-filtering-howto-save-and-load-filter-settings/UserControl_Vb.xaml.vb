Public Class Default_Vb

' #region gridview-filtering-howto-save-and-load-filter-settings_0
Public Class FilterDescriptorProxy
	Public Property [Operator]() As Telerik.Windows.Data.FilterOperator
		Get
			Return m_Operator
		End Get
		Set(value As Telerik.Windows.Data.FilterOperator)
			m_Operator = Value
		End Set
	End Property
	Private m_Operator As Telerik.Windows.Data.FilterOperator
	Public Property Value() As Object
		Get
			Return m_Value
		End Get
		Set(value As Object)
			m_Value = Value
		End Set
	End Property
	Private m_Value As Object
	Public Property IsCaseSensitive() As Boolean
		Get
			Return m_IsCaseSensitive
		End Get
		Set(value As Boolean)
			m_IsCaseSensitive = Value
		End Set
	End Property
	Private m_IsCaseSensitive As Boolean
End Class

Public Class FilterSetting
	Public Property ColumnUniqueName() As String
		Get
			Return m_ColumnUniqueName
		End Get
		Set(value As String)
			m_ColumnUniqueName = Value
		End Set
	End Property
	Private m_ColumnUniqueName As String
	Public SelectedDistinctValues As New List(Of Object)()
	Public Property Filter1() As FilterDescriptorProxy
		Get
			Return m_Filter1
		End Get
		Set(value As FilterDescriptorProxy)
			m_Filter1 = Value
		End Set
	End Property
	Private m_Filter1 As FilterDescriptorProxy
	Public Property FieldFilterLogicalOperator() As Telerik.Windows.Data.FilterCompositionLogicalOperator
		Get
			Return m_FieldFilterLogicalOperator
		End Get
		Set(value As Telerik.Windows.Data.FilterCompositionLogicalOperator)
			m_FieldFilterLogicalOperator = Value
		End Set
	End Property
	Private m_FieldFilterLogicalOperator As Telerik.Windows.Data.FilterCompositionLogicalOperator
	Public Property Filter2() As FilterDescriptorProxy
		Get
			Return m_Filter2
		End Get
		Set(value As FilterDescriptorProxy)
			m_Filter2 = Value
		End Set
	End Property
	Private m_Filter2 As FilterDescriptorProxy
End Class

Partial Public Class SaveLoadSettings
	Inherits Window
	Public Shared Function SaveColumnFilters(grid As Telerik.Windows.Controls.GridView.GridViewDataControl) As IEnumerable(Of FilterSetting)
		Dim settings As IList(Of FilterSetting) = New List(Of FilterSetting)()

		For Each filter As Telerik.Windows.Data.IFilterDescriptor In grid.FilterDescriptors
			Dim columnFilter As Telerik.Windows.Controls.GridView.IColumnFilterDescriptor = TryCast(filter, Telerik.Windows.Controls.GridView.IColumnFilterDescriptor)
			If columnFilter IsNot Nothing Then
				Dim setting As New FilterSetting()

				setting.ColumnUniqueName = columnFilter.Column.UniqueName

				setting.SelectedDistinctValues.AddRange(columnFilter.DistinctFilter.DistinctValues)

				If columnFilter.FieldFilter.Filter1.IsActive Then
					setting.Filter1 = New FilterDescriptorProxy()
					setting.Filter1.[Operator] = columnFilter.FieldFilter.Filter1.[Operator]
					setting.Filter1.Value = columnFilter.FieldFilter.Filter1.Value
					setting.Filter1.IsCaseSensitive = columnFilter.FieldFilter.Filter1.IsCaseSensitive
				End If

				setting.FieldFilterLogicalOperator = columnFilter.FieldFilter.LogicalOperator

				If columnFilter.FieldFilter.Filter2.IsActive Then
					setting.Filter2 = New FilterDescriptorProxy()
					setting.Filter2.[Operator] = columnFilter.FieldFilter.Filter2.[Operator]
					setting.Filter2.Value = columnFilter.FieldFilter.Filter2.Value
					setting.Filter2.IsCaseSensitive = columnFilter.FieldFilter.Filter2.IsCaseSensitive
				End If

				settings.Add(setting)
			End If
		Next

		Return settings
	End Function

	Public Shared Sub LoadColumnFilters(grid As Telerik.Windows.Controls.GridView.GridViewDataControl, savedSettings As IEnumerable(Of FilterSetting))
		grid.FilterDescriptors.SuspendNotifications()

		For Each setting As FilterSetting In savedSettings
			Dim column As Telerik.Windows.Controls.GridViewColumn = grid.Columns(setting.ColumnUniqueName)

			Dim columnFilter As Telerik.Windows.Controls.GridView.IColumnFilterDescriptor = column.ColumnFilterDescriptor

			For Each distinctValue As Object In setting.SelectedDistinctValues
				columnFilter.DistinctFilter.AddDistinctValue(distinctValue)
			Next

			If setting.Filter1 IsNot Nothing Then
				columnFilter.FieldFilter.Filter1.[Operator] = setting.Filter1.[Operator]
				columnFilter.FieldFilter.Filter1.Value = setting.Filter1.Value
				columnFilter.FieldFilter.Filter1.IsCaseSensitive = setting.Filter1.IsCaseSensitive
			End If

			columnFilter.FieldFilter.LogicalOperator = setting.FieldFilterLogicalOperator

			If setting.Filter2 IsNot Nothing Then
				columnFilter.FieldFilter.Filter2.[Operator] = setting.Filter2.[Operator]
				columnFilter.FieldFilter.Filter2.Value = setting.Filter2.Value
				columnFilter.FieldFilter.Filter2.IsCaseSensitive = setting.Filter2.IsCaseSensitive
			End If
		Next

		grid.FilterDescriptors.ResumeNotifications()
	End Sub


	Public Sub New()
		InitializeComponent()

		Me.radGridView.ItemsSource = New NorthwindEntities().Customers
	End Sub

	Private serializedSettings As IEnumerable(Of FilterSetting)

	Private Sub OnSaveButtonClick(sender As Object, e As RoutedEventArgs)
		Dim savedSettings As IEnumerable(Of FilterSetting) = SaveColumnFilters(Me.radGridView)

		' You can serialize the saved settings in any way that you like from here on.
		Me.serializedSettings = savedSettings
	End Sub

	Private Sub OnLoadButtonClick(sender As Object, e As RoutedEventArgs)
		' You should deserialize the settings from where you have serialized them.
		Dim savedSettings As IEnumerable(Of FilterSetting) = Me.serializedSettings

		LoadColumnFilters(Me.radGridView, savedSettings)
	End Sub
End Class
' #endregion

End Class
