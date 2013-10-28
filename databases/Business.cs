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
		public Business ()
		{

			DataAccess dat = new DataAccess("Netflix.sqlite");

			public void totalMovies()
			{
				Console.WriteLine("Printing out all movies in the database:");

			}

			public void nameLookUp()
			{
				Console.WriteLine("Please insert Movie Name");
				string movie = Console.ReadLine();

				Console.WriteLine(movie + " has ID of:" /* + id */ );

			}

			public void IDLookUp()
			{
				Console.WriteLine("Please insert Movie ID");
				string inID1 = Console.ReadLine();
				int id1 = int.Parse(inID1);

				Console.WriteLine("Movie with ID of " + id1 + " is: " /* + movie name */);
			}

			public void convolutedFunction()
			{
				Console.WriteLine("This is where the magic happens");
				/* magic */
			}

			public void topTenMovies()
			{
				Console.WriteLine("Printing top ten movies ");

			}

			public void totalReviews()
			{
				Console.WriteLine("All Reviews");
			}

			public void averageRatings()
			{
				Console.WriteLine("Average ratings accross all reviews");
			}

			public void userInfo()
			{
				Console.WriteLine("Which user would you like to spy on?");
				string inID2 = Console.ReadLine();
				int id2 = int.Parse(inID2);

				/* get user info */
			}

			public void topTenUsers()
			{
				Console.WriteLine ("Printing top ten users ");
			}

			public void addReview()
			{
				Console.WriteLine("Please insert your review ");
				string review = Console.ReadLine();
			}

			return 0;
		}
	}
}

