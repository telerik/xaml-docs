---
title: PaneActivationMode
page_title: PaneActivationMode
description: PaneActivationMode
slug: raddocking-features-panes-activation-mode
tags: paneactivationmode
publish: True
position: 5
---

# PaneActivationMode



With our Q3 2013 release of RadControls we added the possibility to set which RadPane should be focused/activated after another RadPane in its PaneGroup is closed. Setting the activation mode is done via the PaneActivationMode property of the RadDocking control.
      

## Setting PaneActivationMode

The PaneActivationMode property gets or sets a value indicating which Pane in the current PaneGroup
          should be activated when the active Pane is closed and can be set to one of the following values:
        

* __First__ - Activates the first non-disabled and visible __RadPane__ in the Items collection of the PaneGroup
              and if there isn't one - the first non-disabled and visible __RadPane__ in the Items collection of __RadDocking__
              is activated. If there isn't such an item at all no action is performed and the value of the ActivePane property is null.
            

* __Last__ - Activates the last non-disabled and visible __RadPane__ in the Items collection of the PaneGroup 
              and if there isn't one - the first non-disabled and visible __RadPane__ in the Items collection of __RadDocking__ 
              is activated. If there isn't such an item at all no action is performed and the value of the ActivePane property is null.
            

* __Previous__ - Activates the previous non-disabled and visible __RadPane__ in the Items collection of the PaneGroup
              and if there isn't one - the first non-disabled and visible __RadPane__ in the Items collection of __RadDocking__
              is activated. If there isn't such an item at all no action is performed and the value of the ActivePane property is null.
            

* __Next__ - *This is the default mode*. Activates the next non-disabled and visible __RadPane__ in the Items collection of the PaneGroup
              and if there isn't one - the first non-disabled and visible __RadPane__ in the Items collection of __RadDocking__
              is activated. If there isn't such an item at all no action is performed and the value of the ActivePane property is null. 
            

* __LastActivated__ - Activates the previous activated __RadPane__ in the Items collection of the PaneGroup
              and if there isn't one - the first non-disabled and visible __RadPane__ in the Items collection of __RadDocking__
              is activated. If there isn't such an item at all no action is performed and the value of the ActivePane property is null.
            

The next examples will demonstrate the expected behaviors when using the above modes:
        

* When setting the mode to First after closing a Pane in the PaneGroup the first Pane in the PaneGroup will be activated:
            


                Figure 1. Pane 1 is activated after closing Pane 4
              ![raddocking-features-panes-activation-mode-1](images/raddocking-features-panes-activation-mode-1.png)

* When setting the mode to Last after closing a Pane in the PaneGroup the last Pane in that group will be activated:
            


                Figure 2. Pane 5 is activated after closing Pane 3
              ![raddocking-features-panes-activation-mode-2](images/raddocking-features-panes-activation-mode-2.png)

* When setting the mode to Next after closing a Pane in the PaneGroup the last Pane in that group will be activated:
            


                Figure 3. Pane 2 is activated after closing Pane 1
              ![raddocking-features-panes-activation-mode-3](images/raddocking-features-panes-activation-mode-3.png)

* When setting the mode to LastActivated after closing a Pane in the PaneGroup the last Pane which was active will be activated:
            


                Figure 4. Pane 3 is activated after closing Pane 5. Notice that Pane 3 was the last active Pane before closing Pane 5
              ![raddocking-features-panes-activation-mode-4](images/raddocking-features-panes-activation-mode-4.png)
