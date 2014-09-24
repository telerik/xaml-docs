#region raddiagram-howto-semantic-zoom-0
public class CustomNode : HierarchicalNodeViewModel
{
    private ItemDisplayMode currentDisplayMode;
    public ItemDisplayMode CurrentDisplayMode
    {
        get
        {
            return this.currentDisplayMode;
        }
        internal set
        {
            if (this.currentDisplayMode != value)
            {
                this.currentDisplayMode = value;
                OnPropertyChanged("CurrentDisplayMode");
            }
        }
    }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string ImagePath { get; set; }

    public string Address { get; set; }

    public int HeadCount { get; set; }

    public string JobPosition { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public CustomNode()
    {
        this.CurrentDisplayMode = ItemDisplayMode.Small;
    }
}

public enum ItemDisplayMode
{
    Medium,
    Large,
    Small
}
#endregion
#region raddiagram-howto-semantic-zoom-1
public class MainViewModel : ViewModelBase
{
    public ObservableGraphSourceBase<CustomNode, LinkViewModelBase<CustomNode>> Employees { get; set; }

    public MainViewModel()
    {
        this.Employees = new ObservableGraphSourceBase<CustomNode, LinkViewModelBase<CustomNode>>();
        this.Employees.AddNode(new CustomNode()
        {
            FirstName = "Andrew",
            LastName = "Fuller",
            Email = "afuller@contoso.com",
            Phone = "(205) 555 - 9898",
            Address = "London, 120 Hanover Sq.",
            Position = new Point(250, 250),
            ImagePath = "/Images/AndrewFuller.jpg",
            JobPosition = "CEO"
        });
    }
}
#endregion
#region raddiagram-howto-semantic-zoom-2
public class MainViewModel : ViewModelBase
{
    private static double SmallToNormalTemplateThreshHold = 1.2d;
    private static double NormallToLargeTemplateThreshHold = 2.1d;

    public ObservableGraphSourceBase<CustomNode, LinkViewModelBase<CustomNode>> Employees { get; set; }

    private double zoomFactor;
    /// <summary>
    ///     Gets or sets the zoom factor of the diagram.
    /// </summary>
    public double ZoomFactor
    {
        get
        {
            return this.zoomFactor;
        }
        internal set
        {
            if (this.zoomFactor != value)
            {
                this.zoomFactor = value;
                this.OnZoomChanged();
                OnPropertyChanged("ZoomFactor");
            }
        }
    }
    public ItemDisplayMode ItemsCurrentDisplayMode { get; set; }

    public MainViewModel()
    {
        this.Employees = new ObservableGraphSourceBase<CustomNode, LinkViewModelBase<CustomNode>>();
        this.Employees.AddNode(new CustomNode()
        {
            FirstName = "Andrew",
            LastName = "Fuller",
            Email = "afuller@contoso.com",
            Phone = "(205) 555 - 9898",
            Address = "London, 120 Hanover Sq.",
            Position = new Point(250, 250),
            ImagePath = "/Images/AndrewFuller.jpg",
            JobPosition = "CEO"
        });
        this.ItemsCurrentDisplayMode = ItemDisplayMode.Medium;
        this.ZoomFactor = 1;
    }

    private void OnZoomChanged()
    {
        ItemDisplayMode newMode;
        if (SmallToNormalTemplateThreshHold < this.ZoomFactor && this.ZoomFactor <= NormallToLargeTemplateThreshHold)
            newMode = ItemDisplayMode.Medium;
        else if (this.ZoomFactor <= SmallToNormalTemplateThreshHold)
            newMode = ItemDisplayMode.Small;
        else
            newMode = ItemDisplayMode.Large;

        if (this.ItemsCurrentDisplayMode != newMode)
            this.ChangeAllShapesDisplayMode(newMode);
    }

    private void ChangeAllShapesDisplayMode(ItemDisplayMode newMode)
    {
        this.ItemsCurrentDisplayMode = newMode;
        foreach (var node in this.Employees.InternalItems)
        {
            node.CurrentDisplayMode = newMode;
        }
    }
}
#endregion