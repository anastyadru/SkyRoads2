using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float rotationSpeed = 5f;
    // public float moveSpeed = 3f;
    // public float boostedSpeed = 3.0f;
    public float moveSpeed;
    public float rotationX = 0f;

    private void Start()
    {
        moveSpeed = 3f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            moveSpeed = 10f;
        }
        else
        {
            moveSpeed = 3f;
        }
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 1) // Проверила, чтобы корабль не съехал за правый край дороги
            {
                transform.position += new Vector3(0.8f, 0, 0);
                rotationX = Mathf.Lerp(rotationX, -50f, Time.deltaTime * rotationSpeed);
            }
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -14) // Проверила, чтобы корабль не съехал за левый край дороги
            {
                transform.position += new Vector3(-0.8f, 0, 0);
                rotationX = Mathf.Lerp(rotationX, 50f, Time.deltaTime * rotationSpeed);
            }
        }
        else
        {
            rotationX = Mathf.Lerp(rotationX, 0f, Time.deltaTime * rotationSpeed);
        }

        transform.rotation = Quaternion.Euler(0, 0, rotationX);
    }
    
    // private void OnCollisionEnter(Collision collision)
    // {
    //    if (collision.gameObject.tag == "Asteroids")
    //    {
    //        Debug.Log("Game Over");
    //        GameOver();
    //    }
    // }

    //private void GameOver()
    //{
        
    //}
}