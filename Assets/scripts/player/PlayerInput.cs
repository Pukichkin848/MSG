using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct PlayerInput : INetworkInput
{
   public Vector3 moveInput;
    public Vector2 lookInput;
    public bool spaceClicked;
    public bool lmc;
    public bool fClicked;
}

