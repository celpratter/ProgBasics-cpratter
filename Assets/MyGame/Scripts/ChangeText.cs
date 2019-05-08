using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public TestRandom myScript;
    public Text myText;
    private int countPresses = 0;
    public TextMeshProUGUI myTMPText;

    //zufall generieren
    private System.Random rnd = new System.Random();
    private System.Random seedRnd = new System.Random(123);


    public void addPress()
    {
        // countPresses= countPresses + 1;
        countPresses++;
        // countPresses += 1;
        Debug.Log("counts: " + countPresses);
        myText.text = countPresses.ToString();
        //mit seed abprüfbar - immer selbe sequenz mit selbem seed
        Debug.Log("----------- DES IS RANDOM seed " + seedRnd.Next(0, 5));

    }


    // Use this for initialization
    void Start()
    {
        //variable.typ
        myText.text = "Helloo";
        myText.fontSize = 200;
        myTMPText.text = "byeee";
        Debug.Log("+++++++ DES IS RANDOM " + rnd.Next(0, 5));
        Debug.Log("||||||| DES IS RANDOM " + UnityEngine.Random.Range(0, 1));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
