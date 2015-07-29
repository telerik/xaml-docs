---
title: Handling SelectionChanged event for DataFormComboBoxField
page_title: Handling SelectionChanged event for DataFormComboBoxField
description: Handling SelectionChanged event for DataFormComboBoxField
slug: raddataform-howto-selectionchanged-comboboxfield
tags: handling,selectionchanged,event,for,the,dataformcomboboxfield
published: True
position: 2
---

# Handling SelectionChanged event for DataFormComboBoxField



DataFormComboBoxField does not have a SelectionChanged event itself. In case you need such an event to implement your additional logic, you can handle the SelectionChanged event of its editing element (RadComboBox). For example the code to do so is available bellow:

{% if site.site_name == 'WPF' %}

#### __C#__

{{region raddataform-howto-selectionchanged-comboboxfield_1}}

	    public MainWindow()
	    {
	        InitializeComponent();
	        this.AddHandler(RadComboBox.SelectionChangedEvent, new System.Windows.Controls.SelectionChangedEventHandler(OnSelectionChanged));
	    }
	
	    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	    {
	        if (e.RemovedItems.Count > 0)
	        {
	            //your code here
	        }
	    }
	{{endregion}}

{% endif %}{% if site.site_name == 'Silverlight' %}

#### __C#__

{{region raddataform-howto-selectionchanged-comboboxfield_2}}

	    public MainPage()
	    {
	        InitializeComponent();
	        this.AddHandler(RadComboBox.SelectionChangedEvent, new Telerik.Windows.Controls.SelectionChangedEventHandler(OnSelectionChanged));
	    }
	
	    private void OnSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
	    {
	        if (e.RemovedItems.Count > 0)
	        {
	            //your code here
	        }
	    }
	{{endregion}}


>You should add a using statement to __Telerik.Windows__ namespace in order to be able to add the handler.
 {% endif %}

You can see that with the code snippet above I check if there are any items being unselected (through the RemovedItems.Count). This ensures that the event will not be handled on the initial loading when a default item has been selected. 
        

# See Also

 * [Edit Lookup Values with RadComboBox]({%slug raddatafor-edit-lookup-values-with-radcombobox%})
