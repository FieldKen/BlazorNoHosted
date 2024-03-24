using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace BlazorNoHosted.Pages
{
	public partial class Story
	{
		public List<Question> Questions = new List<Question>();
		public List<Person> People = new List<Person>();
		public int Question { get; set; } = 1;
		public List<int> Answers { get; set; } = new List<int>();

        public Story()
		{
			Questions.Add(new Question(
				[
					"The morning light hadn't even begun to seep through the cracks when my eyes snapped open, confusion clouding my mind. Where was I? The room was bare, the walls cold and uninviting. Before I could even attempt to piece together how I ended up here, the door creaked open, and a shadowy figure stepped in. \"It's time,\" they said, their voice a chilling whisper that seemed to echo off the walls.",
					"I had no idea what they meant, but their presence sent a shiver down my spine. They spoke of a choice I had to make, one that seemed straight out of a nightmare. Fight a tiger or an elephant, they said, in a battle where the stakes were life or death. And the catch? I'd be facing this beast with nothing but my bare hands.",
					"As they laid out the rules, the reality of my situation began to sink in. This wasn't just some bizarre dream; it was a fight for survival. The thought of standing in the colosseum, vulnerable and exposed, facing a creature of such immense power, was overwhelming. How did I get here? What had I done to deserve this? The questions swirled in my mind, but there was no time for answers. The choice was mine to make, and the clock was ticking."
				],
				[
					"I would rather fight a tiger to the death.",
					"I would rather fight an elephant to the death."
				])
			);

			Questions.Add(new Question(
				[
					"Exhausted, every muscle in my body screaming, I stumbled out of the colosseum, the roars of the crowd fading behind me. The mysterious figure caught my attention, and offered me a reward as he held two small chests in his hand.",
					"He explained, \"In one chest, there's a pill that will keep you strong and fit forever. The other chest has a pill that will protect you from ever getting sick or getting a serious disease when you get older.\"",
					"I looked at the chests, feeling the weight of this big decision. The idea of always being in great shape was tempting, especially after such a tough battle. But then, not having to worry about serious illnesses sounded like a huge relief too.",
					"The figure stood quietly, waiting for me to decide..."
				],
				[
					"I want to stay in shape forever!",
					"I never want to get sick again!"
				])
			);

			Questions.Add(new Question(
				[
					"With a silent nod, the mysterious figure handed me the chosen chest. In a surprising move, they crushed the pill from the other chest, leaving no trace of what could have been. Guiding me out of the colosseum, I took the pill, feeling its effects ripple through my body instantly, each cell buzzing with newfound vitality.",
					"Stepping into the daylight, I found myself in a small, unfamiliar town, pockets empty, without a single coin to my name. As I wandered, searching for some way to get by, I came across an animal shelter. Desperate, I inquired about any available work. To my relief, they were in need of help.",
					"\"You're in luck,\" said the person at the shelter, a smile warming their face. \"We're very busy today and we need someone to walk the dogs, or you could help us out and groom our cats so we can take care of the dogs instead!\""
				],
				[
					"Walking the dogs sounds like fun!",
					"I'll take care of the cats!"
				])
			);

			Questions.Add(new Question(
				[
					"With the money I earned from a day filled with furry companions, my stomach began to grumble, reminding me of the need to refuel. Walking into the heart of the town, I stumbled upon a quaint little restaurant, its menu curiously limited to just two items: pizza or burgers.",
					"The waiter comes to me and asks if I had chosen what to eat. After a brief pause I confidently answer."
				],
				[
					"I'll eat a large pizza.",
					"I feel like eating burgers today."
				])
			);

			Questions.Add(new Question(
				[
					"As I made my choice between the pizza and burger, the waiter raised an eyebrow, seemingly surprised by my decision, but jotted it down nonetheless. He turned to leave, then paused, spinning back around with a curious glance. \"And what can I get you to drink?\" he asked.",
					"I pondered for a moment, caught between the desire for something alcoholic to unwind after the day's unexpected trials and adventures, or opting for a non-alcoholic beverage to stay sharp and refreshed."
				],
				[
					"Coffee, tea, or maybe a soda sounds great.",
					"Beer, wine or even something stronger to end the day."
				])
			);

			Questions.Add(new Question(
				[
					"After enjoying my meal, I realized I needed to figure out where to sleep. My money was running low, and there were two hotels nearby that caught my eye. One was clearly budget-friendly, nothing fancy, but it looked clean enough. The other hotel was way out of my price range, luxurious and inviting, promising a really comfortable night's sleep.",
					"I was stuck deciding between saving my money and staying somewhere simple, or treating myself to a good night's rest after such a long day but risking running out of money. It was a tough call, especially since I didn't know how long I'd be in this town or what expenses might come up next."
				],
				[
					"As long as I can sleep in a bed.",
					"I want to be treated well and have a comfortable night of sleep."
				])
			);
			Questions.Add(new Question(
				[
					"Lying in bed, the quiet of the room was suddenly broken by the sound of music drifting in through the window. Intrigued, I decided to slip out and see where it was coming from. The lively beats led me to a street party, where the energy was palpable, people moving to the rhythm, completely lost in the moment.",
					"As I stood there, taking it all in, some party-goers noticed me and gestured for me to join them in the dance.I found myself at a crossroads, unsure whether to dive into the festivities or remain a spectator on the sidelines."
				],
				[
					"I decide to dance, I'm feeling energetic!",
					"I think I'll just stay at the bar."
				])
			);

			Questions.Add(new Question(
				[
					"DJ Qetor, perched behind his setup, caught my eye and gestured me over. Curiosity getting the better of me, I approached, and we struck up a conversation about music and the vibrant energy of the night. He was surprisingly easy to talk to, and it felt like we'd known each other for more than just a few minutes.",
					"After a while, he handed me a pair of headphones and asked, \"What song would you like to hear next?\" It was an unexpected offer, one that felt like a small but significant way to leave my mark on the evening."
				],
				[
					"I'm feeling the latest pop song, it's popular for a reason, right?",
					"I decide to switch it up and play a long forgotten rock song from the 90s.",
				])
			);

			Questions.Add(new Question(
				[
					"As the first light of dawn began to paint the sky, the party's energy showed no sign of waning. Yet, in that serene moment of transition from night to day, the mysterious figure reappeared, as if out of nowhere, their presence instantly commanding my attention amidst the fading beats.",
					"They leaned in, their voice barely above the music, and said, \"You only have time for one more adventure here. What will it be? Do you wish to explore the hidden gems of the city, or would you prefer to immerse yourself in the natural beauty that surrounds it?\"",
					"His question caught me off guard. The city, with its streets now familiar and inviting, promised more undiscovered stories and sights. On the other hand, the allure of nature, with its tranquil landscapes and the promise of peace, stood in stark contrast to the vibrant city life."
				],
				[
					"I want to explore more of the city's museums and monuments!",
					"Let's go visit the nearby forest and enjoy the peace and quiet."
				])
			);

			Questions.Add(new Question(
				[
					"I realized it was time to think about heading back home. But how should I get there? I could hop on a plane and be back before I knew it, or I could turn the journey into an adventure of its own with a road trip.",
					"The thought of flying was tempting for its speed and simplicity, but the idea of driving back, taking in new sights along the way, also had its appeal. It was a tough choice. A plane ride meant getting back to routine quickly, while a road trip could extend this unexpected escape a little longer, offering a chance to reflect on everything that had happened."
				],
				[
					"Let's turn it into a road trip!",
					"I'll just take the plane."
				])
			);

			Questions.Add(new Question(
				[
					"Arriving back home, I paused to consider how I wanted to spend the rest of my day. The thought of playing video games and catching up on TV shows was appealing, a way to relax and slowly ease back into my regular life. It felt like a cozy option, just unwinding on the couch with some snacks and letting myself zone out for a bit.",
					"On the other hand, getting outside for some sports sounded energizing. It could be a great way to keep the momentum of my recent adventures going, using the exercise to clear my mind and maybe reflect on everything that had happened."
				],
				[
					"I think I'll just lie in the couch.",
					"Let's go outside again!"
				])
			);

			People.Add(new Person("De Keyser", [0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0]));
			People.Add(new Person("Eva", [0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0]));
			People.Add(new Person("Iliana", [1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0]));
			People.Add(new Person("Ivan", [0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1]));
			People.Add(new Person("Jasper", [0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0]));
			People.Add(new Person("Jochen", [0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1]));
			People.Add(new Person("Joran", [1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0]));
			People.Add(new Person("Ken", [1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0]));
			People.Add(new Person("Lars", [0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0]));
			People.Add(new Person("Lennert", [0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0]));
			People.Add(new Person("Maurice", [1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 0]));
			People.Add(new Person("Mike", [1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0]));
			People.Add(new Person("Sharron", [1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0]));
			People.Add(new Person("Sian", [1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1]));
			People.Add(new Person("Vermachelen", [1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0]));
			People.Add(new Person("Yanis", [0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1]));
			People.Add(new Person("Stijn", [1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0]));
			People.Add(new Person("Ole Lammens?", [1,1,1,0,0,0,1,1,1,1,1]));

			//People.Add(new Person("Evert", [-1, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1]));
			//People.Add(new Person("Fee", [-1, 1, 1, 0, 0, -1, 1, -1, -1, 1, 0]));
			//People.Add(new Person("Cedric", [1, 0, 1, 1, 1, 0, -1, -1, -1, -1, -1]));
			//People.Add(new Person("Koen", [-1, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1]));
		}

		public void NextQuestion(int i)
		{
			Answers.Add(i);
			Question += 1;

		}

		public static PersonComparisonResult FindSimilarities(List<int> myAnswers, List<Person> people)
		{
			PersonComparisonResult result = new PersonComparisonResult();
			int highestScore = -1, secondHighestScore = -1, lowestScore = myAnswers.Count + 1;
			int earliestMatchMostSimilar = myAnswers.Count + 1, earliestMatchSecondSimilar = myAnswers.Count + 1;

			foreach (var person in people)
			{
				int score = 0;
				int firstDiscrepancy = myAnswers.Count + 1;

				for (int i = 0; i < myAnswers.Count; i++)
				{
					if (myAnswers[i] == person.Answers[i])
					{
						score++;
					}
					else if (firstDiscrepancy == myAnswers.Count + 1)
					{
						firstDiscrepancy = i;
					}
				}

				// Update Most Similar
				if (score > highestScore || (score == highestScore && firstDiscrepancy < earliestMatchMostSimilar))
				{
					// Before updating the most similar, shift the current most similar to second most similar
					result.SecondMostSimilar = result.MostSimilar;
					secondHighestScore = highestScore;
					earliestMatchSecondSimilar = earliestMatchMostSimilar;

					result.MostSimilar = person;
					highestScore = score;
					earliestMatchMostSimilar = firstDiscrepancy;
				}
				else if (score > secondHighestScore || (score == secondHighestScore && firstDiscrepancy < earliestMatchSecondSimilar))
				{
					// Update Second Most Similar
					result.SecondMostSimilar = person;
					secondHighestScore = score;
					earliestMatchSecondSimilar = firstDiscrepancy;
				}

				// Update Least Similar
				if (score < lowestScore)
				{
					result.LeastSimilar = person;
					lowestScore = score;
				}
			}

			return result;
		}
	}
	public class Question
	{
		public List<string> FullStory = new List<string>();
		public List<string> Answers { get; set; }

		public Question(List<string> fullStory, List<string> answers)
		{
			FullStory = fullStory;
			Answers = answers;
		}
	}

	public class PersonComparisonResult
	{
		public Person MostSimilar { get; set; }
		public Person SecondMostSimilar { get; set; }
		public Person LeastSimilar { get; set; }

		public PersonComparisonResult()
		{
			MostSimilar = null!;
			SecondMostSimilar = null!;
			LeastSimilar = null!;
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public List<int> Answers { get; set; }
		public Person(string name, List<int> answers)
		{
			Name = name;
			Answers = answers;
		}
	}
}
