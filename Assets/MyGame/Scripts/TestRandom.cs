using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRandom : MonoBehaviour
{
    public float minValX = -6f;
    public float maxValX = 6f;
    public float rndVal;
    public float rndVal2;
    private System.Random rndSystem = new System.Random();

    void Start()
    {
        rndVal = rndSystem.Next(-6, 6);
        rndVal2 = UnityEngine.Random.Range(4, 100);
        Debug.Log("--- TEST RANDOM --- SYSTEM --- " + rndVal);
        Debug.Log("--- TEST RANDOM --- UE --- " + rndVal2);
        
    }

	public void ChangeRandomCube()
	{
		gameObject.transform.position = new Vector3(rndVal, 0f, 0f);
	}

    // Update is called once per frame
    void Update()
    {

    }
}
