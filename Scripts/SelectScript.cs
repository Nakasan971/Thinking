using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*-------------------------------------
        タイトル画面全般の機能
--------------------------------------*/
public class SelectScript : MonoBehaviour
{
    GameObject  main_Cam;     //カメラ制御
    GameObject  stage_Panel;  //ステージ選択パネル 
    Text        click_Txt;    //"Click to Start"

    public bool select;       //stageパネルを表示するか？
    void Start(){
        main_Cam    = GameObject.Find ("Main Camera");
        stage_Panel = GameObject.Find ("SelectMode");
        click_Txt   = GameObject.Find ("Click Start").GetComponent<Text>();
        //初期は非表示
        stage_Panel.gameObject.SetActive(false);
    }
    void Update(){
        OnMouseDown();
        if(select){
            toStageSelect(select);
        }
    }
    //クリックしたかどうか？
    void OnMouseDown(){
        if(Input.GetMouseButtonDown(0)){
            select = true;
        }
    }
    //カメラ移動＆ステージ選択パネル表示
    void toStageSelect(bool select){
        click_Txt.gameObject.SetActive(false);  //テキスト非表示
        if(main_Cam.transform.position.x <= 20f){
            main_Cam.gameObject.transform.Translate(new Vector3(0.5f,0.0f,0.0f));
        }else{
            stage_Panel.gameObject.SetActive(true);
        }
    }
}
