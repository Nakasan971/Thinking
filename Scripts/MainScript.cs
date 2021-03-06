using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*-------------------------------------
        ステージの大まかな機能
--------------------------------------*/
public class MainScript : MonoBehaviour
{
    int   second = 0;               //耐久秒数（整数）
    float limit  = 6;               //耐久秒数（浮動小数）
    Text  counter;                  //秒数表示用

    GameObject  clear_Panel;        //クリア画面

    public bool isDrag;
    public bool OntheGround;        //床にモノがあるか？
    public bool OverWeightL;        //天秤が左に傾きすぎか？
    public bool OverWeightR;        //天秤が右に傾きすぎか？

    CheckerScript      checker;     //水平時の処理（床）
    PointCheckerScript PCheckerL;   //水平時の処理（左）
    PointCheckerScript PCheckerR;   //水平時の処理（右）

    void Start(){
        //オブジェクト生成
        GameObject Balance = (GameObject)Resources.Load("Balance");
        GameObject Wall = (GameObject)Resources.Load("Wall");
        Instantiate(Balance);
        Instantiate(Wall);

        //各種初期宣言
        counter     = GameObject.Find("CountDown").GetComponent<Text>();
        clear_Panel = GameObject.Find("Panel");
        checker     = GameObject.Find("Wall(Clone)").GetComponent<CheckerScript>();
        PCheckerL   = GameObject.Find("Point L").GetComponent<PointCheckerScript>();
        PCheckerR   = GameObject.Find("Point R").GetComponent<PointCheckerScript>();

        //非表示
        clear_Panel.gameObject.SetActive(false);
    }

    void Update(){
        //判定更新
        OntheGround = checker.OntheGround;
        OverWeightL = PCheckerL.OverWeight;
        OverWeightR = PCheckerR.OverWeight;
        OnMouseUp();

        //全てfalse => 釣り合いを保っている
        if(!isDrag && !OntheGround && !OverWeightL && !OverWeightR){
            //秒数表示
            counter.gameObject.SetActive(true);
            //カウントダウン
            if(limit > 0){
                limit -= Time.deltaTime;
                second = (int)limit;
                counter.text = second.ToString();
            }else if(limit <= 0){
                //クリア
                clear_Panel.gameObject.SetActive(true);
            }
        }else{ 
            //秒数非表示
            counter.gameObject.SetActive(false);
            limit = 6; 
        }
    }
    void OnMouseUp(){
        if(Input.GetMouseButtonUp(0)){
            isDrag = false;
        }
    }
}
