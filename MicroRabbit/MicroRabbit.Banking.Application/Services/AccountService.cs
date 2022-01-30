using MicroRabbit.Banking.Application.DTOs;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;
        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAll()
        {
            return _accountRepository.GetAll();
        }

        public void Tranfer(AccountTranfer accountTranfer)
        {
            var createTranferCommand = new CreateTranferCommand(
                accountTranfer.FromAccount,
                accountTranfer.ToAccount,
                accountTranfer.TranferAmount
                );

            _bus.SendCommand(createTranferCommand);
        }
    }
}
