using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMision : MonoBehaviour
{
    [SerializeField]
    GameObject misiones; //Prefab de misiones a realizar
    [SerializeField]
    GameObject Content; //gameobject donde se guardan las misiones
    [SerializeField]
    int timeToSpawn; //Tiempo que tarda en crearse una mision
    void Start()
    {
        StartCoroutine(spawnMision());
    }
    IEnumerator spawnMision()
    {
        yield return new WaitForSeconds(timeToSpawn);
        GameObject misionCreated = Instantiate(misiones, Vector3.zero, Quaternion.identity);
        misionCreated.transform.SetParent(Content.transform);
        StartCoroutine(spawnMision());
    }
}
