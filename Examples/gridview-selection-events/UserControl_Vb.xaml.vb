Public Class Default_Vb


' #region gridview-selection-events_1
Public Sub New()
 InitializeComponent()
 AddHandler Me.radGridView.SelectionChanging, AddressOf Me.SelectionChanging
End Sub
Private Sub SelectionChanging(sender As Object, e As SelectionChangingEventArgs)
End Sub
' #endregion

' #region gridview-selection-events_3
Public Sub New()
    InitializeComponent()
    AddHandler Me.radGridView.SelectionChanged, AddressOf Me.SelectionChanged
End Sub
Private Sub SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangeEventArgs)
End Sub
' #endregion

' #region gridview-selection-events_5
Public Sub New()
    InitializeComponent()
    AddHandler Me.radGridView.CurrentCellChanged, AddressOf Me.CurrentCellChanged
End Sub
Private Sub CurrentCellChanged(ByVal sender As Object, ByVal e As GridViewCurrentCellChangedEventArgs)
End Sub
' #endregion

' #region gridview-selection-events_7
Public Sub New()
 InitializeComponent()
 AddHandler Me.radGridView.SelectedCellsChanging, AddressOf Me.SelectedCellsChanging
End Sub
Private Sub SelectedCellsChanging(sender As Object, e As GridViewSelectedCellsChangingEventArgse 
End Sub
' #endregion

' #region gridview-selection-events_9
Public Sub New()
 InitializeComponent()
 AddHandler Me.gridView.SelectedCellsChanged, AddressOf gridView_SelectedCellsChanged
End Sub 
Private Sub gridView_SelectedCellsChanged(sender As Object, e As GridViewSelectedCellsChangedEventArgs)
End Sub
' #endregion
End Class
