#region raddiagram-howto-mvvm-style-selectors-0
using Telerik.Windows.Controls.Diagrams.Extensions;

public class EllipseNode : NodeViewModelBase
{
    public EllipseNodeType Type { get; set; }
}

public enum EllipseNodeType
{
    Start,
    End
}

public class RectangleNode : NodeViewModelBase
{
    public string Description { get; set; }
}

public class DecisionNode : NodeViewModelBase
{
    public string Content { get; set; }
}
#endregion
#region raddiagram-howto-mvvm-style-selectors-1
using Telerik.Windows.Controls.Diagrams.Extensions.ViewModels;

public class Link : LinkViewModelBase<NodeViewModelBase>
{
    public LinkType Type { get; set; }

    public Link()
        : base()
    { }

    public Link(NodeViewModelBase source, NodeViewModelBase target)
        : base(source, target)
    {
    }
}

public enum LinkType
{
    RightToLeft,
    LeftToRight,
    Normal
}
#endregion
#region raddiagram-howto-mvvm-style-selectors-2
    public class GraphSource : ObservableGraphSourceBase<NodeViewModelBase, Link>
    {
        public void PopulateGraphSource()
        {
            //Add Nodes
            RectangleNode processNode1 = new RectangleNode()
            {
                Position = new Point(160, 280),
                Description = "Process 1"
            };
            this.AddNode(processNode1);
            RectangleNode processNode2 = new RectangleNode()
            {
                Position = new Point(644, 280),
                Description = "Process 2.1"
            };
            this.AddNode(processNode2);
            RectangleNode processNode3 = new RectangleNode()
            {
                Position = new Point(644, 420),
                Description = "Process 2.2"
            };
            this.AddNode(processNode3);
            RectangleNode processNode4 = new RectangleNode()
            {
                Position = new Point(644, 140),
                Description = "Process 2.3"
            };
            this.AddNode(processNode4);
            RectangleNode processNode5 = new RectangleNode()
            {
                Position = new Point(880, 280),
                Description = "Process 3"
            };
            this.AddNode(processNode5);
            RectangleNode processNode6 = new RectangleNode()
            {
                Position = new Point(420, 420),
                Description = "Process A"
            };
            this.AddNode(processNode6);
            RectangleNode processNode7 = new RectangleNode()
            {
                Position = new Point(160, 420),
                Description = "Process B"
            };
            this.AddNode(processNode7);

            DecisionNode decisionNode = new DecisionNode()
            {
                Position = new Point(420, 280),
                Content = "condition"
            };
            this.AddNode(decisionNode);
            EllipseNode endNode = new EllipseNode()
            {
                Position = new Point(1100, 300),
                Type = EllipseNodeType.End
            };
            this.AddNode(endNode);
            EllipseNode startNode = new EllipseNode()
           {
               Position = new Point(60, 300),
               Type = EllipseNodeType.Start,
               Content = "Start"
           };
            this.AddNode(startNode);

            //Add Links
            this.AddLink(new Link(startNode, processNode1) { Type = LinkType.LeftToRight });
            this.AddLink(new Link(processNode1, decisionNode) { Type = LinkType.LeftToRight });
            this.AddLink(new Link(decisionNode, processNode2) { Type = LinkType.LeftToRight });
            this.AddLink(new Link(processNode2, processNode3) { Type = LinkType.Normal });
            this.AddLink(new Link(processNode2, processNode4) { Type = LinkType.Normal });
            this.AddLink(new Link(processNode2, processNode5) { Type = LinkType.LeftToRight });
            this.AddLink(new Link(processNode3, processNode5) { Type = LinkType.LeftToRight });
            this.AddLink(new Link(processNode4, processNode5) { Type = LinkType.LeftToRight });
            this.AddLink(new Link(processNode5, endNode) { Type = LinkType.LeftToRight });
            this.AddLink(new Link(processNode6, decisionNode) { Type = LinkType.RightToLeft });
            this.AddLink(new Link(processNode7, processNode6) { Type = LinkType.RightToLeft });
            this.AddLink(new Link(processNode1, processNode7) { Type = LinkType.RightToLeft });
        }
    }
#endregion
#region raddiagram-howto-mvvm-style-selectors-3
public MainView()
{
    InitializeComponent();

    GraphSource DiagramSource = new GraphSource();
    DiagramSource.PopulateGraphSource();
    this.xDiagram.GraphSource = DiagramSource;
}
#endregion
#region raddiagram-howto-mvvm-style-selectors-4
public class NodeStyleSelector : StyleSelector
{
    public Style DecisionNodeStyle { get; set; }
    public Style StartNodeStyle { get; set; }
    public Style EndNodeStyle { get; set; }
    public Style RectangleNodeStyle { get; set; }

    public override Style SelectStyle(object item, DependencyObject container)
    {
        if (item is DecisionNode)
            return DecisionNodeStyle;
        else if (item is RectangleNode)
            return RectangleNodeStyle;
        else if (item is EllipseNode)
        {
            switch (((EllipseNode)item).Type)
            {
                case EllipseNodeType.Start:
                    return StartNodeStyle;
                case EllipseNodeType.End:
                    return EndNodeStyle;
                default:
                    return base.SelectStyle(item, container);
            }
        }
        else return base.SelectStyle(item, container);
    }
}
#endregion
#region raddiagram-howto-mvvm-style-selectors-5
    public class LinkStyleSelector : StyleSelector
    {
        public Style NormalLinkStyle { get; set; }
        public Style RightCapLinkStyle { get; set; }
        public Style LeftCapLinkStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            Link link = item as Link;
            if (link == null)
                return base.SelectStyle(item, container);
            else switch (link.Type)
                {
                    case LinkType.RightToLeft:
                        return LeftCapLinkStyle;
                    case LinkType.LeftToRight:
                        return RightCapLinkStyle;
                    case LinkType.Normal:
                        return NormalLinkStyle;
                    default:
                        return base.SelectStyle(item, container);
                }
        }
    }
#endregion