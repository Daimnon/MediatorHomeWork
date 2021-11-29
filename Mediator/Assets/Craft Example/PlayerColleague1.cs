using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColleague1 : MonoBehaviour
{
    [SerializeField]
    private ServerMediator1 _mediator;

    public List<Vector3> CubePositions = new List<Vector3>();

    public void AddCube(Vector3 pos)
    {
        CubePositions.Add(pos);
    }

    public void MoveCube(GameObject cube, Vector3 newPos)
    {
        cube.transform.position = newPos;
    }
}
