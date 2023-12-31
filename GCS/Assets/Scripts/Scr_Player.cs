using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Jugador
    public static Player player;
    // Cosas del jugador
    public static int Dinero;
    public Text PlayerMoney;
    public static int Meteoros;
    private int contadorMeteoros;
    public Text PlayerMeteors;

    // Misiones
    public int CompleteMissions;
    public string Mission;
    public bool MissionStatus;
    public Text ShowMission;
    public List<string> Misiones;
    public int MissionCounter;

    // Start is called before the first frame update
    void Start()
    {
        // If there is an instance, and it's not me, delete myself.
        if (player != null && player != this)
        {
            Destroy(this);
        }
        else
        {
            player = this;
        }

        Dinero = 5000;
        AddMissions();
        SetMissions();
        Meteoros = 0;
        CompleteMissions = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoney.text = Dinero.ToString("");
        PlayerMeteors.text = Meteoros.ToString("");
        ShowMission.text = Mission;
        MissionProgress();
    }

    void AddMissions()
    {
        Misiones.Add("Consigue 5000 de dinero");
        Misiones.Add("Consigue 20 meteoros grandes");
    }

    void SetMissions()
    {
        // Agregar más misiones para que se vaya seleccionando una misión nueva cada vez que se llama la función
        int rnd = Random.Range(0, 2);
        Mission = Misiones[rnd];
        MissionStatus = false;
    }

    void MissionProgress()
    {
        // Dependiendo de la misión esto debera ir variando a lo que se pida en el momento
        if (!MissionStatus)
        {
            if (Mission == "Consigue 5000 de dinero")
            {
                if (MissionCounter == 5000)
                {
                    MissionStatus = true;
                }
            }
            else if (Mission == "Consigue 20 meteoros grandes")
            {
                if (MissionCounter == 20)
                {
                    MissionStatus = true;
                }
            }

        }
        else
        {
            CompleteMissions += 1;
            SetMissions();
        }
    }

    public static void VariableVariation(string thing, int quantity)
    {
        if (thing == "dinero")
        {
            Dinero += quantity;
        }
        else if (thing == "meteoro")
        {
            Meteoros += quantity;
        }
    }
}
