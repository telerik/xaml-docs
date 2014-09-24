#region raddiagram-extensions-toolbox-0
public class MainViewModel
{
    public HierarchicalGalleryItemsCollection GalleryItems { get; set; }

    public MainViewModel()
    {
        this.GalleryItems = new HierarchicalGalleryItemsCollection();
    }
}	
#endregion
#region raddiagram-extensions-toolbox-1
public class MainViewModel
{
    public ObservableCollection<Gallery> GalleryItems { get; set; }

    public MainViewModel()
    {
        this.GalleryItems = new ObservableCollection<Gallery>();
        LoadData("Basic", "Flowchart", "Arrow", "Container");
    }

    private void LoadData(params string[] galleryNames)
    {
        var allItems = new GalleryItemsCollection();

        foreach (var galleryName in galleryNames)
        {
            var gallery = new Gallery { Header = galleryName };
            foreach (var item in allItems.GetItemsByType(galleryName).ToArray())
            {
                gallery.Items.Add(item);
            }
            this.GalleryItems.Add(gallery);
        }
    }
}	
#endregion
#region raddiagram-extensions-toolbox-2
public class MainViewModel
{
    public ObservableCollection<Gallery> GalleryItems { get; set; }

    public MainViewModel()
    {
        this.GalleryItems = new ObservableCollection<Gallery>();
        LoadData("Basic");
    }

    private void LoadData(params string[] galleryNames)
    {
        var allItems = new GalleryItemsCollection();

        foreach (var galleryName in galleryNames)
        {
            var gallery = new Gallery { Header = galleryName };
            foreach (var item in allItems.GetItemsByType(galleryName).ToArray())
            {
                gallery.Items.Add(item);
            }
            this.GalleryItems.Add(gallery);
        }
    }
}
#endregion
#region raddiagram-extensions-toolbox-3
public class MyShape
{
    public Geometry Geometry { get; set; }
    public string Header { get; set; }
}
public class MyGallery
{
    public string Header { get; set; }
    public ObservableCollection<MyShape> Shapes { get; set; }
    public MyGallery()
    {
        this.Shapes = new ObservableCollection<MyShape>();
    }
}
public class MainViewModel
{
    public ObservableCollection<MyGallery> Items { get; set; }
    public MainViewModel()
    {
        this.Items = new ObservableCollection<MyGallery>();
        //create and populate the first custom gallery
        MyGallery firstGallery = new MyGallery { Header = "First Gallery" };
        firstGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 1.1",
            Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.CloudShape)
        });
        firstGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 1.2",
            Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.EllipseShape)
        });
        firstGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 1.3",
            Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.HexagonShape)
        });
        firstGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 1.4",
            Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.PentagonShape)
        });
        firstGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 1.5",
            Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.RightTriangleShape)
        });
        this.Items.Add(firstGallery);

        //create and populate the second custom gallery
        MyGallery secondGallery = new MyGallery { Header = "Second Gallery" };
        secondGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 2.1",
            Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.CardShape)
        });
        secondGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 2.2",
            Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.Database1Shape)
        });
        secondGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 2.3",
            Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.CollateShape)
        });
        secondGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 2.4",
            Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.DataShape)
        });
        secondGallery.Shapes.Add(new MyShape
        {
            Header = "Shape 2.5",
            Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.DisplayShape)
        });
        this.Items.Add(secondGallery);
    }
}
#endregion
#region raddiagram-extensions-toolbox-4
#endregion