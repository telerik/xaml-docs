#region raddiagrams-features-drag-drop-0
xDiagram.AllowDrop = true;
#endregion
#region raddiagrams-features-drag-drop-1

public DragDropExample()
{
    InitializeComponent();
    DragDropManager.AddDragInitializeHandler(xListBox, OnDragInitialize);
}

//ListBox OnDragInitialize method implementation
private void OnDragInitialize(object sender, DragInitializeEventArgs args)
{
    args.AllowedEffects = DragDropEffects.All;
    RadDiagramShape draggedShape = (args.OriginalSource as ListBoxItem).Content as RadDiagramShape;
    List<RadDiagramShape> shapes = new List<RadDiagramShape>();
    shapes.Add(draggedShape);
    SerializationInfo serializaedInfo = SerializationService.Default.SerializeItems(shapes);
    args.Data = serializaedInfo;
}
#endregion
#region raddiagrams-features-drag-drop-2
public DragDropExample()
{
    InitializeComponent();
    DragDropManager.AddDragInitializeHandler(xListBox, OnDragInitialize);
}

//ListBox OnDragInitialize method implementation
private void OnDragInitialize(object sender, DragInitializeEventArgs args)
{
    args.AllowedEffects = DragDropEffects.All;
   RadDiagramShape draggedShape = args.OriginalSource as RadDiagramShape;
    List<RadDiagramShape> shapes = new List<RadDiagramShape>();
    shapes.Add(draggedShape);
    SerializationInfo serializaedInfo = SerializationService.Default.SerializeItems(shapes);
    args.Data = serializaedInfo;
}
#endregion

#region raddiagrams-features-drag-drop-3
public class ApplicationInfo
{
    public Double Price
    {
        get;
        set;
    }

    public String IconPath
    {
        get;
        set;
    }

    public String Name
    {
        get;
        set;
    }

    public String Author
    {
        get;
        set;
    }
}
public class MainViewModel
{
    private ObservableCollection<ApplicationInfo> allApplications = GenerateApplicationInfos();

    public ObservableCollection<ApplicationInfo> AllApplications
    {
        get
        {
            return this.allApplications;
        }
        set
        {
            this.allApplications = value;
        }
    }

    public static ObservableCollection<ApplicationInfo> GenerateApplicationInfos()
    {
        ObservableCollection<ApplicationInfo> result = new ObservableCollection<ApplicationInfo>();

        ApplicationInfo info1 = new ApplicationInfo();
        info1.Name = "Large Collider";
        info1.Author = "C.E.R.N.";
        info1.IconPath = @"Images/Atom.png";
        result.Add(info1);

        ApplicationInfo info2 = new ApplicationInfo();
        info2.Name = "Paintbrush";
        info2.Author = "Imagine Inc.";
        info2.IconPath = @"Images/Brush.png";
        result.Add(info2);

        ApplicationInfo info3 = new ApplicationInfo();
        info3.Name = "Lively Calendar";
        info3.Author = "Control AG";
        info3.IconPath = @"Images/CalendarEvents.png";
        result.Add(info3);

        ApplicationInfo info4 = new ApplicationInfo();
        info4.Name = "Fire Burning ROM";
        info4.Author = "The CD Factory";
        info4.IconPath = @"Images/CDBurn.png";
        result.Add(info4);

        ApplicationInfo info5 = new ApplicationInfo();
        info5.Name = "Fav Explorer";
        info5.Author = "Star Factory";
        info5.IconPath = @"Images/favorites.png";
        result.Add(info5);

        return result;
    }
}
#endregion
#region raddiagrams-features-drag-drop-4
public DragDropExample()
{
    InitializeComponent();
    DragDropManager.AddDragInitializeHandler(xListBox, OnDragInitialize);
}

//ListBox OnDragInitialize method implementation
private void OnDragInitialize(object sender, DragInitializeEventArgs args)
{
    args.AllowedEffects = DragDropEffects.All;
    args.Data = ((FrameworkElement)args.OriginalSource).DataContext;
    args.DragVisual = new ContentControl { Content = args.Data, ContentTemplate = this.Resources["ApplicationTemplate"] as DataTemplate };
}
#endregion
//Silverlight
#region raddiagrams-features-drag-drop-5
public DragDropExample()
{
    InitializeComponent();
    DragDropManager.AddDropHandler(this.xDiagram, OnDiagramDrop);
}

private void OnDiagramDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    e.Handled = true;
    RadDiagramShape shape = new RadDiagramShape();
    shape.Content = e.Data is ApplicationInfo ? (e.Data as ApplicationInfo).Name : e.Data.ToString();
    var currentPosition = xDiagram.GetTransformedPoint(e.GetPosition(xDiagram));
    shape.Position = new Point(currentPosition.X, currentPosition.Y);

    this.xDiagram.AddShape(shape);
}
#endregion
//WPF
#region raddiagrams-features-drag-drop-6
public DragDropExample()
{
    InitializeComponent();
    DragDropManager.AddDropHandler(this.xDiagram, OnDiagramDrop);
}

private void OnDiagramDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    e.Handled = true;
    RadDiagramShape shape = new RadDiagramShape();
    ApplicationInfo draggedData = (e.Data as DataObject).GetData(typeof(ApplicationInfo)) as ApplicationInfo;
    shape.Content = draggedData != null ? draggedData.Name : e.Data.ToString();
    var currentPosition = xDiagram.GetTransformedPoint(e.GetPosition(xDiagram));
    shape.Position = new Point(currentPosition.X, currentPosition.Y);

    this.xDiagram.AddShape(shape);
}
#endregion
