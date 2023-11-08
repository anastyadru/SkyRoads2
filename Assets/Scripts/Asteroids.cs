using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    private void Start()
    {
        InvokeRepeating("AsteroidsSpace", 0, 5f);
    }

    private void AsteroidsSpace()
    {
        Instantiate(asteroid);
        asteroid.transform.position = new Vector3(Random.Range(-14, 6), 1, 200);
    }
}