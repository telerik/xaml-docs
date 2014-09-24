Public Class Default_Vb


' #region raddataform-validation_1
Private Sub DataForm1_ValidatingItem(sender As Object, e As System.ComponentModel.CancelEventArgs) 
 Dim employer = TryCast(Me.DataForm1.CurrentItem, Employee)
 If employer.Salary < 1000 Then
  RadWindow.Alert("You have to raise " & Convert.ToString(employer.LastName) & " salary")
 End If
End Sub
' #endregion

' #region raddataform-validation_3
Public Property StartingDate() As DateTime
 Get
  Return Me.startingDate
 End Get
 Set
  If value <> Me.startingDate Then
   If value > DateTime.Now Then
    Throw New ValidationException("Starting date should not be earlier than 2011")
   Else
    Me.startingDate = value
    Me.OnPropertyChanged("StartingDate")
   End If
  End If
 End Set
End Property
' #endregion
End Class
