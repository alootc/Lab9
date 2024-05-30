using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graficonodirigido : MonoBehaviour
{

    public int cost_energy;
    public Graficonodirigido[] list_nodos;


    public Graficonodirigido GetNodeRandom()
    {
        return list_nodos[Random.Range(0, list_nodos.Length)];
    }


}
