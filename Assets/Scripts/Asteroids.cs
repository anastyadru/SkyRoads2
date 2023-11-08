using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    private void Start()
    {
        InvokeRepeating("AsteroidsSpace", 0, 1f);
    }

    private void AsteroidsSpace()
    {
        Instantiate(asteroid);
        asteroid.transform.position = new Vector3(Random.Range(-12, 2), 1, 200);
    }
}