using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBridge : MonoBehaviour
{
    public BridgeMovable bridgeMovable;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            bridgeMovable.ActivateBridgeEvent();
        }
    }
}
