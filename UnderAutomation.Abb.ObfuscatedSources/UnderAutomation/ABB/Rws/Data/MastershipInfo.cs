//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// State of the mastership of one domain: who holds it, and whether this connection is the holder.
	/// <p>Returned by <code>MastershipService.GetInfo()</code>.</p>
	/// 
	/// </summary>
	public class MastershipInfo : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.MastershipInfo" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public MastershipInfo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this mastership state
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Domain this state describes
		/// 
		/// </summary>
		public MastershipDomain Domain { get; set; }

		/// <summary>
		/// 
		/// Who holds the mastership of the domain
		/// 
		/// </summary>
		public MastershipHolder Holder { get; set; }

		/// <summary>
		/// 
		/// Whether this connection is the one holding the mastership, and is therefore allowed to write in
		/// the domain
		/// 
		/// </summary>
		public bool HeldByMe { get; set; }

		/// <summary>
		/// 
		/// Identifier the controller gave the user holding the mastership, null when nobody holds it
		/// 
		/// </summary>
		public Nullable<long> UserId { get; set; }

		/// <summary>
		/// 
		/// Where the holder is, as it declared itself, null when nobody holds the mastership
		/// 
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// 
		/// Alternate name of the location of the holder, null when nobody holds the mastership
		/// 
		/// </summary>
		public string Alias { get; set; }

		/// <summary>
		/// 
		/// Name of the application holding the mastership, null when nobody holds it
		/// 
		/// </summary>
		public string Application { get; set; }
	}
}
