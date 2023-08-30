namespace GasStationSample.CommerceRuntime
{
    using System.Runtime.Serialization;
    using Microsoft.Dynamics.Commerce.Runtime.Messages;

    /// <summary>
    /// A class representing the request to get the gas pumps data.
    /// </summary>
    [DataContract]
    public sealed class UpdateCustomerDataRequest : Request
    {
        public UpdateCustomerDataRequest(string customerId, string city, string state, string country)
        {
            this.CustomerId = customerId;
            this.City = city;
            this.State = state;
            this.Country = country;
        }

        /// <summary>
        /// The store number.
        /// </summary>
        public string CustomerId { get; private set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [DataMember]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [DataMember]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [DataMember]
        public string Country { get; set; }
    }
}