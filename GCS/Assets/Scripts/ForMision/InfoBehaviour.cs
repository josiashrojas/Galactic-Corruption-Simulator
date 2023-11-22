using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InfoBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject newContent; //Content donde estan las misiones aceptadas

    public GameObject target; //GameObject mostrado

    [SerializeField]
    TextMeshProUGUI nombre;
    [SerializeField]
    TextMeshProUGUI descripcion;
    [SerializeField]
    Image imagen;

    [SerializeField]
    GameObject nombregm;
    [SerializeField]
    GameObject descripciongm;
    [SerializeField]
    GameObject aceptar;
    [SerializeField]
    GameObject cancelar;
    [SerializeField]
    GameObject imagengm;


    public void showInfo(string nombreString,string descripcionString, GameObject newTarget, Image newimagen)
    {
        nombre.text = nombreString;
        descripcion.text = descripcionString;
        target = newTarget;
        imagen.sprite = newimagen.sprite;

        nombregm.SetActive(true);
        descripciongm.SetActive(true);
        aceptar.SetActive(true);
        cancelar.SetActive(true);
        imagengm.SetActive(true);
    }
    public void AcceptMision()
    {
        target.GetComponent<MisionBehaviour>().gm = newContent;
        target.transform.SetParent(newContent.transform);
        target.GetComponent<MisionBehaviour>().nextMision();

        nombregm.SetActive(false);
        descripciongm.SetActive(false);
        aceptar.SetActive(false);
        cancelar.SetActive(false);
        imagengm.SetActive(false);
    }
    public void CancelMision()
    {
        if (target != null)
        {
        Destroy(target);
        }

        nombregm.SetActive(false);
        descripciongm.SetActive(false);
        aceptar.SetActive(false);
        cancelar.SetActive(false);
        imagengm.SetActive(false);
        target = null;
    }
}
