using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour
{
    public GameObject cube;
     MeshRenderer Colorchange;
      public Material Red;
    // Start is called before the first frame update
    void Start()
    {Colorchange=transform.GetComponent<MeshRenderer>();
      Colorchange.material=Red;   
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
