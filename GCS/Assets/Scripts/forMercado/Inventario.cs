using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventario : MonoBehaviour
{
    [SerializeField]
    int limiteInventario;
    [SerializeField]
    GameObject inventarioPrefab;
    [SerializeField]
    GameObject content;

    [SerializeField]
    spawnMercado mercado;

    List<Objeto> inventario = new List<Objeto>();


    public void updateInventario()
    {
        inventario = mercado.GetObjetos();
    }

    public void LoadInventario()
    {
        clearContent();
        updateInventario();
        foreach (Objeto objeto in inventario)
        {
            GameObject instance = Instantiate(inventarioPrefab, Vector3.zero, Quaternion.identity);
            instance.transform.SetParent(content.transform);
            instance.GetComponentInChildren<TextMeshProUGUI>().text = objeto.nombre;
        }
    }

    void clearContent()
    {
        foreach(Transform child in content.transform)
        {
            Destroy(child.gameObject);
        }
    }

    public bool TieneEspacioDisponible()
    {
        return (limiteInventario - inventario.Count) > 0;
    }
}
