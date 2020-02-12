using System;
using NC_Datas;

namespace NC_DBInterface
{
    public abstract class Transaction_Base
    {
        public string transaction_id;
        public string src_account_id;
        public string dst_account_id;
        public Currency srcCurrency;
        public Currency dstCurrency;
        public float amount;
        public float fees;
        public float change_fees;
        public DateTime date;
        public bool acknowledgement;
        public DateTime ackDate;

        public Transaction_Base(
                string transaction_id,
                string src_account_id,
                string dst_account_id,
                Currency srcCurrency,
                Currency dstCurrency,
                float amount,
                float fees,
                float change_fees,
                DateTime date,
                bool acknowledgement,
                DateTime ackDate)
        {
            this.transaction_id = transaction_id;
            this.src_account_id = src_account_id;
            this.dst_account_id = dst_account_id;
            this.srcCurrency = srcCurrency;
            this.dstCurrency = dstCurrency;
            this.amount = amount;
            this.fees = fees;
            this.change_fees = change_fees;
            this.date = date;
            this.acknowledgement = acknowledgement;
            this.ackDate = ackDate;
        }
    }

    public class Transaction : Transaction_Base
    {
        public Transaction(
                string transaction_id,
                string src_account_id,
                string dst_account_id,
                Currency srcCurrency,
                Currency dstCurrency,
                float amount,
                float fees,
                float change_fees,
                DateTime date,
                bool acknowledgement,
                DateTime ackDate)
            : base(
                transaction_id,
                src_account_id,
                dst_account_id,
                srcCurrency,
                dstCurrency,
                amount,
                fees,
                change_fees,
                date,
                acknowledgement,
                ackDate)
        {

        }
    }

    public class ShadowTransaction : Transaction_Base
    {
        public ShadowTransaction(
                string transaction_id,
                string src_account_id,
                string dst_account_id,
                Currency srcCurrency,
                Currency dstCurrency,
                float amount,
                float fees,
                float change_fees,
                DateTime date,
                bool acknowledgement,
                DateTime ackDate)
            : base(
                transaction_id,
                src_account_id,
                dst_account_id,
                srcCurrency,
                dstCurrency,
                amount,
                fees,
                change_fees,
                date,
                acknowledgement,
                ackDate)
        {

        }
    }
}
