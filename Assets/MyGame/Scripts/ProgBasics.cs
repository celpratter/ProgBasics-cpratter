using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour
{
    //public variables
    public int test1;
    public float test2;
    public string test3;
    public string vorname = "Celina";
    public string nachname = "Pratter";


    // Use this for initialization
    void Start()
    {

        test1 = 1;
        test2 = 0.25F;
        test3 = "test3";
        Debug.Log("test 1 in start (mit int): " + test1);
        Debug.Log("test 2 in start (mit float): " + test2);
        Debug.Log("test 3 in start (mit string)" + test3);
        AllTests();

        WerBinIch();
        XY();
        ABC();

        // add values for parameters
        AddNumbers(3, 4);
        MultNumbers(2, 1, 8, 4);

        // all methodes combined
        // Combine();

        meinName();
        DatenParameter("Celina", 18, 4);
        intAdd();


        // return type
        Debug.Log(MyText("cpratter"));
        string drama = MyText("cpratter");
        Debug.Log("neu " + drama);

        // return type
        Debug.Log(StadtLand("Salzburg", "Austria"));
    }

    public void AllTests()
    {
        Debug.Log("all tests: " + test1 + " " + test2 + " " + test3);
    }

    public void WerBinIch()
    {
        Debug.Log("Ich bin " + vorname + " " + nachname);
    }

    // methode referes to methode ABC
    public void XY()
    {
        Debug.Log("Methode XY - führe ABC aus");
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
        Debug.Log("adding numbers numbers " + c);
        test1 = 3;
        Debug.Log("test 1 in AddNumbers " + test1);
    }

    // methode add parameters, new variables
    public void MultNumbers(int d, int e, int f, int g)
    {
        int h = d * e * f * g;
        Debug.Log("* numbers " + h);
    }

    public void meinName()
    {
        Debug.Log("mein Name: " + vorname + "" + nachname);
    }

    public void DatenParameter(string username, int alter, int level)
    {
        Debug.Log("Name: " + username + "  " + "Alter: " + alter + "  " + "Level: " + level + "  ");
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

    // combine methodes
    public void Combine()
    {
        Operators();
        AddNumbers(20, 35);
        MultNumbers(2, 6, 8, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
