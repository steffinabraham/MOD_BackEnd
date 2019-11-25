using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Repository
{
    public interface ILoginRepository
    {
        User UserLogin(string email, string pwd);
        Mentor MentorLogin(string email, string pwd);
    }
}
