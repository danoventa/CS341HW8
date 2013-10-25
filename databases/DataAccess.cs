// 
// N-Tier database app: Data Acces Tier 
// 
// Daniel A. Noventa 
// U. of Illinois, Chicago 
// CS341, Fall 2013 
// Homework 8 
//

using System;

namespace databases
{
	public class DataAccess
	{
		public DataAccess ()
		{
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

		}
	}
}

