using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetections : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            print("Caiste");
        }
    }

}
