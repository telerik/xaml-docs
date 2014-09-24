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

#region radrichtextbox-features-track-changes_0
this.radRichTextBox.IsTrackChangesEnabled = true;
#endregion

#region radrichtextbox-features-track-changes_1
this.radRichTextBox.TrackChangesOptions.Insert.Decoration = RevisionDecoration.ColorOnly;
this.radRichTextBox.TrackChangesOptions.Insert.ColorOptions = new RevisionColor(Colors.Green);

this.radRichTextBox.TrackChangesOptions.Delete.Decoration = RevisionDecoration.Underline;
this.radRichTextBox.TrackChangesOptions.Delete.ColorOptions = new RevisionColor(Colors.Orange);

this.radRichTextBox.TrackChangesOptions.ChangedLinesDecorationColorOptions.ColorOptions = new RevisionColor(Colors.Red);
#endregion

#region radrichtextbox-features-track-changes_2
this.radRichTextBox.CurrentUser = new UserInfo("Group", "Boby", "Boby", "bobby@telerik.com");
#endregion

#region radrichtextbox-features-track-changes_3
public Revision GoToPreviousRevision()
public Revision GoToNextRevision()
public Revision GetCurrentRevision()
public Revision GetNextRevision()
public Revision GetPreviousRevision()
public IEnumerable<Revision> GetAllRevisions()
#endregion

#region radrichtextbox-features-track-changes_4
public void AcceptRevision(Revision revision)
public void RejectRevision(Revision revision)
#endregion
}
