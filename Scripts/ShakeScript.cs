using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*-------------------------------------
        ステージ４のボツ機能（機能未実装）
--------------------------------------*/
public class ShakeScript : MonoBehaviour
{
    Rigidbody2D rb;
    float speed;
    float limit = 0.01f;
    int shake;
    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
    }
    void Update(){
        ShakeCheck(); 
    }
    void ShakeCheck(){
        speed = rb.velocity.magnitude;
        limit -= Time.deltaTime;
        if(limit <= 0){
            if(speed > 20){
                shake++;
            }
            limit = 0.01f;
        }
        //Debug.Log(limit);
        //Debug.Log(speed);
        speed = 0;
    }
}
