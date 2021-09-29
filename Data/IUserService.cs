﻿using Models;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public interface IUserService
    {
        void Create(User user);
        User Get(string username);

        User ValidateUser(string username, string password); 
    }
}