Public Class UserControl_Vb


' #region radchart-axes-axis_2
Public Class BinaryTemplateSelector
    Inherits DataTemplateSelector
    Private _template1 As DataTemplate
    Private _template2 As DataTemplate
    Public Property Template1 As DataTemplate
        Get
            Return Me._template1
        End Get
        Set(value As DataTemplate)
            Me._template1 = value
        End Set
    End Property
    Public Property Template2 As DataTemplate
        Get
            Return Me._template2
        End Get
        Set(value As DataTemplate)
            Me._template2 = value
        End Set
    End Property
    Public Overrides Function SelectTemplate(item As Object, container As System.Windows.DependencyObject) As System.Windows.DataTemplate
        Dim tmp As DataTemplate
        tmp = Me.Template1
        Me.Template1 = Me.Template2
        Me.Template2 = tmp
        Return tmp
    End Function
End Class
' #endregion
End Class
