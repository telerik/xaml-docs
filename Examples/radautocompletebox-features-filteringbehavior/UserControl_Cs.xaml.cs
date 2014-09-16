using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using Telerik.Windows.Controls;

namespace AutoCompleteBoxExample
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
	
public class DummyClass
{
#region radautocompletebox-features-filteringbehavior-0
public class MyCustomFilteringBehavior : FilteringBehavior
{

}
#endregion 
}

#region radautocompletebox-features-filteringbehavior-1
public class MyCustomFilteringBehavior : FilteringBehavior
{
	public override IEnumerable<object> FindMatchingItems(string searchText, IList items, IEnumerable<object> escapedItems, string textSearchPath, TextSearchMode textSearchMode)
	{
		var result = base.FindMatchingItems(searchText, items, escapedItems, textSearchPath, textSearchMode) as IEnumerable<object>;
 
		if (string.IsNullOrEmpty(searchText) || !result.Any())
		{
			return ((IEnumerable<object>)items).Where(x => !escapedItems.Contains(x));
		}

		return result;
	}
}
#endregion
}