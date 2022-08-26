using FreddinhoWebApi.Interfaces;
using FreddinhoWebApi.Models.Entity;
using FreddinhoWebApi.Repository.Context;
using FreddinhoWebApi.Util;
using Microsoft.EntityFrameworkCore;

namespace FreddinhoWebApi.Repository
{
    public class EntityRepository
    {
        private DataBaseContext? _repository { get; set; }

        public EntityRepository(DataBaseContext dataBaseContext) =>
            _repository = dataBaseContext;


        public async Task<bool> UserExist(string email, string password) =>
            (await _repository.DbAccount
                    .Where(u => u.Email == email
                        && u.Password == EncryptPassword(password))
                    .ToListAsync()).Count >= 1;

        public async Task<(bool, string)> InsertUser(IAccount account) 
        {
            try
            {
                if ((await UserExist(account.Email, account.Password)))
                    return new(false, "Usuário já cadastrado no Freddinho!");

                var user = ConvertToEntityClass(account);

                await _repository.DbAccount.AddAsync(user);

                await _repository.SaveChangesAsync();

                return new(true, "");
            }
            catch (Exception ex)
            {
                return new(false, ex.Message);
            }   
        }

        private EntityAccount ConvertToEntityClass(IAccount account) =>
            new() 
            {
                Name = account.Name,
                CellphoneNumber = account.CellphoneNumber,
                Email = account.Email,
                BirthDate = account.BirthDate,
                Gender = account.Gender,
                Password = EncryptPassword(account.Password)
            };

        private string EncryptPassword(string password) =>
            Encrypt.EncryptData(password);

        public async Task<(bool, string)> InsertUser(Dependent dependent)
        {
            try
            {
                await _repository.DbDependent.AddAsync(dependent);

                await _repository.SaveChangesAsync();

                return new(true, "");
            }
            catch (Exception ex)
            {
                return new(false, ex.Message);
            }
        }
    }
}