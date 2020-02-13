using System;
using NC_Datas;

namespace NC_DBInterface.db_objects
{
    public class Position
    {
        public string id;
        public string member_id;
        public string transaction_id;
        public string isin;
        public AssetClass assetClass;
        public PositionDirection direction;
        public float leverage;
        public Currency currency;
        public int amount;
        public float openingPrice;
        public float openingFees;
        public DateTime openingDate;
        public float closingPrice;
        public float closingFees;
        public DateTime closingDate;
        public float openingNetTotal
        {
            get =>
                openingPrice * amount;
        }

        public float openingBrutTotal
        {
            get =>
                (openingPrice * amount) + openingFees;
        }

        public float exposure
        {
            get =>
                (openingPrice * amount) * leverage;
        }

        public float marketValue
        {
            get
            {
                /*
                 * TODO : Call API or manual entry trought Proxy Class !!!
                 */
                return 0;
            }
        }

        public float result
        {
            get
            {
                if (closingDate != null)
                    return (closingPrice * amount * leverage + closingFees) - (exposure + openingFees);
                else
                    return (marketValue * amount * leverage) - (exposure + openingFees);
            }
        }

        public Position(
                string id,
                string member_id,
                string transaction_id,
                string isin,
                AssetClass assetClass,
                PositionDirection direction,
                float leverage,
                Currency currency,
                int amount,
                float openingPrice,
                float openingFees,
                DateTime openingDate,
                float closingPrice,
                float closingFees,
                DateTime closingDate)
        {
            this.id = id;
            this.member_id = member_id;
            this.transaction_id = transaction_id;
            this.isin = isin;
            this.assetClass = assetClass;
            this.direction = direction;
            this.leverage = leverage;
            this.currency = currency;
            this.amount = amount;
            this.openingPrice = openingPrice;
            this.openingFees = openingFees;
            this.openingDate = openingDate;
            this.closingPrice = closingPrice;
            this.closingFees = closingFees;
            this.closingDate = closingDate;
        }
    }
}
