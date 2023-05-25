using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndShoot: MonoBehaviour
{
    [SerializeField] private Projections _projection;

   
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    private Rigidbody rb;

    private bool isShoot;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    /*
    private void Update()
    {
       
        _projection.SimulateTrajectory(_ballPrefab, _ballSpawn.position, _ballSpawn.forward * _force);
        ball ballPrefab, Vector3 pos, Vector3 velocity
    }
    */
    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        Shoot(mouseReleasePos - mousePressDownPos);
    }

    private float forceMultiplier = 3;
    void Shoot(Vector3 Force)
    {
        

        rb.AddForce(new Vector3(-Force.x, -Force.y, -Force.y) * forceMultiplier);
        
    }

}
