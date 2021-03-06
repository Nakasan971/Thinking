using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*-------------------------------------
        ステージ4のギミック機能
--------------------------------------*/
public class SliderScript : MonoBehaviour{

    GameObject sound;   //『音』ブロック
    Rigidbody2D rb;     //ブロック制御
    Slider slider;      //スライダー制御

    void Start(){
        sound = GameObject.Find("Block1");
        rb = sound.GetComponent<Rigidbody2D>();
        slider = GetComponent<Slider>();
    }
    //スケール・重さ変更
    public void ChangeSize(){
     sound.gameObject.transform.localScale =
                     new Vector2(slider.value,slider.value);
     rb.mass = slider.value * 1000;  
    }
}
