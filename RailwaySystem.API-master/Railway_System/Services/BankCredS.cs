using RailwaySystem.API.Models;
using RailwaySystem.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Services
{
    public class BankCredS
    {
        private IBankCred _bankcredRepository;
        public BankCredS(IBankCred bankcredRepository)
        {
            _bankcredRepository = bankcredRepository;
        }
        public string DeactBankCred(int BankCredId)
        {
            return _bankcredRepository.DeactBankCred(BankCredId);
        }
        public string SaveBankCred(BankCred bankCred)
        {
            return _bankcredRepository.SaveBankCred(bankCred);
        }
        public string UpdateBankCred(BankCred bankCred)
        {
            return _bankcredRepository.UpdateBankCred(bankCred);
        }
        public BankCred GetBankCred(int BankCredId)
        {
            return _bankcredRepository.GetBankCred(BankCredId);
        }
        public List<BankCred> GetAllBankCreds()
        {
            return _bankcredRepository.GetAllBankCreds();
        }
    }
}
