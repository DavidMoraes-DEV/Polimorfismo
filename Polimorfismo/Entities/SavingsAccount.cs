using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao_PalavraVirtual_Override_Base.Entities
{
    sealed class SavingsAccount : Account //Essa classe agora com o sealed é selada para que não possa ter uma sub classe derivada dessa.
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //Agora esse método sobreposto com a palavra sealed NÃO poderá ser sobreposta novamente em outra subclasse.
        {
            base.Withdraw(amount); 
            Balance -= 2.0; 
        }

    }
}
