Public Class Default_Vb


' #region gridview-managing-data-validation_3
Private Sub radGridView_CellValidating(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewCellValidatingEventArgs)
    If e.Cell.Column.UniqueName = "OrderNO" Then
        If e.NewValue.ToString().Length < 5 Then
            e.IsValid = False
            e.ErrorMessage = "OrderNO must be longer than five characters."
        End If
    End If
End Sub
' #endregion

' #region gridview-managing-data-validation_5
Public Class Order
    Private m_orderNo As String
    Public Property OrderNO() As String
        Get
            Return Me.m_orderNo
        End Get
        Set(ByVal value As String)
            If value.Length < 5 Then
                Throw New Exception("OrderNo should be longer than 5 characters.")
            End If
            Me.m_orderNo = value
        End Set
    End Property
End Class
' #endregion

' #region gridview-managing-data-validation_8
Private Sub radGridView_RowValidating(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewRowValidatingEventArgs)
    Dim order As Order = TryCast(e.Row.DataContext, Order)
    If [String].IsNullOrEmpty(order.OrderNO) OrElse order.OrderNO.Length < 5 Then
        Dim validationResult As New GridViewCellValidationResult()
        validationResult.PropertyName = "OrderNO"
        validationResult.ErrorMessage = "OrderNO is required and must be at least five characters"
        e.ValidationResults.Add(validationResult)
        e.IsValid = False
    End If
    If order.Total < 0 Then
        Dim validationResult As New GridViewCellValidationResult()
        validationResult.PropertyName = "Total"
        validationResult.ErrorMessage = "Total must be positive"
        e.ValidationResults.Add(validationResult)
        e.IsValid = False
    End If
End Sub
' #endregion

' #region gridview-managing-data-validation_10
<Required()> _
Public Property OrderNO() As String
    Get
        Return Me.orderNo
    End Get
    Set(ByVal value As String)
        Dim validationContext As New ValidationContext(Me, Nothing, Nothing)
        validationContext.MemberName = "OrderNO"
        Validator.ValidateProperty(value, validationContext)
        Me.orderNo = value
    End Set
End Property
' #endregion
End Class
