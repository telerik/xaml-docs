#region raddiagram-howto-customize-dragging-0
public class MyDragging : DraggingService
{

    public MyDragging(RadDiagram graph)
        : base(graph as IGraphInternal)
    {

    }

}
#endregion
#region raddiagram-howto-customize-dragging-1
public class MyDragging : DraggingService, INotifyPropertyChanged
{
    private bool isRestrictedToBounds;
    private bool isOn;
    private bool useRotaitonBounds;

    public MyDragging(RadDiagram graph)
        : base(graph as IGraphInternal)
    {
        //initialize the properties of the service
        this.DragAllowedArea = Rect.Empty;
        this.IsOn = true;
        this.UseRotaitonBounds = true;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public Rect DragAllowedArea { get; set; }
    public bool IsRestrictedToBounds
    {
        get
        {
            return this.isRestrictedToBounds;
        }
        set
        {
            if (this.isRestrictedToBounds != value)
            {
                this.isRestrictedToBounds = value;
                this.OnPropertyChaged("IsRestrictedToBounds");
            }
        }
    }
    public bool UseRotaitonBounds
    {
        get
        {
            return this.useRotaitonBounds;
        }
        set
        {
            if (this.useRotaitonBounds != value)
            {
                this.useRotaitonBounds = value;
                this.OnPropertyChaged("UseRotaitonBounds");
            }
        }
    }
    public bool IsOn
    {
        get
        {
            return this.isOn;
        }
        set
        {
            if (this.isOn != value)
            {
                this.isOn = value;
                this.OnPropertyChaged("IsOn");
            }
        }
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
#region raddiagram-howto-customize-dragging-2
public override void Drag(Point newPoint)
{
	Point dragPoint = newPoint;
    //if the mouse position during a drag operation should be restricted within the DragAllowedArea
	if (this.DragAllowedArea != Rect.Empty && !this.DragAllowedArea.Contains(newPoint))
	{
        //calculate the proper position of the dragPoint
		double X = dragPoint.X;
		double Y = dragPoint.Y;
		if (X > this.DragAllowedArea.Right)
			X = this.DragAllowedArea.Right;
		else if (X < this.DragAllowedArea.Left)
			X = this.DragAllowedArea.Left;

		if (Y > this.DragAllowedArea.Bottom)
			Y = this.DragAllowedArea.Bottom;
		else if (Y < this.DragAllowedArea.Top)
			Y = this.DragAllowedArea.Top;

		dragPoint = new Point(X, Y);
	}
}
#endregion
#region raddiagram-howto-customize-dragging-3
 private readonly RadDiagram diagram;
//this method gets the bounds of the selected DiagramItems 
private Rect GetSelectionBounds()
{
	if (this.UseRotaitonBounds)
	{
        //find the selection bounds after a rotation
		Rect result = Rect.Empty;
		foreach (var item in this.diagram.SelectedItems)
		{
			var container = this.diagram.ContainerGenerator.ContainerFromItem(item);
			var shape = item as IShape;
			if (shape != null)
				result.Union(shape.ActualBounds);
			else
				result.Union(container.Bounds);
		}

		return result;
	}
	else
	{
        //or get the default selection bounds
		return this.diagram.SelectionBounds;
	}
}
#endregion
#region raddiagram-howto-customize-dragging-4
public MyDragging(RadDiagram graph)
	: base(graph as IGraphInternal)
{
    this.diagram = graph;
			
    this.DragAllowedArea = Rect.Empty;
	this.IsOn = true;
	this.UseRotaitonBounds = true;
}
#endregion
#region raddiagram-howto-customize-dragging-5
public override void Drag(Point newPoint)
{
	Point dragPoint = newPoint;
	if (this.IsRestrictedToBounds)
	{
        //get the bounds of the selected RadDiagramItems
		var selectionBounds = this.GetSelectionBounds();
        //find the drag offset by comparing the coordinates of the last and the new drag position 
		var offset = new Vector(newPoint.X - this.lastPoint.X, newPoint.Y - this.lastPoint.Y);
        //calculate the new bounds of the dragged selected items
		var newBounds = new Rect(selectionBounds.X + offset.X, selectionBounds.Y + offset.Y, selectionBounds.Width, selectionBounds.Height);

        //if there is no predefined draggable area or 
        //if the bounds of the dragged selected items are within the predefined draggable area
        //invoke the default implementation of the DraggingService Drag() method
		if (this.DragAllowedArea == Rect.Empty || this.DragAllowedArea.Contains(newBounds))
		{
			base.Drag(newPoint);
			this.lastPoint = dragPoint;
			return;
		}

        //if the bounds of the selected items is outside the bounds of the draggable area, 
        //recalculate the coordinates of the drag point to make sure the bounds of the selected items is inside the draggable area 
		if (this.DragAllowedArea.Left > newBounds.Left)
			dragPoint = new Point(dragPoint.X - (newBounds.Left - this.DragAllowedArea.Left), dragPoint.Y);
		else if (this.DragAllowedArea.Right < newBounds.Right)
			dragPoint = new Point(dragPoint.X - (newBounds.Right - this.DragAllowedArea.Right), dragPoint.Y);

		if (this.DragAllowedArea.Top > newBounds.Top)
			dragPoint = new Point(dragPoint.X, dragPoint.Y - (newBounds.Top - this.DragAllowedArea.Top));
		else if (this.DragAllowedArea.Bottom < newBounds.Bottom)
			dragPoint = new Point(dragPoint.X, dragPoint.Y - (newBounds.Bottom - this.DragAllowedArea.Bottom));
	}
}
#endregion
#region raddiagram-howto-customize-dragging-6
public override void Drag(Point newPoint)
{
	Point dragPoint = newPoint;

	if (this.IsOn)
	{
        //if the actual bounds of the shape should be within the DragAllowedArea
		if (this.IsRestrictedToBounds)
		{
            //get the bounds of the selected RadDiagramItems
			var selectionBounds = this.GetSelectionBounds();
            //find the drag offset by comparing the coordinates of the last and the new drag position 
			var offset = new Vector(newPoint.X - this.lastPoint.X, newPoint.Y - this.lastPoint.Y);
            //calculate the new bounds of the dragged selected items
			var newBounds = new Rect(selectionBounds.X + offset.X, selectionBounds.Y + offset.Y, selectionBounds.Width, selectionBounds.Height);

            //if there is no predefined draggable area or 
            //if the bounds of the dragged selected items are within the predefined draggable area
            //invoke the default implementation of the DraggingService Drag() method
			if (this.DragAllowedArea == Rect.Empty || this.DragAllowedArea.Contains(newBounds))
			{
				base.Drag(newPoint);
				this.lastPoint = dragPoint;
				return;
			}

            //if the bounds of the selected items is outside the bounds of the draggable area, 
            //recalculate the coordinates of the drag point to make sure the bounds of the selected items is inside the draggable area 
			if (this.DragAllowedArea.Left > newBounds.Left)
				dragPoint = new Point(dragPoint.X - (newBounds.Left - this.DragAllowedArea.Left), dragPoint.Y);
			else if (this.DragAllowedArea.Right < newBounds.Right)
				dragPoint = new Point(dragPoint.X - (newBounds.Right - this.DragAllowedArea.Right), dragPoint.Y);

			if (this.DragAllowedArea.Top > newBounds.Top)
				dragPoint = new Point(dragPoint.X, dragPoint.Y - (newBounds.Top - this.DragAllowedArea.Top));
			else if (this.DragAllowedArea.Bottom < newBounds.Bottom)
				dragPoint = new Point(dragPoint.X, dragPoint.Y - (newBounds.Bottom - this.DragAllowedArea.Bottom));
		}
		else
		{
            //if the mouse position during a drag operation should be restricted within the DragAllowedArea
			if (this.DragAllowedArea != Rect.Empty && !this.DragAllowedArea.Contains(newPoint))
			{
                //calculate the proper position of the dragPoint
				double X = dragPoint.X;
				double Y = dragPoint.Y;
				if (X > this.DragAllowedArea.Right)
					X = this.DragAllowedArea.Right;
				else if (X < this.DragAllowedArea.Left)
					X = this.DragAllowedArea.Left;

				if (Y > this.DragAllowedArea.Bottom)
					Y = this.DragAllowedArea.Bottom;
				else if (Y < this.DragAllowedArea.Top)
					Y = this.DragAllowedArea.Top;

				dragPoint = new Point(X, Y);
			}
		}
	}
    //invoke the base implementation of the DraggingService Drag() method with the calculated proper coordinates of the dragPoint  
	base.Drag(dragPoint);
    //update the lastPosition property to always keep track of the last drag position
	this.lastPoint = dragPoint;
}
#endregion
#region raddiagram-howto-customize-dragging-7
//override this method to get the coordinates of the point where the drag started
public override void InitializeDrag(Point point)
{
	this.lastPoint = point;
	base.InitializeDrag(point);
}
#endregion
#region raddiagram-howto-customize-dragging-8
private MyDragging newDraggingService;

public Example()
{
    InitializeComponent();

    this.InitializeNewServices();
}

private void InitializeNewServices()
{
    //initialize MyDragging 
    this.newDraggingService = new MyDragging(this.diagram);
    //create a binding with Path=IsOn
    Binding binding = new Binding("IsOn");
    //use the newDraggingService as a source of the binding
    binding.Source = this.newDraggingService;
    binding.Mode = BindingMode.TwoWay;
    //apply the binding on the toggleDrag RadToggleButton
    this.toggleDrag.SetBinding(RadToggleButton.IsCheckedProperty, binding);
           
    //create a binding with Path=IsRestrictedToBounds
    binding = new Binding("IsRestrictedToBounds");
    //use the newDraggingService as a source of the binding
    binding.Source = this.newDraggingService;
    binding.Mode = BindingMode.TwoWay;
    //apply the binding on the IsRestrictedToBounds RadToggleButton
    this.IsRestrictedToBounds.SetBinding(RadToggleButton.IsCheckedProperty, binding);

    //create a binding with Path=UseRotaitonBounds
    binding = new Binding("UseRotaitonBounds");
    //use the newDraggingService as a source of the binding
    binding.Source = this.newDraggingService;
    binding.Mode = BindingMode.TwoWay;
    //apply the binding on the useRotaitonBounds RadToggleButton
    this.useRotaitonBounds.SetBinding(RadToggleButton.IsCheckedProperty, binding);
}
#endregion
#region raddiagram-howto-customize-dragging-9
public Example()
{
    InitializeComponent();
    this.InitializeNewServices();
    this.diagram.ServiceLocator.Register<IDraggingService>(this.newDraggingService);
}
#endregion
#region raddiagram-howto-customize-dragging-10
private void SetRestrictRect(Rect rect)
{
    if (this.newDraggingService != null)
        this.newDraggingService.DragAllowedArea = rect.InflateRect(-rect.Width / 4, -rect.Height / 4);
}

private void OnDiagramViewportChanged(object sender, PropertyEventArgs<Rect> e)
{
    this.SetRestrictRect(e.NewValue);
    this.border.Width = (e.NewValue.Width / 2) * this.diagram.Zoom;
    this.border.Height = (e.NewValue.Height / 2) * this.diagram.Zoom;
}
#endregion