using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisionBehaviour : MonoBehaviour
{
    GameObject newContent; //Content donde estan las misiones aceptadas

    public void AcceptMision()
    {
        transform.SetParent(newContent.transform);
    }
    public void CancelMision()
    {
        Destroy(gameObject);
    }
}
