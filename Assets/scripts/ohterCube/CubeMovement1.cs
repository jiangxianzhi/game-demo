using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement1 : MonoBehaviour
{


     public Transform Target1;//放小球，跟随，即小球就是敌人要追踪的物体
    private Vector3 direction;//一个三维坐标
    public float speed = 5f;//给一个追踪速度
    // Start is called before the first frame update
    void Start()
    {
        

direction = transform.position - Target1.position;//物体与小球的位置差
        direction.y = 0;//y轴方向上的位置不需要改变，根据实际情况而定

       
       
    }

    // Update is called once per frame
    void Update()
    { 
        
        transform.Translate(direction * speed * Time.deltaTime);

    }


}
