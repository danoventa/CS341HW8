using System;
using System.Data;
using Mono.Data.Sqlite;

namespace databases
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string connectionInfo = "Data Source=Netflix.sqlite";
			SqliteConnection db = new SqliteConnection(connectionInfo);
			db.Open ();

			Console.WriteLine (db.State.ToString ());
			db.Close ();


			Console.WriteLine ("Hello World!");
		}
	}
}
