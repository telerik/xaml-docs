---
title: RadUpload ChunkTag
description: RadUpload ChunkTag or how to deal with uploaded files by chunk.
type: how-to
page_title: How to deal with uploaded files by chunk.
slug: kb-upload-chunktag
position: 0
tags: upload, chunktag, formchunktag, resultchunktag
ticketid:
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadUpload for Silverlight</td>
	</tr>
</table>


## Description

Telerik RadUpload for Silverlight supports Chunk tagging. Thus, the __RadUploadHandler__ has the ability to tag the uploaded chain of chunks. For example, you can use the ChunkTag to save the uploaded files in a database by chunk and not wait for the whole file to be uploaded (and saved to disk by default). 

__Chunk-Tag__ rely on two properties in the RadUploadHandler class: 
* __FormChunkTag__: The ChunkTag value supplied by the upload client for the current chunk.
* __ResultChunkTag__: Gets or sets the ChunkTag value returned from the upload-handler to the upload-client.

__InitializeChunkStorage__ and __SaveChunkData__ are two main methods you should be aware of when you customize your upload handler.

## Solution

The following example demonstrate how you can create custom class and override the __InitializeChunkStorage__ and __SaveChunkData__ methods.

#### __[C#]__
{{region cs-kb-htmlplaceholder-howto-enable-scrollbars-0}}
	public class SampleUploadHandler : RadUploadHandler
	{
		int FileID = 0;

		public override bool InitializeChunkStorage(string filePath)
		{
			// If this is the first time the InitializeChunkStorage is invoked,
			// create the a new Key (just a time stamp in our example).
			// The next time InitializeChunkStorage gets invoked, we will use this Key.

			if (this.IsNewFileRequest())
			{
				this.ResultChunkTag = MyUniqueKeyGenerator.GetKey();
			}
			else
			{
				if (this.FormChunkTag != null)
				{
					this.ResultChunkTag = this.FormChunkTag;
				}
			}
			return true;
		}

		public override bool SaveChunkData(string filePath, long position, byte[] buffer, int contentLength, out int savedBytes)
		{
			savedBytes = 0;
			bool success = false;
			string UserID = this.GetQueryParameter("UserID");

			string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FilesDataBaseConnectionString"].ConnectionString;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string cmdText = "INSERT INTO FileChunk(FileChunk, ChunkTag, ChunkSize, UserID) VALUES(@FileChunk, @ChunkTag, @ChunkSize, @UserID)  SET @Identity = SCOPE_IDENTITY()";
				SqlCommand cmd = new SqlCommand(cmdText, conn);

				SqlParameter identityParam = new SqlParameter("@Identity", SqlDbType.Int, 0, "FileID");
				identityParam.Direction = ParameterDirection.Output;

				cmd.Parameters.AddWithValue("FileChunk", buffer);
				cmd.Parameters.AddWithValue("ChunkSize", buffer.Length);
				cmd.Parameters.AddWithValue("ChunkTag", this.ResultChunkTag);
				cmd.Parameters.AddWithValue("UserID", UserID);

				cmd.Parameters.Add(identityParam);

				conn.Open();
				cmd.ExecuteNonQuery();

				FileID = (int)identityParam.Value;

			}

			// Note: do not forget to set the success value:
			success = true;

			if (!success)
			{
				string fileName = this.GetFileName();
				this.AddReturnParam(RadUploadConstants.ParamNameMessage, String.Format("Cannot save the file: [{0}]", fileName));
			}
			return success;
		}

		public override Dictionary<string, object> GetAssociatedData()
		{
			Dictionary<string, object> associatedData = base.GetAssociatedData();
			if (this.IsFinalFileRequest())
			{
				associatedData.Add("FileID", FileID.ToString());
			}
			return associatedData;
		}


		public class MyUniqueKeyGenerator
		{
			public static string GetKey()
			{
				// Here you should create an appropriate Key depending on your scenario.
				// For example it may be a real GUID or UserID-related...
				string key = string.Format(".{0:yyyymmdd.hhmmss}", DateTime.Now);
				return key;
			}
		}
	}
{{endregion}}
