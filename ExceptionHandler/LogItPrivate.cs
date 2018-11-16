using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LogIt
{
	public sealed partial class LogIt
	{
		private bool _isCSV = false;
		private bool _isTXT = true;
		private string _filePath;
		private Encoding _useEncoding;
		private void WriteInit()
		{
			string data = "";
			if(_isCSV)
			{
				data = "Logging File," + DateTime.Now + "\n\n";
				data = "Date Time, Error number, Error StackTrace, Error/Info Message, Error Inner Message\n";
			}
			if(_isTXT)
			{
				data = "Logging file created on " + DateTime.Now + "\n\n\n";
			}
			Write(data);
		}
		
		private void Write(string Data)
		{
			////Initial creation
			if (!File.Exists(_filePath))
			{
				var file = File.Create(_filePath);
				file.Close();
				//Writing Initial content
				WriteInit();
			}
			//Writing data to file
			File.AppendAllText(_filePath,Data,_useEncoding);
		}
	}
}
