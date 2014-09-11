' #region radpivotgrid-getting-started_1
Public Class Product
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property
    Private m_Name As String
    Public Property Quantity() As Integer
        Get
            Return m_Quantity
        End Get
        Set(value As Integer)
            m_Quantity = value
        End Set
    End Property
    Private m_Quantity As Integer
    Public Property Price() As Double
        Get
            Return m_Price
        End Get
        Set(value As Double)
            m_Price = value
        End Set
    End Property
    Private m_Price As Double
    Public Property [Date]() As DateTime
        Get
            Return m_Date
        End Get
        Set(value As DateTime)
            m_Date = value
        End Set
    End Property
    Private m_Date As DateTime
End Class
' #endregion

' #region radpivotgrid-getting-started_2
Private Shared Function GeneratePivotData() As IList(Of Product)
    Dim PivotData As IList(Of Product) = New List(Of Product)() From { _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
 .Price = 10.4, _
 .Quantity = 148 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
 .Price = 10.99, _
 .Quantity = 122 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
 .Price = 11.24, _
 .Quantity = 80 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
 .Price = 11.24, _
 .Quantity = 90 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
 .Price = 11.14, _
 .Quantity = 140 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
 .Price = 10.89, _
 .Quantity = 162 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
 .Price = 10.89, _
 .Quantity = 181 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
 .Price = 10.88, _
 .Quantity = 180 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
 .Price = 11.0, _
 .Quantity = 116 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
 .Price = 10.99, _
 .Quantity = 128 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
 .Price = 10.95, _
 .Quantity = 145 _
}, _
New Product() With { _
 .Name = "Pen", _
 .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
 .Price = 10.45, _
 .Quantity = 189 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
 .Price = 5.22, _
 .Quantity = 100 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
 .Price = 5.99, _
 .Quantity = 85 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
 .Price = 6.04, _
 .Quantity = 80 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
 .Price = 6.28, _
 .Quantity = 72 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
 .Price = 6.12, _
 .Quantity = 99 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
 .Price = 6.59, _
 .Quantity = 40 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
 .Price = 6.29, _
 .Quantity = 68 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
 .Price = 5.99, _
 .Quantity = 95 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
 .Price = 5.89, _
 .Quantity = 120 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
 .Price = 5.99, _
 .Quantity = 105 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
 .Price = 5.96, _
 .Quantity = 111 _
}, _
New Product() With { _
 .Name = "Pencil", _
 .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
 .Price = 5.99, _
 .Quantity = 108 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
 .Price = 22.86, _
 .Quantity = 88 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
 .Price = 23.02, _
 .Quantity = 95 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
 .Price = 23.22, _
 .Quantity = 102 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
 .Price = 21.99, _
 .Quantity = 95 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
 .Price = 22.45, _
 .Quantity = 84 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
 .Price = 22.56, _
 .Quantity = 96 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
 .Price = 22.88, _
 .Quantity = 88 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
 .Price = 22.42, _
 .Quantity = 99 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
 .Price = 22.56, _
 .Quantity = 111 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
 .Price = 22.18, _
 .Quantity = 102 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
 .Price = 22.93, _
 .Quantity = 105 _
}, _
New Product() With { _
 .Name = "Notebook", _
 .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
 .Price = 22.89, _
 .Quantity = 122 _
} _
}

    Return PivotData
End Function
' #endregion

' #region radpivotgrid-getting-started_3
InitializeComponent()
TryCast(Me.Resources("LocalDataProvider"), LocalDataSourceProvider).ItemsSource = GeneratePivotData()
' #endregion


' #region radpivotgrid-getting-started_4
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports Telerik.Pivot.Core

Public Class Product
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property
    Private m_Name As String
    Public Property Quantity() As Integer
        Get
            Return m_Quantity
        End Get
        Set(value As Integer)
            m_Quantity = value
        End Set
    End Property
    Private m_Quantity As Integer
    Public Property Price() As Double
        Get
            Return m_Price
        End Get
        Set(value As Double)
            m_Price = value
        End Set
    End Property
    Private m_Price As Double
    Public Property [Date]() As DateTime
        Get
            Return m_Date
        End Get
        Set(value As DateTime)
            m_Date = value
        End Set
    End Property
    Private m_Date As DateTime
End Class

