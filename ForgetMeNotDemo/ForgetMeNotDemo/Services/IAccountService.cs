using ForgetMeNot.Api.Dto;

namespace ForgetMeNotDemo.Services;

public interface IAccountService
{
  Task CreateAccount(AccountCreateRequest accountCreateRequest);
  Task GetNewPassword();
  Task Login(LoginRequest request);
  bool IsLoggedIn();
}