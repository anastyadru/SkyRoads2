using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float _asteroidSpeed;
    public float rotation;

    public void Start()
    {
        var asteroid = GetComponent<Rigidbody>();
        asteroid.angularVelocity = Random.insideUnitSphere * rotation;
    }

    public void Update()
    {
        _asteroidSpeed -= 0.15f;
        transform.Translate(0, 0, _asteroidSpeed);
        // transform.Rotate(0.0f, 1f, 0.0f);
    }
}