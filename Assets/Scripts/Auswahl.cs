using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auswahl : MonoBehaviour
{
    public GameObject fischRot;
    public GameObject fischBlau;
    public GameObject fischGelb;
    public GameObject fischRosa;
    public GameObject wuerfel;
    public GameObject AuswahlDialog;
    public void MoveRed()
    {
        fischRot.transform.position += new Vector3(-80f, 0, 0);
        wuerfel.SetActive(true);
        AuswahlDialog.SetActive(false);
        Debug.Log("is Pressed");
    }

    public void MoveBlue()
    {
        fischBlau.transform.position += new Vector3(-80f, 0, 0);
        wuerfel.SetActive(true);
        AuswahlDialog.SetActive(false);
        Debug.Log("is Pressed");
    }

    public void MoveYellow()
    {
        fischGelb.transform.position += new Vector3(-80f, 0, 0);
        wuerfel.SetActive(true);
        AuswahlDialog.SetActive(false);
        Debug.Log("is Pressed");
    }

    public void MoveRosa()
    {
        fischRosa.transform.position += new Vector3(-80f, 0, 0);
        wuerfel.SetActive(true);
        AuswahlDialog.SetActive(false);
        Debug.Log("is Pressed");
    }


}
