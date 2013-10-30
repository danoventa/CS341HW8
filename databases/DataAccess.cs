// 
// N-Tier database app: Data Acces Tier 
// 
// Daniel A. Noventa 
// U. of Illinois, Chicago 
// CS341, Fall 2013 
// Homework 8 
//
using System.Data.Sqlite;
using System.Collections.Generic.List;
using System;

namespace databases
{
	public class DataAccess
	{
		public DataAccess ()
		{

			string connectionInfo = "Data Source = Netflix.sqlite";
			SqliteConnection db = new SqliteConnection(connectionInfo);
			public db.Open();



			
			public string getMovie(string s)
			{ 
				SqliteCommand cmd = new SqliteCommand(db);
				cmd.CommandText = s;
				cmd.ExecuteNonQuery();

				closeDA();
			}

			public void closeDA()
			{
				db.Close();
			}
		}
	}
}

