' #region radtreeview-how-to-tri-state-0 
Imports System.Collections.ObjectModel
Imports Telerik.Windows.Controls

Namespace TreeViewMVVMCheckBoxSample.ViewModels
	Public Class CategoryViewModel
		Inherits ViewModelBase
		Private _name As String
		Private _isChecked As Boolean?

		Private _subCategories As ObservableCollection(Of CategoryViewModel) = Nothing

		Public Property Name() As String
			Get
				Return Me._name
			End Get
			Set(ByVal value As String)
				Me._name = value
			End Set
		End Property
		Public Property IsChecked() As Boolean?
			Get
				Return Me._isChecked
			End Get
			Set(ByVal value As Boolean?)
				If Not Me._isChecked.Equals(value) Then
					Me._isChecked = value
					OnPropertyChanged("IsChecked")
				End If
			End Set
		End Property

		Public ReadOnly Property SubCategories() As ObservableCollection(Of CategoryViewModel)
			Get
				If Me._subCategories Is Nothing Then
					Me._subCategories = New ObservableCollection(Of CategoryViewModel)()
				End If
				Return Me._subCategories
			End Get
		End Property
	End Class
End Namespace
' #endregion
' #region radtreeview-how-to-tri-state-1 
Public Property IsChecked() As Boolean?
	Get
		Return Me._isChecked
	End Get
	Set(ByVal value As Boolean?)
		If Not Me._isChecked.Equals(value) Then
			Me._isChecked = value
			Me.UpdateCheckState()
			OnPropertyChanged("IsChecked")
		End If
	End Set
End Property
Private Sub UpdateCheckState()
	' update all children:
	If Me.SubCategories.Count <> 0 Then
		Me.UpdateChildrenCheckState()
	End If
	'update parent item
	If Me.parentItem IsNot Nothing Then
		Dim parentIsChecked? As Boolean = Me.parentItem.DetermineCheckState()
		Me.parentItem.IsChecked = parentIsChecked

	End If
End Sub
' #endregion
' #region radtreeview-how-to-tri-state-2
Private reentrancyCheck As Boolean = False
Public Property IsChecked() As Boolean?
	Get
		Return Me._isChecked
	End Get
	Set(ByVal value As Boolean?)
		If Not Me._isChecked.Equals(value) Then
			If reentrancyCheck Then
				Return
			End If
			Me.reentrancyCheck = True
			Me._isChecked = value
			Me.UpdateCheckState()
			OnPropertyChanged("IsChecked")
			Me.reentrancyCheck = False
		End If
	End Set
End Property
' #endregion
' #region radtreeview-how-to-tri-state-3
Imports System.Collections.ObjectModel
Imports Telerik.Windows.Controls

Namespace TreeViewMVVMCheckBoxSample.ViewModels
	Public Class CategoryViewModel
		Inherits ViewModelBase
		Private _name As String
		Private _isChecked As Boolean?
		Private reentrancyCheck As Boolean = False
		Private parentItem As CategoryViewModel

		Private _subCategories As ObservableCollection(Of CategoryViewModel) = Nothing

		Public Property Name() As String
			Get
				Return Me._name
			End Get
			Set(ByVal value As String)
				Me._name = value
			End Set
		End Property
		Public Property IsChecked() As Boolean?
			Get
				Return Me._isChecked
			End Get
			Set(ByVal value As Boolean?)
				If Not Me._isChecked.Equals(value) Then
					If reentrancyCheck Then
						Return
					End If
					Me.reentrancyCheck = True
					Me._isChecked = value
					Me.UpdateCheckState()
					OnPropertyChanged("IsChecked")
					Me.reentrancyCheck = False
				End If
			End Set
		End Property

		Public ReadOnly Property SubCategories() As ObservableCollection(Of CategoryViewModel)
			Get
				If Me._subCategories Is Nothing Then
					Me._subCategories = New ObservableCollection(Of CategoryViewModel)()
				End If
				Return Me._subCategories
			End Get
		End Property

		Public Sub New(ByVal parent As CategoryViewModel)
			Me.parentItem = parent
		End Sub

		Private Sub UpdateCheckState()
			' update all children:
			If Me.SubCategories.Count <> 0 Then
				Me.UpdateChildrenCheckState()
			End If
			'update parent item
			If Me.parentItem IsNot Nothing Then
				Dim parentIsChecked? As Boolean = Me.parentItem.DetermineCheckState()
				Me.parentItem.IsChecked = parentIsChecked

			End If
		End Sub

		Private Sub UpdateChildrenCheckState()
			For Each item In Me.SubCategories
				If Me.IsChecked IsNot Nothing Then
					item.IsChecked = Me.IsChecked
				End If
			Next item
		End Sub

		Private Function DetermineCheckState() As Boolean?
			Dim allChildrenChecked As Boolean = Me.SubCategories.LongCount(Function(x) x.IsChecked.Equals(True)) = Me.SubCategories.Count
			If allChildrenChecked Then
				Return True
			End If

			Dim allChildrenUnchecked As Boolean = Me.SubCategories.LongCount(Function(x) x.IsChecked.Equals(False)) = Me.SubCategories.Count
			If allChildrenUnchecked Then
				Return False
			End If

			Return Nothing
		End Function
	End Class
End Namespace
' #endregion
' #region radtreeview-how-to-tri-state-4
Imports System.Collections.ObjectModel

Namespace TreeViewMVVMCheckBoxSample.ViewModels
	Public Class MainViewModel
		Public Property Categories() As ObservableCollection(Of CategoryViewModel)

		Public Sub New()
			Categories = New ObservableCollection(Of CategoryViewModel)()

			Dim beverages As New CategoryViewModel(Nothing)
			beverages.Name = "Bevereges"

			For i As Integer = 0 To 4
				Dim prod As New CategoryViewModel(beverages) With {.Name = String.Format("Beverage {0}", i), .IsChecked = False}

				For j As Integer = 0 To 2
					prod.SubCategories.Add(New CategoryViewModel(prod) With {.Name = String.Format("SubBeverage {0}.{1}", i, j), .IsChecked = False})
				Next j
				beverages.SubCategories.Add(prod)
			Next i
			Categories.Add(beverages)


			Dim confections As New CategoryViewModel(Nothing)
			confections.Name = "Confections"
			For i As Integer = 0 To 6
				confections.SubCategories.Add(New CategoryViewModel(confections) With {.Name = String.Format("Confection {0}", i), .IsChecked = False})
			Next i
			Categories.Add(confections)

			Dim condiments As New CategoryViewModel(Nothing)
			condiments.Name = "Condiments"
			For i As Integer = 0 To 2
				condiments.SubCategories.Add(New CategoryViewModel(condiments) With {.Name = String.Format("Condiment {0}", i), .IsChecked = False})
			Next i
			Categories.Add(condiments)

		End Sub
	End Class
End Namespace
' #endregion
