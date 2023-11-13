using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float _asteroidSpeed;
    // public float rotationSpeed = 50f;
    public void Update()
    {
        // transform.Rotate(transform.up, rotationSpeed * Time.deltaTime);
        _asteroidSpeed -= 0.15f;
        transform.Translate(0, 0, _asteroidSpeed);
    }
}