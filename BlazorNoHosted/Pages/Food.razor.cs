using System.Web;

namespace BlazorNoHosted.Pages
{
	public partial class Food
	{
		List<FoodQuestion> FoodQuestions { get; set; } = new List<FoodQuestion>();
		public int CurrentQuestion { get; set; } = 1;

		public List<HistoryItem> History { get; set; } = new List<HistoryItem>();

		public Food()
		{
			FoodQuestions.Add(Question(0, "Are you hungry?", Answer("Yes", 8), Answer("No", 3)));
			FoodQuestions.Add(Question(1, "Are you going out with friends?", Answer("Yes", 2), Answer("No", 0)));
			FoodQuestions.Add(Question(2, "Your social life is important! Enjoy your meal!"));
			FoodQuestions.Add(Question(3, "Do you really want to eat?", Answer("Yes", 4), Answer("No", 7)));
			FoodQuestions.Add(Question(4, "REALLY, really?", Answer("Yes", 6), Answer("No", 7)));
			FoodQuestions.Add(Question(5, "Go to the store and enjoy your meal!"));
			FoodQuestions.Add(Question(6, "Do you have enough spare calories today, burned not included?", Answer("Yes", 10), Answer("No", 7)));
			FoodQuestions.Add(Question(7, "Don't be a little bitch."));
			FoodQuestions.Add(Question(8, "Really?", Answer("Yes", 6), Answer("No", 7)));
			FoodQuestions.Add(Question(9, "Okay, whatever, enjoy your takeaway meal."));
			FoodQuestions.Add(Question(10, "Would you be able to distract yourself for about hour, instead?", Answer("Yes", 7), Answer("No", 12)));
			FoodQuestions.Add(Question(11, "Is there still time to go to the store?", Answer("Yes", 5), Answer("No", 9)));
			FoodQuestions.Add(Question(12, "Do you have food at home?", Answer("Yes", 13), Answer("No", 14)));
			FoodQuestions.Add(Question(13, "Enjoy your meal!"));
			FoodQuestions.Add(Question(14, "Check again.", Answer("Yes", 13), Answer("No", 11)));
		}

		private FoodQuestion Question(int id, string question, params FoodAnswer[] answers)
		{
			return new FoodQuestion(id, question, answers.ToList());
		}

		private FoodAnswer Answer(string answer, int question)
		{
			return new FoodAnswer(answer, question);
		}

		public void NextQuestion(int id, string question, string answer)
		{
			History.Add(new HistoryItem(question, answer));
			CurrentQuestion = id;
		}
	}

	public class HistoryItem
	{
		public string Question { get; set; } = string.Empty;
		public string Answer { get; set; } = string.Empty;

		public HistoryItem(string question, string answer)
		{
			Question = question;
			Answer = answer;
		}
	}

	public class FoodQuestion
	{
		public int Id { get; set; } = -1;
		public string Question { get; set; } = string.Empty;
		public List<FoodAnswer> Answers { get; set; }

		public FoodQuestion(int id, string question, List<FoodAnswer> answers)
		{
			Id = id;
			Question = question;
			Answers = answers;
		}
	}

	public class FoodAnswer
	{
		public string Answer { get; set; } = string.Empty;
		public int Question { get; set; } = -1;

		public FoodAnswer(string answer, int question)
		{
			Answer = answer;
			Question = question;
		}
	}
}
