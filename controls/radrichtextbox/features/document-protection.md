---
title: Document Protection
page_title: Document Protection
description: Document Protection
slug: radrichtextbox-features-document-protection
tags: document,protection
published: True
---

# Document Protection



__Document Protection__ allows defining and enforcing different editing restrictions in the document for a set of users and groups.
      

This article describes how this feature can be used in terms of UI and API of __RadRichTextBox__.
      

* [Defining Users](#defining-the-users)

* [Changing the Current User](#changing-the-current-user)

* [Toggling Document Protection](#toggling-document-protection)

* [Creating And Modifying Document Protection Regions](#creating-and-modifying-document-protection-regions)

## Defining the Users

The editing restrictions can be used with a set of users or groups. When document protection is enforced, each user will be able to edit only the parts of the document he/she has rights for and the parts that are editable by the group he/she belongs to.
        
The __PermissionInfo__ class allows you to create permission objects, which later can be assigned to instances of the __UserInfo__ class through the Group property. The permission type could be declared as Everyone, Group or Individual using the values of the {% if site.site_name == 'Silverlight' %}[PermissionType](http://docs.telerik.com/devtools/silverlight/api/html/T_Telerik_Windows_Documents_Model_PermissionType.htm){% endif %}{% if site.site_name == 'WPF' %}[PermissionType](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Model_PermissionType.htm){% endif %}  enumeration. 

The users that will be able to edit the document and the groups they are in can be declared like this:

#### __[C#] Example 1: Set Permissions to Users__

{{region radrichtextbox-features-document-protection_0}}
	this.editor.Users = new PermissionInfoCollection() 
	                {
	                    PermissionInfo.CreateEveryonePermissionInfo(),
	                    new PermissionInfo("jmiller", PermissionType.Individual, "James Miller"),
	                    new PermissionInfo("jsmith", PermissionType.Individual, "John Smith"),
	                    new PermissionInfo("rbrown", PermissionType.Individual, "Robert Brown"),
	                    new PermissionInfo("Administrators", PermissionType.Group, "Administrators"),
	                };
{{endregion}}



The code from __Example 1__ determines 3 users and two groups but does not specify the relationship between the users and the groups. This is so because users have the potential to change their groups.
        

The collection kept in the Users property of __RadRichTextBox__ is also used in the default __ChangeEditingPermissionsDialog__ which creates the PermissionRangeInfos to be inserted in the document.
        

## Changing the Current User

The current user of the document is set using the __CurrentUser__ property of the editor. It is of type __UserInfo__ - here in addition to the name, e-mail and user name of the user, the group that the user belongs to can also be passed.
        

#### __[C#] Example 2: Change CurrentUser__

{{region radrichtextbox-features-document-protection_1}}
	this.editor.CurrentUser = new UserInfo("Users", "James Miller", "jmiller", "jmiller@example.com");
{{endregion}}



You can also create a collection with the UserInfos that will be interracting with the document and wire it with some UI of yours. For example, if you set-up the collection as follows:
        

#### __[C#] Example 3: Create Collection of UserInfo objects__

{{region radrichtextbox-features-document-protection_2}}
	PermissionInfoCollection CurrentUsers = new List<UserInfo>() 
	                {
	                    new UserInfo("Users", "James Miller", "jmiller", "jmiller@example.com"),
	                    new UserInfo("Administrators", "John Smith", "jsmith", "jsmith@example.com"),
	                    new UserInfo("Administrators", "Robert Brown", "rbrown", "rbrown@example.com"),
	                };
{{endregion}}



You can declare a __RadComboBox__ which will be used to change the current user in the following way:

#### __[XAML] Example 1: Declaring RadComboBox__

{{region radrichtextbox-features-document-protection_0}}
	<telerik:RadRibbonComboBox x:Name="comboBoxLoggedUser" Height="23" Width="150" DisplayMemberPath="RealName" SelectionChanged="comboBoxLoggedUser_SelectionChanged" />
{{endregion}}



and populate it like this:

#### __[C#] Example 4: Populating RadComboBox__

{{region radrichtextbox-features-document-protection_3}}
	this.comboBoxLoggedUser.ItemsSource = dataContext.CurrentUsers;
	this.comboBoxLoggedUser.SelectedIndex = 0;
{{endregion}}



Then, when the selected item of the combo changes, the CurrentUser of the editor will be updated:

#### __[C#] Example 5: Update CurrentUser__

{{region radrichtextbox-features-document-protection_4}}
	private void comboBoxLoggedUser_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
	{
	    this.editor.CurrentUser = this.comboBoxLoggedUser.SelectedItem as UserInfo;
	}
{{endregion}}



## Toggling Document Protection

When document protection is enforced, the current user can modify the rights for editing the part of the document that he/she is entitled to editing. When the protection is disabled, the editing rights for the document can be freely modified by all users.
        

The protection of the document can be turned on and off using the __ToggleDocumentProtectionCommand__ command of RadRichTextBox.
        

The command opens a dialog that allows you to enter a password. By clicking OK, the document protection starts to be enforced. You can use the command by binding a button to it:
        

#### __[XAML] Example 2: Binding a button to ToggleDocumentProtectionCommand__

{{region radrichtextbox-features-document-protection_1}}
	<telerik:RadRibbonToggleButton DataContext="{Binding ElementName=editor, Path=Commands}"  LargeImage="/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/32/ProtectDocument.png" telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=ToggleDocumentProtectionCommand}" Size="Large" Text="Protect Document" telerik:ScreenTip.Title="Toggle Document Protection" telerik:ScreenTip.Description="Restrict how people edit specific parts of the document." />
{{endregion}}



It is also possible to toggle document protection in code-behind, without showing a dialog:

#### __[C#] Example 6: Protect Document in Code-Behind__

{{region radrichtextbox-features-document-protection_5}}
	this.editor.Document.ProtectDocument(DocumentProtectionMode.ReadOnly, "password");
{{endregion}}



The reverse operations can be executed like this:

#### __[C#] Example 7: Unprotect Document in Code-Behind__

{{region radrichtextbox-features-document-protection_6}}
	this.editor.Document.UnprotectDocument("password");
{{endregion}}



Note that the UnprotectDocument method will succeed only if the password you have passed as parameter matches the one used to protect the document.

## Creating and Modifying Document Protection Regions

DocumentProtection regions can be most easily created and modified through the ChangeEditingPermissionsDialog which can be invoked through the __ShowChangeEditingPermissionsDialogCommand__ of __RadRichTextBox__. They can also be edited in code-behind, using the API of RadRichTextBox and RadDocument.
        

Here is an example:

#### __[C#] Example 8: Editing Permissions__

{{region radrichtextbox-features-document-protection_7}}
	PermissionRangeInfo info = new PermissionRangeInfo();
	info.Type = PermissionType.Individual;
	info.Name = this.editor.CurrentUser.Username;
	List<PermissionRangeInfo> infos = new List<PermissionRangeInfo>() { info };
	this.editor.InsertPermissionRange(infos);
{{endregion}}



This code will insert a permission range around the current selection in the document. The type of the permissionis Individual - meaning that only the CurrentUser will be able to edit the region.
        

# See Also

 * [Selection]({%slug radrichtextbox-features-selection%})

 * [Positioning]({%slug radrichtextbox-features-positioning%})
