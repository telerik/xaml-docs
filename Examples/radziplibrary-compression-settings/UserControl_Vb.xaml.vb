Imports System.IO
Imports Telerik.Windows.Zip

Namespace RadZipLibraryDocumentationSourceCode.Examples.CompressionSettings
	Public Class UserControl_Cs
		Private Sub DeflateSettings()
'			#Region "radziplibrary-compression-settings_0"
			Dim compressionSettings As New DeflateSettings()
			compressionSettings.CompressionLevel = CompressionLevel.Best
			compressionSettings.HeaderType = CompressedStreamHeader.ZLib
'			#End Region
		End Sub

		Private Sub LzmaSettings()
'			#Region "radziplibrary-compression-settings_1"
			Dim compressionSettings As New LzmaSettings()
			compressionSettings.DictionarySize = 23
			compressionSettings.FastBytes = 32
			compressionSettings.LiteralContextBits = 3
			compressionSettings.LiteralPositionBits = 3
			compressionSettings.MatchFinderType = LzmaMatchFinderType.BT4
			compressionSettings.PositionStateBits = 2
'			#End Region
		End Sub

		Public Sub StoreSettings()
'			#Region "radziplibrary-compression-settings_2"
			Dim compressionSettings As New StoreSettings()
'			#End Region
		End Sub
	End Class
End Namespace