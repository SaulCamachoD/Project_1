using UnityEngine;

public class PointRotateCam : MonoBehaviour
{
    private Quaternion startRotation;
    private Quaternion endRotation;
    private bool isRotating = false;
    private bool rotatingForward = true;
    private float rotationTime = 0.0f;
    private float duration = 1.0f; 

    void Start()
    {
        startRotation = Quaternion.Euler(30, -45, 0);
        endRotation = Quaternion.Euler(30, 45, 0);
        transform.rotation = startRotation;
    }

    void Update()
    {
        if (isRotating)
        {
            rotationTime += Time.deltaTime / duration;

            if (rotatingForward)
            {
                transform.rotation = Quaternion.Lerp(startRotation, endRotation, rotationTime);
            }
            else
            {
                transform.rotation = Quaternion.Lerp(endRotation, startRotation, rotationTime);
            }

            if (rotationTime >= 1.0f)
            {
                isRotating = false;
            }
        }
    }

    public void StartRotation45()
    {
        if (!isAtRotation(endRotation))
        {
            isRotating = true;
            rotatingForward = true;
            rotationTime = 0.0f;
        }
    }

    public void StartRotationOrigin()
    {
        if (!isAtRotation(startRotation))
        {
            isRotating = true;
            rotatingForward = false;
            rotationTime = 0.0f;
        }
    }

    private bool isAtRotation(Quaternion targetRotation)
    {
        return Quaternion.Angle(transform.rotation, targetRotation) < 0.1f;
    }
}