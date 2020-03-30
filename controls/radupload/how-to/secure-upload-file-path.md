---
title: Secure Upload File Paths
page_title: Sanitize Upload File Paths
description: Secure the uploading file location when using RadUpload control and RadUploadHandler.
slug: radupload-how-to-sanitize-upload-file-paths
tags: sanitize,upload,cloud,handler,relative,path,directory
published: True
position: 0
site_name: Silverlight
---

# Secure Upload File Paths

This article shows how to improve the security of the RadUploadHandler used with RadUpload for Silverlight. 

__RadUploadHandler__ expects a web request that provides the file location of the uploading file along with few other parameters. The uploading file location should be inside the directory where the upload handler class is defined. Before version `2020.1.330` a specially crafted web request could result in uploads to arbitrary locations. To avoid this and allow only safe paths __[upgrade]({%slug radcontrols-for-silverlight-vs-extensions-upgrading%}) to version `2020.1.330` or later__ of Telerik UI for Silverlight.

>tip Version `2020.1.330` is a [LIB]({%slug installation-installing-lib%}) but it is considered stable which means that we approve it for production use.

If you don't plan to upgrade to version `2020.1.330` or later, we recommend to manually ensure that the file paths received by the upload handler are sanitized. The following example shows one way to do this through a [custom handler]({%slug radupload-features-upload-handler%}).

#### __[C#] Example 1: Custom RadUploadHandler__
{{region radupload-how-to-sanitize-upload-file-paths-0}}
	using System.IO;
	using System.Text;
	using System.Web;
	using Telerik.Windows;
	
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

            string extension = Path.GetExtension(fileName);
            string securedFileName = Path.GetFileNameWithoutExtension(this.Decode(fileName));
            return string.Format("{0}{1}", Path.Combine(targetFolder, Path.GetFileName(securedFileName)), extension);
        }

        public override string GetTargetFolder()
        {
            string targetPhysicalFolder = this.TargetPhysicalFolder;
            if (!string.IsNullOrEmpty(targetPhysicalFolder))
            {
                return Path.GetFileNameWithoutExtension(this.Decode(targetPhysicalFolder));
            }
            
            string decodedFolderPath = this.Decode(this.TargetFolder);
            string sanitizedPath = Path.GetFileNameWithoutExtension(decodedFolderPath);
            string targetFolder = this.Context.Server.MapPath(sanitizedPath);
            return targetFolder;
        }

		private string Decode(string str)
		{
			var urlDecoded = HttpUtility.UrlDecode(str);
			var encoding = new UTF8Encoding();
			var utfDecoded = encoding.GetString(encoding.GetBytes(urlDecoded));
			return utfDecoded;
		}
	}
{{endregion}}

## See Also
 * [Getting Started]({%slug radupload-getting-started%})
 * [Upload Handler]({%slug radupload-features-upload-handler%})
