#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-0
public partial class MainPage : UserControl
{
	public MainPage()
	{
		InitializeComponent();

		MainViewModel viewModelData = new MainViewModel();

        this.xLocalMachineTree.ItemsSource = viewModelData.LocalMachinePartitions;
        this.xApplicationTree.ItemsSource = viewModelData.Applications;

        DragDropManager.AddDragOverHandler(this.xLocalMachineTree, OnLocalMachineTreeDragOver, true);
        DragDropManager.AddDragOverHandler(this.xApplicationTree, OnApplicationTreeDragOver, true);
        DragDropManager.AddDropHandler(this.xApplicationTree, OnApplicationTreeDrop, true);
	}

	private void OnApplicationTreeDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
    {
        var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
        if (options == null)
            return;

        // The condition after the first OR operator is needed to deny the drop of items in Application File. (sub-items)
        RadTreeViewItem dropTargetItem = options.DropTargetItem;

        var draggedItem = options.DraggedItems.First();         
        if (dropTargetItem == null ||
            (dropTargetItem != null &&
                options.DropTargetItem.DataContext is Resource &&
                options.DropPosition == DropPosition.Inside) ||
            draggedItem is PartitionViewModel)
        {
            options.DropAction = DropAction.None;
        }

        options.UpdateDragVisual();
    }

    private void OnApplicationTreeDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
    {
        var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;

        if (options == null)
            return;

        MediaFile draggedItem = options.DraggedItems.FirstOrDefault() as MediaFile;
        if (draggedItem == null)
            return;

        RadTreeViewItem dropTargetItem = options.DropTargetItem;
        if (dropTargetItem == null)
            return;

        var dropItemModel = dropTargetItem.DataContext;
        if (dropItemModel == null)
            return;

        var dropTree = sender as RadTreeView;
        if (dropTree != null)
        {
            // Disable drop in Application File.
            if (dropItemModel is Resource && options.DropAction == DropAction.None)
            {
                e.Handled = true;
                return;
            }

            // Drop in Application.
            if (dropItemModel is ApplicationViewModel || dropItemModel is Resource)
            {
                options.DropAction = DropAction.Copy;
                options.UpdateDragVisual();

                ApplicationViewModel destinationFolder = null;
                if (dropItemModel is ApplicationViewModel)
                {
                    // Dropping inside Application.
                    destinationFolder = dropItemModel as ApplicationViewModel;
                }
                else
                {
                    // Dropping Before or After an Application Resource.
                    destinationFolder = options.DropTargetItem.ParentItem.DataContext as ApplicationViewModel;
                }

                if (destinationFolder == null)
                    return;

                Resource file = new Resource()
                {
                    ImageFilePath = new System.Windows.Media.Imaging.BitmapImage(new Uri(draggedItem.ImageFilePath, UriKind.RelativeOrAbsolute)),
                    Title = draggedItem.ImageTitle
                };
                                        
                destinationFolder.Resources.Add(file);
            }
        }
    }

    // Forbids the local machine tree view to drop anything
    private void OnLocalMachineTreeDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
    {
        var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
        if (options != null)
        {
            options.DropAction = DropAction.None;
            options.UpdateDragVisual();

            e.Handled = true;
        }
    }	
}
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-1
public class MainViewModel
{
	public MainViewModel()
	{
		this.LocalMachinePartitions = new ObservableCollection<PartitionViewModel>();
		this.Applications = new ObservableCollection<ApplicationViewModel>();
		this.GenetareSampleData();
	}

	public ObservableCollection<PartitionViewModel> LocalMachinePartitions
	{
		get;
		set;
	}

	public ObservableCollection<ApplicationViewModel> Applications
	{
		get;
		set;
	}

