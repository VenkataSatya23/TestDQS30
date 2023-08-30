namespace GasStationSample.CommerceRuntime
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// A class representing the response to the get gas pumps data request.
    /// </summary>
    [DataContract]
    public sealed class UpdateCustomerDataResponse : Response
    {
        public UpdateCustomerDataResponse(string status)
        {
            this.Status = status;
        }

        /// <summary>
        /// The gas pumps.
        /// </summary>        
        public string Status { get; private set; }
    }
}