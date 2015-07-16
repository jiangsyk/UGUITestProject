using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/*
 * Description: LoginController
 * Author:      JiangShu
 * Create Time: 2015/7/16 17:16:27
 */
public class LoginController : MonoBehaviour
{
    public InputField usernameText;
    public InputField passwordText;
    public Text errorTips;
    void Start()
    {

    }
    void Update()
    {

    }
    public void OnClickLoginBtn()
    {
        string username = usernameText.text;
        string password = passwordText.text;
        if(username != "jiangshu" || password != "jiangshu")
        {
            errorTips.text = "帐号或密码错误！";
            StartCoroutine(HideErrorTips());
            return;
        }
        Application.LoadLevel("Menu");
    }
    public IEnumerator HideErrorTips()
    {
        yield return new WaitForSeconds(1);
        errorTips.text = "";
    }
}
