Public Class Default_Vb

    ' #region radpropertygrid-defining-propertysets_3
    Public Class Ellipse
        Public Property FillColor() As Color
            Get
                Return m_FillColor
            End Get
            Set(value As Color)
                m_FillColor = Value
            End Set
        End Property
        Private m_FillColor As Color
        Public Property RadiusX1() As Double
            Get
                Return m_RadiusX1
            End Get
            Set(value As Double)
                m_RadiusX1 = Value
            End Set
        End Property
        Private m_RadiusX1 As Double
        Public Property RadiusX2() As Double
            Get
                Return m_RadiusX2
            End Get
            Set(value As Double)
                m_RadiusX2 = Value
            End Set
        End Property
        Private m_RadiusX2 As Double
        Public Property Center() As Point
            Get
                Return m_Center
            End Get
            Set(value As Point)
                m_Center = Value
            End Set
        End Property
        Private m_Center As Point
    End Class

    Public Class RegularPolygon
        Public Property CornersCount() As Integer
            Get
                Return m_CornersCount
            End Get
            Set(value As Integer)
                m_CornersCount = Value
            End Set
        End Property
        Private m_CornersCount As Integer
        Public Property FillColor() As Color
            Get
                Return m_FillColor
            End Get
            Set(value As Color)
                m_FillColor = Value
            End Set
        End Property
        Private m_FillColor As Color
        Public Property Center() As Point
            Get
                Return m_Center
            End Get
            Set(value As Point)
                m_Center = Value
            End Set
        End Property
        Private m_Center As Point
        Public Property SideLength() As Double
            Get
                Return m_SideLength
            End Get
            Set(value As Double)
                m_SideLength = Value
            End Set
        End Property
        Private m_SideLength As Double
    End Class

    Public Class ViewModel
        Public ReadOnly Property Shapes() As IEnumerable(Of Object)
            Get
			Return New List(Of Object)() With { _
				New Ellipse() With { _
					.Center = New Point(1, 1), _
					.FillColor = Colors.Red, _
					.RadiusX1 = 4, _
					.RadiusX2 = 2 _
				}, _
				New RegularPolygon() With { _
					.Center = New Point(3, 2), _
					.FillColor = Colors.Blue, _
					.CornersCount = 3, _
					.SideLength = 10 _
				} _
			}
            End Get
        End Property
    End Class
    ' #endregion

    ' #region radpropertygrid-defining-propertysets_5
    Private Sub RadPropertyGrid_AutoGeneratingPropertyDefinition(sender As Object, e As Telerik.Windows.Controls.Data.PropertyGrid.AutoGeneratingPropertyDefinitionEventArgs)
        If e.PropertyDefinition.DisplayName = "CornersCount" Then
            e.PropertyDefinition.EditorTemplate = TryCast(LayoutRoot.Resources("editorTemplate"), DataTemplate)
        End If
    End Sub


    Public Class MyConverter
        Implements IValueConverter

        Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
            Return Int32.Parse(value.ToString())
        End Function

        Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
            Return value
        End Function
    End Class

    ' #endregion

End Class
