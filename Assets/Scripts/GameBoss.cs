using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GameBoss : MonoBehaviour
{
    public const string achievement1 = "CggItbTZvnIQAhAA";
    public const string leaderboard = "CggItbTZvnIQAhAC";

    private void Start()
    {
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            if (success) print("Connection estabileshed");
            else print("Google service login error");
        });
    }

    private void Update()
    {
        
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
