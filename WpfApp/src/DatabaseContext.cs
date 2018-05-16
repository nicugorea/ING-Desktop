
public class DatabaseContext
{
    private static DatabaseContext _instance = null;

    private DatabaseContext() { }

    private WpfApp.INGService.INGServiceClient _serviceClient = null;



    public WpfApp.INGService.INGServiceClient ServiceClient
    {
        get
        {
            if (_serviceClient == null)
            {
                _serviceClient = new WpfApp.INGService.INGServiceClient();
            }
            return _serviceClient;
        }
    }

    public static DatabaseContext Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DatabaseContext();
            }
            return _instance;
        }
    }
}

