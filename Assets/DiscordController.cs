using System.Collections;using System.Collections.Generic;using UnityEngine;using Discord;using UnityEngine.UI;public class DiscordController : MonoBehaviour
{    //variables/gameobjects	public Discord.Discord discord;	public Text audioText = null;
	public AudioSource AudioPlayer = null;
	// Use this for initialization
	void Start()
	{		discord = new Discord.Discord(969928142795968523, (System.UInt64)Discord.CreateFlags.Default);		var activityManager = discord.GetActivityManager();		var audio = audioText;

		var activity = new Discord.Activity		{			Details = "YOOOOOO MUSIC"
		};


		activityManager.UpdateActivity(activity, (res) =>		{			if (res == Discord.Result.Ok)			{				Debug.Log("Everything is fine!");			}
			else
			{				Debug.LogError("WE ARE NOT GOOD");
			}		});
	}

	// Update is called once per frame
	void Update()
	{
		var Audiopl = AudioPlayer;
		var audio1 = audioText;
		var activityManager = discord.GetActivityManager();

        discord.RunCallBacks();
		//If player is playing music
		if (Audiopl.isPlaying)
		{
			//IF Player Is playing Dream - Mask, Displays the image on discord.
			if (audio1.text == "Dream - Mask")
			{
				var activity1 = new Discord.Activity
				{
					State = "Listening to " + audio1.text,
					Assets =
					{
						LargeImage = "mask",
						LargeText = audio1.text,
						SmallImage = "music",
						SmallText = "Unity Music Player"
					}
				};
				activityManager.UpdateActivity(activity1, (res) =>
				{
					//removed the log code so it dont spam console.
					if (res == Discord.Result.Ok)
					{
						return;
					}
					else
					{
						return;
					}
				});
			}
			// Else if it is playing OTher songs by title, Display their image
			else if (audio1.text == "Lyin' To Me - CG5")
			{
				var activity1 = new Discord.Activity
				{
					State = "Listening to " + audio1.text,
					Assets =
					{
						LargeImage = "lyin",
						LargeText = audio1.text,
						SmallImage = "music",
						SmallText = "Unity Music Player"
					}
				};
				activityManager.UpdateActivity(activity1, (res) =>
				{
					//removed the log code so it dont spam console.
					if (res == Discord.Result.Ok)
					{
						return;
					}
					else
					{
						return;
					}
				});
			}
			else if (audio1.text == "Vision - Lost Sky")
			{
				var activity1 = new Discord.Activity
				{
					State = "Listening to " + audio1.text,
					Assets =
					{
						LargeImage = "vision",
						LargeText = audio1.text,
						SmallImage = "music",
						SmallText = "Unity Music Player"
					}
				};
				activityManager.UpdateActivity(activity1, (res) =>
				{
					//removed the log code so it dont spam console.
					if (res == Discord.Result.Ok)
					{
						return;
					}
					else
					{
						return;
					}
				});
			} else if (audio1.text == "Wilbur Soot - Your New Boyfriend")
			{
				var activity1 = new Discord.Activity
				{
					State = "Listening to " + audio1.text,
					Assets =
					{
						LargeImage = "wilbur",
						LargeText = audio1.text,
						SmallImage = "music",
						SmallText = "Unity Music Player"
					}
				};
				activityManager.UpdateActivity(activity1, (res) =>
				{
					//removed the log code so it dont spam console.
					if (res == Discord.Result.Ok)
					{
						return;
					}
					else
					{
						return;
					}
				});
			} else if (audio1.text == "In the Nether - Larry Poppins")
			{
				var activity1 = new Discord.Activity
				{
					State = "Listening to " + audio1.text,
					Assets =
					{
						LargeImage = "dream2",
						LargeText = audio1.text,
						SmallImage = "music",
						SmallText = "Unity Music Player"
					}
				};
				activityManager.UpdateActivity(activity1, (res) =>
				{
					//removed the log code so it dont spam console.
					if (res == Discord.Result.Ok)
					{
						return;
					}
					else
					{
						return;
					}
				});
			} else if (audio1.text == "RoadTrip Remix - Larry Poppins")
			{
				var activity1 = new Discord.Activity
				{
					State = "Listening to " + audio1.text,
					Assets =
					{
						LargeImage = "dream3",
						LargeText = audio1.text,
						SmallImage = "music",
						SmallText = "Unity Music Player"
					}
				};
				activityManager.UpdateActivity(activity1, (res) =>
				{
					//removed the log code so it dont spam console.
					if (res == Discord.Result.Ok)
					{
						return;
					}
					else
					{
						return;
					}
				});
			} else if (audio1.text == "Clear My Head - Ellis")
            {
				var activity1 = new Discord.Activity
				{
					State = "Listening to " + audio1.text,
					Assets =
					{
						LargeImage = "ellis",
						LargeText = audio1.text,
						SmallImage = "music",
						SmallText = "Unity Music Player"
					}
				};
				activityManager.UpdateActivity(activity1, (res) =>
				{
					//removed the log code so it dont spam console.
					if (res == Discord.Result.Ok)
					{
						return;
					}
					else
					{
						return;
					}
				});
			} else if (audio1.text == "Arcadia - TheFatRat")
            {
				var activity1 = new Discord.Activity
				{
					State = "Listening to " + audio1.text,
					Assets =
					{
						LargeImage = "arcadia",
						LargeText = audio1.text,
						SmallImage = "music",
						SmallText = "Unity Music Player"
					}
				};
				activityManager.UpdateActivity(activity1, (res) =>
				{
					//removed the log code so it dont spam console.
					if (res == Discord.Result.Ok)
					{
						return;
					}
					else
					{
						return;
					}
				});
			}
            // This code replaces the not coded image songs.
            else

            {
				var activity1 = new Discord.Activity
				{
					State = "Listening to " + audio1.text,
					Assets =
					{
						LargeImage = "music",
						LargeText = audio1.text,
						SmallImage = "music",
						SmallText = "Unity Music Player"
					}
				};
				activityManager.UpdateActivity(activity1, (res) =>
				{
					//removed the log code so it dont spam console.
					if (res == Discord.Result.Ok)
					{
						return;
					}
					else
					{
						return;
					}
				});
			}
		} 


		 else
         // this makes it when the music isnt playing it says isnt playing in discord.
        {
			var activity2 = new Discord.Activity
			{
				State = "Not Listening to anything."
			};
			activityManager.UpdateActivity(activity2, (res) =>
			{
				//removed the log code so it dont spam console.
				if (res == Discord.Result.Ok)
				{
					return;
				}
				else
				{
					return;
				}
			});
		}
	}

        void OnDestroy()
        //kills the discord status
	{
		discord.Dispose();
	}
}

