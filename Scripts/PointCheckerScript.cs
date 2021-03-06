using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*-------------------------------------
        Point L/Rの機能
--------------------------------------*/
public class PointCheckerScript : MonoBehaviour
{
    public bool OverWeight = false;     //傾きすぎ検出用

    //皿と接触している
    void OnCollisionEnter2D(Collision2D collision){
            OverWeight = true;
    }
    //皿と離れている
    void OnCollisionExit2D(Collision2D collision){
            OverWeight = false;
    }
}
