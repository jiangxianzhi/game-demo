using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



[System.Serializable]
public class EventVector3: UnityEvent<Vector3>{}

public class Mousemanager : MonoBehaviour
{

    public EventVector3 OnMouseCliked;
}
   
