using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsThroughCode.Users
{
  public sealed class User
  {
    public Guid Id = Guid.NewGuid();

    public User(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
  }
}
