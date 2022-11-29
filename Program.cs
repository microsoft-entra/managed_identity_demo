// Construct the blob container endpoint from the arguments.
using Azure.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

// Get a credential and create a service client object for the blob container.
BlobContainerClient containerClient = new BlobContainerClient(
                new Uri("https://contosoplay.blob.core.windows.net/reports"),
                new DefaultAzureCredential());

// Get the hello.txt file content
var response = await containerClient.GetBlobClient("hello.txt").DownloadContentAsync();

Console.WriteLine(response.Value.Content);