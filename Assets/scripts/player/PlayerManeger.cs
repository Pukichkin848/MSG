using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour
{
    public NetworkEvents events;
    public NetworkObject playerPrefab;
    public bool spaceClicked;
    public bool lmc;
    public bool fClicked;
    void Awake()
    {
        events.PlayerJoined.AddListener(OnPlayerJoined);
        events.PlayerLeft.AddListener(OnPlayerLeft);
        events.OnInput.AddListener(OnInput);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceClicked = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            lmc = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            print("мышка зажата");

        }
        if (Input.GetMouseButtonUp(1))
        {
            print("мышка отжата ");

        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            fClicked = true;
        }

    }
    private void OnPlayerJoined(NetworkRunner runner,PlayerRef player)
    {
        Debug.Log($"Ѕрод€га по имене <b><color=green>{player}</color></b> зашЄл");
        NetworkObject newPlayer = runner.Spawn(playerPrefab, inputAuthority:player) ;
        runner.SetPlayerObject(player,newPlayer);
    }   
    private void OnPlayerLeft(NetworkRunner runner,PlayerRef player)
    {
        Debug.Log($"<b><color=yellow>{player}</color></b> пошЄл кушать");
        runner.Despawn(runner.GetPlayerObject(player));
    }
    private void OnInput(NetworkRunner runner,NetworkInput input)
    {
        PlayerInput playerInput = new PlayerInput();
        playerInput.moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerInput.lookInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        playerInput.spaceClicked = spaceClicked;
        spaceClicked = false;
        playerInput.lmc = lmc;
        lmc = false;
        playerInput.fClicked = fClicked;
        fClicked = false;
        input.Set(playerInput);

        

    }

}
