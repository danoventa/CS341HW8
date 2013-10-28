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




			/*	
			 * 	1. Ability to retrieve total # of movies 
			 *	2. Ability to lookup a movie name from a movie id 
			 *	3. Ability to lookup a movie id from a movie name 
			 *	4. Ability to retrieve information about all the movies: ids, names, number of reviews, average rating, 
			 *		lowest rating, and highest rating; also the ability to foreach through this data 
			 *	5. Ability to retrieve top-10 movies with the highest average ratings 
			 *	6. Ability to retrieve total # of reviews 
			 *	7. Ability to retrieve average rating across all the reviews 
			 *	8. Ability to retrieve information about a user based on user id: number of distinct movies reviewed, 
			 *		number of reviews submitted, and average rating given by user across all their reviews 
			 *	9. Ability to retrieve top-10 users who have submitted the most reviews 
			 *	10. Ability to insert a new review into the database
			 */
		}
	}
}

