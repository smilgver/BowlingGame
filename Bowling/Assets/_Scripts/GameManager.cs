using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float score;
    public static int turnIndex;
    public static bool ballThrown = false;
    [SerializeField] private GameObject pinParentGO;
    [SerializeField] private GameObject bowlingBall;

    private void Awake()
    {
        pinParentGO = (GameObject)Resources.Load("Prefabs/PinParent");
        bowlingBall = (GameObject)Resources.Load("Prefabs/BowlingBall");
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.R))
       { ReplacePins(); }
    }
    void ReplacePins()
    {
        Instantiate(pinParentGO);
    }
}
