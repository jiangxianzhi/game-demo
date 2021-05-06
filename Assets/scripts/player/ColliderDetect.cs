using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetect : MonoBehaviour
{
    //检测碰撞是什么
    private void OnCollisionEnter(Collision collision){

//如果撞到其他的cube，就退出游戏

if(collision.collider.tag=="Cube"){
    
Application.Quit();
Debug.Log(collision.collider.name);

}
    }
}
