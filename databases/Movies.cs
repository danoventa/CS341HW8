using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This was another class presented by Sean Deitz as a solution to the 
// assignment. Will be keeping it, to see if it is needed for my solution. 
// otherwise, will be deleted once I see how it works. 

namespace databases
{
	public class Movie
	{
		public bool valid;
		public long ID;
		public string movieName;
		public int numReviews;
		public double avgReview;
		public int minReview;
		public int maxReview;

		// need to use this function, or whatever, but cant yet. Need to somehow make it connect to the 
		// business layer, where it will be used. 

		public Movie(long pID, string pmovieName, int pnumReviews, double pavgReview, int pminReview, int pmaxReview)
		{
			ID = pID;
			movieName = pmovieName;
			numReviews = pnumReviews;
			avgReview = pavgReview;
			minReview = pminReview;
			maxReview = pmaxReview;
		}
	}
}

