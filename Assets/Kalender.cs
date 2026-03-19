using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Kalender : MonoBehaviour
{
    public Button yourButton;
    public GameObject thingToShow;

    
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        if (thingToShow.activeSelf == false)
        {
            thingToShow.SetActive(true);

        }
        else
        {
            thingToShow.SetActive(false);

        }
        
        
        
    }

    
    void Update()
    {
        
    }
}
