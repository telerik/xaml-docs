Public Class Default_Vb


' #region radtreemap-populating-with-data-radpivotmap_1
Private _category As String
    Public Property Category() As String
        Get
            Return _Category
        End Get
        Set(ByVal value As String)
            _Category = value
        End Set
    End Property
Private _Value As Integer
    Public Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            _Value = value
        End Set
    End Property
Private _Subcategory As String
    Public Property Subcategory() As String
        Get
            Return _subcategory
        End Get
        Set(ByVal value As String)
            _Subcategory = value
        End Set
    End Property
' #endregion
End Class
