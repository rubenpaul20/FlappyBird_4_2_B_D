using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeaweedCollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Fish has entered the seaweed");
        //Loud our game scene when the fish hits the seaweed
        SceneManager.LoadScene(0);
    }
}