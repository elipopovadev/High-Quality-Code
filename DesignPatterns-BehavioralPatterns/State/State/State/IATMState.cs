namespace State
{
   public interface IATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
