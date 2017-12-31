using DevOps.ContentDelivery.Structures.AzureBlob;
using static Common.Functions.DownloadFile.FileDownloader;
using static DevOps.ContentDelivery.Functions.ResolveAzureCdnBlobUrl.UrlResolver;

namespace DevOps.ContentDelivery.Functions.DownloadAzureCdnBlob
{
    public static class CdnBlobDownloader
    {
        public static void DownloadBlob(string endpointName, Blob blob, string destinationPath)
            => Download(
                Uri(endpointName, blob),
                destinationPath);
    }
}
