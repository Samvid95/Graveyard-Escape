using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour {

    public Text[] text;
    public int Readtime = 3;
    public int elementSize;
    private int i = 0;

	// Use this for initialization
	void Start () {
        for(int i =1; i < elementSize; i++)
        {
            text[i].GetComponent<Text>().enabled = false;
        }

        Invoke("ChangeText", Readtime); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void ChangeText()
    {
        if(i < elementSize-1)
        {
            text[i].GetComponent<Text>().enabled = false;
            text[i + 1].GetComponent<Text>().enabled = true;
            i++;
            Invoke("ChangeText", Readtime);
        }
        else
        {
            return;
        }
    }
}
