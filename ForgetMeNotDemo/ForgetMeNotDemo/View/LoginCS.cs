//using CommunityToolkit.Maui.Markup;
//using ForgetMeNotDemo.ViewModel;
//using static CommunityToolkit.Maui.Markup.GridRowsColumns;

//namespace ForgetMeNotDemo.View;

//enum Row
//{
//  Username,
//  Password,
//  Buttons
//}

//enum Column
//{
//  Submit,
//  Create,
//  Forgot
//}
//class LoginCS : ContentPage
//{
//  public LoginCS()
//  {
//    BindingContext = new LoginViewModel();

//    var activity = new ActivityIndicator()
//    {
//      HeightRequest = 50,
//      Color = Color.FromRgb(0, 0, 0xF),
//    };


//    Content = new VerticalStackLayout()
//    {
//      Children =
//                {
//                    activity,

//                    new Grid()
//                    {
//                        RowDefinitions = GridRowsColumns.Rows.Define(
//                            (Row.Username,Auto),
//                            (Row.Password,Auto),
//                            (Row.Buttons, Auto)
//                            ),

//                        ColumnDefinitions = GridRowsColumns.Columns.Define(
//                            (Column.Submit,Star),
//                            (Column.Create, Star),
//                            (Column.Forgot, Star)
//                            ),
//                        Children =
//                        {
//                            new Label()
//                                .Text("User name")
//                                .Row(Row.Username).Column(0),

//                            new Entry()
//                                .Placeholder("User name")
//                                .Bind(Entry.TextProperty,nameof(LoginViewModel.LoginName))
//                                .Row(Row.Username).Column(1)
//                                .ColumnSpan(2),

//                            new Label()
//                                .Text("Password")
//                                .Row(Row.Password).Column(0),

//                            new Entry {IsPassword = true}
//                                .Placeholder("Password")
//                                .Bind(Entry.TextProperty, nameof(LoginViewModel.Password))
//                                .Row(Row.Password).Column(1)
//                                .ColumnSpan(2),

//                            new Button()
//                                .Text("Submit")
//                                .Row(Row.Buttons).Column(Column.Submit)
//                                .Margin(5)
//                                .BindCommand(nameof(LoginViewModel.DoLoginCommand)),
//                            new Button()
//                                .Text("Create Account")
//                                .Margin(5)
//                                .Row(Row.Buttons).Column(Column.Create)
//                                .BindCommand(nameof(LoginViewModel.DoCreateAccountCommand)),
//                            new Button()
//                                .Margin(5)
//                                .Text("Forgot Password")
//                                .Row(Row.Buttons).Column(Column.Forgot)
//                        }
//                    }
//                }
//    };
//  }
//}




