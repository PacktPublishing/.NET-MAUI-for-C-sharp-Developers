using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeNotDemo.Model;

namespace ForgetMeNotDemo.Services
{
  public interface IBuddyService
  {
    Task<List<Buddy>> GetBuddies();
    List<Preference> GetBuddyPreferences(string buddyId);
  }
}
