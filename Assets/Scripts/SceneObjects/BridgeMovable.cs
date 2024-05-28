using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMovable : MonoBehaviour
{
    public float closeAngle = 0f; 
    public float openSpeed = 2f; 

    private bool isOpen = false; 
    private float initialZRotation; 
    private float targetZRotation; 
    private bool isMoving = false; 

    void Start()
    {
        initialZRotation = transform.rotation.eulerAngles.z; 
        targetZRotation = initialZRotation; 
    }

    void Update()
    {
        if (isMoving)
        {
            float currentZRotation = Mathf.LerpAngle(transform.rotation.eulerAngles.z, targetZRotation, Time.deltaTime * openSpeed);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, currentZRotation);

            
            if (Mathf.Abs(Mathf.DeltaAngle(transform.rotation.eulerAngles.z, targetZRotation)) < 0.1f)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, targetZRotation);
                isMoving = false; 
            }
        }
    }

    public void ActivateBridgeEvent()
    {
        isOpen = !isOpen;
        targetZRotation = isOpen ? closeAngle : initialZRotation;
        isMoving = true; 
    }
}
