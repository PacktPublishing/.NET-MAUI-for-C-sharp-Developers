using ForgetMeNotDemo.Database;
using ForgetMeNotDemo.Model;
using SQLite;

public class ForgetMeNotDemoDatabase
{
  private SQLiteAsyncConnection Database;

  private async Task Init()
  {
    if (Database is not null)
      return;

    Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
    await Database.CreateTableAsync<Preference>();
  }

  public async Task<int> SavePreference(Preference preference)
  {
    await Init();
    if (preference.Id != 0)
    {
      return await Database.UpdateAsync(preference);
    }
    else
    {
      return await Database.InsertAsync(preference);
    }
  }

  public async Task<List<Preference>> GetPreferences()
  {
    await Init();
    return await Database.Table<Preference>().ToListAsync();
    
    // return await Database.QueryAsync<Preference>("SELECT * FROM [Preference]");
  }
}