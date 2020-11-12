using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 

public class settingSwitch : MonoBehaviour
{
    public Sprite newsprite; //selectedOOn
    private Button EffectButton; //효과음
    private Button SoundButton; //배경음 
    private Button Button;
    
    private Sprite Onsprite; //selectedOff
    


    // Start is called before the first frame update
    void Start()
    {
        SoundButton = GameObject.Find("SoundButton").GetComponent<Button>();
        EffectButton = GameObject.Find("EffectButton").GetComponent<Button>();
        Button = GameObject.Find("Button").GetComponent<Button>();

        Onsprite = SoundButton.image.sprite;

        SoundButton.onClick.AddListener( () => switchChange(SoundButton));
        EffectButton.onClick.AddListener( () => switchChange(EffectButton));
        Button.onClick.AddListener( () => switchChange(Button));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void switchChange(Button button) {
        if(button.image.sprite == newsprite){
            button.image.sprite = Onsprite;
        }
        else {
            button.image.sprite = newsprite;
        }
    }
}
