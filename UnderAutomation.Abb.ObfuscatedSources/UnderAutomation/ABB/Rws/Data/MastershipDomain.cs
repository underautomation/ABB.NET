//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Domain of the controller a client can take the mastership of.
	/// <p>Mastership is what a client has to hold before it is allowed to change anything in a domain.
	/// Only one client at a time holds it, and it stays held until the client releases it or its connection
	/// ends.</p>
	/// <p>The two connection versions do not cut the controller in the same domains: a connection
	/// established with version 1 keeps the configuration and the RAPID programs apart, a connection
	/// established with version 2 covers both with <xref href="UnderAutomation.ABB.Rws.Data.MastershipDomain.Edit" data-throw-if-not-resolved="false"></xref>. Whichever name is used, the service
	/// asks the connected controller for the domains it really has.</p>
	/// 
	/// </summary>
	public sealed class MastershipDomain : Enum {


		public int value__;

		/// <summary>
		/// 
		/// Everything that changes the system itself: its configuration and its RAPID programs.
		/// <p>On a connection established with version 1, where the two are separate domains, asking for
		/// this one takes <xref href="UnderAutomation.ABB.Rws.Data.MastershipDomain.Configuration" data-throw-if-not-resolved="false"></xref> and <xref href="UnderAutomation.ABB.Rws.Data.MastershipDomain.Rapid" data-throw-if-not-resolved="false"></xref> together.</p>
		/// 
		/// </summary>
		public const MastershipDomain Edit;

		/// <summary>
		/// 
		/// The movement of the robot: jogging, the mechanical units and everything that makes an axis move
		/// 
		/// </summary>
		public const MastershipDomain Motion;

		/// <summary>
		/// 
		/// The system parameters of the controller.
		/// <p>On a connection established with version 2, where it is not a domain of its own, this is
		/// the same domain as <xref href="UnderAutomation.ABB.Rws.Data.MastershipDomain.Edit" data-throw-if-not-resolved="false"></xref>.</p>
		/// 
		/// </summary>
		public const MastershipDomain Configuration;

		/// <summary>
		/// 
		/// The RAPID programs and their data.
		/// <p>On a connection established with version 2, where it is not a domain of its own, this is
		/// the same domain as <xref href="UnderAutomation.ABB.Rws.Data.MastershipDomain.Edit" data-throw-if-not-resolved="false"></xref>.</p>
		/// 
		/// </summary>
		public const MastershipDomain Rapid;
	}
}
