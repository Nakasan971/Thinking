using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*-------------------------------------
        ブロック機能
--------------------------------------*/
public class DragAndDropScript : MonoBehaviour
{
    private Vector3 screenPoint;    //画面空間座標取得 

    MainScript mainScript;
    void Start(){
        mainScript = GameObject.Find("MainSystem").GetComponent<MainScript>();
    }
    //押下した時
    void OnMouseDown() {
        //ワールド空間座標　＝＞　画面空間座標に変換
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        mainScript.isDrag = true;
    }

    //ドラッグした時(毎フレーム呼び出し)
    void OnMouseDrag() {
        //マウスの座標を動的取得
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        //画面空間座標　＝＞　ワールド空間座標に変換
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        //座標をオブジェクトに適応
        transform.position = currentPosition;
    }
}
