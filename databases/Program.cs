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
			PresentationLayer theProgram = new PresentationLayer ();
			theProgram.OutputTrolls (); // not trolls



			/*
			var query = from m in db.Movies where m.MovieID <= ID 
			orderby m.MovieName select new {ID = m.MovieID, Name = m.MovieName };
			*/ // this looks like sql, shoudl be in dataaccess

			//SetupDB;// prob LINQ
			//string input2 = Console.ReadLine();
			// int ID = int.Parse(input);
			// var query = from m in db.Movies where m.MovieID == ID select m.MovieName;//need LINQ?
			// foreach(var name in query) Console.WriteLine(name);

			/*
			Console.Write ("Please enter a movieID: ");
			string input2 = Console.ReadLine();
			int movieid2 = int.Parse(input2);




			//Console.WriteLine (result2);
			db.Close ();



		}
	}
}
