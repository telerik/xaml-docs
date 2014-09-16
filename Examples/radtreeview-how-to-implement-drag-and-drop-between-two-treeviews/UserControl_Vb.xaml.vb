' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-0
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-1
Public Class MainViewModel
    Public Sub New()
        Me.LocalMachinePartitions = New ObservableCollection(Of PartitionViewModel)()
        Me.Applications = New ObservableCollection(Of ApplicationViewModel)()
        Me.GenetareSampleData()
    End Sub

    Public Property LocalMachinePartitions() As ObservableCollection(Of PartitionViewModel)
        Get
            Return m_LocalMachinePartitions
        End Get
        Set(value As ObservableCollection(Of PartitionViewModel))
            m_LocalMachinePartitions = Value
        End Set
    End Property
    Private m_LocalMachinePartitions As ObservableCollection(Of PartitionViewModel)

    Public Property Applications() As ObservableCollection(Of ApplicationViewModel)
        Get
            Return m_Applications
        End Get
        Set(value As ObservableCollection(Of ApplicationViewModel))
            m_Applications = Value
        End Set
    End Property
    Private m_Applications As ObservableCollection(Of ApplicationViewModel)

    Private Sub GenetareSampleData()
        Dim defaultImagePath As String = "Images/MediaFiles/{0}"
        Dim firstPartishionFiles As New ObservableCollection(Of MediaFile)()
        firstPartishionFiles.Add(New MediaFile() With { _
            .ImageTitle = "1PersonalFolders.png", _
            .ImageFilePath = String.Format(defaultImagePath, "Images/1PersonalFolders.png") _
        })
        firstPartishionFiles.Add(New MediaFile() With { _
            .ImageTitle = "2DeletedItems.png", _
            .ImageFilePath = String.Format(defaultImagePath, "Images/2DeletedItems.png") _
        })
        firstPartishionFiles.Add(New MediaFile() With { _
            .ImageTitle = "3Drafts.png", _
            .ImageFilePath = String.Format(defaultImagePath, "Images/3Drafts.png") _
        })

        Me.LocalMachinePartitions.Add(New PartitionViewModel() With { _
            .Name = "C:/Images", _
            .MediaFiles = firstPartishionFiles _
        })

        Dim secondPartishionFiles As New ObservableCollection(Of MediaFile)()
        secondPartishionFiles.Add(New MediaFile() With { _
            .ImageTitle = "beach_small.png", _
            .ImageFilePath = String.Format(defaultImagePath, "Photos/beach_small.png") _
        })
        secondPartishionFiles.Add(New MediaFile() With { _
            .ImageTitle = "forest_small.png", _
            .ImageFilePath = String.Format(defaultImagePath, "Photos/forest_small.png") _
        })

        Me.LocalMachinePartitions.Add(New PartitionViewModel() With { _
            .Name = "D:/Photos", _
            .MediaFiles = secondPartishionFiles _
        })

        Me.Applications.Add(New ApplicationViewModel() With { _
            .Name = "Web Client" _
        })
        Me.Applications.Add(New ApplicationViewModel() With { _
            .Name = "Desktop Client" _
        })
    End Sub
End Class
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-2
Public Class PartitionViewModel
    Public Sub New()
        Me.MediaFiles = New ObservableCollection(Of MediaFile)()
    End Sub

    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = Value
        End Set
    End Property
    Private m_Name As String
    Public Property MediaFiles() As ObservableCollection(Of MediaFile)
        Get
            Return m_MediaFiles
        End Get
        Set(value As ObservableCollection(Of MediaFile))
            m_MediaFiles = Value
        End Set
    End Property
    Private m_MediaFiles As ObservableCollection(Of MediaFile)
End Class
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-3
Public Class MediaFile
    Public Property ImageTitle() As String
    Public Property ImageFilePath() As String
End Class
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-4
Public Class ApplicationViewModel
    Public Sub New()
        Me.Resources = New ObservableCollection(Of Resource)()
    End Sub

    Public Property Name() As String

    Public Property Resources() As ObservableCollection(Of Resource)
End Class
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-5
Public Class Resource
    Public Property ImageFilePath() As BitmapImage
    Public Property Title() As String
End Class
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-6
Public Sub New()
    InitializeComponent()

    Dim viewModelData As New MainViewModel()

    Me.xLocalMachineTree.ItemsSource = viewModelData.LocalMachinePartitions
    Me.xApplicationTree.ItemsSource = viewModelData.Applications

    DragDropManager.AddDragOverHandler(Me.xLocalMachineTree, OnLocalMachineTreeDragOver, True)
    DragDropManager.AddDragOverHandler(Me.xApplicationTree, OnApplicationTreeDragOver, True)
    DragDropManager.AddDropHandler(Me.xApplicationTree, OnApplicationTreeDrop, True)
End Sub
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-7
Private Sub OnApplicationTreeDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
    Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
    If options Is Nothing Then
        Return
    End If

    Dim dropTargetItem As RadTreeViewItem = options.DropTargetItem

    Dim draggedItem = options.DraggedItems.First()
    If dropTargetItem Is Nothing OrElse (dropTargetItem IsNot Nothing AndAlso TypeOf options.DropTargetItem.DataContext Is Resource AndAlso options.DropPosition = DropPosition.Inside) OrElse TypeOf draggedItem Is PartitionViewModel Then
        options.DropAction = DropAction.None
    End If

    options.UpdateDragVisual()
End Sub
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-8
Private Sub OnApplicationTreeDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
    Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)

    If options Is Nothing Then
        Return
    End If

    Dim draggedItem As MediaFile = TryCast(options.DraggedItems.FirstOrDefault(), MediaFile)
    If draggedItem Is Nothing Then
        Return
    End If

    Dim dropTargetItem As RadTreeViewItem = options.DropTargetItem
    If dropTargetItem Is Nothing Then
        Return
    End If

    Dim dropItemModel = dropTargetItem.DataContext
    If dropItemModel Is Nothing Then
        Return
    End If

    Dim dropTree = TryCast(sender, RadTreeView)
    If dropTree IsNot Nothing Then
        If TypeOf dropItemModel Is Resource AndAlso options.DropAction = DropAction.None Then
            e.Handled = True
            Return
        End If

        If TypeOf dropItemModel Is ApplicationViewModel OrElse TypeOf dropItemModel Is Resource Then
            options.DropAction = DropAction.Copy
            options.UpdateDragVisual()

            Dim destinationFolder As ApplicationViewModel = Nothing
            If TypeOf dropItemModel Is ApplicationViewModel Then
                destinationFolder = TryCast(dropItemModel, ApplicationViewModel)
            Else
                destinationFolder = TryCast(options.DropTargetItem.ParentItem.DataContext, ApplicationViewModel)
            End If

            If destinationFolder Is Nothing Then
                Return
            End If

            Dim file As New Resource() With { _
                .ImageFilePath = New System.Windows.Media.Imaging.BitmapImage(New Uri(draggedItem.ImageFilePath, UriKind.RelativeOrAbsolute)), _
                .Title = draggedItem.ImageTitle _
            }

            destinationFolder.Resources.Add(file)
        End If
    End If
End Sub
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-9
Private Sub OnLocalMachineTreeDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
    Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
    If options IsNot Nothing Then
        options.DropAction = DropAction.None
        options.UpdateDragVisual()

        e.Handled = True
    End If
End Sub
' #endregion
