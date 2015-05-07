---
title: Handle SelectionChanged for GridViewComboBoxColumn
page_title: Handle SelectionChanged for GridViewComboBoxColumn
description: Handle SelectionChanged for GridViewComboBoxColumn
slug: gridview-columns-howto-selectionchanged-comboboxcolumn
tags: handle,selectionchanged,gridviewcomboboxcolumn
published: True
position: 7
---

# Handle SelectionChanged for GridViewComboBoxColumn

GridViewComboBoxColumn does not expose a SelectionChanged event itself. In case you need such an event to implement your additional logic, you can handle the SelectionChanged event of its editing element (RadComboBox). For example the code to do so is available bellow:
{% if site.site_name == 'WPF' %}

#### __C#__

{{region gridview-columns-howto-selectionchanged-comboboxcolumn_1}}

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

{% endif %}
{% if site.site_name == 'Silverlight' %}

#### __C#__

{{region gridview-columns-howto-selectionchanged-comboboxcolumn_2}}

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

>You should add a using statement to __Telerik.Windows__ namespace in order to be able to add the handler. {% endif %}

You can see that with the code snippet above I check if there are any items being unselected (through the RemovedItems.Count). This ensures the event will not be handled on initial loading when a default item has been selected. 

# See Also

 * [ComboBox Column]({%slug radgridview-columns-column-types-combobox-column%})

 * [Empty Cells in Combobox column]({%slug gridview-troubleshooting-blank-cells%})

 * [Number of clicks in the ComboBox column]({%slug gridview-combobox-column-clicks%})
