using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace SecureEmployee.Application.Common.Interfaces;
public interface ICurrentUserService
{
   public Guid UserId { get;}
   public string Email { get; }
   public string Role { get; }
   public bool IsAuthenticated { get; }

}