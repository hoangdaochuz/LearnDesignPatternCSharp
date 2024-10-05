namespace SingletonPattern.FacadePattern;

public class UpdateUserMVCFacade
{
    private readonly UpdateUserController _updateUserController;
    private readonly UpdateUserService _updateUserService;
    private readonly UpdateUserRepository _updateUserRepository;

    public UpdateUserMVCFacade()
    {
        _updateUserController = new UpdateUserController();
        _updateUserService = new UpdateUserService();
        _updateUserRepository = new UpdateUserRepository();
    }

    public void UpdateUserFlow()
    {   
        _updateUserController.getRequestIncommingUser();
        _updateUserController.callUpdateUserService();
        _updateUserService.doBusineesLogic();
        _updateUserService.callUpdateUserRepository();
        _updateUserRepository.UpdateUserDB();
        _updateUserRepository.returnValue();
    }
}