using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*-------------------------------------
        ブロック衝突・生成機能
--------------------------------------*/
public class SplitScript : MonoBehaviour{
    //ブロック生成関数
    void BlockRespone(string callName){
        Vector3 pos = transform.position;
        pos.y += 1f;
        Destroy(this.gameObject);
        GameObject newBlock = (GameObject)Resources.Load(callName);
        Instantiate(newBlock,pos,Quaternion.identity);
    }
    //衝突判定
    void OnCollisionEnter2D(Collision2D col){
        //Debug.Log(collision.gameObject.name);
        switch(col.gameObject.name){
            case "Knife":
                BlockRespone("Apples");
                break;
            case "Ice":
                BlockRespone("He");
                break;
            case "Shou":
                if(this.gameObject.name == "Moon"){
                    Destroy(col.gameObject);
                    BlockRespone("Shou2");
                }
                break;
            case "Sanzui":
                if(this.gameObject.name == "Shou2(Clone)"){
                    Destroy(col.gameObject);
                    BlockRespone("Shou3");
                }
                break;
            case "Soil":
                if(this.gameObject.name == "Mu"){
                    Destroy(col.gameObject);
                    BlockRespone("Kyo");
                }
                break;
            case "Kyo(Clone)":
                if(this.gameObject.name == "Shou3(Clone)"){
                    Destroy(col.gameObject);
                    Destroy(this.gameObject);
                }
                break;
        }       
    }
}

/*衝突判定(旧式)
//Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "Knife"){
            Vector3 pos = transform.position;
            pos.y += 1f;
            Destroy(this.gameObject);
            GameObject Apple = (GameObject)Resources.Load("Apples");
            Instantiate(Apple,pos,Quaternion.identity);
        }
        if(collision.gameObject.name == "Ice"){
            Vector3 pos = transform.position;
            pos.y += 1f;
            Destroy(this.gameObject);
            GameObject He = (GameObject)Resources.Load("He");
            Instantiate(He,pos,Quaternion.identity);
        }
        if(this.gameObject.name == "Moon"){
            if(collision.gameObject.name == "Shou"){
                Vector3 pos = transform.position;
                pos.y += 1f;
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
                GameObject Shou2 = (GameObject)Resources.Load("Shou2");
                Instantiate(Shou2);
            }
        }
        if(this.gameObject.name == "Shou2(Clone)"){
           if(collision.gameObject.name == "Sanzui"){
            Vector3 pos = transform.position;
            pos.y += 1f;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            GameObject Shou3 = (GameObject)Resources.Load("Shou3");
            Instantiate(Shou3);
           } 
        }
        if(this.gameObject.name == "Mu"){
           if(collision.gameObject.name == "Soil"){
            Vector3 pos = transform.position;
            pos.y += 1f;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            GameObject Kyo = (GameObject)Resources.Load("Kyo");
            Instantiate(Kyo);
           } 
        }
        if(this.gameObject.name == "Shou3(Clone)" || this.gameObject.name == "Kyo(Clone)"){
           if(collision.gameObject.name == "Kyo(Clone)" || collision.gameObject.name == "Shou3(Clone)"){
            Vector3 pos = transform.position;
            pos.y += 1f;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
           } 
        }
*/