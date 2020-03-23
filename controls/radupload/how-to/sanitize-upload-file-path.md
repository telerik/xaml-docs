---
title: Sanitize Upload File Paths
page_title: Sanitize Upload File Paths
description: Secure the uploading file location when using RadUpload control and RadUploadHandler.
slug: radupload-how-to-sanitize-upload-file-paths
tags: sanitize,upload,cloud,handler,relative,path,directory
published: True
position: 0
site_name: Silverlight
---

# Sanitize Upload File Paths

This article shows how to improve the security of the RadUploadHandler used with RadUpload. 

__RadUploadHandler__ expects a web request that provides the file location of the uploading file along with few other parameters. The uploading file location should be inside the directory where the upload handler class is defined. Before version `2020.1.330` you could use the web request to reach a folder defined in a directory that is up in the hierarchy relatively to the directory of the upload handler. To avoid this and allow only safe paths __upgrade to version `2020.1.330` or later__ of Telerik UI for Silverlight.

>tip Version `2020.1.330` is [LIB]({%slug installation-installing-lib%}) but it is considered stable which means that we approve it for production use too.

If you don't plan to upgrade to version `2020.1.330` or later, we recommend you to manually ensure that the file paths received by the upload handler are sanitized. The following example shows how to do this.

#### __[C#] Example 1: Custom UploadHandler__
{{region radupload-how-to-sanitize-upload-file-paths-0}}
	public class SampleUploadHandler : RadUploadHandler
	{
		public override string GetFilePath(string fileName)
		{
			if (string.IsNullOrEmpty(fileName))
			{
				return null;
			}

			string targetFolder = this.GetTargetFolder();
			if (targetFolder == null)
			{
				return null;
			}

			string securedFolderPath = this.SecureFilePath(targetFolder);
			string securedFileName = this.SecureFilePath(fileName);
			return System.IO.Path.Combine(securedFolderPath, System.IO.Path.GetFileName(securedFileName));
		}

		public override string GetTargetFolder()
		{
			var targetFolder = base.GetTargetFolder();
			string securedFolderPath = this.SecureFilePath(targetFolder);
			return securedFolderPath;
		}

		private string SecureFilePath(string filePath)
		{
			int startIndex = 0;

			for (int i = 0; i < filePath.Length; i++)
			{
				var ch = filePath[i];
				if (ch == '.' || ch == '/' || ch == '\\')
				{
					continue;
				}

				startIndex = i;
				break;
			}

			string securedPath = filePath.Substring(startIndex);
			return securedPath;
		}
	}
{{endregion}}

## See Also
 * [Getting Started]({%slug radupload-getting-started%})
 * [Upload Handler]({%slug radupload-features-upload-handler%})
