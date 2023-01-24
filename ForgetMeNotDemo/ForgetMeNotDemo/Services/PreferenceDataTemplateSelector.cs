using ForgetMeNotDemo.Model;

namespace ForgetMeNotDemo.Services;

public class PreferenceDataTemplateSelector : DataTemplateSelector
{
  public DataTemplate PreferenceTemplate { get; set; }
  public DataTemplate PreferenceTemplateEmpty { get; set; }

  protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
  {
    if (((Preference)item)?.PreferenceValue == null)
      return PreferenceTemplateEmpty;
    return ((Preference) item).PreferenceValue.Length > 0 ? 
      PreferenceTemplate : PreferenceTemplateEmpty;
  }
}

