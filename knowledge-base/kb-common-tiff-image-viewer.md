---
title: Create Tiff Image Viewer for WPF
description: This article explains how to create a custom image viewer control that shows .tiff images 
type: how-to
page_title: How to Implement Tif Image Format Viewer
slug: kb-common-tiff-image-viewer
tags: tiff,imageviewer,viewer,picture
res_type: kb
---

## Environment

| Property | Value |
|----------|-------|
| Product  | Progress Telerik UI for WPF |
| Version  | 2024.1.312 |

## Description

How to create a control that shows TIFF images.

## Solution 1

You can use the [RadImageEditor]({%slug radimageeditor-overview%}) control to show the .tiff image format. 

At the moment of writing this article (2024), the `RadImageEditor` displays the .tiff only as static image.

## Solution 2

If `RadImageEditor` is not suitable and you need to change between the multiple images in the .tiff file, then you can implement custom tiff image viewer control.

__Custom Tiff Viewer Code-Behind Definition__
```C#
	public partial class TiffImageViewer : UserControl
	{
		private const double zoomStep = 0.1;
		private const double maxZoom = 4;
		private const double minZoom = 0.5;
		private Point origin;
		private Point start;
		private BitmapImage currentImage;
		private int currentFrame = 0;

		TransformGroup transformGroup;
		ScaleTransform scaleTransform;
		TranslateTransform translateTransform;
		RotateTransform rotateTransform;

		public BitmapImage Source
		{
			get { return (BitmapImage)GetValue(SourceProperty); }
			set { SetValue(SourceProperty, value); }
		}

		public static readonly DependencyProperty SourceProperty =
			DependencyProperty.Register(
				"Source", 
				typeof(BitmapImage),
				typeof(TiffImageViewer), 
				new PropertyMetadata(null, OnImageSourceChanged));

		private static void OnImageSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
		}

		public TiffImageViewer()
		{
			InitializeComponent();

			transformGroup = new TransformGroup();
			scaleTransform = new ScaleTransform();
			translateTransform = new TranslateTransform();
			rotateTransform = new RotateTransform();
			transformGroup.Children.Add(scaleTransform);            
			transformGroup.Children.Add(translateTransform);
			transformGroup.Children.Add(rotateTransform);

			imageVisual.RenderTransform = transformGroup;

			this.slider.Minimum = minZoom;
			this.slider.Maximum = maxZoom;
			this.slider.Value = 1;
		}

		public void imgTiffReport_MouseWheel(object sender, MouseWheelEventArgs e)
		{   
			double zoom = e.Delta > 0 ? zoomStep : -zoomStep;            
			if ((zoom > 0 && scaleTransform.ScaleX < maxZoom) || zoom < 0 && scaleTransform.ScaleX > minZoom)
			{
				scaleTransform.ScaleX += zoom;
				scaleTransform.ScaleY += zoom;
				imageVisual.Width = svTiffReport.ActualWidth * scaleTransform.ScaleX;
				imageVisual.Height = svTiffReport.ActualHeight * scaleTransform.ScaleY;

				this.slider.Value = scaleTransform.ScaleX;
			}
		}

		public void imgTiffReport_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			imageVisual.Cursor = Cursors.Hand;
			imageVisual.CaptureMouse();
			start = e.GetPosition(bdrTiffReport);
			origin = new Point(translateTransform.X, translateTransform.Y);
		}

		public void imgTiffReport_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			imageVisual.ReleaseMouseCapture();
			imageVisual.Cursor = Cursors.Arrow;
		}

		public void imgTiffReport_MouseMove(object sender, MouseEventArgs e)
		{
			if (!imageVisual.IsMouseCaptured)
			{
				return;
			}
			var vMM = start - e.GetPosition(bdrTiffReport);
			translateTransform.X = origin.X - vMM.X;
			translateTransform.Y = origin.Y - vMM.Y;
		}

		private void OnNextButtonClick(object sender, RoutedEventArgs e)
		{
			if (currentImage == null)
			{
				currentImage = Source;
				currentFrame = 0;
			}

			TiffBitmapDecoder dec = new TiffBitmapDecoder(currentImage.UriSource, BitmapCreateOptions.None, BitmapCacheOption.None);
			if (dec.Frames.Count > currentFrame + 1)
			{
				currentFrame += 1;
			}
			imageVisual.Source = dec.Frames[currentFrame];
		}

		private void OnPreviousButtonClick(object sender, RoutedEventArgs e)
		{
			if (currentImage == null)
			{
				currentImage = Source;
				currentFrame = 0;
			}

			TiffBitmapDecoder dec = new TiffBitmapDecoder(currentImage.UriSource, BitmapCreateOptions.None, BitmapCacheOption.None);
			if (currentFrame > 0)
			{
				currentFrame -= 1;
			}
			imageVisual.Source = dec.Frames[currentFrame];
		}

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (scaleTransform != null)
			{
				scaleTransform.ScaleX = e.NewValue;
				scaleTransform.ScaleY = e.NewValue;
			}            
		}
	}
```

__Using the Custom Tiff Viewer__
```XAML
	<local:TiffImageViewer>
		<local:TiffImageViewer.Source>
			<BitmapImage UriSource="sample.tiff" />
		</local:TiffImageViewer.Source>
	</local:TiffImageViewer>
```


