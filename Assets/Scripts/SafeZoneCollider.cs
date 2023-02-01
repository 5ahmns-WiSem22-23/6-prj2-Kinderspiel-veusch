using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SafeZoneCollider : MonoBehaviour
{

    public GameObject fischRot;
    public GameObject fischBlau;
    public GameObject fischGelb;
    public GameObject fischRosa;

    public int fischSicher = 0;
    public GameObject fischGerettet1;
    public GameObject fischGerettet2;
    public GameObject fischGerettet3;
    public GameObject fischGerettet4;


    public GameObject auswahlRot;
    public GameObject auswahlBlau;
    public GameObject auswahlGelb;
    public GameObject auswahlRosa;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischBlau)
        {
            fischSicher++;
            fischBlau.SetActive(false);
            GameState.instance.fischBSafed = true;
            auswahlBlau.SetActive(false);
            GameState.instance.fischSicher++;
            GameState.instance.fischeImGame--;

        }

        if (other.gameObject == fischGelb)
        {
            fischSicher++;
            fischGelb.SetActive(false);
            GameState.instance.fischGSafed = true;
            auswahlGelb.SetActive(false);
            GameState.instance.fischSicher++;

            GameState.instance.fischeImGame--;

        }

        if (other.gameObject == fischRosa)
        {
           
            fischSicher++;
            fischRosa.SetActive(false);
            GameState.instance.fischRosaSafed = true;
            auswahlRosa.SetActive(false);
            GameState.instance.fischSicher++;
            GameState.instance.fischeImGame--;


        }

        if (other.gameObject == fischRot)
        {
            
            fischSicher++;
            fischRot.SetActive(false);
            GameState.instance.fischRSafed = true;
            auswahlRot.SetActive(false);
            GameState.instance.fischSicher++;
            GameState.instance.fischeImGame--;

        }
    }

    private void Update()
    {
        if(fischSicher==4)
        {
            Debug.Log("Spiel gewonnen alle fische sicher");
            SceneManager.LoadScene(3);
        }

        if (fischSicher == 1)
        {
            fischGerettet1.SetActive(true);
        }

        if (fischSicher == 2)
        {
            fischGerettet1.SetActive(true);

            fischGerettet2.SetActive(true);
        }
        if (fischSicher == 3)
        {
            fischGerettet1.SetActive(true);
            fischGerettet2.SetActive(true);
            fischGerettet3.SetActive(true);
        }
        if (fischSicher == 4)
        {
            fischGerettet1.SetActive(true);
            fischGerettet2.SetActive(true);
            fischGerettet3.SetActive(true);
            fischGerettet4.SetActive(true);
        }
       
    }
}

