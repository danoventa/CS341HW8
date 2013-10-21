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
			string connectionInfo = "Data Source=Netflix.sqlite";
			SqliteConnection db = new SqliteConnection(connectionInfo);
			db.Open ();

			Console.Write ("Please enter a movieID: ");
			string input = Console.ReadLine();
			int movieid = int.Parse(input);

			SqliteCommand cmd = new SqliteCommand(db); 
			cmd.CommandText = "SELECT MovieName FROM Movies WHERE MovieID = " + movieid + ";" ;
			object result = cmd.ExecuteScalar();

			Console.Write ("Please enter a movieID: ");
			string input2 = Console.ReadLine();
			int movieid2 = int.Parse(input2);

			cmd.CommandText = @"SELECT AVG(Rating) FROM Reviews
			INNER JOIN Movies ON Reviews.MovieID = Movies.MovieID WHERE Movies.MovieName = " + movieid2 + ";";
			object result2 = cmd.ExecuteScalar();

			// just to play? 
			// string sql = "CREATE TABLE [Movies] ([MovieID] INTEGER PRIMARY KEY, [Movie Name]
			/*
			*	SqliteCommand cmd = new SqliteCommand(db); 
			*	cmd.CommandText = "CREATE TABLE [Movies] ([MovieID] INTEGER PRIMARY KEY,[MovieName] TEXT);" ;
			*	cmd.ExecuteNonQuery();
			*	cmd.CommandText = @"INSERT INTO Movies(MovieID, MovieName) Values(1, 'When Harry Met Salley');";
			*/

			Console.WriteLine (result);
			Console.WriteLine (result2);
			db.Close ();



		}
	}
}
