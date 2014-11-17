#region raddiagram-data-databinding-0
public interface IGraphSource
{
    IEnumerable<ILink> Links { get; }
    IEnumerable Items { get; }
}

public interface IGraphSource<T> : IGraphSource
{
    new IEnumerable<ILink<T>> Links { get; }
    new IEnumerable<T> Items { get; }
}
#endregion

#region raddiagram-data-databinding-1
public class PascalNode
{
    public Point Position
    {
        get;
        set;
    }
    public int PascalNumber
    {
        get;
        set;
    }
}
#endregion

#region raddiagram-data-databinding-2
public class PascalEdge : ILink<PascalNode>
{
    public PascalNode Source
    {
        get;
        set;
    }

    public PascalNode Target
    {
        get;
        set;
    }

    object ILink.Source
    {
        get
        {
            return this.Source;
        }
        set
        {
        }

    }

    object ILink.Target
    {
        get
        {
            return this.Target;
        }
        set
        {
        }
    }
}
#endregion

#region raddiagram-data-databinding-3
public class PascalTriangleGraphSource : IGraphSource
{
    public PascalTriangleGraphSource()
    {
        this.InternalItems = new ObservableCollection<PascalNode>();
        this.InternalEdges = new ObservableCollection<PascalEdge>();
    }

    public ObservableCollection<PascalNode> InternalItems
    {
        get;
        private set;
    }

    public ObservableCollection<PascalEdge> InternalEdges
    {
        get;
        private set;
    }

    IEnumerable<ILink> IGraphSource.Links
    {
        get { return this.InternalEdges; }
    }

    System.Collections.IEnumerable IGraphSource.Items
    {
        get { return this.InternalItems; }
    }
}
#endregion

#region raddiagram-data-databinding-4
const int ROOT_X_Position = 400;
const int ROOT_Y_Position = 20;
const int X_DELIMITER_WIDTH = 80;
const int Y_DELIMITER_HEIGHT = 60;
const int X_START_NEGATIVE_OFFSET = 40;       

private IGraphSource CreatePascalTriangleGraphSource(int levels)
{
    PascalTriangleGraphSource graph = new PascalTriangleGraphSource();
    for (int i = 0; i < levels; i++)
    {
        for (int j = 0; j < i + 1; j++)
        {
            PascalNode node = new PascalNode()
            {
                Position = new Point() 
                {
                    Y = ROOT_Y_Position + i * Y_DELIMITER_HEIGHT,
                    X = ROOT_X_Position - i * X_START_NEGATIVE_OFFSET + j * X_DELIMITER_WIDTH 
                },
                PascalNumber = Binom(i, j)
            };
            graph.InternalItems.Add(node);  
            int currIndex = i * (i + 1) / 2 + j;
            if (j == 0) graph.InternalEdges.Add(new PascalEdge() { Source = graph.InternalItems[currIndex - i], Target = node });
            if (j == i && i != 0) graph.InternalEdges.Add(new PascalEdge() { Source = graph.InternalItems[currIndex - i - 1], Target = node });
            if (0 < j && j < i)
            {
                graph.InternalEdges.Add(new PascalEdge() { Source = graph.InternalItems[currIndex - i - 1], Target = node });
                graph.InternalEdges.Add(new PascalEdge() { Source = graph.InternalItems[currIndex - i], Target = node });
            }
        }                
    }
    return graph;
}

private int Binom(int n, int k)
{           
    return FactN(n) / (FactN(k) * FactN(n -k));            
}

private int FactN(int n)
{
    if (n == 0 || n == 1) return 1;
    int res = 1;
    for (int i = 1; i <= n; i++)
    {
        res = res * i;
    }           
    return res;
}
#endregion

#region raddiagram-data-databinding-5
public class Person : NodeViewModelBase 
{ 
	public Person(string name) 
	{ 
		this.Name = name; 
	} 
 
	public string Name 
	{ 
		get 
		{ 
			return this.Content.ToString(); 
		} 
		set 
		{ 
			this.Content = value; 		 
			this.OnPropertyChanged("Name"); 
		} 
	} 
 
	public override string ToString() 
	{ 
		return this.Name; 
	} 
}
#endregion
#region raddiagram-data-databinding-6
public class DataStore : ObservableGraphSourceBase<NodeViewModelBase, LinkViewModelBase<NodeViewModelBase>> 
	{ 
		public DataStore() 
		{ 
			this.AddNode(new Person("Johnny Carter")); 
			this.AddNode(new Person("Alexandra Morgan")); 
			this.AddNode(new Person("Jeff Kadensky")); 
		}

		public override void AddNode(NodeViewModelBase node)
		{
			if (!(node is Person)) node = new Person("New Person!");
			base.AddNode(node);
		}
	}
#endregion