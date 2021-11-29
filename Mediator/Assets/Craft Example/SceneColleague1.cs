using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneColleague1 : MonoBehaviour
{
    [SerializeField]
    private ServerMediator1 _serverMediator;

    public List<GameObject> AllCubesInScene = new List<GameObject>();
    public void CreateCube(GameObject cube, List<Vector3> positions)
    {
        foreach (Vector3 pos in positions)
        {
            // initialize cube
            AllCubesInScene.Add(Instantiate(cube, pos, Quaternion.identity));
            Debug.Log("New Cube");
        }
    }

    public void RemoveCubes()
    {
        // destroy all cubes
        foreach (GameObject actualCube in AllCubesInScene)
        {
            Destroy(actualCube);
            Debug.Log("delete all cubes");
        }

        AllCubesInScene.Clear();
    }
}
