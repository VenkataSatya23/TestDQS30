namespace GasStationSample.CommerceRuntime
{
    using Microsoft.Dynamics.Commerce.Runtime.DataModel;
    using System.Runtime.Serialization;
    using SystemAnnotations = System.ComponentModel.DataAnnotations;

    public class CustomerEntity : CommerceEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GasPump"/> class.
        /// </summary>
        public CustomerEntity()
            : base("CustomerEntity")
        {
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [SystemAnnotations.Key]
        [DataMember]
        public long Id { get; set; }

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