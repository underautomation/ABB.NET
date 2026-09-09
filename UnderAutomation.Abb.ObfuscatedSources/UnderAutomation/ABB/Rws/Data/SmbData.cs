//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace UnderAutomation.ABB.Rws.Data {
	/// <summary>
	/// 
	/// Serial measurement board data of one mechanical unit, held twice: once in the controller cabinet and
	/// once in the memory of the robot itself.
	/// <p>Returned by <code>MotionSystemService.GetSmbData()</code>. Comparing the cabinet properties with the
	/// robot ones tells whether the two copies still agree, which is what
	/// <code>MotionSystemService.SetSmbData()</code> repairs by copying one over the other.</p>
	/// 
	/// </summary>
	public class SmbData : Object {

		/// <summary>
		/// 
		/// Initializes a new instance of the <xref href="UnderAutomation.ABB.Rws.Data.SmbData" data-throw-if-not-resolved="false"></xref> class
		/// 
		/// </summary>
		public SmbData()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// 
		/// Returns a string representation of this data
		/// 
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// 
		/// Whether the serial number stored in the cabinet is usable, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<bool> CabinetSerialNumberValid { get; set; }

		/// <summary>
		/// 
		/// High part of the serial number stored in the cabinet
		/// 
		/// </summary>
		public string CabinetSerialNumberHighPart { get; set; }

		/// <summary>
		/// 
		/// Low part of the serial number stored in the cabinet
		/// 
		/// </summary>
		public string CabinetSerialNumberLowPart { get; set; }

		/// <summary>
		/// 
		/// State of the service information data stored in the cabinet
		/// 
		/// </summary>
		public SmbDataStatus CabinetServiceInformationStatus { get; set; }

		/// <summary>
		/// 
		/// State of the absolute accuracy data stored in the cabinet
		/// 
		/// </summary>
		public SmbDataStatus CabinetAbsoluteAccuracyStatus { get; set; }

		/// <summary>
		/// 
		/// State of the calibration data stored in the cabinet
		/// 
		/// </summary>
		public SmbDataStatus CabinetCalibrationStatus { get; set; }

		/// <summary>
		/// 
		/// State of the axis calibration data stored in the cabinet
		/// 
		/// </summary>
		public SmbDataStatus CabinetAxisCalibrationStatus { get; set; }

		/// <summary>
		/// 
		/// Whether the serial number stored in the robot is usable, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<bool> RobotSerialNumberValid { get; set; }

		/// <summary>
		/// 
		/// High part of the serial number stored in the robot
		/// 
		/// </summary>
		public string RobotSerialNumberHighPart { get; set; }

		/// <summary>
		/// 
		/// Low part of the serial number stored in the robot
		/// 
		/// </summary>
		public string RobotSerialNumberLowPart { get; set; }

		/// <summary>
		/// 
		/// State of the service information data stored in the robot
		/// 
		/// </summary>
		public SmbDataStatus RobotServiceInformationStatus { get; set; }

		/// <summary>
		/// 
		/// State of the absolute accuracy data stored in the robot
		/// 
		/// </summary>
		public SmbDataStatus RobotAbsoluteAccuracyStatus { get; set; }

		/// <summary>
		/// 
		/// State of the calibration data stored in the robot
		/// 
		/// </summary>
		public SmbDataStatus RobotCalibrationStatus { get; set; }

		/// <summary>
		/// 
		/// State of the axis calibration data stored in the robot
		/// 
		/// </summary>
		public SmbDataStatus RobotAxisCalibrationStatus { get; set; }

		/// <summary>
		/// 
		/// Number of the drive module the data belongs to, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> DriveModule { get; set; }

		/// <summary>
		/// 
		/// Number of the measurement link the data belongs to, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> MeasurementLink { get; set; }

		/// <summary>
		/// 
		/// Number of the measurement board the data belongs to, null when the controller did not report it
		/// 
		/// </summary>
		public Nullable<int> MeasurementBoard { get; set; }
	}
}
