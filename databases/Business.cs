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
				Console.WritLine("Enter a movie ID");
				string movie = Console.ReadLine();

				Console.WriteLine(movie + " has ID of:" /* + id */ );

			}

			public void IDLookUp()
			{
				Console.WritLine("Enter a movie name");
				string movie = Console.ReadLine();
				int id1 = int.Parse(movie);

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
				/* get top ten movies from data access */
			}

			public void totalReviews()
			{
				Console.WriteLine("All Reviews");
				/* return all reviews from the database */
			}

			public void averageRatings()
			{
				Console.WriteLine("Average ratings accross all reviews");
				/* send request to do all average ratings from database */
			}

			public void userInfo()
			{
				Console.WritLine("Enter a user ID");
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
				Console.WritLine("Enter a Movie name or id: ");
				string movie = Console.ReadLine();
				Console.WritLine("Enter a review for Movie " + movie + ".");
				string review = Console.ReadLine();
			
				if (int.tryParse(movie, out movieID){
					/* use movie ID to look up movie to review */
				}
				else{
					/* use movie name to look up movie for review */
				}
				string review = Console.ReadLine();
			}

			return 0;
		}
	}
}

