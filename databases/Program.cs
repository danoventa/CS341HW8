using System;
using System.Data;
using Mono.Data;
using Mono.Data.Sqlite;

namespace databases
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Presentation theProgram = new Presentation ();
			theProgram.Presentation();
		
			return 0;
		}
	}
}
