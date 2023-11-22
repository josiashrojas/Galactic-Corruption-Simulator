using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MisionBehaviour : MonoBehaviour
{
    [SerializeField]
    public GameObject newContent; //Content donde estan las misiones aceptadas

    public GameObject gm;

    //Info de la mision
    [SerializeField]
    string nombre;
    [SerializeField]
    string descripcion;
    [SerializeField]
    Image imagen;

    int misionStatus = 0; //0 = Mision por aceptar, 1= mision aceptada

    public void LookInfo(GameObject gm)
    {
        gm.GetComponent<InfoBehaviour>().showInfo(nombre, descripcion, gameObject, imagen);
    }
    public void nextMision()
    {
        misionStatus = 1;
    }
}
