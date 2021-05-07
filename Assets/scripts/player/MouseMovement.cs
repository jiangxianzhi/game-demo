using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    private Ray ray;
    public float MoveSpeed;
    public float FastSpeed=10f;
    private RaycastHit hit;
    private Vector3 EndPosition;

    // Start is called before the first frame update
    void Start()
    {
      MoveSpeed = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
          

ray = Camera.main.ScreenPointToRay(Input.mousePosition);//赋值鼠标从
//相机位置的射线赋值给ray
//两个判断同时满足一个碰撞到物体，一个是碰撞到Plane
if(Physics.Raycast(ray,out hit)){
    

 if(hit.collider.gameObject.name=="Plane"){
     
    EndPosition = hit.point;
    Debug.Log(EndPosition.x);
    transform.LookAt(EndPosition);
    MoveSpeed =FastSpeed; 
    Debug.Log(MoveSpeed);
}
        }
        }

//判断是否在鼠标点击位置，不在就移动，在就不移动
if(Vector3.Distance(transform.position, EndPosition)<1f){

MoveSpeed = 0;


}
else{ transform.Translate(transform.forward*MoveSpeed*Time.deltaTime, Space.World);

    
}



    }






}

