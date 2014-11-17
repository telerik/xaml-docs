Public Class Default_Vb


' #region radscheduleview-styles-and-templates-styling-timeruleritems_5
Public Class CustomTimeRulerItemStyleSelector
 Inherits OrientedTimeRulerItemStyleSelector
 Public Property MinorTickLineStyle() As Style
  Get
   Return m_MinorTickLineStyle
  End Get
  Set
   m_MinorTickLineStyle = Value
  End Set
 End Property
 Private m_MinorTickLineStyle As Style
 Public Property MajorTickLineStyle() As Style
  Get
   Return m_MajorTickLineStyle
  End Get
  Set
   m_MajorTickLineStyle = Value
  End Set
 End Property
 Private m_MajorTickLineStyle As Style
 Public Overrides Function SelectStyle(item As Object, container As DependencyObject, activeViewDeifinition As ViewDefinitionBase) As Style
  If TypeOf container Is TimeRulerLine Then
   Dim tick As TickData = TryCast(item, TickData)
   If tick.Type = TickType.Major Then
    Return MajorTickLineStyle
   End If
   Return MinorTickLineStyle
  End If
  Return MyBase.SelectStyle(item, container, activeViewDeifinition)
 End Function
End Class
' #endregion
End Class
