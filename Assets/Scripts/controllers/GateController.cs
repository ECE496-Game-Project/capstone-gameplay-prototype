using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour, IController
{
    
    void IController.rayTriggerController(RaycastHit2D hit){
        Debug.Log("Trigger Gate Receiver");
    }
}
