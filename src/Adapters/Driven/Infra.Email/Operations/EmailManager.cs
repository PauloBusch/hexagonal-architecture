﻿using Domain.Adapters;
using System.Threading.Tasks;

namespace Infra.Email.Operations
{
    public class EmailManager : IEmailAdapter
    {
        public Task SendEmail(string from, string to, string subject, string body)
        {
            throw new System.NotImplementedException();
        }
    }
}
