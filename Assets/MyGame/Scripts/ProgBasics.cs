using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("erste Tests mit Operatoren");

        //  Multiplikative Operatoren
        Debug.Log("Multiplikative Operatoren * " + (4 * 4));
        Debug.Log("Multiplikative Operatoren / " + (36 / 4));
        Debug.Log("Multiplikative Operatoren % " + (7 % 2));

        // Additive Operatoren
        Debug.Log("Additive Operatoren + " + (1 + 1));
        Debug.Log("Additive Operatoren - " + (100 - 1));

        // Relationale Operatoren
        Debug.Log("Relationale Operatoren < " + (2 < 3));
        Debug.Log("Relationale Operatoren <= " + (2 <= 2));
        Debug.Log("Relationale Operatoren > " + (28637 > 28638));
        Debug.Log("Relationale Operatoren >= " + (28637 >= 28638));

        // Gleichheits Operatoren
        Debug.Log("Gleichheits Operatoren == " + (3 == 3));
        Debug.Log("Gleichheits Operatoren != " + (2 != 2));

        //Logische Operatoren
        Debug.Log("Logische Operatoren && " + (3 > 2 && 1 < 2));
        Debug.Log("Logische Operatoren | " + (3 < 2 | 1 < 2));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
