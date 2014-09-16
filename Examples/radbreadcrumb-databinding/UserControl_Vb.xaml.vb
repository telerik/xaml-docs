Public Class Default_Vb


' #region radbreadcrumb-databinding_1
Public Class ExplorerItem
        Public Property Header() As String
                Get
                        Return _Header
                End Get
                Set
                        _Header = Value
                End Set
        End Property
        Private _Header As String
        Public Property PreviewHeader() As String
                Get
                        Return _PreviewHeader
                End Get
                Set
                        _PreviewHeader = Value
                End Set
        End Property
        Private _PreviewHeader As String
        Public Property Path() As String
                Get
                        Return _Path
                End Get
                Set
                        _Path = Value
                End Set
        End Property
        Private _Path As String
        Public Property IconPath() As ImageSource
                Get
                         Return _IconPath
                End Get
                Set
                         _IconPath = Value
                End Set
        End Property
        Private _IconPath As ImageSource
End Class
' #endregion

' #region radbreadcrumb-databinding_3
Public Class MainViewModel
	Public Property Items() As ObservableCollection(Of ExplorerItem)
		Get
			Return m_Items
		End Get
		Set
			m_Items = Value
		End Set
	End Property
	Private m_Items As ObservableCollection(Of ExplorerItem)
	Public Property Header() As String
		Get
			Return m_Header
		End Get
		Set
			m_Header = Value
		End Set
	End Property
	Private m_Header As String
	Public Sub New()
		Dim isc As New ImageSourceConverter()
		Me.Header = "MyComputer"
		Me.Items = New ObservableCollection(Of ExplorerItem)()
		Dim personalInfo As New ExplorerItem() With { _
			Key .Header = "Personal Folders", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/1PersonalFolders.png"), ImageSource), _
			Key .Path = "PersonalFolders" _
		}
		Me.Items.Add(personalInfo)
		Dim programFiles As New ExplorerItem() With { _
			Key .Header = "Program Files", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder2.png"), ImageSource), _
			Key .Path = "ProgramFiles" _
		}
		Me.Items.Add(programFiles)
		Dim programFiles86 As New ExplorerItem() With { _
			Key .Header = "Program Files(86)", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder2.png"), ImageSource), _
			Key .Path = "ProgramFiles(86)" _
		}
		Me.Items.Add(programFiles86)
		Dim downloads As New ExplorerItem() With { _
			Key .Header = "Downloads", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder2.png"), ImageSource), _
			Key .Path = "Downloads" _
		}
		Me.Items.Add(downloads)
		Dim localHard As New ExplorerItem() With { _
			Key .Header = "Local Disk (C:)", _
			Key .Path = "LocalDisk(C:)", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/HardDrive16.png"), ImageSource) _
		}
		Me.Items.Add(localHard)
		Dim localHard2 As New ExplorerItem() With { _
			Key .Header = "Local Disk (D:)", _
			Key .Path = "LocalDisk(D:)", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/HardDrive16.png"), ImageSource) _
		}
		Me.Items.Add(localHard2)
		Dim desktop As New ExplorerItem() With { _
			Key .Header = "Desktop", _
			Key .Path = "Desktop", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/Desktop.png"), ImageSource) _
		}
		Me.Items.Add(desktop)
	End Sub
End Class
' #endregion

' #region radbreadcrumb-databinding_6
Public Class ExplorerItem
	Public Property Header() As String
		Get
			Return m_Header
		End Get
		Set
			m_Header = Value
		End Set
	End Property
	Private m_Header As String
	Public Property PreviewHeader() As String
		Get
			Return m_PreviewHeader
		End Get
		Set
			m_PreviewHeader = Value
		End Set
	End Property
	Private m_PreviewHeader As String
	Public Property Path() As String
		Get
			Return m_Path
		End Get
		Set
			m_Path = Value
		End Set
	End Property
	Private m_Path As String
	Public Property IconPath() As ImageSource
		Get
			Return m_IconPath
		End Get
		Set
			m_IconPath = Value
		End Set
	End Property
	Private m_IconPath As ImageSource
	Public Property Children() As ObservableCollection(Of ExplorerItem)
		Get
			Return m_Children
		End Get
		Set
			m_Children = Value
		End Set
	End Property
	Private m_Children As ObservableCollection(Of ExplorerItem)
	Public Sub New()
		Me.Children = New ObservableCollection(Of ExplorerItem)()
	End Sub
End Class
' #endregion

