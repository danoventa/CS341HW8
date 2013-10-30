// 
// N-Tier database app: Business Tier 
// 
// Daniel A. Noventa
// U. of Illinois, Chicago 
// CS341, Fall 2013 
// Homework 8 
//

using System.Collections.Generic;
using System;


namespace databases
{
	public class Business
	{
		DataAccess dat = new DataAccess("Netflix.sqlite");

		public void totalMovies()
		{

			Console.WriteLine("Printing out total number of movies in the database:");
			Console.WriteLine(dat.getStuff("SELECT COUNT(*) FROM Movies"));
		}

		public void nameLookUp()
		{
			Console.WriteLine("Enter a movie ID");
			string movie = Console.ReadLine();
			Console.WriteLine(dat.getStuff("SELECT MovieName FROM Movies WHERE MovieID = " + movie ));
		}

		public void IDLookUp()
		{
			Console.WriteLine("Enter a movie name");
			string movie = Console.ReadLine();
			Console.WriteLine(movie);

			Console.WriteLine(dat.getStuff("SELECT MovieID FROM Movies WHERE MovieName = " + movie ));
		}

		public void convolutedFunction()
		{
			Console.WriteLine("This is where the magic happens");
			/* magic */
		}

		public void topTenMovies()
		{
			Console.WriteLine("Printing top ten movies ");
			/* get top ten movies from data access */
		}

		public void totalReviews()
		{
			Console.WriteLine("Total Number of Reviews");
			Console.WriteLine(dat.getStuff("SELECT COUNT(*) FROM Reviews"));

			/* return all reviews from the database */
		}

		public void averageRatings()
		{
			Console.WriteLine("Average ratings accross all reviews, give it a few seconds");
			Console.WriteLine(dat.getStuff(@"SELECT AVG(Rating) FROM Reviews INNER JOIN Movies"));

			/* send request to do all average ratings from database */
		}

		public void userInfo()
		{
			Console.WriteLine("Enter a user ID");
			string user = Console.ReadLine();
			int id2 = int.Parse(user);

			/* get user info */
		}

		public void topTenUsers()
		{
			Console.WriteLine ("Printing top ten users ");
			/*send string to print top ten users to data acces */
		}

		public void addReview()
		{
			Console.WriteLine("Enter a Movie name or id: ");
			string movie = Console.ReadLine();
			Console.WriteLine("Enter a review for Movie " + movie + ".");
			string review = Console.ReadLine();
			int movieID = 0;

			if (int.TryParse(movie, out movieID))
			{
				/* use movie ID to look up movie to review */
			}
			else{
				/* use movie name to look up movie for review */
			}
		}
	}
}

