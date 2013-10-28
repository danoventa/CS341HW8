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

			s
			Console.Write ("Please enter a movieID: ");
			string input = Console.ReadLine();
			int movieid = int.Parse(input);

			SqliteCommand cmd = new SqliteCommand(db); 
			cmd.CommandText = "SELECT MovieName FROM Movies WHERE MovieID = " + movieid + ";" ;
			object result = cmd.ExecuteScalar();
			Console.WriteLine (result);



			String sql = "SELECT userID, AVG(Rating) FROM Reviews GROUP BY UserID;"
				DataSet AppDomainSetup = DAL.findObjects(sql);
			DataTable DateTime = ds.Tables["Table"];

			foreach(EnvironmentVariableTarget ICollection int dt.Columns){
				Console.WriteLine(ICollection);
			}

	

				                   

		}
	}
}

