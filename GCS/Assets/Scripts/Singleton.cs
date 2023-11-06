using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance;

    private void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Player");
        // If there is an instance, and it's not me, delete myself.
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
