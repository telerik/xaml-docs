Public Class Default_Vb


' #region gridview-cell-template-selector_1
    Public Class MyCellTemplateSelector
        Inherits DataTemplateSelector
        Public Overrides Function SelectTemplate(item As Object, container As System.Windows.DependencyObject) As System.Windows.DataTemplate
            If TypeOf item Is Club Then
                Dim club As Club = TryCast(item, Club)
                If club.StadiumCapacity > 50000 Then
                    Return bigStadium
                Else
                    Return smallStadium
                End If
            End If
            Return Nothing
        End Function
        Public Property bigStadium() As DataTemplate
            Get
                Return m_bigStadium
            End Get
            Set(value As DataTemplate)
                m_bigStadium = Value
            End Set
        End Property
        Private m_bigStadium As DataTemplate
        Public Property smallStadium() As DataTemplate
            Get
                Return m_smallStadium
            End Get
            Set(value As DataTemplate)
                m_smallStadium = Value
            End Set
        End Property
        Private m_smallStadium As DataTemplate
    End Class
' #endregion
End Class
