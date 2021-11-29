using UnityEngine;

public class Package : MonoBehaviour
{
    [SerializeField]
    protected GameObject _mediatorGO;

    protected IPackageMediator Mediator => _mediatorGO.GetComponent<IPackageMediator>();
}
