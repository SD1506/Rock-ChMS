//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System.ServiceModel;

namespace Rock.REST.CRM
{
	/// <summary>
	/// Represents a REST WCF service for PhoneNumbers
	/// </summary>
	[ServiceContract]
    public partial interface IPhoneNumberService
    {
		/// <summary>
		/// Gets a PhoneNumber object
		/// </summary>
		[OperationContract]
        Rock.CRM.DTO.PhoneNumber Get( string id );

		/// <summary>
		/// Gets a PhoneNumber object
		/// </summary>
		[OperationContract]
        Rock.CRM.DTO.PhoneNumber ApiGet( string id, string apiKey );

		/// <summary>
		/// Updates a PhoneNumber object
		/// </summary>
        [OperationContract]
        void UpdatePhoneNumber( string id, Rock.CRM.DTO.PhoneNumber PhoneNumber );

		/// <summary>
		/// Updates a PhoneNumber object
		/// </summary>
        [OperationContract]
        void ApiUpdatePhoneNumber( string id, string apiKey, Rock.CRM.DTO.PhoneNumber PhoneNumber );

		/// <summary>
		/// Creates a new PhoneNumber object
		/// </summary>
        [OperationContract]
        void CreatePhoneNumber( Rock.CRM.DTO.PhoneNumber PhoneNumber );

		/// <summary>
		/// Creates a new PhoneNumber object
		/// </summary>
        [OperationContract]
        void ApiCreatePhoneNumber( string apiKey, Rock.CRM.DTO.PhoneNumber PhoneNumber );

		/// <summary>
		/// Deletes a PhoneNumber object
		/// </summary>
        [OperationContract]
        void DeletePhoneNumber( string id );

		/// <summary>
		/// Deletes a PhoneNumber object
		/// </summary>
        [OperationContract]
        void ApiDeletePhoneNumber( string id, string apiKey );
    }
}
