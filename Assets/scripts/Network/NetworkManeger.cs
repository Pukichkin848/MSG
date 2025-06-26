using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NetworkManeger : MonoBehaviour

{
    public NetworkRunner runner;
    void Start()
    {
        StartGameArgs startGameArgs = new StartGameArgs();
        startGameArgs.GameMode = GameMode.AutoHostOrClient;
        runner.StartGame(startGameArgs);
    }
}
