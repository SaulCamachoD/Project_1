using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorII : MonoBehaviour
{
    private Vector3 initianPosition;
    void Start()
    {
        initianPosition = transform.position;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            MovementDoor();
        }
    }

    public void MovementDoor()
    {
        transform.position = new Vector3(0f, -2f, 0f);
    }
}
