Public Class Default_Vb

    ' #region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_3
    Class MyFilteringControl
        Inherits FilteringControl
        Public Sub New(column As Telerik.Windows.Controls.GridViewColumn)

            MyBase.New(column)
        End Sub

        Protected Overrides Sub OnApplyFilter()
            MyBase.OnApplyFilter()

            Dim popup = Me.ParentOfType(Of System.Windows.Controls.Primitives.Popup)()
            If popup IsNot Nothing Then
                popup.IsOpen = False
            End If
        End Sub
    End Class
    ' #endregion
    ' #region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_4
   Me.clubsGrid.Columns("Name").FilteringControl = New MyFilteringControl(Me.clubsGrid.Columns("Name"))s
    ' #endregion
End Class
