using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootCollider : MonoBehaviour
{
    public GameObject fischRot;
    public GameObject fischBlau;
    public GameObject fischGelb;
    public GameObject fischRosa;
    public GameObject EndZone;

    public GameObject fischRotD;
    public GameObject fischBlauD;
    public GameObject fischGelbD;
    public GameObject fischRosaD;

    public GameObject fischGefangenTafel1;
    public GameObject fischGefangenTafel2;
    public GameObject fischGefangenTafel3;
    public GameObject fischGefangenTafel4;

    public GameObject auswahlRot;
    public GameObject auswahlBlau;
    public GameObject auswahlGelb;
    public GameObject auswahlRosa;




    public int fischGefangen = 0;

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischBlau)
        {
            fischBlau.SetActive(false);
            fischGefangen++;
            fischBlauD.SetActive(true);
            GameState.instance.fischBlauD++;
            auswahlBlau.SetActive(false);
            GameState.instance.fischeImGame--;

        }

        if (other.gameObject == fischGelb)
        {
            fischGelb.SetActive(false);
            fischGefangen++;
            fischGelbD.SetActive(true);
            GameState.instance.fischGelbD++;
            auswahlGelb.SetActive(false);
            GameState.instance.fischeImGame--;


        }

        if (other.gameObject == fischRosa)
        {
            fischRosa.SetActive(false);
            fischGefangen++;
            fischRosaD.SetActive(true);
            GameState.instance.fischRosaD++;
            auswahlRosa.SetActive(false);
            GameState.instance.fischeImGame--;


        }

        if (other.gameObject == fischRot)
        {
            fischRot.SetActive(false);
            fischGefangen++;
            fischRotD.SetActive(true);
            GameState.instance.fischRotD++;
            auswahlRot.SetActive(false);
            GameState.instance.fischeImGame--;

        }

        if (other.gameObject == EndZone)
        {
            if (fischGefangen > GameState.instance.fischSicher)
            {
                SceneManager.LoadScene(2);
            }


            if (fischGefangen <= GameState.instance.fischSicher)
            {
                SceneManager.LoadScene(3);
            }

          
        }


    }


    private void Update()
    {
        if(fischGefangen==4)
        {
            SceneManager.LoadScene(2);
        }

        if(fischGefangen==1)
        {
            fischGefangenTafel1.SetActive(true);
        }

        if (fischGefangen == 2)
        {
            fischGefangenTafel1.SetActive(true);
            fischGefangenTafel2.SetActive(true);
        }

        if (fischGefangen == 3)
        {
            fischGefangenTafel1.SetActive(true);
            fischGefangenTafel2.SetActive(true);
            fischGefangenTafel3.SetActive(true);
        }

        if (fischGefangen == 4)


        {

            fischGefangenTafel1.SetActive(true);
            fischGefangenTafel2.SetActive(true);
            fischGefangenTafel3.SetActive(true);
            fischGefangenTafel4.SetActive(true);
        }
    }

}
