using ForgetMeNot.Api.Dto;
using ForgetMeNot.ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotDemo.Services
{
  public class AccountService : IAccountService
  {
    readonly Client apiClient;

    public AccountService(Client apiClient)
    {
      this.apiClient = apiClient;
    }

    public async Task CreateAccount(AccountCreateRequest accountCreateRequest)
    {
      await apiClient.CreateAccount(accountCreateRequest);
    }

    public async Task GetNewPassword()
    {

    }

    public async Task Login(LoginRequest request)
    {
      await apiClient.Login(request);
    }

    public bool IsLoggedIn()
    {
      return apiClient.IsAuthenticated;
    }

  }
}
