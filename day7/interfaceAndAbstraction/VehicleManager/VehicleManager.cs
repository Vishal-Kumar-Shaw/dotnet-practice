public class VehicleManager
{
    private readonly IService _service;
    public VehicleManager(IService service)
    {
        _service = service;
    }
    public void PerformService()
    {
        _service.Service();
    }
}