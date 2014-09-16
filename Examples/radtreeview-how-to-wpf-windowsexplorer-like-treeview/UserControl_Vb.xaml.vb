Public Class Default_Vb


' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_2
Public Class File
    Public Sub New(ByVal fullPath As String, ByVal name As String)
        Me.FullPath = fullPath
        Me.Name = name
    End Sub
Private _FullPath As String
    Public Property FullPath() As String
        Get
            Return _FullPath
        End Get
        Set(ByVal value As String)
            _FullPath = value
        End Set
    End Property
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_4
Public Class Directory
    Public Sub New(ByVal fullPath As String, ByVal name As String)
        Me.FullPath = fullPath
        Me.Name = name
        Me.Childs = New ObservableCollection(Of Object)()
    End Sub
Private _FullPath As String
    Public Property FullPath() As String
        Get
            Return _FullPath
        End Get
        Set(ByVal value As String)
            _FullPath = value
        End Set
    End Property
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
		Private _Children As ObservableCollection(Of Object)
		Public Property Children() As ObservableCollection(Of Object)
			Get
				Return _Children
			End Get
			Set(ByVal value As ObservableCollection(Of Object))
				_Children = value
			End Set
		End Property
End Class
' #endregion

' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_6
Public Class Drive
    Public Sub New(ByVal name As String, ByVal isReady As Boolean)
        Me.Name = name
        Me.IsReady = isReady
			Me.Children = New ObservableCollection(Of Object)()
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
Private _IsReady As Boolean
    Public Property IsReady() As Boolean
        Get
            Return _IsReady
        End Get
        Set(ByVal value As Boolean)
            _IsReady = value
        End Set
    End Property
		Private _Children As ObservableCollection(Of Object)
		Public Property Children() As ObservableCollection(Of Object)
			Get
				Return _Children
			End Get
			Set(ByVal value As ObservableCollection(Of Object))
				_Children = value
			End Set
		End Property
End Class
' #endregion

' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_8
Public NotInheritable Class ServiceFacade
    Private Shared m_instance As ServiceFacade
    Public Shared ReadOnly Property Instance() As ServiceFacade
        Get
            If m_instance Is Nothing Then
                m_instance = New ServiceFacade()
                m_instance.Initialize()
            End If
            Return m_instance
        End Get
    End Property
Private _Drives As ObservableCollection(Of Drive)
    Public Property Drives() As ObservableCollection(Of Drive)
        Get
            Return _Drives
        End Get
        Set(ByVal value As ObservableCollection(Of Drive))
            _Drives = value
        End Set
    End Property
    Private Sub Initialize()
    End Sub
End Class
' #endregion

' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_10
Private Sub Initialize()
    Me.Drives = New ObservableCollection(Of Drive)()
    For Each driveInfo As DriveInfo In System.IO.DriveInfo.GetDrives()
        Me.Drives.Add(New Drive(driveInfo.Name, driveInfo.IsReady))
    Next
End Sub
' #endregion

' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_14
Public Class ItemStyleSelector
    Inherits StyleSelector
    Public Overloads Overrides Function SelectStyle(ByVal item As Object, ByVal container As System.Windows.DependencyObject) As System.Windows.Style
        If TypeOf item Is Drive Then
            Return Me.DriveStyle
        ElseIf TypeOf item Is Directory Then
            Return Me.DirectoryStyle
        ElseIf TypeOf item Is File Then
            Return Me.FileStyle
        End If
        Return MyBase.SelectStyle(item, container)
    End Function
Private _DirectoryStyle As Style
    Public Property DirectoryStyle() As Style
        Get
            Return _DirectoryStyle
        End Get
        Set(ByVal value As Style)
            _DirectoryStyle = value
        End Set
    End Property
Private _FileStyle As Style
    Public Property FileStyle() As Style
        Get
            Return _FileStyle
        End Get
        Set(ByVal value As Style)
            _FileStyle = value
        End Set
    End Property
Private _DriveStyle As Style
    Public Property DriveStyle() As Style
        Get
            Return _DriveStyle
        End Get
        Set(ByVal value As Style)
            _DriveStyle = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_17
	Private Sub RadTreeView_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
	End Sub

	Private Sub RadTreeView_ItemPrepared(sender As Object, e As RadTreeViewItemPreparedEventArgs)
	End Sub
' #endregion

' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_20
	Private Sub RadTreeView_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    e.Handled = true;
		Dim expandedItem As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
		If expandedItem Is Nothing Then
			Exit Sub
		End If
		Dim drive As Drive = TryCast(expandedItem.Item, Drive)
		If drive IsNot Nothing Then
			ServiceFacade.Instance.LoadChildren(drive)
			Exit Sub
		End If
		Dim directory As Directory = TryCast(expandedItem.Item, Directory)
		If directory IsNot Nothing Then
			ServiceFacade.Instance.LoadChildren(directory)
		End If
	End Sub
' #endregion

' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_22
	Public Sub LoadChildren(ByVal d As Drive)
		For Each directory As String In System.IO.Directory.GetDirectories(d.Name)
			Dim directoryInfo As New DirectoryInfo(directory)
			d.Children.Add(New Directory(directory, directoryInfo.Name))
		Next
		For Each file As String In System.IO.Directory.GetFiles(d.Name)
			Dim fileInfo As New FileInfo(file)
			d.Children.Add(New File(file, fileInfo.Name))
		Next
	End Sub
	Public Sub LoadChildren(ByVal d As Directory)
		For Each directory As String In System.IO.Directory.GetDirectories(d.FullPath)
			Dim directoryInfo As New DirectoryInfo(directory)
			d.Children.Add(New Directory(directory, directoryInfo.Name))
		Next
		For Each file As String In System.IO.Directory.GetFiles(d.FullPath)
			Dim fileInfo As New FileInfo(file)
			d.Children.Add(New File(file, fileInfo.Name))
		Next
	End Sub
	' #endregion
	' #region radtreeview-how-to-wpf-windowsexplorer-like-treeview_23
	Private Sub RadTreeView_ItemPrepared(sender As Object, e As RadTreeViewItemPreparedEventArgs)
		If TypeOf e.PreparedItem.DataContext Is File Then
			e.PreparedItem.IsLoadOnDemandEnabled = False
		End If
	End Sub
	' #endregion
End Class
