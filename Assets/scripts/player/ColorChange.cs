using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    public GameObject cube;
    MeshRenderer Colorchange;
    public Material blue;
     public Material red;
      public Material black;
       public Material otherblue;


    // Start is called before the first frame update
    void Start()
    {
        Colorchange=transform.GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){

Colorchange.material=blue;

        if(Input.GetMouseButtonDown(2)){

Colorchange.material=blue;



 

        }
    }
}
