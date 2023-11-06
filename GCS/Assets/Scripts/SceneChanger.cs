using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static void ChangeScene(string NextScene)
    {
        SceneManager.LoadScene(int.Parse(NextScene));
    }
    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}

