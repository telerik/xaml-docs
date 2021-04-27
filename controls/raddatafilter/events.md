---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadDataFilter {{ site.framework_name }} control.
slug: raddatafilter-events
tags: datafilter, events
published: True
position: 6
---

# Events

This topic will describe the various events exposed by **RadDataFilter**.

* **AutoGeneratingItemPropertyDefinition**: Occurs when RadDataFilter auto-generates item property definitions. Through the **ItemPropertyDefinition** you can get ahold of the generated property definition and cancel its creation if it does not pass your criteria.

#### __[C#] Example 1: Cancel the creation of a property definition__

{{region cs-raddatafilter-events_1}}        

   private void radDataFilter_AutoGeneratingItemPropertyDefinition(object sender, Telerik.Windows.Controls.Data.DataFilter.DataFilterAutoGeneratingItemPropertyDefinitionEventArgs e)
        {
            if (e.ItemPropertyDefinition.PropertyType == typeof(string))
            {
                e.Cancel = true;
            }
        }
{{endregion}}

* **EditorCreated**: Occurs when a filter editor has been created and before it is added to the visual tree. Use this event if you want to customize the editor for a given property definition. A good example of how to achieve this can be found in the [Create Custom Filter Editors]({%slug raddatafilter-how-to-create-custom-filter-editors%}) article.

#### __[C#] Example 2: Configure the generated editor__

{{region cs-raddatafilter-events_2}}        

   private void radDataFilter_EditorCreated( object sender, EditorCreatedEventArgs e ) 
   { 
      switch (e.ItemPropertyDefinition.PropertyName) 
      {
         case "Title": 
            ((RadComboBox)e.Editor).ItemsSource = this.GetTitles(); 
            break;
      } 
   } 
{{endregion}}

* **FilterOperatorsLoading**: Occurs before the filter operators are loaded. Use this event if you want to remove one or more filter operators from the list or want to change the default operator.

#### __[C#] Example 3: Configure the filter operators__

{{region cs-raddatafilter-events_3}}        

   private void radDataFilter_FilterOperatorsLoading(object sender, Telerik.Windows.Controls.Data.DataFilter.FilterOperatorsLoadingEventArgs e)
   {
      if (e.ItemPropertyDefinition.PropertyType == typeof(int))
      {
            e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNull);
            e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotNull);
            e.DefaultOperator = Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo;
      }
   }
{{endregion}}

## See Also

* [Create Custom Filter Editors]({%slug raddatafilter-how-to-create-custom-filter-editors%})