Public Class Default_Vb


' #region radmap-features-information-layer-shape-reder_2
Me.informationLayer.Reader = New MapShapeReader()
' #endregion

' #region radmap-features-information-layer-shape-reder_5
Me.informationLayer.Reader.ToolTipFormat = "CNTRY_NAME";
' #endregion

' #region radmap-features-information-layer-shape-reder_8
Me.informationLayer.Reader.ToolTipFormat = "{SQKM|F2} sq.km.";
' #endregion

' #region radmap-features-information-layer-shape-reder_11
Me.informationLayer.Reader.ToolTipFormat = "{CNTRY_NAME} - {SQKM|F2} sq.km."
' #endregion
End Class
