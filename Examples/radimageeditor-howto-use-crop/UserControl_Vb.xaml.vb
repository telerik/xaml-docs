Public Class Default_Vb
Private Sub CreateToolInitialSize()
	#Region "radimageeditor-howto-use-crop_0"
	Dim cropTool As New CropTool()
	cropTool.InitialSize = New Size(150, 150)
	#End Region
End Sub
Private Sub CreateToolFixedSize()
	#Region "radimageeditor-howto-use-crop_1"
	Dim tool As New CropTool()
	tool.FixedSize = New Size(200, 100)
	#End Region
End Sub
Private Sub CreateToolAspectRatio()
	#Region "radimageeditor-howto-use-crop_2"
	Dim tool As New CropTool()
	tool.AspectRatio = 0.5
	#End Region
End Sub
End Class
