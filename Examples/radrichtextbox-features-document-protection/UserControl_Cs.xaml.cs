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

#region radrichtextbox-features-document-protection_0
this.editor.Users = new PermissionInfoCollection() 
                {
                    PermissionInfo.CreateEveryonePermissionInfo(),
                    new PermissionInfo("jmiller", PermissionType.Individual, "James Miller"),
                    new PermissionInfo("jsmith", PermissionType.Individual, "John Smith"),
                    new PermissionInfo("rbrown", PermissionType.Individual, "Robert Brown"),
                    new PermissionInfo("Administrators", PermissionType.Group, "Administrators"),
                };
#endregion

#region radrichtextbox-features-document-protection_1
this.editor.CurrentUser = new UserInfo("Users", "James Miller", "jmiller", "jmiller@example.com");
#endregion

#region radrichtextbox-features-document-protection_2
PermissionInfoCollection CurrentUsers = new List<UserInfo>() 
                {
                    new UserInfo("Users", "James Miller", "jmiller", "jmiller@example.com"),
                    new UserInfo("Administrators", "John Smith", "jsmith", "jsmith@example.com"),
                    new UserInfo("Administrators", "Robert Brown", "rbrown", "rbrown@example.com"),
                };
#endregion

#region radrichtextbox-features-document-protection_3
this.comboBoxLoggedUser.ItemsSource = dataContext.CurrentUsers;
this.comboBoxLoggedUser.SelectedIndex = 0;
#endregion

#region radrichtextbox-features-document-protection_4
private void comboBoxLoggedUser_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
{
    this.editor.CurrentUser = this.comboBoxLoggedUser.SelectedItem as UserInfo;
}
#endregion

#region radrichtextbox-features-document-protection_5
this.editor.Document.ProtectDocument(DocumentProtectionMode.ReadOnly, "password");
#endregion

#region radrichtextbox-features-document-protection_6
this.editor.Document.UnprotectDocument("password");
#endregion

#region radrichtextbox-features-document-protection_7
PermissionRangeInfo info = new PermissionRangeInfo();
info.Type = PermissionType.Individual;
info.Name = this.editor.CurrentUser.Username;
List<PermissionRangeInfo> infos = new List<PermissionRangeInfo>() { info };
this.editor.InsertPermissionRange(infos);
#endregion


}
