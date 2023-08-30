namespace GasStationSample.CommerceRuntime
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// A class representing the response to the get gas pumps data request.
    /// </summary>
    [DataContract]
    public sealed class GetCustomerDataResponse : Response
    {
        public GetCustomerDataResponse(IEnumerable<CustomerEntity> customer)
        {
            this.Customer = customer;
        }

        /// <summary>
        /// The gas pumps.
        /// </summary>
        public IEnumerable<CustomerEntity> Customer { get; private set; }
    }
}