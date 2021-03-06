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
using System;
using System.Collections.Generic;
using System.Linq;

using Rock.Data;

namespace Rock.CRM
{
	/// <summary>
	/// Person Trail POCO Service class
	/// </summary>
    public partial class PersonTrailService : Service<Rock.CRM.PersonTrail>
    {
		/// <summary>
		/// Gets Person Trails by Current Id
		/// </summary>
		/// <param name="currentId">Current Id.</param>
		/// <returns>An enumerable list of PersonTrail objects.</returns>
	    public IEnumerable<Rock.CRM.PersonTrail> GetByCurrentId( int currentId )
        {
            return Repository.Find( t => t.CurrentId == currentId );
        }

        /// <summary>
        /// Get's the current person Guid
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public string Current( string publicKey )
        {
            PersonTrail personTrail = GetByEncryptedKey( publicKey );
            while ( personTrail != null )
            {
                publicKey = personTrail.CurrentPublicKey;
                personTrail = GetByEncryptedKey( publicKey );
            }
            return publicKey;
        }

        /// <summary>
        /// Get's the current person id
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public int Current( int id )
        {
            PersonTrail personTrail = Get( id );
            while ( personTrail != null )
            {
                id = personTrail.CurrentId;
                personTrail = Get( id );
            }
            return id;
        }
    }
}
