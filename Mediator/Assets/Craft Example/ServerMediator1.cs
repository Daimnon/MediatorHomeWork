using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerMediator1 : MonoBehaviour
{
    [SerializeField]
    private SceneColleague1 _scene;
    
    [SerializeField] 
    private List<PlayerColleague1> _players;

    [SerializeField]
    private GameObject _cubePrefub;

    [SerializeField]
    private Vector3 _newPos = Vector3.zero, _moveToPos = Vector3.zero;

    public void AddCube(Vector3 pos)
    {
        foreach (PlayerColleague1 player in _players)
            player.CubePositions.Add(pos);
    }

    public void CreateCube(Vector3 pos)
    {
        // clear all existing cubes
        _scene.RemoveCubes();

        // add cube position to cube positions list
        AddCube(pos);

        // instantiate
        foreach (PlayerColleague1 player in _players)
            _scene.CreateCube(_cubePrefub, player.CubePositions);
    }

    public void MoveCube(GameObject cube, Vector3 newPos)
    {
        foreach (PlayerColleague1 player in _players)
        {
            player.MoveCube(cube, newPos);
            _scene.CreateCube(_cubePrefub, player.CubePositions);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            CreateCube(_newPos);

        if (Input.GetKeyDown(KeyCode.D))
            foreach (GameObject cube in _scene.AllCubesInScene)
                if (cube.gameObject.activeInHierarchy)
                {
                    Destroy(cube);
                    MoveCube(cube, _moveToPos);
                }
    }
}
