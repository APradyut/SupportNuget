using System;
using System.Collections.Generic;
using System.Text;

namespace LogIt
{
	public sealed partial class LogIt
	{
		public string LogException(Exception e)
		{
			string data = "";
			string Key = DateTime.Now.ToFileTime().ToString().Substring(0, 9);
			if (_isTXT)
			{
				data = "############################################################################\n"
					+ "Date Time: "+ DateTime.Now + "\n"
					+ "Error number: " + Key + "\n"
					+ "Error occured in: " + e.StackTrace + "\n"
					+ "Error Message: " + e.Message + "\n"
					+ "Error Inner Message: " + e.InnerException + "\n";
			}
			else
			{
				data = DateTime.Now + ","
					+ Key + ","
					+ e.StackTrace + ","
					+ e.Message + ","
					+ e.InnerException + "\n";
			}
			Write(data);
			return Key;
		}

		public void LogInfo(string Message)
		{
			string data = "";
			if (_isCSV)
				data = ",Log,," + Message + "\n";
			else data = "############################################################################\n" 
					+ "Log: " + Message + "\n";
			Write(data);
		}
	}
}
