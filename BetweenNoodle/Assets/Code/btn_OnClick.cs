using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_OnClick : MonoBehaviour
{
    public void GoRule()
    {
        SceneManager.LoadScene("Rule");
    }
    public void GoSet()
    {
        SceneManager.LoadScene("SettingScene");
    }
    public void GoCheck()
    {
        SceneManager.LoadScene("AttendanceScene");
    }
    public void GoStage()
    {
        SceneManager.LoadScene("Stage");
    }
    public void GoShop()
    {
        SceneManager.LoadScene("Clothes");
    }
}
