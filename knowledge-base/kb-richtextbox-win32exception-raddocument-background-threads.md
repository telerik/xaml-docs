---
title: Win32Exception Is Thrown when Multiple RadDocument Instances Are Created in Background Threads
description: Learn why a Win32Exception about insufficient storage is thrown when multiple RadDocument instances are created on background threads, and how to work around it.
components: ["richtextbox"]
type: troubleshooting
page_title: RadRichTextBox Win32Exception on Multiple RadDocument Instances in Background Threads
slug: kb-richtextbox-win32exception-raddocument-background-threads
tags: radrichtextbox, troubleshooting, win32exception, dispatcher, background threads, raddocument
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product</td>
			<td>RadRichTextBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The __"Win32Exception (0x80004005): Not enough storage is available to process this command"__ exception is thrown when multiple `RadDocument` instances are created in background threads.

The exception occurs due to a leak of `Dispatcher` instances and their related infrastructure objects. When a `DispatcherObject` type is instantiated on a thread, a `Dispatcher` instance is associated with this thread. Even after the thread finishes successfully, its `Dispatcher` is not disposed. This behavior is also reproducible with `RadDocument`, as it uses core WPF logic for some of its operations. For instance, using a `Brush` element on a thread automatically instantiates a `Dispatcher` object.

The exception is reproducible only in scenarios with heavy usage of new threads.

## Solution

If you incorporate solutions with heavy usage of new threads, use the workaround shown below, which Microsoft also recommends.

__Shutting Down the Dispatcher of a Thread__

<snippet id='radrichtextbox-troubleshooting-common-problems-block_2-cs' />

## See Also

* [Getting Started]({%slug radrichtextbox-getting-started%})
