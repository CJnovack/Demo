using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject sphere;
    
    // Update is called once per frame
    void Update()
    {
        Instantiate(sphere);
    }
}
