using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouseMovement : MonoBehaviour
{


    RaycastHit rayInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if(Input.GetMouseButtonDown(1)){
Ray cameraRay= Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(cameraRay.origin,cameraRay.direction,out rayInfo,1000f)){
if(rayInfo.transform.gameObject.layer==LayerMask.NameToLayer("Ground")){
    GetComponent<NavMeshAgent>().SetDestination(rayInfo.point);
}


}


    }
        
    }
}
