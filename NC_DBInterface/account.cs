using System;
using NC_Datas;

namespace NC_DBInterface
{
    public abstract class Account_Base
    {
        public string id;
        public string member_id;
        public Currency currency;
        public float amount;

        public Account_Base(string id, string member_id, object currency, float amount)
        {
            this.id = id;
            this.member_id = member_id;
            this.amount = amount;
            if (currency is Currency || currency is int)
                this.currency = (Currency)currency;
            else if (currency is string)
                this.currency = (Currency)Enum.Parse(typeof(Currency), (string)currency, true);

        }
    }

    public class Account : Account_Base
    {
        string depositary_id;

        public Account(string id, string member_id, object currency, float amount, string depositary)
            : base(id, member_id, currency, amount)
        {
            this.depositary_id = depositary;
        }
    }

    public class ShadowAccount : Account_Base
    {
        public ShadowAccount(string id, string member_id, object currency, float amount)
            : base(id, member_id, currency, amount)
        {

        }
    }
}
