Public Class Default_Vb


' #region radrichtextbox-features-spellcheck_1
Private Sub LoadDictionary(ByVal tdfFileStream As Stream)
 Dim dictionary As New RadDictionary()
 dictionary.Load(tdfFileStream)
 CType(Me.radRichTextBox.SpellChecker, DocumentSpellChecker).AddDictionary(dictionary, CultureInfo.InvariantCulture)
End Sub
' #endregion

' #region radrichtextbox-features-spellcheck_3
Private Sub CreateCustomDictionary()
 Dim dictionary As New RadIsolatedStorageCustomDictionary(IsolatedStorageScope.Site, "CustomDictionary.txt")
 Dim spellchecker As New DocumentSpellChecker(dictionary)
 Me.radRichTextBox.SpellChecker = spellchecker
End Sub
' #endregion

' #region radrichtextbox-features-spellcheck_5
Me.radRichTextBox.SpellChecker.AddWord("RadRichTextBox", CultureInfo.InvariantCulture)
' #endregion

' #region radrichtextbox-features-spellcheck_7
Private Sub LoadDictionary(ByVal tdfFileStream As Stream)
 Dim dictionary As New RadDictionary()
 dictionary.Load(tdfFileStream)
 CType(Me.radRichTextBox.SpellChecker, DocumentSpellChecker).AddDictionary(dictionary, New CultureInfo("de-DE"); }
' #endregion
End Class
