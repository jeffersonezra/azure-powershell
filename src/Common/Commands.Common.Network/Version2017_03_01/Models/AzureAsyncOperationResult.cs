// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Network.Version2017_03_01.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Internal;
    using Microsoft.Azure.Management.Internal.Network;
    using Microsoft.Azure.Management.Internal.Network.Version2017_03_01;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The response body contains the status of the specified asynchronous
    /// operation, indicating whether it has succeeded, is in progress, or has
    /// failed. Note that this status is distinct from the HTTP status code
    /// returned for the Get Operation Status operation itself. If the
    /// asynchronous operation succeeded, the response body includes the HTTP
    /// status code for the successful request. If the asynchronous operation
    /// failed, the response body includes the HTTP status code for the failed
    /// request and error information regarding the failure.
    /// </summary>
    public partial class AzureAsyncOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the AzureAsyncOperationResult class.
        /// </summary>
        public AzureAsyncOperationResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureAsyncOperationResult class.
        /// </summary>
        /// <param name="status">Status of the Azure async operation. Possible
        /// values are: 'InProgress', 'Succeeded', and 'Failed'. Possible
        /// values include: 'InProgress', 'Succeeded', 'Failed'</param>
        public AzureAsyncOperationResult(string status = default(string), Error error = default(Error))
        {
            Status = status;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of the Azure async operation. Possible values
        /// are: 'InProgress', 'Succeeded', and 'Failed'. Possible values
        /// include: 'InProgress', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }

    }
}
