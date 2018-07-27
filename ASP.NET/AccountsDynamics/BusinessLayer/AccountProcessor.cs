using System;
using BusinessInterface;
using BusinessType;
using DataInterface;

namespace BusinessLayer
{
    public class AccountProcessor : IAccountProcessor
    {
        private IAccountRepository _repository;

        public AccountProcessor(IAccountRepository accoutRepository)
        {
            _repository = accoutRepository;
        }

        public string ConfirmationCreationAccount(Account account)
        {
            try
            {
                Guid accountId = _repository.CreateAccount(account);
                if (accountId != default(Guid))
                {
                    return "Se creo con éxito";
                }
                else
                {
                    return "Hubo un problema al crear el contacto";
                }
            }
            catch (Exception)
            {
                return "No se pudo guardar el contacto";
            }
        }
    }
}
