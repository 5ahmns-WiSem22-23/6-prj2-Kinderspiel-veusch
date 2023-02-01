using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState instance;

    public int fischRotD;
    public int fischGelbD;
    public int fischBlauD;
    public int fischRosaD;

    public int fischeImGame=4;

    public int fischRotS;
    public int fischGelbS;
    public int fischBlauS;
    public int fischRosaS;


    public bool fischRSafed = false;
    public bool fischGSafed = false;
    public bool fischBSafed = false;
    public bool fischRosaSafed = false;

    public int fischSicher;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
    }
    void Update()
    {
        
    }
}
