using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace testcsharp.Models
{
    public interface IPrinciple
    {
        IIdentity Identity { get; }

        bool IsinRole(string role);
    }
}
