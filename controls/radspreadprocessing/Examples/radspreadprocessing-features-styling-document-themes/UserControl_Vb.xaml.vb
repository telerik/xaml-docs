Public Class Default_Vb

    Public Sub Demo()
        '#Region radspreadsheet-model-features-styling-document-themes_0
        
        Dim colorScheme As New ThemeColorScheme("Mine", Colors.Black, _
                                                        Colors.Blue, _
                                                        Colors.Brown, _
                                                        Colors.Cyan, _
                                                        Colors.DarkGray, _
                                                        Colors.Gray, _
                                                        Colors.Green, _
                                                        Colors.LightGray, _
                                                        Colors.Magenta, _
                                                        Colors.Orange, _
                                                        Colors.Purple, _
                                                        Colors.Red)
        '#End Region

        '#Region radspreadsheet-model-features-styling-document-themes_1
        Dim themableColor As New ThemableColor(ThemeColorType.Accent1)
        '#End Region

        '#Region radspreadsheet-model-features-styling-document-themes_2
        ' latinMajor
        Dim fontScheme As New ThemeFontScheme("Mine", "Times New Roman", "Arial")
        ' latinMinor
        '#End Region

        '#Region radspreadsheet-model-features-styling-document-themes_3
        Dim themableFont As New ThemableFontFamily(ThemeFontType.Major)
        '#End Region

        '#Region radspreadsheet-model-features-styling-document-themes_4
        Dim theme As New DocumentTheme("Mine", colorScheme, fontScheme)
        '#End Region

        '#Region radspreadsheet-model-features-styling-document-themes_5
        Dim theme1 As New DocumentTheme("From Predefined schemes", PredefinedThemeSchemes.ColorSchemes(0), PredefinedThemeSchemes.FontSchemes(5))
        '#End Region

        '#Region  '#Region radspreadsheet-model-features-styling-document-themes_6
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()
        workbook.Theme = theme
        '#End Region

        '#Region radspreadsheet-model-features-styling-document-themes_7
        Dim actualColor As Color = themableColor.GetActualValue(theme)
        ' the actual color is the same as Accent1 color of the colorScheme
        '#End Region

        '#Region radspreadsheet-model-features-styling-document-themes_8
        Dim actualFont = themableFont.GetActualValue(theme)
        ' the actualFont is the same as the Major font of the fontScheme
        '#End Region

    End Sub

End Class
