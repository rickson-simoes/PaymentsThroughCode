using PaymentsThroughCode.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentsThroughCode
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var management = new UserManagement();

      var newUser1 = new User("Rickson", 28);
      var newUser2 = new User("Fulano", 12);
      var newUser3 = new User("Beltrano", 19);

      management.AddUser(newUser1);
      management.AddUser(newUser2);
      management.AddUser(newUser3);


      var menorDeDezoito = management.Users.Where(user => user.Age < 18);

      management.Users.RemoveAll(user => user.Age < 18);

      Console.WriteLine("Usuarios:");
      foreach (var u in management.Users)
      {
        Console.WriteLine($"{u.Name} - {u.Age} - {u.Id}");
      }

    }
  }
}
