#region raddiagrams-howto-serialize-databound-diagram-0
public interface ISerializableGraphSource : IObservableGraphSource
{
    void SerializeNode(object model, SerializationInfo info);
    void SerializeLink(ILink link, SerializationInfo info);

    object DeserializeNode(IShape shape, SerializationInfo info);
    ILink DeserializeLink(IConnection connection, SerializationInfo info);
}
#endregion
#region raddiagrams-howto-serialize-databound-diagram-1
namespace Telerik.Windows.Controls.Diagrams.Extensions.ViewModels
{
    public abstract class SerializableGraphSourceBase<TNode, TLink> : ObservableGraphSourceBase<TNode, TLink>,
                                                                      ISerializableGraphSource where TLink : ILink
    {
        public abstract string GetNodeUniqueId(TNode node);
    }
}
#endregion
#region raddiagrams-howto-serialize-databound-diagram-2
public class OrgItem : HierarchicalNodeViewModel
{
    public OrgItem()
    {
    }

    public OrgItem(string title)
    {
        this.Title = title;
    }

    private string title;
    public string Title
    {
        get { return this.title; }
        set
        {
            if (this.title != value)
            {
                this.title = value;
                this.OnPropertyChanged("Title");
            }
        }
    }

    public string Id { get; set; }
}

public class OrgLink : LinkViewModelBase<OrgItem>
{
    public OrgLink()
    {
    }

    public OrgLink(OrgItem source, OrgItem target)
        : base(source, target)
    {
    }

    public string Id { get; set; }
}
#endregion
#region raddiagrams-howto-serialize-databound-diagram-3
public class GraphSource : SerializableGraphSourceBase<OrgItem, OrgLink>
{
    public override string GetNodeUniqueId(OrgItem node)
    {
        return node.Id;
    }

    public override void SerializeNode(OrgItem node, Telerik.Windows.Diagrams.Core.SerializationInfo info)
    {
        base.SerializeNode(node, info);
        info["Title"] = node.Title;
    }

    public override OrgItem DeserializeNode(Telerik.Windows.Diagrams.Core.IShape shape, Telerik.Windows.Diagrams.Core.SerializationInfo info)
    {
        base.DeserializeNode(shape, info);
        if (info["Title"] != null)
        {
            return new OrgItem(info["Title"].ToString());
        }
        return null;
    }
}
#endregion
#region raddiagrams-howto-serialize-databound-diagram-4
public MainWindow()
{
    InitializeComponent();
    BindGraphSource();
}
private void BindGraphSource()
{
	int uniqueIdCounter = 0;
	GraphSource source = new GraphSource();
	OrgItem rootItem = new OrgItem() { Title = "CEO", Position = new Point(200, 20), Id = (uniqueIdCounter++).ToString() };
	source.AddNode(rootItem);

	OrgItem unitOne = new OrgItem() { Title = "Unit Manager USA", Position = new Point(100, 100), Id = (uniqueIdCounter++).ToString() };
	source.AddNode(unitOne);
	source.AddLink(new OrgLink(rootItem, unitOne) { Id = (uniqueIdCounter++).ToString() });

	OrgItem unitTwo = new OrgItem() { Title = "Unit Manager Europe", Position = new Point(300, 100), Id = (uniqueIdCounter++).ToString() };
	source.AddNode(unitTwo);
	source.AddLink(new OrgLink(rootItem, unitTwo) { Id = (uniqueIdCounter++).ToString() });

	this.xDiagram.GraphSource = source;
}	
#endregion
#region raddiagrams-howto-serialize-databound-diagram-5
private string diagramXMLString;
private void CommandBinding_Executed_Save(object sender, ExecutedRoutedEventArgs e)
{
    diagramXMLString = this.xDiagram.Save();
}

private void CommandBinding_Executed_Open(object sender, ExecutedRoutedEventArgs e)
{
    if (diagramXMLString != null)
    {
        this.xDiagram.Load(diagramXMLString);
    }
}

private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
{
    e.CanExecute = this.xDiagram.Items.Count > 0;
}
#endregion