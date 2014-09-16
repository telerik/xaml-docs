#region raddiagram-howto-customize-rotation-0
public class MyRotation : RotationService
{
    private int rotationStep;

    public MyRotation(RadDiagram owner)
        : base(owner as IGraphInternal)
    {
        //initialize the RotationStep property
        this.RotationStep = 1;
    }

    public int RotationStep
    {
        get
        {
            return this.rotationStep;
        }
        set
        {
            this.rotationStep = value;
        }
    }

    protected override double CalculateRotationAngle(Point newPoint)
    {
        //take the angle calculated by the default rotation mechanism
        var angle = base.CalculateRotationAngle(newPoint);
        //change that angle based on the user-defined value of the RotationStep property
        return angle = Math.Floor(angle / this.RotationStep) * this.RotationStep;
    }
}
#endregion
#region raddiagram-howto-customize-rotation-1
private MyRotation newRotationService;
private void InitializeNewServices()
{
    //initialize the newRotationService and define a default RotationStep
    this.newRotationService = new MyRotation(this.diagram) { RotationStep = 45 };
    //create a binding with Path=RotationStep
    Binding binding = new Binding("RotationStep");
    //use the newRotationService as a source of the binding
    binding.Source = this.newRotationService;
    binding.Mode = BindingMode.TwoWay;
    //apply the binding on the rotationStep TextBox
    this.rotationStep.SetBinding(TextBox.TextProperty, binding);
}
#endregion
#region raddiagram-howto-customize-rotation-2
private MyRotation newRotationService;
public Example()
{
	InitializeComponent();

	this.InitializeNewServices();
    this.diagram.ServiceLocator.Register<IRotationService>(this.newRotationService);
}
#endregion