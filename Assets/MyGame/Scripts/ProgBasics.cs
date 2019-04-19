using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour
{
    public int test1;
    public float test2;
    public string test3;
    public string vorname = "Celina";
    public string nachname = "Pratter";



    // Use this for initialization
    void Start()
    {

        test1 = 1;
        Debug.Log("test 1 in start " + test1);
        XY();

        // add values for parameters
        AddNumbers(3, 4);
        MultNumbers(2, 1, 8, 4);

        // all methodes combined
        Combine();

        // return type
        Debug.Log(MyText("cpratter"));
        string drama = MyText("cpratter");
        Debug.Log("neu " + drama);

        meinName();
        intAdd();

        Debug.Log(StadtLand("Salzburg", "Austria"));

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
        test1 = 3;
        Debug.Log("test 1 in AddNumbers " + test1);
    }

    // methode add parameters, new variables
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

    public void meinName()
    {
        Debug.Log("mein Name: " + vorname + "" + nachname);

    }

    public void intAdd()
    {
        int eins;
        eins = 1;
        int vier;
        vier = 4;

        Debug.Log("int addieren " + (eins + vier));
    }



    public string StadtLand(string stadt, string land)
    {
        return "Heimat: " + stadt + ", " + land;
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
