---
title: Overview
page_title: Telerik UI for WPF AI Tooling Overview
description: Learn about the AI-powered developer tools that integrate with your IDE or code editor for greater productivity and enhanced developer experience.
slug: ai-overview
tags: telerik,wpf,ai,coding assistant
position: 0
---

# Telerik UI for WPF AI Coding Assistant

The Telerik UI for WPF __AI Coding Assistant__ enhances your developer experience and increases productivity when building WPF applications with Telerik UI for WPF components.

The coding assistant is an AI code generator that provides specialized context to AI models, enabling them to produce higher-quality code samples using the [Telerik UI for WPF components](https://www.telerik.com/products/wpf/overview.aspx) and APIs.

## Available Tools

The Telerik AI Coding Assistant is available through:

* [Telerik WPF GitHub Copilot Extension]({%slug ai-copilot-extension%})
* [Telerik WPF MCP Server]({%slug ai-mcp-server%})

### Key Differences

| Feature                | MCP Server                                                                | GitHub Copilot Extension                                   |
|------------------------|---------------------------------------------------------------------------|------------------------------------------------------------|
| Prompt Handling        | Handles complex, multi-step prompts                                       | Offers shorter, focused code snippets                      |
| Client Compatibility   | Works with MCP-enabled clients (e.g. Copilot Agent mode)         		 | Integrated as a Copilot extension                          |
| Code Suggestions       | Can directly suggest changes and rebuild applications to verify code      | Provides detailed explanations alongside code suggestions  |
| Response Focus         | Primarily code-focused                                                    | Better for learning and understanding implementation       |

## Getting Started

To use the Telerik WPF AI Coding Assistant, you need:

@[template](/_contentTemplates/ai-coding-assistant.md#getting-started)
* @[template](/_contentTemplates/ai-coding-assistant.md#number-of-requests)

## Number of Requests

The Telerik WPF AI Coding Assistant allows the following maximum number of requests based on your [Telerik license type](https://www.telerik.com/purchase/faq/licensing-purchasing):

| License Type | Request Limit |
|--------------|---------------|
| Perpetual | 50 requests per year |
| Subscription | Virtually unlimited with fair use threshold of 300 requests per day |
| Trial | 300 requests per trial period (does not reset with new trial activations) |

> All Telerik AI tools share a single request quota for your Telerik account. Usage from the [Telerik Copilot extension]({%slug ai-copilot-extension%}) and [Telerik MCP server]({%slug ai-mcp-server%}) counts toward the same limit. Complex prompts in the MCP server may consume multiple requests.

## Privacy

The Telerik WPF AI Coding Assistant operates under strict privacy guidelines:

Data Access:
* No access to your workspace and application code.
* Exception: when using the Telerik MCP server (or any other MCP server), the LLM generates parameters for the MCP server request, which may include parts of your application code.

Data Usage:
* Your prompts are not used to train Telerik AI models.
* Does not generate or access AI responses.
* Provides enhanced context to improve responses from your chosen AI model (GPT, Gemini, Claude, etc.).

Data Storage:
* Prompts and context are anonymized and stored only for statistical analysis and troubleshooting.
* No association between prompts and your Telerik user account.
* Usage metrics are collected to ensure [license compliance](#number-of-requests).

> Make sure also to review the terms and privacy policies of your selected AI model and AI client.

## Next Steps

* Install the [Telerik WPF GitHub Copilot Extension]({%slug ai-copilot-extension%})
* Configure the [Telerik WPF MCP Server]({%slug ai-mcp-server%}) with an MCP-enabled client