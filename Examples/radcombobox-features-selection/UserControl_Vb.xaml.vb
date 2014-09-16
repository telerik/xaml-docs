Public Class Default_Vb


' #region radcombobox-features-selection_1
Dim selectedItem As RadComboBoxItem = TryCast(radComboBox.SelectedItem, RadComboBoxItem)
' #endregion

' #region radcombobox-features-selection_3
Dim agency As Agency = TryCast(radComboBox.SelectedItem, Agency)
' #endregion

' #region radcombobox-features-selection_5
Public Class Agency2
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _Phone As String
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property
End Class
' #endregion

' #region radcombobox-features-selection_9
Dim text As String = radComboBox.Text
' #endregion
End Class
