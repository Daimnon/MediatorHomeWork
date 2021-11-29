using UnityEngine;

public class PackageMediator : MonoBehaviour, IPackageMediator
{
    [SerializeField]
    private CreatorProductPackage _creator;

    [SerializeField]
    private PackagingProductPackage _packaging;
    
    [SerializeField]
    private DeliveryProductPackage _delivery;

    public void Do(Package package)
    {
        if (package == _creator)
        {
            _packaging.Execute(_creator.ProductPackage);
            return;
        }

        if (package == _packaging)
        {
            _delivery.Send(_packaging.ProductPackage);
            return;
        }
    }
}
