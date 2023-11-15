using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class Spaceship : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float normalSpeed = 3f;
    public float boostedSpeed = 10f;
    private float moveSpeed;
    private float rotationX = 0f;
    // public ScoreManager scoreManager;
    // public Text scoreText;
    
    // private void Start()
    // {
    //    scoreManager = FindObjectOfType<ScoreManager>();
    // }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveSpeed = boostedSpeed;
            // scoreManager.AddBoostSpeedPoints();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            moveSpeed = normalSpeed;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1) // Проверила, чтобы корабль не съехал за правый край дороги
            {
                transform.position += new Vector3(0.8f, 0, 0);
                rotationX = Mathf.Lerp(rotationX, -50f, Time.deltaTime * rotationSpeed);
            }
        }
        else if (Input.GetKey(KeyCode.A))
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
    
    // private void FixedUpdate()
    // {
    //    float scoreIncrease = 0;

    //    if (moveSpeed == normalSpeed)
    //    {
    //        scoreIncrease = 1; // 1 очко в секунду за полёт на обычной скорости
    //    }
    //    else if (moveSpeed == boostedSpeed)
    //    {
    //        scoreIncrease = 2; // 2 очка в секунду за полёт в режиме ускорения
    //    }

    //    scoreManager.AddScore(scoreIncrease * Time.deltaTime); // Увеличиваем счет на основе времени и бонусных очков

    //    scoreText.text = "Score: " + Mathf.Round(scoreManager.GetScore()).ToString();
    //}

    // private void OnTriggerEnter(Collider other)
    // {
    //    if (other.tag == "Asteroid")
    //    {
    //        scoreManager.AddScore(5); // 5 очков за пройденный астероид
    //    }
    // }
    
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