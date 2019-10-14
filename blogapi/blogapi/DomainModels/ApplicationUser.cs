using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogapi.DomainModels
{
  public class ApplicationUser : IdentityUser
  {
    public string FullName { get; set; }

    public string NickName { get; set; }

    public string TwitterHandle { get; set; }

    public string GitHubHandle { get; set; }

    public string EmailAddress { get; set; }

    public string Facebook { get; set; }

    public DateTimeOffset DateOfBirth { get; set; }
  }
}
