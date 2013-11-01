// 
// N-Tier database app: Data Acces Tier 
// 
// Daniel A. Noventa 
// U. of Illinois, Chicago 
// CS341, Fall 2013 
// Homework 8 
//
// 
// The findObjects funciton was taken from Sean Deitz homework solution. 
// trying to see how it would work with my code. Needed a few more references
// with the mono framework vs. Visual studio. 


using System.Data;
using System.Collections.Generic;
using Mono.Data.Sqlite;
using Mono.Data;
using System;

namespace databases
{
	public class DataAccess
	{
		public string connectionInfo = "Data Source = Netflix.sqlite";
		public SqliteConnection db;
		public SqliteCommand cmd;
		public SqliteDataAdapter adapter; //from Sean Deitz Code

		public object getStuff(string s)
		{ 
			db = new SqliteConnection(connectionInfo);
			db.Open();

			cmd = new SqliteCommand(db);
			cmd.CommandText = s;
			object result = cmd.ExecuteScalar();

			db.Close();
			return result;
		}

		public DataSet findObjects(String command) // from Sean Deitz Code
		{
			DataSet ds = new DataSet(); // Requires using System.Data
			cmd.CommandText = command;
			adapter.Fill(ds);
			return ds;
		}
	}
}

