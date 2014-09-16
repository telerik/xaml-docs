
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace RadOutlookBarDataBinding
    Partial Public Class MainWindow
        Inherits Window
#Region "radoutlookbar-databinding-0"
        Public Sub New()
            InitializeComponent()
            Me.radOutlookBar.DataContext = New MailMenuViewModel()
        End Sub
#End Region
    End Class

#Region "radoutlookbar-databinding-1"

    Public Class MailMenuViewModel
        Inherits ViewModelBase
        Public Property MenuItems() As ObservableCollection(Of MenuItem)
            Get
                Return m_MenuItems
            End Get
            Set(value As ObservableCollection(Of MenuItem))
                m_MenuItems = Value
            End Set
        End Property
        Private m_MenuItems As ObservableCollection(Of MenuItem)

        Private m_selectedItem As MenuItem
        Public Property SelectedItem() As MenuItem
            Get
                Return Me.m_selectedItem
            End Get
            Set(value As MenuItem)
                If Me.m_selectedItem <> value Then
                    Me.m_selectedItem = value
                    Me.OnPropertyChanged("SelectedItem")
                End If
            End Set
        End Property

        Public Sub New()
            Me.MenuItems = New ObservableCollection(Of MenuItem)()
		Me.MenuItems.Add(New MenuItem() With { _
			Key .Content = "Mails content", _
			Key .Header = "Mail", _
			Key .ImageSourcePath = "/images/mailBig.png" _
		})
		Me.MenuItems.Add(New MenuItem() With { _
			Key .Content = "Contacts content", _
			Key .Header = "Contacts", _
			Key .ImageSourcePath = "/images/contactsBig.png" _
		})
		Me.MenuItems.Add(New MenuItem() With { _
			Key .Content = "Calendar content", _
			Key .Header = "Calendar", _
			Key .ImageSourcePath = "/images/calendarBig.png" _
		})

            Me.m_selectedItem = Me.MenuItems(0)
        End Sub
    End Class
#End Region

#Region "radoutlookbar-databinding-2"

    Public Class MenuItem
        Public Property Header() As String
            Get
                Return m_Header
            End Get
            Set(value As String)
                m_Header = Value
            End Set
        End Property
        Private m_Header As String
        Public Property Content() As String
            Get
                Return m_Content
            End Get
            Set(value As String)
                m_Content = Value
            End Set
        End Property
        Private m_Content As String
        Public Property ImageSourcePath() As String
            Get
                Return m_ImageSourcePath
            End Get
            Set(value As String)
                m_ImageSourcePath = Value
            End Set
        End Property
        Private m_ImageSourcePath As String
    End Class
#End Region
End Namespace