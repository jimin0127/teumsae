using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization;


public class papperButton : MonoBehaviour
{
    public Sprite newsprite;
    
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(fClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fClick() {
        Debug.Log("Button Click");
        button.image.sprite = newsprite;

    }
}
