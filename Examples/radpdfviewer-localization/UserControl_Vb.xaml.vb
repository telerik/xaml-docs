Public Class Default_Vb
    '#Region radpdfviewer-command-descriptors_0
    Public Class FitToWidthCommand
        Inherits FixedDocumentViewerCommandBase
        Private Const PageMargin As Double = 20

        Public Sub New(fixedDocumentViewerBase As FixedDocumentViewerBase)
            MyBase.New(fixedDocumentViewerBase)
        End Sub

        Public Overrides Sub Execute(parameter As Object)
            Dim width As Double = Me.Viewer.ActualWidth - 2 * PageMargin
            Dim pageWidth As Double = Me.Viewer.CurrentPage.ActualWidth
            Me.Viewer.ScaleFactor = width / pageWidth
        End Sub
    End Class
    '#EndRegion

    '#Region radpdfviewer-command-descriptors_1
    Public Class FitToWidthCommand
        Inherits FixedDocumentViewerCommandBase
        Private Const PageMargin As Double = 20

        Public Sub New(fixedDocumentViewerBase As FixedDocumentViewerBase)
            MyBase.New(fixedDocumentViewerBase)
        End Sub

        Public Overrides Sub Execute(parameter As Object)
            Dim width As Double = Me.Viewer.ActualWidth - 2 * PageMargin
            Dim pageWidth As Double = Me.Viewer.CurrentPage.ActualWidth
            Me.Viewer.ScaleFactor = width / pageWidth
        End Sub
    End Class
    '#EndRegion

    '#Region radpdfviewer-command-descriptors_2
    Me.customCommandDescriptors = New CustomCommandDescriptors(Me.viewer)
    '#EndRegion
End Class
