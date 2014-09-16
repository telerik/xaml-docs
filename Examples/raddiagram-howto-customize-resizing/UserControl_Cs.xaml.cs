#region raddiagram-howto-customize-resizing-0
public class MyResizing : ResizingService
{
    public MyResizing(RadDiagram owner)
        : base(owner as IGraphInternal)
    {
    }

    protected override Point CalculateNewDelta(Point newPoint)
    {
        return base.CalculateNewDelta(newPoint);
    }
}
#endregion
#region raddiagram-howto-customize-resizing-1
public class MyResizing : ResizingService, INotifyPropertyChanged
{
    private bool canResizeHeight;
    private bool canResizeWidth;

    public MyResizing(RadDiagram owner)
        : base(owner as IGraphInternal)
    {
        //Initialize the boolean properties that will control the availability of the resizing
        this.CanResizeWidth = true;
        this.CanResizeHeight = true;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public bool CanResizeWidth
    {
        get
        {
            return this.canResizeWidth;
        }
        set
        {
            if (this.canResizeWidth != value)
            {
                this.canResizeWidth = value;
                this.OnPropertyChaged("CanResizeWidth");
            }
        }
    }
    public bool CanResizeHeight
    {
        get
        {
            return this.canResizeHeight;
        }
        set
        {
            if (this.canResizeHeight != value)
            {
                this.canResizeHeight = value;
                this.OnPropertyChaged("CanResizeHeight");
            }
        }
    }

    protected override Point CalculateNewDelta(Point newPoint)
    {
        //calculate the size change using the defaul calulation mechanism
        var newDelta = base.CalculateNewDelta(newPoint);
        //use the boolean properties to determine whether to apply any changes in the size of the manipulated item
        return new Point(this.CanResizeWidth ? newDelta.X : 0, this.CanResizeHeight ? newDelta.Y : 0);
    }

    private void OnPropertyChaged(string name)
    {
        if (this.PropertyChanged != null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
#endregion
#region raddiagram-howto-customize-resizing-2
private MyResizing newResizingService;

public Example()
{
    InitializeComponent();

    this.InitializeNewServices();
}

private void InitializeNewServices()
{
    //initialize the newResizingService
    this.newResizingService = new MyResizing(this.diagram);
     //create a binding with Path=CanResizeWidth
    Binding binding = new Binding("CanResizeWidth");
    //use the newResizingService as a source of the binding
    binding.Source = this.newResizingService;
    binding.Mode = BindingMode.TwoWay;
    //apply the binding on the resizeWidth RadToggleButton
    this.resizeWidth.SetBinding(RadToggleButton.IsCheckedProperty, binding);

    //create a binding with Path=CanResizeHeight
    binding = new Binding("CanResizeHeight");
    //use the newResizingService as a source of the binding
    binding.Source = this.newResizingService;
    binding.Mode = BindingMode.TwoWay;
    //apply the binding on the resizeHeight RadToggleButton
    this.resizeHeight.SetBinding(RadToggleButton.IsCheckedProperty, binding);
}
#endregion
#region raddiagram-howto-customize-resizing-3
public Example()
{
    InitializeComponent();

    this.InitializeNewServices();
    this.diagram.ServiceLocator.Register<IResizingService>(this.newResizingService);
}
#endregion