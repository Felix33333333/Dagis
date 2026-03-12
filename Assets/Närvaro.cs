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
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        print("Yannic");
        thingToShow.SetActive(true);
        nameList.text = "Yannic, Anna, Adam, Roger, Ludvig, Lukas ";
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