Partial Public Class MainWindow
    Public Sub New()
        InitializeComponent()
        TryCast(Me.Resources("LocalDataProvider"), LocalDataSourceProvider).ItemsSource = GeneratePivotData()
    End Sub

    Private Shared Function GeneratePivotData() As IList(Of Product)
        Dim PivotData As IList(Of Product) = New List(Of Product)() From { _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
     .Price = 10.4, _
     .Quantity = 148 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
     .Price = 10.99, _
     .Quantity = 122 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
     .Price = 11.24, _
     .Quantity = 80 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
     .Price = 11.24, _
     .Quantity = 90 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
     .Price = 11.14, _
     .Quantity = 140 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
     .Price = 10.89, _
     .Quantity = 162 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
     .Price = 10.89, _
     .Quantity = 181 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
     .Price = 10.88, _
     .Quantity = 180 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
     .Price = 11.0, _
     .Quantity = 116 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
     .Price = 10.99, _
     .Quantity = 128 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
     .Price = 10.95, _
     .Quantity = 145 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
     .Price = 10.45, _
     .Quantity = 189 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
     .Price = 5.22, _
     .Quantity = 100 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 85 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
     .Price = 6.04, _
     .Quantity = 80 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
     .Price = 6.28, _
     .Quantity = 72 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
     .Price = 6.12, _
     .Quantity = 99 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
     .Price = 6.59, _
     .Quantity = 40 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
     .Price = 6.29, _
     .Quantity = 68 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 95 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
     .Price = 5.89, _
     .Quantity = 120 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 105 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
     .Price = 5.96, _
     .Quantity = 111 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 108 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
     .Price = 22.86, _
     .Quantity = 88 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
     .Price = 23.02, _
     .Quantity = 95 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
     .Price = 23.22, _
     .Quantity = 102 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
     .Price = 21.99, _
     .Quantity = 95 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
     .Price = 22.45, _
     .Quantity = 84 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
     .Price = 22.56, _
     .Quantity = 96 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
     .Price = 22.88, _
     .Quantity = 88 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
     .Price = 22.42, _
     .Quantity = 99 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
     .Price = 22.56, _
     .Quantity = 111 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
     .Price = 22.18, _
     .Quantity = 102 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
     .Price = 22.93, _
     .Quantity = 105 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
     .Price = 22.89, _
     .Quantity = 122 _
    } _
   }

        Return PivotData
    End Function
End Class
' #endregion

' #region radpivotgrid-getting-started_5
Imports System
Imports System.Collections.Generic
Imports System.Windows.Controls
Imports Telerik.Pivot.Core

Public Class Product
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property
    Private m_Name As String
    Public Property Quantity() As Integer
        Get
            Return m_Quantity
        End Get
        Set(value As Integer)
            m_Quantity = value
        End Set
    End Property
    Private m_Quantity As Integer
    Public Property Price() As Double
        Get
            Return m_Price
        End Get
        Set(value As Double)
            m_Price = value
        End Set
    End Property
    Private m_Price As Double
    Public Property [Date]() As DateTime
        Get
            Return m_Date
        End Get
        Set(value As DateTime)
            m_Date = value
        End Set
    End Property
    Private m_Date As DateTime
End Class

Partial Public Class MainPage
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
        TryCast(Me.Resources("LocalDataProvider"), LocalDataSourceProvider).ItemsSource = GeneratePivotData()
    End Sub

    Private Shared Function GeneratePivotData() As IList(Of Product)
        Dim PivotData As IList(Of Product) = New List(Of Product)() From { _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
     .Price = 10.4, _
     .Quantity = 148 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
     .Price = 10.99, _
     .Quantity = 122 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
     .Price = 11.24, _
     .Quantity = 80 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
     .Price = 11.24, _
     .Quantity = 90 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
     .Price = 11.14, _
     .Quantity = 140 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
     .Price = 10.89, _
     .Quantity = 162 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
     .Price = 10.89, _
     .Quantity = 181 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
     .Price = 10.88, _
     .Quantity = 180 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
     .Price = 11.0, _
     .Quantity = 116 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
     .Price = 10.99, _
     .Quantity = 128 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
     .Price = 10.95, _
     .Quantity = 145 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
     .Price = 10.45, _
     .Quantity = 189 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
     .Price = 5.22, _
     .Quantity = 100 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 85 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
     .Price = 6.04, _
     .Quantity = 80 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
     .Price = 6.28, _
     .Quantity = 72 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
     .Price = 6.12, _
     .Quantity = 99 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
     .Price = 6.59, _
     .Quantity = 40 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
     .Price = 6.29, _
     .Quantity = 68 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 95 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
     .Price = 5.89, _
     .Quantity = 120 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 105 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
     .Price = 5.96, _
     .Quantity = 111 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 108 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
     .Price = 22.86, _
     .Quantity = 88 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
     .Price = 23.02, _
     .Quantity = 95 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
     .Price = 23.22, _
     .Quantity = 102 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
     .Price = 21.99, _
     .Quantity = 95 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
     .Price = 22.45, _
     .Quantity = 84 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
     .Price = 22.56, _
     .Quantity = 96 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
     .Price = 22.88, _
     .Quantity = 88 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
     .Price = 22.42, _
     .Quantity = 99 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
     .Price = 22.56, _
     .Quantity = 111 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
     .Price = 22.18, _
     .Quantity = 102 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
     .Price = 22.93, _
     .Quantity = 105 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
     .Price = 22.89, _
     .Quantity = 122 _
    } _
   }

        Return PivotData
    End Function
End Class
' #endregion