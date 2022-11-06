using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private LineRenderer lineRend;
    Vector3[] points;

    private float _rotationSpeed = 50f;
    private Vector3 _horizontalMovement;

    void Start(){
        lineRend = GetComponentInChildren<LineRenderer>();
        points = new Vector3[2];
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));

        transform.Rotate(_horizontalMovement * _rotationSpeed * Time.deltaTime);


        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 100f);

        points[0] = transform.position;
        points[1] = new Vector3(hit.point.x, hit.point.y, -1.0f);
        lineRend.SetPositions(points);

        if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Controller")){
            
            IController ictrl = hit.collider.GetComponent<IController>();
            ictrl.rayTriggerController(hit);
        }
        if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Medium")){
            
        }
    }
}
