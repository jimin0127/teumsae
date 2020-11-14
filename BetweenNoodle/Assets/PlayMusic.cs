using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMusic : MonoBehaviour
{
    public Sprite Onsprite;
    public Sprite Offsprite;
    public AudioSource sound;

    private Button SoundButton;

    //settingSwitch ss;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(settingSwitch.soundFlag);
        //SoundButton = ss.GetSoundBtn();
        if(settingSwitch.soundFlag == 1){
             sound.mute = false;
         } 
         else if(settingSwitch.soundFlag == 0){
             sound.mute = true;
         }

        // if(SoundButton.image.sprite == Onsprite){
        //     sound.mute = false;
        // } else {
        //     sound.mute = true;
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
