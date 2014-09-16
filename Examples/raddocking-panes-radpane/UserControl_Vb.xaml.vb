Public Class Default_Vb


' #region raddocking-panes-radpane_2
Dim radPane1 As New RadPane()
radPane1.Header = "Document 1"
Dim textBlock As New TextBlock()
textBlock.Text = "Some simple text here"
radPane1.Content = textBlock
Dim radPane2 As New RadPane()
radPane2.Header = "Document 2"
textBlock = New TextBlock()
textBlock.Text = "Some simple text here"
radPane2.Content = textBlock
radPaneGroup.Items.Add(radPane1)
radPaneGroup.Items.Add(radPane2)
' #endregion

' #region raddocking-panes-radpane_5
radPane.IsHidden = true
' #endregion
End Class
