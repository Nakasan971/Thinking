using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePicker : MonoBehaviour
{
    [SerializeField]            //シリアライズオブジェクト宣言
    public string scenePath;    //シーンパス格納
    //シーン移動
    public void ToScene(){
        SceneManager.LoadScene(scenePath);
    }
}
