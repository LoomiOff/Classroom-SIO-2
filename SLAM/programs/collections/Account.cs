using SLAM.utils;

namespace SLAM.programs.Collections
{
    public class Account
    {
        private uint Id = 0;
        private string Name = "";
        private double Balance = 0;
        private double MaxOverdraft = 0;
        private double MaxDebit = 0;
        private bool NonNullOverdraft = true;

        public Account() { }

        public Account(uint id, string name)
        {
            Id = id;
            Name = name;
            Balance = 0;
            NonNullOverdraft = true;

            MaxOverdraft = 0;
            MaxDebit = 0;
        }

        public Account(uint id, string name, double balance = 0, double maxOverdraft = 0, double maxDebit = 0, bool nonNullOverdraft = true)
        {
            Id = id;
            Name = name;
            Balance = balance;
            NonNullOverdraft = nonNullOverdraft;

            MaxOverdraft = Balance * 0.1;
            MaxDebit = Balance * 0.25;
        }

        public void Init(uint id, string name, double balance = 0, double maxOverdraft = 0, double maxDebit = 0, bool nonNullOverdraft = true)
        {
            Id = id;
            Name = name;
            Balance = balance;
            NonNullOverdraft = nonNullOverdraft;

            MaxOverdraft = Balance * 0.1;
            MaxDebit = Balance * 0.25;
        }

        public void Credit(double solde)
        {
            if (MaxOverdraft == 0 && MaxDebit == 0 && NonNullOverdraft)
            {
                MaxOverdraft = Balance * 0.1;
                MaxDebit = Balance * 0.1;
            }

            Balance += solde;
        }

        public void Debit(double amount)
        {
            if (amount > GetMaxDebit())
            {
                Utils.PrintError($"Le compte de {GetName()} ne peut dépasser un débit maximum de {GetMaxDebit()}.");
                return;
            }
            if ((Balance - amount) < -MaxOverdraft)
            {
                Utils.PrintError($"Le compte de {GetName()} passera en découvert.");
                return;
            }

            Balance -= amount;
        }

        public bool IsInRed()
        {
            return Balance < 0;
        }

        public bool IsOverdrawn()
        {
            return Balance < MaxOverdraft;
        }

        public void Transfer(Account other, double amount)
        {
            if (amount > GetMaxDebit())
            {
                Utils.PrintError($"Le compte de {GetName()} ne peut dépasser un débit maximum de {GetMaxDebit()}.");
                return;
            }
            if ((Balance - amount) < -MaxOverdraft)
            {
                Utils.PrintError($"Le compte de {GetName()} passera en découvert.");
                return;
            }

            Debit(amount);
            other.Credit(amount);
        }

        public int Compare(Account other)
        {
            int value = 0;
            if (Balance < other.Balance)
                value = -1;
            else if (Balance > other.Balance)
                value = 1;
            else
                value = 0;

            return value;
        }

        #region Méthodes d'accès

        public string Status()
        {
            return $"------==================------\n" +
                $"Le compte {Id} appartenant à {Name} à un solde de {Balance}.\n" +
                $"Débit Maximum : {MaxDebit}, Découvert Maximum : {MaxOverdraft}\n" +
                $"Le compte est débiteur ? {IsInRed()}\n" +
                $"Le compte est-il à découvert ? {IsOverdrawn()}" +
                $"\n------==================------";
        }

        public double GetBalance() { return Balance; }
        public void SetBalance(double newBalance) { Balance = newBalance; }

        public uint GetId() { return Id; }
        public void SetId(uint newId) { Id = newId; }

        public string GetName() { return Name; }
        public void GetName(string newName) { Name = newName; }

        public void SetMaxOverdraft(double value) { MaxOverdraft = value; }
        public double GetMaxOverdraft() { return MaxOverdraft; }

        public void SetMaxDebit(double value) { MaxDebit = value; }
        public double GetMaxDebit() { return MaxDebit; }

        #endregion Méthodes d'accès
    }
}
