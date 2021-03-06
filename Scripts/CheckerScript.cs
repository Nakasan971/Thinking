using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*-------------------------------------
        ステージの床の機能
--------------------------------------*/
public class CheckerScript : MonoBehaviour
{

    public bool OntheGround;    //ブロックが床に落ちているか？
    List<GameObject> list;      //ブロック管理

    void Start(){
        list = new List<GameObject>();
    }
    //ブロックが床にある場合
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Block"){
            list.Add(collision.gameObject);
            //Debug.Log(collision.gameObject.name);
            OntheGround = true;
        }
    }
    //ブロックが床にない場合
    void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.tag == "Block"){
            list.Remove(collision.gameObject);
            //Debug.Log(list);
        }
        //全てのブロックが床にない場合
        if(!(list?.Count > 0)){
            OntheGround = false;
        }
    }
}
