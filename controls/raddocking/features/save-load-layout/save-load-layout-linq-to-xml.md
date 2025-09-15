---
title: Save/load Layout with LINQ to XML
page_title: Save/load Layout with LINQ to XML
description: Check our &quot;Save/load Layout with LINQ to XML&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-features-save-load-layout-linq-to-xml
tags: save/load,layout,with,linq,to,xml
published: True
position: 3
---

# Save/load Layout with LINQ to XML

In many scenarios when creating an application that requires a more complex and flexible layout using __RadDocking__ control as a layout layer is the way to go. One of the built-in features that enrich the control’s functionality is the ability to easily save and load the state of the entire RadDocking control’s layout. The built-in __SaveLayout/LoadLayout__ functionality of the control uses XML in order to serialize and deserialize the state of the RadSplitContainer, RadPaneGroup, RadPane and RadDocumentPane instances in the control. XML is widely adopted and use as a way of formatting data in many contexts. Unfortunately working with XML is not a straight forward and easy task when customizing its notes and value is required. In scenarios where reordering and working with collections has been required developers turn to use the well known LINQ library. In the latest versions of .NET Framework a support for “LINQ to XML” has been provided in order to ease the described tasks.
            
## 

>Make sure that the __System.Xml.Linq__ assembly is included in the project.
                    
Create a new application and add the following declaration.
                
#### __XAML__

```XAML
	<Grid>
	    <Grid.RowDefinitions>
	        <RowDefinition Height="Auto"/>
	        <RowDefinition Height="*"/>
	    </Grid.RowDefinitions>
	    <StackPanel>
	        <Button Content="Save layout to XElement" 
	Click="OnSaveLayoutButtonClick"/>
	        <Button Content="Load layout from XElement" 
	Click="OnLoadLayoutButtonClick"
	x:Name="LoadLayoutFromXElementButton"/>
	    </StackPanel>
	    <telerik:RadDocking x:Name="radDocking"
	Grid.Row="1">
	        <telerik:RadDocking.DocumentHost>
	
	            <telerik:RadSplitContainer>
	                <telerik:RadPaneGroup x:Name="DocumentGroup">
	                    <telerik:RadPane x:Name="LayoutXml" Header="Layout Xml"
	                telerik:RadDocking.SerializationTag="LayoutXml"
	                telerik:RadDocking.FloatingSize="450, 400">
	                        <TextBox TextWrapping="Wrap" x:Name="XmlTextBox"
	            VerticalScrollBarVisibility="Auto"
	            Text="{Binding Xml, Mode=TwoWay}" />
	                    </telerik:RadPane>
	                    <telerik:RadDocumentPane Header="Document 1" Title="Document 1"
	                        telerik:RadDocking.SerializationTag="DocumentPane">
	                        <TextBox x:Name="DocumentTextBox" Text="Some text" />
	                    </telerik:RadDocumentPane>
	                </telerik:RadPaneGroup>
	            </telerik:RadSplitContainer>
	
	        </telerik:RadDocking.DocumentHost>
	
	        <telerik:RadSplitContainer InitialPosition="DockedLeft">
	            <telerik:RadPaneGroup>
	                <telerik:RadPane Header="Pane Left 1"
	            telerik:RadDocking.SerializationTag="PaneLeft1">
	                    <TextBox x:Name="TextBox" Text="Some other text" />
	                </telerik:RadPane>
	                <telerik:RadPane Header="Pane Left 2"
	            telerik:RadDocking.SerializationTag="PaneLeft2">
	                    <TextBox Text="Pane Left 2" />
	                </telerik:RadPane>
	                <telerik:RadPane Header="Pane Left 3"
	            telerik:RadDocking.SerializationTag="PaneLeft3">
	                    <TextBox Text="Pane Left 3" />
	                </telerik:RadPane>
	                <telerik:RadPane Header="Pane Left 4"
	            telerik:RadDocking.SerializationTag="PaneLeft4">
	                    <TextBox Text="Pane Left 4" />
	                </telerik:RadPane>
	            </telerik:RadPaneGroup>
	        </telerik:RadSplitContainer>
	
	        <telerik:RadSplitContainer InitialPosition="DockedRight">
	            <telerik:RadPaneGroup>
	                <telerik:RadPane Header="Pane Right 1"
	            telerik:RadDocking.SerializationTag="PaneRight1">
	                    <telerik:RadTreeView>
	                        <telerik:RadTreeViewItem Header="RootItem">
	                            <telerik:RadTreeViewItem Header="Item1" />
	                            <telerik:RadTreeViewItem Header="Item2">
	                                <telerik:RadTreeViewItem Header="Item21" />
	                                <telerik:RadTreeViewItem Header="Item22" />
	                                <telerik:RadTreeViewItem Header="Item23">
	                                    <telerik:RadTreeViewItem Header="Item231" />
	                                </telerik:RadTreeViewItem>
	                            </telerik:RadTreeViewItem>
	                            <telerik:RadTreeViewItem Header="Item3" />
	                        </telerik:RadTreeViewItem>
	                    </telerik:RadTreeView>
	                </telerik:RadPane>
	            </telerik:RadPaneGroup>
	        </telerik:RadSplitContainer>
	
	        <telerik:RadSplitContainer InitialPosition="DockedTop">
	            <telerik:RadPaneGroup>
	                <telerik:RadPane Header="Pane Top 1"
	            telerik:RadDocking.SerializationTag="PaneTop1">
	                    <TextBox Text="Pane Top 1" />
	                </telerik:RadPane>
	            </telerik:RadPaneGroup>
	        </telerik:RadSplitContainer>
	    </telerik:RadDocking>
	</Grid>
```

## Save layout’s XML to XElement

Example 1 shows how you can convert the generated XML from the SaveLayout functionality of the RadDocking control into valid XElement:

* Create a new instance of a __MemoryStream__ that will be used to temporary store the generated XML from the built-in SaveLayout functionality of the RadDocking control.

* Use the __SaveLayout__ method of the control with the above temporary MemoryStream object.

* Create a field of __XElement__ type in which the converter structure from the XML will be stored.

* Use the static __Load__ method of the XElement class with the temporary MemoryStream object in order to convert it to XElement

#### __C#__

```C#
	private XElement dockingLayout;
	
	private void OnSaveLayoutButtonClick(object sender, RoutedEventArgs e)
	{
	    this.dockingLayout = this.GetXLayoutAsElement();
	}
	
	private XElement GetXLayoutAsElement()
	{
	    var destinationStream = new MemoryStream();
	    this.radDocking.SaveLayout(destinationStream);
	    destinationStream.Seek(0, SeekOrigin.Begin);
	
	    return XElement.Load(destinationStream);
	}
```

## Load layout’s from XElement

Example 2 shows how to load a RadDocking control's layout stored as valid XElement object:


* Create a temporary object of __MemoryStream__ which will be used by the LoadLayout method of the control.


* Use the __Save__ method of the XElement class and pass the temporary MemoryStream object as parameter.


* Call the __LoadLayout__ method of the control with the temporary MemoryStream object.

#### __C#__

```C#
	private void OnLoadLayoutButtonClick(object sender, RoutedEventArgs e)
	{
	    MemoryStream sourceAsStream = new MemoryStream();
	    this.dockingLayout.Save(sourceAsStream);
	    sourceAsStream.Seek(0, SeekOrigin.Begin);
	    this.radDocking.LoadLayout(sourceAsStream);
	}
```
