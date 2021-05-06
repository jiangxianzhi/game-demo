using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//目标位置一直跟踪物体的位置在update里执行

public class CubeMovement : MonoBehaviour
{
   public Transform player;//放小球，跟随，即小球就是敌人要追踪的物体
    private Vector3 direction;//一个三维坐标
    public float speed = 5f;//给一个追踪速度
    void Start(){
         direction = transform.position - player.position;//物体与小球的位置差
    }
    // Update is called once per frame
    void Update()
    {
       
        direction.y = 0;//y轴方向上的位置不需要改变，根据实际情况而定
        transform.Translate(-direction * speed * Time.deltaTime,Space.World);
        //direction，是根据你的位置决定。
        //因为这里是减法，所以要向着负号加上方向的方向前进
        
      if(Vector3.Distance(transform.position,player.position)>500)
      Destroy(this.gameObject);//如果两者的距离大于500就自我销毁
        
    }
}

