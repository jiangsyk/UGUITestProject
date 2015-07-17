using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/*
 * Description: MenuController
 * Author:      JiangShu
 * Create Time: 2015/7/16 17:43:28
 */
public class MenuController : MonoBehaviour
{
    public enum GameModel
    {
        EASY,
        NORMAL,
        HARD
    }
    [HideInInspector]
    public bool soundIsOn = false;
    [HideInInspector]
    public float soundVal = 0;
    [HideInInspector]
    public GameModel model = GameModel.EASY;

    public Toggle soundToggle;
    public Slider soundSlider;

    public GameObject optionsView;
    public bool optionsShow = false;


    private float hideX = 0;
   
    void Start()
    {
        soundIsOn = soundToggle.isOn;
        soundVal = soundSlider.value;


        hideX = -Screen.width / 2 + 80;
        optionsView.transform.localPosition = new Vector3(hideX, 0, 0);
    }
    void Update()
    {

    }
    public void OnSoundToggleValueChanged(bool isOn)
    {
        soundIsOn = isOn;
    }
    public void OnSoundValChanged(float val)
    {
        soundVal = val;
    }
    public void OnModelChanged(string model)
    {
        switch(model)
        {
            case "easy":
                this.model = GameModel.EASY;
                break;
            case "normal":
                this.model = GameModel.NORMAL;
                break;
            case "hard":
                this.model = GameModel.HARD;
                break;
        }
    }
    public void OnClickStartBtn()
    {
        print("SoundIsOn:" + soundIsOn + "\nSoundVal:" + soundVal + "\nGameModel:" + model);
        Application.LoadLevel("Game");
    }
    public void OnClickOptionsBtn()
    {
        print(Screen.width);
        print(Screen.height);


        if(!optionsShow)
        {
            iTween.MoveTo(optionsView, iTween.Hash("position", Vector3.zero, "time", 0.5f, "islocal", true,"easetype",iTween.EaseType.linear));
            optionsShow = true;
        }
        else
        {
            iTween.MoveTo(optionsView,iTween.Hash("position",new Vector3(hideX, 0, 0),"time",0.5f,"islocal",true,"easetype",iTween.EaseType.linear));
            optionsShow = false ;
        }
    }
    public void OnClickExit()
    {
        Application.LoadLevel("Login");
    }
}
