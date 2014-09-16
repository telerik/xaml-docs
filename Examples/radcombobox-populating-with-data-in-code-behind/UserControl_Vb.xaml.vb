Public Class Default_Vb


' #region radcombobox-populating-with-data-in-code-behind_2
Dim comboBoxItem As New RadComboBoxItem()
comboBoxItem.Content = "Alapattah"
Me.radComboBox.Items.Add(comboBoxItem)
comboBoxItem = New RadComboBoxItem()
comboBoxItem.Content = "Brickell Avenue"
Me.radComboBox.Items.Add(comboBoxItem)
' #endregion

' #region radcombobox-populating-with-data-in-code-behind_4
Private Sub RemoveComboBoxItem(ByVal itemToRemove As RadComboBoxItem)
    Me.radComboBox.Items.Remove(itemToRemove)
End Sub
' #endregion
End Class
