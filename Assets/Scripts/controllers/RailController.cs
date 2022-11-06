using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailController : MonoBehaviour, IController
{
    
    void IController.rayTriggerController(RaycastHit2D hit){
        Debug.Log("Trigger Rail Receiver");
    }
}
