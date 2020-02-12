using NC_Datas;
using System;

namespace NC_Assets
{
    public enum BondType
    {
        Coupon,
        ZeroCoupon,
        Perpetual,
        InterestAtMaturity
    }

    public enum BondPlacementMethod
    {

    }

    public class BondClass
    {
        public bool Subordinated { get; set; } = false;
        public bool Sinkable { get; set; } = false;
        public bool Perpetual { get; set; } = false;
        public bool Convertible { get; set; } = false;
        public bool Structured { get; set; } = false;
        public bool Restructuring { get; set; } = false;
        public bool Securitization { get; set; } = false;
        public bool Mortgage { get; set; } = false;
        public bool Covered { get; set; } = false;
        public bool CDO { get; set; } = false;
        public bool Sukuk { get; set; } = false;
        public bool Retail { get; set; } = false;
        public bool Supranational { get; set; } = false;
        public bool Marketable { get; set; } = false;
    }

    public class Bond_Base
    {
        public string ISIN;
        public string Issuer;
        public Country Country;
        // TODO Currency
        public bool Corporate;
        public DateTime Placement;
        public DateTime Maturity;
        public int Nominal;
        public int OutstandingPrincipalAmount;
        public int ParAmount;
        public int Amount;
        public float FloatingRate;
        public float CouponRate;
        public float CurrentCouponRate;
        public float DayCountFraction;
        public DateTimeOffset CouponFrequencyOffset;
        public int CouponFrequency;
        public BondClass Class;

        // Call API using ISIN
        public Bond_Base(string ISIN)
        {

        }
    }
}
