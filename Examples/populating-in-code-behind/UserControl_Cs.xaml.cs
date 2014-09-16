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

#region populating-in-code-behind_1
RadRatingItem ratingItem = new RadRatingItem();
this.radRating.Items.Add(ratingItem);
#endregion

#region populating-in-code-behind_3
this.radRating.Items.Clear(); 
RadRatingItem ratingItem = new RadRatingItem();
ratingItem.Content = "1";
this.radRating.Items.Add(ratingItem);
ratingItem = new RadRatingItem();
ratingItem.Content = "2";
this.radRating.Items.Add(ratingItem);
#endregion

#region populating-in-code-behind_5
private void RemoveRatingItem( RadRatingItem itemToRemove )
{
   this.radRating.Items.Remove( itemToRemove );
}
#endregion
}
