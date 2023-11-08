using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private float _asteroidSpeed;

    private void Update()
    {
        _asteroidSpeed -= 0.15f;
        transform.Translate(0, 0, _asteroidSpeed);
    }
}
