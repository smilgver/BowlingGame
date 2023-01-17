using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinParent : MonoBehaviour
{
    private GameObject[] pinArray= new GameObject[9];
    public List<GameObject> pins = new List<GameObject>();
    private void Awake()
    {
        for(int i = 0; i < pinArray.Length; i++)
        {
            pinArray[i] = GetComponent<Transform>().GetChild(i).gameObject;
        }
        foreach (GameObject pin in pinArray)
        { 
            pins.Add(pin);
        }
    }
    private void Update()
    {
        if(pins.Count <= 0)
        {
            Destroy(gameObject);
        }
    }
}
