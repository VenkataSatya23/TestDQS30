namespace GasStationSample.CommerceRuntime
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// A class representing the request to get the gas pumps data.
    /// </summary>
    [DataContract]
    public sealed class GetCustomerDataRequest : Request
    {
        public GetCustomerDataRequest(string customerId)
        {
            this.CustomerId = customerId;
        }

        /// <summary>
        /// The store number.
        /// </summary>
        public string CustomerId { get; private set; }
    }
}