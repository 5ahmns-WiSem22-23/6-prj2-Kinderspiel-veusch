using System.Collections;
using UnityEngine;

public class Würfel : MonoBehaviour
{
    public GameObject fischRot;
    public GameObject fischBlau;
    public GameObject fischGelb;
    public GameObject fischRosa;
    public GameObject anzeige;
    public GameObject wuerfel;
   
    public GameObject fischerBoot;


    // Array of dice sides sprites to load from Resources folder
    private Sprite[] WürfelSeiten;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;

    
    private void Start()
    {

        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Load dice sides sprites to array 
        WürfelSeiten = Resources.LoadAll<Sprite>("WürfelSeiten/");
    }

    // If you left click over the dice then RollTheDice coroutine is started
    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

    // Coroutine that rolls the dice
    private IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        int randomDiceSide = 0;

        // Final side or value that dice reads in the end of coroutine
        int finalSide = 0;

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 6 
            randomDiceSide = Random.Range(0, 6);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = WürfelSeiten[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }

       
        // for player movement for example
        finalSide = randomDiceSide + 1;
            
        // Show final dice value in Console
        Debug.Log(finalSide);

        if(finalSide==2)
        {
            Debug.Log("Seite 2, grün");
            fischerBoot.transform.position += new Vector3(-80f, 0, 0);

            

        }

        if (finalSide == 1)
        {
            Debug.Log("Seite 1, blau");
            fischBlau.transform.position += new Vector3(-80f, 0, 0);
            if (GameState.instance.fischBlauD == 1)
            {
                fischerBoot.transform.position += new Vector3(-80f, 0, 0);
            }


          if(GameState.instance.fischBSafed==true && GameState.instance.fischeImGame > 4)
            {
                anzeige.SetActive(true);
                wuerfel.SetActive(false);
                
            }



        }

        if (finalSide == 3)
        {
            Debug.Log("Seite 3, orange");
            fischerBoot.transform.position += new Vector3(-80f, 0, 0);


        }

        if (finalSide == 4)
        {
            Debug.Log("Seite 4, rot");
            fischRot.transform.position += new Vector3(-80f, 0, 0);
            if (GameState.instance.fischRotD == 1)
            {
                fischerBoot.transform.position += new Vector3(-80f, 0, 0);
            }

            if (GameState.instance.fischRSafed == true && GameState.instance.fischeImGame > 4)
            {
                anzeige.SetActive(true);
                wuerfel.SetActive(false);

            }


        }
        if (finalSide == 5)
        {
            Debug.Log("Seite 5, rosa");
            fischRosa.transform.position += new Vector3(-80f, 0, 0);
            if (GameState.instance.fischRosaD == 1)
            {
                fischerBoot.transform.position += new Vector3(-80f, 0, 0);
            }

            if (GameState.instance.fischRosaSafed == true && GameState.instance.fischeImGame>4)
            {
                anzeige.SetActive(true);
                wuerfel.SetActive(false);

            }

        }

        if (finalSide == 6)
        {
            Debug.Log("Seite 5, gelb");
            fischGelb.transform.position += new Vector3(-80f, 0, 0);
            if (GameState.instance.fischGelbD == 1)
            {
                fischerBoot.transform.position += new Vector3(-80f, 0, 0);
            }
            if (GameState.instance.fischGSafed == true && GameState.instance.fischeImGame > 4)
            {
                anzeige.SetActive(true);
                wuerfel.SetActive(false);

            }


        }
    }




   
}
