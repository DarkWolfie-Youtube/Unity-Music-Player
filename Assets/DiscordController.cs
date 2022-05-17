using System.Collections;using System.Collections.Generic;using UnityEngine;using Discord;using UnityEngine.UI;public class DiscordController : MonoBehaviour {	public Discord.Discord discord;	public Text audioText = null;
	// Use this for initialization
	void Start () {		discord = new Discord.Discord(id, (System.UInt64)Discord.CreateFlags.Default);		var activityManager = discord.GetActivityManager();		var audio = audioText;		var activity = new Discord.Activity		{			State = "is currently listening to " + audio.text,			Details = "YOOOOOO MUSIC"		};		activityManager.UpdateActivity(activity, (res) =>		{			if (res == Discord.Result.Ok)			{				Debug.Log("Everything is fine!");			} else {				Debug.LogError("WE ARE NOT GOOD");            }		});    }    // Update is called once per frame    void Update()    {

		var audio1 = audioText;
        var activityManager = discord.GetActivityManager();
		var activity1 = new Discord.Activity		{			State = "is currently listening to " + audio1.text,			Details = "YOOOOOO MUSIC"		};
		discord.RunCallbacks();
		activityManager.UpdateActivity(activity1, (res) =>		{			//removed the log code so it dont spam console.			if (res == Discord.Result.Ok)			{				return;			}
			else
			{				return;
			}		});


	}    void OnDestroy()    {		discord.Dispose();	}}