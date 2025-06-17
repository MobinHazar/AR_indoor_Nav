using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetTarget : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Camera topDownCamera;
    [SerializeField]
    private GameObject navTargetObject;

    private NavMeshPath path;
    private LineRenderer line;

    void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        NavMesh.CalculatePath(transform.position, navTargetObject.transform.position, NavMesh.AllAreas, path);
        line.positionCount = path.corners.Length;
        line.SetPositions(path.corners);
        line.enabled = true;
    }
}
