using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LogIt
{
	public sealed partial class LogIt
	{
		public LogIt(bool isCSV, bool isTXT, string filePath, Encoding useEncoding)
		{
			_isCSV = isCSV;
			_isTXT = isTXT;
			_filePath = filePath;
			_useEncoding = useEncoding;
			if (_isCSV)
			{
				_filePath += ".csv";
			}
			else if (_isTXT)
			{
				_filePath += ".txt";
			}
			//Initial creation
			if (!File.Exists(_filePath))
			{
				var file = File.Create(_filePath);
				file.Close();
				//Writing Initial content
				WriteInit();
			}
		}
	}
}
