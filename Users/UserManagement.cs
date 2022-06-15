using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsThroughCode.Users
{
  public sealed class UserManagement
  {
    public List<User> Users { get; set; }

    public UserManagement()
    {
      Users = new List<User>();
    }
    public void AddUser(User user)
    {
      Users.Add(user);
    }
  }
}
