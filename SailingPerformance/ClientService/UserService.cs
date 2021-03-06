﻿using System.Threading.Tasks;
using ClientService.UserServiceReference;

namespace ClientService
{
    public class UserService
    {
        public async Task<bool> CheckUser(string login, string password)
        {
            var result = await Task.Run(() =>
            {
                UserServiceClient client = new UserServiceClient();
                return client.CheckUser(login, password);
            });
            return result;
        }
    }
}
