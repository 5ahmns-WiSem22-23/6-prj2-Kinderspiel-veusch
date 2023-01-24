using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject fischRot;
    public GameObject fischBlau;
    public GameObject fischGelb;
    public GameObject fischRosa;
    public GameObject FischerBoot;


    public void BewegeFischRot()
    {
        fischRot.transform.position += new Vector3(2f, 0, 0);
    }


    private void Update()
    {
     
    }

}
