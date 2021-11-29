public class DeliveryProductPackage : Package
{
    public void Send(string productPackage)
    {
        var package = productPackage + "Delivery";

        print("Packaging: " + package);
    }
}