' #region radbreadcrumb-databinding_8
Public Class MainViewModel
	Public Property Items() As ObservableCollection(Of ExplorerItem)
		Get
			Return m_Items
		End Get
		Set
			m_Items = Value
		End Set
	End Property
	Private m_Items As ObservableCollection(Of ExplorerItem)
	Public Property Root() As ExplorerItem
		Get
			Return m_Root
		End Get
		Set
			m_Root = Value
		End Set
	End Property
	Private m_Root As ExplorerItem
	Public Sub New()
		Me.Items = New ObservableCollection(Of ExplorerItem)()
		Me.LoadItems()
	End Sub
	Public Sub LoadItems()
		Dim isc As New ImageSourceConverter()
		Dim personalInfo As New ExplorerItem() With { _
			Key .Header = "Personal Folders", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/1PersonalFolders.png"), ImageSource), _
			Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
				New ExplorerItem() With { _
					Key .Header = "Deleted Items(6)", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/2DeletedItems.png"), ImageSource), _
					Key .Path = "DeletedItems" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Drafts", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/3Drafts.png"), ImageSource), _
					Key .Path = "Drafts" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Inbox(14)", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/4Inbox.png"), ImageSource), _
					Key .Path = "Inbox", _
					Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
						New ExplorerItem() With { _
							Key .Header = "Folders", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
							Key .Path = "Folders" _
						} _
					} _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Junk E-mails", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/junk.png"), ImageSource), _
					Key .Path = "JunkEmails" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Outbox", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/outbox.png"), ImageSource), _
					Key .Path = "Outbox" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Sent Items", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/sent.png"), ImageSource), _
					Key .Path = "SentItems" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Search Folder", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/searchFolder.png"), ImageSource), _
					Key .Path = "SearchFolder", _
					Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
						New ExplorerItem() With { _
							Key .Header = "From Follow up", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/search.png"), ImageSource), _
							Key .Path = "FromFollowup" _
						}, _
						New ExplorerItem() With { _
							Key .Header = "Large Mail", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/search.png"), ImageSource), _
							Key .Path = "LargeMail" _
						}, _
						New ExplorerItem() With { _
							Key .Header = "Unread Mail", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/search.png"), ImageSource), _
							Key .Path = "UnreadMail" _
						} _
					} _
				} _
			}, _
			Key .Path = "PersonalFolders" _
		}
		Dim programFiles As New ExplorerItem() With { _
			Key .Header = "Program Files", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder2.png"), ImageSource), _
			Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
				New ExplorerItem() With { _
					Key .Header = "Microsoft", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
					Key .Path = "Microsoft" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Microsoft.NET", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
					Key .Path = "Microsoft.NET" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Internet Explorer", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder2.png"), ImageSource), _
					Key .Path = "InternetExplorer", _
					Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
						New ExplorerItem() With { _
							Key .Header = "SIGNUP", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
							Key .Path = "SIGNUP" _
						} _
					} _
				} _
			}, _
			Key .Path = "ProgramFiles" _
		}
		Dim programFiles86 As New ExplorerItem() With { _
			Key .Header = "Program Files(86)", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder2.png"), ImageSource), _
			Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
				New ExplorerItem() With { _
					Key .Header = "Microsoft", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
					Key .Path = "Microsoft" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Microsoft.NET", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
					Key .Path = "Microsoft.NET" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Skype", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder2.png"), ImageSource), _
					Key .Path = "Skype", _
					Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
						New ExplorerItem() With { _
							Key .Header = "Phone", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
							Key .Path = "Phone" _
						}, _
						New ExplorerItem() With { _
							Key .Header = "Toolbars", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
							Key .Path = "Toolbars" _
						}, _
						New ExplorerItem() With { _
							Key .Header = "Plugin Manager", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
							Key .Path = "PluginManager" _
						} _
					} _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Notepad++", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder2.png"), ImageSource), _
					Key .Path = "Notepad++", _
					Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
						New ExplorerItem() With { _
							Key .Header = "localization", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
							Key .Path = "localization" _
						}, _
						New ExplorerItem() With { _
							Key .Header = "plugins", _
							Key .IconPath = DirectCast(isc.ConvertFromString("Images/junk.png"), ImageSource), _
							Key .Path = "plugins" _
						} _
					} _
				} _
			}, _
			Key .Path = "ProgramFiles(86)" _
		}
		Dim downloads As New ExplorerItem() With { _
			Key .Header = "Downloads", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder2.png"), ImageSource), _
			Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
				New ExplorerItem() With { _
					Key .Header = "Music", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
					Key .Path = "Music" _
				}, _
				New ExplorerItem() With { _
					Key .Header = "Movies", _
					Key .IconPath = DirectCast(isc.ConvertFromString("Images/folder.png"), ImageSource), _
					Key .Path = "Movies" _
				} _
			}, _
			Key .Path = "Downloads" _
		}
		Dim localHard As New ExplorerItem() With { _
			Key .Header = "Local Disk (C:)", _
			Key .Path = "LocalDisk(C:)", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/HardDrive16.png"), ImageSource), _
			Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
				personalInfo, _
				programFiles, _
				programFiles86, _
				downloads _
			} _
		}
		Dim localHard2 As New ExplorerItem() With { _
			Key .Header = "Local Disk (D:)", _
			Key .Path = "LocalDisk(D:)", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/HardDrive16.png"), ImageSource) _
		}
		Dim computer As New ExplorerItem() With { _
			Key .Header = "Computer", _
			Key .Path = "Computer", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/Computer.png"), ImageSource), _
			Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
				localHard, _
				localHard2 _
			} _
		}
		Dim computer2 As New ExplorerItem() With { _
			Key .Header = "Computer2", _
			Key .Path = "Computer2", _
			Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
				localHard, _
				localHard2 _
			} _
		}
		Me.Root = New ExplorerItem() With { _
			Key .Header = "Desktop", _
			Key .Path = "Desktop", _
			Key .IconPath = DirectCast(isc.ConvertFromString("Images/Desktop.png"), ImageSource), _
			Key .Children = New ObservableCollection(Of ExplorerItem)() From { _
				computer, _
				computer2 _
			} _
		}
		Me.Items = New ObservableCollection(Of ExplorerItem)() From { _
			Me.Root _
		}
	End Sub
End Class
' #endregion
End Class
