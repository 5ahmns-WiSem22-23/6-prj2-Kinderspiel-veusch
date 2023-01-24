using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootCollider : MonoBehaviour
{
    public GameObject fischRot;
    public GameObject fischBlau;
    public GameObject fischGelb;
    public GameObject fischRosa;
    public GameObject fischerBoot;


   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischBlau)
        {
            fischBlau.SetActive(false);
        }

        if (other.gameObject == fischGelb)
        {
            fischGelb.SetActive(false);
        }

        if (other.gameObject == fischRosa)
        {
            fischRosa.SetActive(false);
        }

        if (other.gameObject == fischRot)
        {
            fischRot.SetActive(false);
        }
    }
}
