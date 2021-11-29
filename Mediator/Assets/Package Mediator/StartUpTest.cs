using UnityEngine;

public class StartUpTest : MonoBehaviour
{
    [SerializeField]
    private CreatorProductPackage _creator;

    private void Start()
    {
        _creator.Create();
    }
}
