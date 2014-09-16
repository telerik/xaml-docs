Public Class Default_Vb


' #region radrichtextbox-features-import-export-settings_1
Public Sub ExportToHtml(ByVal document As RadDocument)
 Dim dialog As New SaveFileDialog()
 If dialog.ShowDialog() = True Then
  Using _stream As Stream = dialog.OpenFile()
   Dim provider As New HtmlFormatProvider()
   Dim settings As New HtmlExportSettings()
   settings.ImageExporting += settings_ImageExporting
   settings.InlineUIContainerExporting += settings_InlineUIContainerExporting
   settings.DocumentExportLevel = DocumentExportLevel.Fragment
   settings.StylesExportMode = StylesExportMode.Inline
   settings.ImageExportMode = ImageExportMode.UriSource
   provider.ExportSettings = settings
   provider.Export(document, _stream)
  End Using
 End If
End Sub
    ' #endregion

    ' #region radrichtextbox-features-import-export-settings_2
    Public Sub SetupDefaultHtmlFormatProvider()
        Dim htmlFormatProvider As DocumentFormatProvidersManager.GetProviderByExtension("html")
        Dim htmlExportSettings As New HtmlExportSettings()
        htmlExportSettings.DocumentExportLevel = DocumentExportLevel.Fragment
        htmlExportSettings.StylesExportMode = StylesExportMode.Inline
        htmlExportSettings.StyleRepositoryExportMode = StyleRepositoryExportMode.DontExportStyles
        htmlExportSettings.ExportFontStylesAsTags = True

        htmlFormatProvider.ExportSettings = htmlExportSettings
    End Sub
    ' #endregion


End Class
