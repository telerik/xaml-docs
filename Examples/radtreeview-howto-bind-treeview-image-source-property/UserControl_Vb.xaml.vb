Public Class Default_Vb


' #region radtreeview-howto-bind-treeview-image-source-property_1
Public Class Person
    Implements INotifyPropertyChanged
    Public Sub New()
    End Sub
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _Selected As Boolean
    Public Property Selected() As Boolean
        Get
            Return _Selected
        End Get
        Set(ByVal value As Boolean)
            _Selected = value
        End Set
    End Property
Private _ImagePath As String
    Public Property ImagePath() As String
        Get
            Return _ImagePath
        End Get
        Set(ByVal value As String)
            _ImagePath = value
        End Set
    End Property
    ' INotifyPropertyChanged implementation goes here
End Class
' #endregion
End Class
