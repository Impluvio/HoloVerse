using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;

public class PlanetSelector : MonoBehaviour
{
    public GameObject[] planetList;
    [SerializeField] private int currentPlanet;
    public GameObject buttonObject;
    
    // Start is called before the first frame update
    void Start()
    {
        resetCycle();
        
    }

    public void cyclePlanet()
    {
      
        if (currentPlanet < planetList.Length - 1)
        {
           currentPlanet++;
        }
        else
        {
            resetCycle();       
        } 
        planetName();
    }

    private void planetName()
    {
        buttonObject.GetComponent<ButtonConfigHelper>().MainLabelText = planetList[currentPlanet].name;
    }


    private void resetCycle()
    {
        currentPlanet = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
