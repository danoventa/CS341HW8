using System;

namespace databases
{
	public class Presentation
	{
		public static void Main (string[] args)
		{
			Business bt = new Business();

			Console.WriteLine("Which function would you like to perform?");
			Console.WriteLine("Enter 1 for total number of Movies.");
			Console.WriteLine("Enter 2 to look up a movie name from a movie ID.");
			Console.WriteLine("Enter 3 to look up movie ID from movie name.");
			Console.WriteLine("Enter 4 to perform a convoluted function");
			Console.WriteLine("Enter 5 to get the top ten movies based on average review");
			Console.WriteLine("Enter 6 for total number of reviews");
			Console.WriteLine("Enter 7 to get average ratings accross all reviews");
			Console.WriteLine("Enter 8 get specific informaition on a user with user ID");
			Console.WriteLine("Enter 9 to get top 10 users based on number of reviews submitted");
			Console.WriteLine("Enter 10 to insert a new review into the database");
			Console.WriteLine("Enter 11 to exit");

			bool testing = true;

			while (testing){
				string input = Console.ReadLine();
				int caseSwitch = int.Parse(input);

				switch (caseSwitch)
				{
				case 1:
					bt.totalMovies();
					break;
				case 2:
					bt.nameLookUp();
					break;
				case 3:
					bt.IDLookUp();
					break;
				case 4:
					bt.convolutedFunction();
					break;
				case 5:
					bt.topTenMovies();
					break;	
				case 6: 
					bt.totalReviews();
					break;
				case 7:
					bt.averageRatings();
					break;
				case 8:
					bt.userInfo(); 
					break;
				case 9:
					bt.topTenUsers();
					break;
				case 10:
					bt.addReview();
					break;
				case 11:
					testing = false;
					Console.WriteLine("Exiting");
					break;
				default:
					Console.WriteLine("Those are not the numbers we are looking for");
					break;
				}
				Console.WriteLine("Next Function:");
			}
			return;
		}
	}
}

