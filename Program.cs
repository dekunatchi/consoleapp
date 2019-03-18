using System;

	class Program
	{
		public static int score=0;
		public static int life=5;
		public static int count=0;
		public static void Main()
		{
			Menu();
			Items();
			GameOver();
			
		}
		public static void Menu()
		{
			int choose;
			Console.Clear();
			Console.WriteLine("Select a Game ");
			Console.WriteLine("1. Item Builds");
			Console.WriteLine("2. Hero Builds");
			Console.WriteLine("3. Item Builds(reverse)");
			Console.WriteLine("4. About");
			Console.WriteLine("5. Exit");
			Console.Write("Select Your Choice: ");
			choose = Convert.ToInt32(Console.ReadLine());
			if (choose == 1)
			{
				Console.Clear();
				Console.WriteLine("Item Builds Game");
				Console.WriteLine("Press enter..\n\n\n\n");
				Console.ReadLine();
				Items();
			}
			else if(choose == 2)
			{
				Console.Clear();
				Console.WriteLine("Hero Builds Game");
				Console.WriteLine("Press enter..\n\n\n\n");
				Console.ReadLine();
				Heros();
			}
			
			else if(choose == 5)
			{
				Console.Clear();
				Console.WriteLine("The program will exit..\n");
				Console.WriteLine("Press enter to exit");
				Console.ReadLine();
				Environment.Exit(0);
			}
			else 
			{
				Environment.Exit(0);
			}
		}
		public static void Items()
		{
			string ans;
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("1.Skull Basher + Vanguard + Recipe");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Abyssal Blade" || ans == "abyssal blade")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("2.Vitality Booster + Energy Booster + Recipe");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Aeon Disk" || ans == "aeon disk")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("3. Perseverance + Ultimate Orb + Recipe");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Linkens Sphere" || ans == "linkens sphere")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("4. Staff of Wizardry + Crown + Crown + Recipe");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Rod of Atos" || ans == "rod of atos" || ans == "Rod Of Atos")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("5. Crown + Sages Mask + Wind Lace + Recipe");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Drum of Endurance" || ans == "drum of endurance")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.WriteLine("Congratulations You Finished the Item Builds!");
			Console.Write("Your Total Score is " +score+"\n");
			Console.Write("Press Enter to Continue..");
			Console.ReadLine();
			Menu();
			if (life <= 0)
			{
				GameOver();
			}
			else 
			{
				Items();
			}
		}
		public static void Heros()
		{
			string ans;
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("1. Phase Boots + Battle Fury + Satanic + Abyssal Blade + Desolator + Butterfly");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Phantom Assassin" || ans == "phantom assassin")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("2.Manta Style + Phase Boots + Abyssal Blade + Eye of Skadi + Battle Fury + Mjolnir");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Juggernaut" || ans == "juggernaut" || ans == "jugg")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("3. Linkens Sphere + Boots of Travel + Refresher Orb + Aghanims Scepter + Black King Bar + Octarine Core");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Invoker" || ans == "invoker")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("4. Silver Edge + Phase Boots + Echo Sabre + Desolator + Abyssal Blade + Black King Bar");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Monkey King" || ans == "monkey king"|| ans == "mk")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("5. Guardian Greaves + Vladimirs Offering + Solar Crest + Force Staff + Spirit Vessel + Aghanims Scepter");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Vengeful Spirit" || ans == "vengeful spirit"|| ans == "vs")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=10;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.WriteLine("Congratulations You Finished the Hero Builds!");
			Console.Write("Your Total Score is " +score+"\n");
			Console.Write("Press Enter to Continue..");
			Console.ReadLine();
			Menu();
			if (life <= 0)
			{
				GameOver();
			}
			else 
			{
				Heros();
			}
		}
		
		public static void GameOver()
		{	
			int overchoose;
			Console.Clear();
			Console.WriteLine("Game Over!");
			Console.WriteLine("1. Main Menu");
			Console.WriteLine("2. Exit");
			overchoose = Convert.ToInt32(Console.ReadLine());
			if (overchoose == 1)
			{
				Console.Clear();
				Menu();
			}
			else if (overchoose == 2)
			{
				Environment.Exit(0);
			}
		}
	}