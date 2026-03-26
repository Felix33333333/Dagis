using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Närvaro : MonoBehaviour 
{
    public Button yourButton;
    public GameObject thingToShow;
    public TMP_Text nameList;
    
    
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>(); // hämtar en button komponent från (yourobject) 
        btn.onClick.AddListener(TaskOnClick); // säger när knapen klickas så körs funkitionenn "taskonclick"
    }

    public void TaskOnClick() //själva fu nktionen
    {
        print("Yannic");
        if (thingToShow.activeSelf == false) // detta gör om objectet inte är aktivt så visa de och om objecter är activt så göm de
        {
            thingToShow.SetActive(true);
        }
        else
        {
            thingToShow.SetActive(false);
        }

            nameList.text = "Yannic (Frånvarande), Anna, Adam, Roger(Frånvarande), Ludvig, Lukas "; // visar lista me namn
        
    }
    

    // Update is called once per frame
    void Update ()
    {
       // thingToShow.SetActive(false);
       
    }
}