	private void GenetareSampleData()
	{
		string defaultImagePath = "Images/MediaFiles/{0}";
		ObservableCollection<MediaFile> firstPartishionFiles = new ObservableCollection<MediaFile>();
		firstPartishionFiles.Add(new MediaFile() { ImageTitle = "1PersonalFolders.png", ImageFilePath = string.Format(defaultImagePath, "Images/1PersonalFolders.png") });
		firstPartishionFiles.Add(new MediaFile() { ImageTitle = "2DeletedItems.png", ImageFilePath = string.Format(defaultImagePath, "Images/2DeletedItems.png") });
		firstPartishionFiles.Add(new MediaFile() { ImageTitle = "3Drafts.png", ImageFilePath = string.Format(defaultImagePath, "Images/3Drafts.png") });

		this.LocalMachinePartitions.Add(new PartitionViewModel()
		{
			Name = @"C:/Images",
			MediaFiles = firstPartishionFiles
		});

		ObservableCollection<MediaFile> secondPartishionFiles = new ObservableCollection<MediaFile>();
		secondPartishionFiles.Add(new MediaFile() { ImageTitle = "beach_small.png", ImageFilePath = string.Format(defaultImagePath, "Photos/beach_small.png") });
		secondPartishionFiles.Add(new MediaFile() { ImageTitle = "forest_small.png", ImageFilePath = string.Format(defaultImagePath, "Photos/forest_small.png") });
			
		this.LocalMachinePartitions.Add(new PartitionViewModel() 
		{
			Name = @"D:/Photos",
			MediaFiles = secondPartishionFiles
		});

		this.Applications.Add(new ApplicationViewModel() { Name = "Web Client" });
		this.Applications.Add(new ApplicationViewModel() { Name = "Desktop Client" });
	}
}
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-2
public class PartitionViewModel
{
    public PartitionViewModel()
    {
        this.MediaFiles = new ObservableCollection<MediaFile>();
    }

    public string Name { get; set; }
    public ObservableCollection<MediaFile> MediaFiles { get; set; }
}
#endregion
#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-3
public class MediaFile
{
	public string ImageTitle { get; set; }
	public string ImageFilePath { get; set; }
}
#endregion
#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-4
public class ApplicationViewModel
{
	public ApplicationViewModel()
	{
		this.Resources = new ObservableCollection<Resource>();
	}

	public string Name { get; set; }

	public ObservableCollection<Resource> Resources { get; set; }
}
#endregion
#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-5
public class Resource
{
	public BitmapImage ImageFilePath { get; set; }
	public string Title { get; set; }
}
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-6
public MainPage()
{
	InitializeComponent();

	 MainViewModel viewModelData = new MainViewModel();

    this.xLocalMachineTree.ItemsSource = viewModelData.LocalMachinePartitions;
    this.xApplicationTree.ItemsSource = viewModelData.Applications;

    DragDropManager.AddDragOverHandler(this.xLocalMachineTree, OnLocalMachineTreeDragOver, true);
    DragDropManager.AddDragOverHandler(this.xApplicationTree, OnApplicationTreeDragOver, true);
    DragDropManager.AddDropHandler(this.xApplicationTree, OnApplicationTreeDrop, true);
}
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-7
private void OnApplicationTreeDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options == null)
        return;
   
    RadTreeViewItem dropTargetItem = options.DropTargetItem;

    var draggedItem = options.DraggedItems.First();         
    if (dropTargetItem == null ||
        (dropTargetItem != null &&
            options.DropTargetItem.DataContext is Resource &&
            options.DropPosition == DropPosition.Inside) ||
        draggedItem is PartitionViewModel)
    {
        options.DropAction = DropAction.None;
    }

    options.UpdateDragVisual();
}
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-8
private void OnApplicationTreeDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;

    if (options == null)
        return;

    MediaFile draggedItem = options.DraggedItems.FirstOrDefault() as MediaFile;
    if (draggedItem == null)
        return;

    RadTreeViewItem dropTargetItem = options.DropTargetItem;
    if (dropTargetItem == null)
        return;

    var dropItemModel = dropTargetItem.DataContext;
    if (dropItemModel == null)
        return;

    var dropTree = sender as RadTreeView;
    if (dropTree != null)
    {
        if (dropItemModel is Resource && options.DropAction == DropAction.None)
        {
            e.Handled = true;
            return;
        }

        if (dropItemModel is ApplicationViewModel || dropItemModel is Resource)
        {
            options.DropAction = DropAction.Copy;
            options.UpdateDragVisual();

            ApplicationViewModel destinationFolder = null;
            if (dropItemModel is ApplicationViewModel)
            {
                destinationFolder = dropItemModel as ApplicationViewModel;
            }
            else
            {
                destinationFolder = options.DropTargetItem.ParentItem.DataContext as ApplicationViewModel;
            }

            if (destinationFolder == null)
                return;

            Resource file = new Resource()
            {
                ImageFilePath = new System.Windows.Media.Imaging.BitmapImage(new Uri(draggedItem.ImageFilePath, UriKind.RelativeOrAbsolute)),
                Title = draggedItem.ImageTitle
            };
                                        
            destinationFolder.Resources.Add(file);
        }
    }
}
#endregion

#region radtreeview-how-to-implement-drag-and-drop-between-two-treeviews-9
private void OnLocalMachineTreeDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options != null)
    {
        options.DropAction = DropAction.None;
        options.UpdateDragVisual();

        e.Handled = true;
    }
}
#endregion