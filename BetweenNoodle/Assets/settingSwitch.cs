using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 

public class settingSwitch : MonoBehaviour
{



    public static int soundFlag = 1;

    public Sprite Onsprite; //selectedOn
    //public AudioSource sound;
    public Sprite Offsprite;

    private Button EffectButton; //효과음
    private  Button SoundButton; //배경음 
    private Button Button;
        


    // Start is called before the first frame update
    void Start()
    {
        SoundButton = GameObject.Find("SoundButton").GetComponent<Button>();
        EffectButton = GameObject.Find("EffectButton").GetComponent<Button>();
        Button = GameObject.Find("Button").GetComponent<Button>();
        SoundButton.image.sprite = Offsprite;
        EffectButton.image.sprite = Offsprite;
        Button.image.sprite = Offsprite;


        SoundButton.onClick.AddListener( () => switchChange(SoundButton));
        SoundButton.onClick.AddListener( () => PlaySound(SoundButton));

        EffectButton.onClick.AddListener( () => switchChange(EffectButton));
        Button.onClick.AddListener( () => switchChange(Button));


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void switchChange(Button button) {
        if(button.image.sprite == Offsprite){ //on
            button.image.sprite = Onsprite;
        }
        else if(button.image.sprite == Onsprite){
            button.image.sprite = Offsprite;
        }

    }

    void PlaySound(Button SoundButton) {
        GameObject BackgroundMusic = GameObject.Find("BackgroundMusic");
        AudioSource backmusic = BackgroundMusic.GetComponent<AudioSource>(); //배경음악 저장해둠
        if(SoundButton.image.sprite == Offsprite){ //on
            soundFlag = 0;
            backmusic.Pause();

        }
        else if(SoundButton.image.sprite == Onsprite){
            
            soundFlag = 1;
            backmusic.Play();
            DontDestroyOnLoad(BackgroundMusic); //배경음악 계속 재생하게(이후 버튼매니저에서 조작)
        }
    }
}
