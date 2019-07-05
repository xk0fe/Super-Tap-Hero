using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GameBoss : MonoBehaviour
{
    public const string Achievement1 = "CggItbTZvnIQAhAA"; //level completed
    public const string Achievement2 = "CggItbTZvnIQAhAD"; //three stars on any level
    public const string Achievement3 = "CggItbTZvnIQAhAE"; //stats menu found
    public const string Leaderboard = "CggItbTZvnIQAhAC";

    private void Start()
    {
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            if (success) print("Connection estabileshed");
            else print("Google service login error");
        });
    }

    public void UpdateLeaderboard()
    {
        if(!PlayGamesPlatform.Instance.localUser.authenticated)
        {
            return;
        }
        Social.ReportScore(LevelManager.CoinCount, "CggItbTZvnIQAhAC", (bool success) => {
            if (success) print("Your coins been recorded.");
            else print("Coins are destroyed ;o");
        });
    }


    public void ResetSavedData()
    {
        PlayerPrefs.DeleteAll();
    }

    private void OnApplicationQuit()
    {
        PlayGamesPlatform.Instance.SignOut();
    }

    public void GetTheAchievement(string id)
    {
        Social.ReportProgress(id, 100.0f, (bool success) =>
        {
            if (success) print("Achievement get: " + id);
        });
    }

}
