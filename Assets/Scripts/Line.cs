using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    Vector3 startPos;
    Vector3 endPos;

    [SerializeField]

    LineRenderer lineRenderer;

    Camera camera;

    [SerializeField]

    AnimationCurve lineCurve;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        lineRenderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!lineRenderer.enabled)
            {
                lineRenderer.enabled = true;
            }
            lineRenderer.positionCount = 2;
            startPos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2f));

            lineRenderer.SetPosition(0, startPos);
            lineRenderer.useWorldSpace = true;
            lineRenderer.widthCurve = lineCurve;
            lineRenderer.numCapVertices = 7;

        }

        if (Input.GetMouseButton(0))
        {
            endPos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2f));

            lineRenderer.SetPosition(1, endPos);
        }
        
        if(Input.GetMouseButtonUp(0))
        {
            if (lineRenderer.enabled)
            {
                lineRenderer.enabled = false;
            }
        }
    }
}
