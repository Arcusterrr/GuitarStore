using Domain.Abstractions.Data;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class User : IdentityUser<int>, IEntity
    {
        public bool Deleted { get; private set; }

        public DateTime RegistrationDate { get; private set; }

        public IReadOnlyList<UserRoleEntity> RolesEntities { get; private set; }
        public IReadOnlyList<UserRole> Roles => _roles ??= GetRoles();

        private List<UserRole> _roles;

        public List<Cart> Carts { get; set; }

        public User(DateTime dateCreated, string userName)
        {
            UserName = userName;
            SecurityStamp = Guid.NewGuid().ToString();
            RegistrationDate = dateCreated;
        }

        protected User() { }

        public bool IsStaff => Roles.Any(r => r == UserRole.Admin || r == UserRole.Moderator);

        public void SetRegistrationDate(DateTime date)
        {
            RegistrationDate = date;
        }

        private List<UserRole> GetRoles() =>
            RolesEntities
                .Select(r => Enum.Parse<UserRole>(r.Role.Name))
                .ToList();

        public void Delete()
        {
            Deleted = true;

            var delGuid = Guid.NewGuid().ToString("N");

            PhoneNumber = delGuid;

            Email = delGuid;
            NormalizedEmail = delGuid;

            UserName = delGuid;
            NormalizedUserName = delGuid;
        }
    }
}