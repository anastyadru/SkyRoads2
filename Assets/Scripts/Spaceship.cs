using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float rotationSpeed = 5f;
    private float rotationX = 0f;
    public float boostedSpeed = 1.6f;
    public float normalSpeed = 0.8f;
    private float currentSpeed;

    private void Start()
    {
        currentSpeed = normalSpeed;
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.position += new Vector3(currentSpeed, 0, 0);
            rotationX = Mathf.Lerp(rotationX, -50f, Time.deltaTime * rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.A)) 
        {
            transform.position += new Vector3(-currentSpeed, 0, 0);
            rotationX = Mathf.Lerp(rotationX, 50f, Time.deltaTime * rotationSpeed);
        }
        else
        {
            rotationX = Mathf.Lerp(rotationX, 0f, Time.deltaTime * rotationSpeed);
        }

        transform.rotation = Quaternion.Euler(0, 0, rotationX);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentSpeed = boostedSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            currentSpeed = normalSpeed;
        }
    }
}