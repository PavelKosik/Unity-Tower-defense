﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalManagerScript : MonoBehaviour
{
    public float numberOfCrystals;
    public Text numberOfCrystalsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //updates the text to reflect the current amount of crystals that player has
        numberOfCrystalsText.text = numberOfCrystals.ToString();
    }
}
