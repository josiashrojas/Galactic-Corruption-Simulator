using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class spawnMercado : MonoBehaviour
{

    [SerializeField]
    GameObject mercadoPrefab;
    [SerializeField]
    Objeto[] objetos;
    [SerializeField]
    GameObject content;
    [SerializeField]
    Inventario inventario;
    [SerializeField]
    TextMeshProUGUI dineroDisplay;


    private List<Objeto> comprados;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDineroDisplay();
        comprados = new List<Objeto>();
        
        foreach(Objeto objeto in objetos)
        {
            GameObject instance = Instantiate(mercadoPrefab, Vector3.zero, Quaternion.identity);
            instance.transform.SetParent(content.transform);
            instance.GetComponentInChildren<TextMeshProUGUI>().text = objeto.nombre + "\n$" + objeto.precio.ToString();
            instance.GetComponentInChildren<Button>().onClick.AddListener(() => comprar(objeto));
        }

    }

    public void UpdateDineroDisplay()
    {
        dineroDisplay.text = "$" + Player.Dinero;
    }

    void comprar(Objeto objeto)
    {
        if (inventario.TieneEspacioDisponible())
        {
            /*
            if(Player.Dinero >= objeto.precio)
            {
            }*/
                Debug.Log("Comprado a "+ objeto.precio.ToString());
                comprados.Add(objeto);
                inventario.updateDisplay();
                Player.Dinero -= objeto.precio;
                UpdateDineroDisplay();
            /*
            else
            {
                Debug.Log("No se puede comprar, falta dinero");
            }*/
        }
        else
        {
            Debug.Log("No se puede comprar, falta espacio");
        }
    }

    public List<Objeto> GetObjetos()
    {
        return comprados;
    }

}

[System.Serializable]
public class Objeto
{
    public string nombre;
    public int precio;
    public string descripcion;
}
