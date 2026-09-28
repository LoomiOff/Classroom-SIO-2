namespace SLAM.programs.Collections
{
    public class CollectionProgram : IProgram
    {
        public void Execute()
        {
            string bankName = Utils.ReadString("Entrer un nom de banque.");
            Bank bank = new Bank(bankName);

            Utils.PrintSuccess($"La banque '{bank.GetName()}' a était créée avec {bank.GetSize()} comptes.");

            string accountName = Utils.ReadString("Entrer un nom de compte.");
            Account account1 = new Account(1, accountName);
            Utils.PrintSuccess($"Le compte {account1.GetName()} (id: {account1.GetId()}) a était créer.");

            bank.AddAccount(account1);
            Utils.PrintSuccess($"La banque possède désormais le compte '{account1.GetName()}' et possède donc {bank.GetSize()} comptes.");
        }
    }
}
