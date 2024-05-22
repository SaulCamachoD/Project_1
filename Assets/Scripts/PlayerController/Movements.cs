using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    PlayerVariables playerVariables;
    Rigidbody rb;
    private float _mX;
    private float _mZ;
    private float _VR;

    void Start()
    {
        playerVariables = GetComponent<PlayerVariables>();
        rb = GetComponent<Rigidbody>();
        _mX = playerVariables.movInX;
        _mZ = playerVariables.movInZ;
        _VR = playerVariables.rotationSpeed;
    }

    
    void Update()
    {
        _mX = Input.GetAxis("Horizontal");
        _mZ = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(_mX, 0 , _mZ).normalized;

        if (movement.magnitude >= 0.5f )
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _VR, 0.1f);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            rb.MovePosition(transform.position + moveDirection * playerVariables.speed * Time.deltaTime);
        }
    }
}
