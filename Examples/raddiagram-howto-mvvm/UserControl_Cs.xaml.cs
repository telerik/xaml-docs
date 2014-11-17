#region raddiagram-howto-mvvm-0
using Telerik.Windows.Controls.Diagrams.Extensions.ViewModels;
public class DiagramViewModel : GraphSourceBase<NodeViewModelBase, LinkViewModelBase<NodeViewModelBase>>
{
    public DiagramViewModel()
    {
        var first = new NodeViewModelBase
        {
            Content = "First item",
            Position = new Point(50, 100)
        };
        var second = new NodeViewModelBase
        {
            Content = "Second item",
            Position = new Point(150, 100),
            RotationAngle = 45
        };
        var third = new NodeViewModelBase
        {
            Content = "Third item",
            Position = new Point(250, 100)
        };
        this.AddNode(first);
        this.AddNode(second);
        this.AddNode(third);
        this.AddLink(new LinkViewModelBase<NodeViewModelBase>(first, second));
        this.AddLink(new LinkViewModelBase<NodeViewModelBase>(second, third));
    }
}
#endregion
#region raddiagram-howto-mvvm-1
xDiagram.GraphSource = new DiagramViewModel();
#endregion
#region raddiagram-howto-mvvm-2
public class Brand : ContainerNodeViewModelBase<object>
{
}
public class Model : NodeViewModelBase
{

}
public class Link : LinkViewModelBase<NodeViewModelBase>
{

}
public class CarsGraphSource : ObservableGraphSourceBase<NodeViewModelBase, Link>
{
	public CarsGraphSource()
	{
		Brand vwGroup = new Brand() { Content = "Volkswagen Group", Position = new Point(250, 100) };

		Brand bentley = new Brand() { Content = "Bentley", Position = new Point(250, 100) };
		Model continental = new Model() { Content = "Continental GT", Position = new Point(250, 100) };
		bentley.AddItem(continental);
		vwGroup.AddItem(bentley);

		Brand bugatti = new Brand() { Content = "Bugatti", Position = new Point(475, 100) };
		Model veyron = new Model() { Content = "Bugatti Veyron", Position = new Point(475, 100) };
		bugatti.AddItem(veyron);
		vwGroup.AddItem(bugatti);

		Brand vw = new Brand() { Content = "Volkswagen", Position = new Point(220, 400) };
		Model polo = new Model() { Content = "Polo", Position = new Point(220, 400) };
		Model golf = new Model() { Content = "Golf", Position = new Point(340, 400) };
		Model passat = new Model() { Content = "Passat", Position = new Point(240, 460) };
		vw.AddItem(polo);
		vw.AddItem(golf);
		vw.AddItem(passat);
		Link groupToVw = new Link() { Content = "Owns", Source = vwGroup, Target = vw };

		Brand audi = new Brand() { Content = "Audi", Position = new Point(520, 400) };
		Model r8 = new Model() { Content = "R8", Position = new Point(520, 400) };
		Model a4 = new Model() { Content = "A4", Position = new Point(640, 400) };
		Model a6 = new Model() { Content = "A6", Position = new Point(540, 460) };
		audi.AddItem(r8);
		audi.AddItem(a4);
		audi.AddItem(a6);
		Link groupToAudi = new Link() { Content = "Owns", Source = vwGroup, Target = audi };

		this.AddNode(vw);
		this.AddNode(audi);
		this.AddNode(vwGroup);

		this.AddLink(groupToVw);
		this.AddLink(groupToAudi);
	}
}
#endregion
#region raddiagram-howto-mvvm-3
public Example()
{
	InitializeComponent();

	this.diagram.GraphSource = new CarsGraphSource();
}
#endregion