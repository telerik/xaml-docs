using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
    }

    #region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_1
    class MyFilteringControl : FilteringControl
    {
        public MyFilteringControl(Telerik.Windows.Controls.GridViewColumn column) : base(column)
        {         

        }        
       
        protected override void OnApplyFilter()
        {
            base.OnApplyFilter();

            var popup = this.ParentOfType<System.Windows.Controls.Primitives.Popup>();
            if (popup != null)
            {
                popup.IsOpen = false;
            }           
        }
    }
    #endregion

    #region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_2
     this.clubsGrid.Columns["Name"].FilteringControl = new MyFilteringControl(this.clubsGrid.Columns["Name"]);
    #endregion

    #region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_3
    var FilterDialogs = this.clubsGrid.ChildrenOfType<Popup>().Where(p => p.Name == "PART_DropDownPopup");
    if (FilterDialogs != null)
    foreach (Popup FilterDialog in FilterDialogs)
    {
        if (FilterDialog.IsOpen)
            FilterDialog.IsOpen = false;
    }
     #endregion
}
