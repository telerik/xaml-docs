---
title: Overview
page_title: Overview
description: Overview
slug: radbarcode-overview
tags: overview
published: True
position: 0
---

# Overview



## RadBarcodeSymbology Specifications
<table><th><tr><td>BarCode</td><td>Description</td></tr></th><tr><td>

Code 128</td><td>

Very dense code, used extensively worldwide</td></tr><tr><td>

Code 128 A</td><td>

Subset of Code 128  *([more info below](#Code128))</td></tr><tr><td>

Code 128 B</td><td>

Subset of Code 128  *([more info below](#Code128))</td></tr><tr><td>

Code 128 C</td><td>

Subset of Code 128  *([more info below](#Code128))</td></tr><tr><td>

Code 39</td><td>

(aka USD-3, 3 of 9): U.S. Government and military use, required for DoD applications</td></tr><tr><td>

EAN 8</td><td>

Short version of EAN-13, 8 characters</td></tr><tr><td>

EAN 13</td><td>

Used with consumer products internationally, 13 characters</td></tr><tr><td>

UPC A</td><td>

Used with consumer products in U.S., 12 characters</td></tr><tr><td>

UPC E</td><td>

Short version of UPC symbol, 6 characters</td></tr></table>Additional information on Code128

1. Code128A, Code128B and Code128C represent the A, B and C subsets of the Code128 symbology. Code128 uses an intelligent algorithm that picks automatically the appropriate subset according to the input value, and might switch between these subsets in the middle of a BarCode in order to produce a shorter generated sequence. For example, if you have the input string “ABCD1234”, the “ABCD” part of the string will be encoded using the A subset, while the “1234” part will be encoded with the C subset, because Code128C uses a double-density code for numerical values, thus producing a shorter BarCode as a result. If you want to disable this behavior you can specify explicitly one of the subsets: Code128A, Code128B or Code128C to the Symbology property of the BarCode report item.
							

1. Code128 can represent both ASCII characters and non-ASCII control characters. Normally the BarCode report item inserts automatically the appropriate control characters in order to conform to the Code128 specification. However certain applications might require manual insertion of certain control characters, such as the functional characters: FNC1-FNC4. For this purpose the BarCode report item assigns special Unicode values to these control characters outside the normal 0-127 ASCII code range. The following table lists all Code128 control characters and their corresponding Unicode values:
							
<table>Code 128 Control Characters<th><tr><td>

Control Character</td><td>

Hexadecimal</td><td>

Decimal</td></tr></th><tr><td>

Code A</td><td>

F4</td><td>

244</td></tr><tr><td>

Code B</td><td>

F5</td><td>

245</td></tr><tr><td>

Code C</td><td>

F6</td><td>

246</td></tr><tr><td>

FNC1</td><td>

F7</td><td>

247</td></tr><tr><td>

FNC2</td><td>

F8</td><td>

248</td></tr><tr><td>

FNC3</td><td>

F9</td><td>

249</td></tr><tr><td>

FNC4</td><td>

FA</td><td>

250</td></tr><tr><td>

Shift</td><td>

FB</td><td>

251</td></tr><tr><td>

Start A</td><td>

FC</td><td>

252</td></tr><tr><td>

Start B</td><td>

FD</td><td>

253</td></tr><tr><td>

Start C</td><td>

FE</td><td>

254</td></tr><tr><td>

Stop</td><td>

FF</td><td>

255</td></tr></table>Additional information on EAN128

EAN128 is a special case of Code128. The only difference between EAN128 and 
							Code 128 is that EAN128 inserts the FNC1 control character at the beginning of the 
							BarCode in order to conform to the EAN128 specification. If you have a multi-part 
							EAN128 BarCode which requires the FNC1 control character as a delimiter between 
							the different parts, you should insert it manually:
						

## RadBarcodeQR

The QRCode represents a square matrix, filled with black and white modules. There are four modes available in the control, namely:
				

* 

__Numeric data__ (digits __0 - 9__)

* 

__Alphanumeric data__ (digits __0 - 9__; upper case letters __A-Z__; nine other characters: __space, $ % * + - . / :__ )

* 

__8-bit byte data__ (JIS 8-bit character set (Latin and Kana) in accordance with JIS X 0201)

* 

__Kanji characters__ (Shift JIS character set in accordance with JIS X 0208 Annex 1 Shift Coded Representation)
