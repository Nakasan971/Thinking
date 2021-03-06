using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*-------------------------------------
        Button機能全般
--------------------------------------*/
public class ButtonScript : MonoBehaviour
{
    string　SceneName;      //現在のシーン格納 
    //現在のシーン取得         
    void Start(){
        SceneName = SceneManager.GetActiveScene().name;
    }
    //タイトル画面へ
    public void toTitle(){
        SceneManager.LoadScene("TitleScene");
    }
    //リトライ
    public void Retry(){
        SceneManager.LoadScene(SceneName);
    }
    //ゲーム終了
    public void ToQuit(){
        #if UNITY_EDITOR    //エディタ依存コンパイル
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
