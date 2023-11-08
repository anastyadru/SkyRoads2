using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float rotationSpeed = 5f;
    private float rotationX = 0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.position += new Vector3(0.8f, 0, 0);
            rotationX = Mathf.Lerp(rotationX, -50f, Time.deltaTime * rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.A)) 
        {
            transform.position += new Vector3(-0.8f, 0, 0);
            rotationX = Mathf.Lerp(rotationX, 50f, Time.deltaTime * rotationSpeed);
        }
        else
        {
            rotationX = Mathf.Lerp(rotationX, 0f, Time.deltaTime * rotationSpeed);
        }

        transform.rotation = Quaternion.Euler(0, 0, rotationX);
    }
}
