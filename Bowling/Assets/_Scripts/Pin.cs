using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private PinParent pinParent;
    public Transform pinChildTransform;
    private void Awake()
    {
        pinParent = GetComponentInParent<PinParent>();
        pinChildTransform = GetComponent<Transform>().GetChild(0);
    }
    private void Update()
    {
        if(pinChildTransform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        pinParent.pins.Remove(gameObject);
    }
}
