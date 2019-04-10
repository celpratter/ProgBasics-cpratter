using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Operators();
        XY();

        // values for a and b
        AddNumbers(3, 4);
        MultNumbers(2, 1, 8, 4);
        // Combine();

        Debug.Log(MyText("cpratter"));
        string drama = MyText("cpratter");
        Debug.Log(drama);

    }

    // methode referes to methode ABC
    public void XY()
    {
        Debug.Log("Methode XY");
        ABC();
    }


    public void ABC()
    {
        Debug.Log("ABC wird ausgeführt");
        Debug.Log(1 + 2);
    }


    // methode add parameters, new variables
    public void AddNumbers(int a, int b)
    {
        int c = a + b;
        Debug.Log("+ numbers " + c);
    }

    public void MultNumbers(int d, int e, int f, int g)
    {
        int h = d * e * f * g;
        Debug.Log("* numbers " + h);
    }

    // combines all methodes
    public void Combine()
    {
        Operators();
        AddNumbers(20, 35);
        MultNumbers(2, 6, 8, 4);
    }


    // return type methode string
    public string MyText(string myname)
    {
        return "Drama" + " " + myname;
    }

    // Methode Operatoren
    public void Operators()
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
