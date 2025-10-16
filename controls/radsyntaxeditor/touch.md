---
title: Touch
page_title: Touch
description: The RadSyntaxEditor comes with out-of-the-box support for touch gestures.
slug: radsyntaxeditor-touch
tags: touch,radsyntaxeditor
position: 6
---

# Touch

The RadSyntaxEditor comes with out-of-the-box support for touch gestures.

When using touch, touch selector markers appear when the user taps on the editor. Swiping **30 pixels** around them moves the selection's start/end. Switching to a mouse device hides the markers. The markers are also hidden during a swipe or pinch. Swiping over the line numbers selects each of the lines the swipe passes over.

![RadSyntaxEditor Touch Support](images/syntaxeditor_touch-support-1.gif)

## Supported Touch Gestures

|Gesture|RadSyntaxEditor Action|
|-------|-----------------|
|Tap|Moves the caret under the finger|
|Double Tap|Selects the word under the finger|
|Pinch|Scales the document (the ScaleFactor changes)|
|Swipe|Scrolls the document|
|Swipe inertia|Scrolls the document continuously with increased speed|

## Override Default Touch Logic

If you wish to implement your own touch logic, you can override the **InitializeTouch** method of the **RadSyntaxEditor**.

__Example 1: Default InitializeTouch method__
```C#

        protected override void InitializeTouch(SyntaxEditorPresenter presenter)
        {
            TouchManager.AddSwipeEventHandler(presenter, new SwipeEventHandler(OnSwipe));
            base.InitializeTouch(presenter);
        }

        private void OnSwipe(object sender, SwipeEventArgs args)
        {
            // your custom logic for swiping
            args.Handled = true; // you can omit this if your custom logic does not contradict with the default logic
        }
```

> You can read the [following article]({%slug touchmanager-events%}) article, which describes all of the events exposed by the TouchManager.

## Increase Markers Drag Area

By default, dragging the markers is possible if the swipe occurs up to **30 pixels** from their center. This area can be controlled via the **TouchMarkerDragDistance** property of the **RadSyntaxEditor** control.

__Example 2: Increase markers drag area__
```C#

    this.syntaxEditor.TouchMarkerDragDistance = 40;
```

## See Also

* [Events]({%slug radsyntaxeditor-events%})
* [Commands]({%slug radsyntaxeditor-commands%})
