Public Class Default_Vb


' #region radslider-tick-templateselector_3
Public Class TickTemplateSelector
       Inherits DataTemplateSelector
End Class
' #endregion

' #region radslider-tick-templateselector_5
Public Class TickTemplateSelector
       Inherits DataTemplateSelector
       Public EllipseTempl As DataTemplate
       Public Property EllipseTemplate() As DataTemplate
              Get
                 Return EllipseTempl
              End Get
              Set(ByVal value As DataTemplate)
                 EllipseTempl = value
              End Set
       End Property
       Public EmptyTempl As DataTemplate
       Public Property EmptyTemplate() As DataTemplate
              Get
                 Return EmptyTempl
              End Get
              Set(ByVal value As DataTemplate)
                 EmptyTempl = value
              End Set
       End Property
       Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
              Dim tick As Double = Convert.ToDouble(item)
              If tick Mod 4 = 0 Then
                 Return EllipseTempl
              Else
                 Return EmptyTempl
              End If
       End Function
End Class
' #endregion
End Class
