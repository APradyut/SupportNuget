using System;
using System.Text;
using LogIt;

namespace LogItTest
{
	class Program
	{
		static void Main(string[] args)
		{
			LogIt.LogIt logger = LogItBuilder.CreateNew()
			.WithEncoding(Encoding.UTF8)
			.WithDestinationTXT()
			.WithLoggingFile("logsnew1.csv")
			.Build();
				
			Console.WriteLine(logger.LogException(new ArithmeticException()));
			Console.WriteLine(logger.LogException(new Exception()));
			logger.LogInfo("This is a test log message");
			Console.WriteLine(logger.LogException(new ArithmeticException()));
			Console.WriteLine(logger.LogException(new Exception()));
		}
	}
}
