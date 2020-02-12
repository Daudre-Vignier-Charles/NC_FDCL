namespace NC_DBInterface
{
    public class Depositary
    {
        public string depositary_id;
        public string socialReason;
        public string depoOwnId;
        public string depoOwnIdType;

        public Depositary(string depositary_id, string socialReason, string depoOwnId, string depoOwnIdType)
        {
            this.depositary_id = depositary_id;
            this.socialReason = socialReason;
            this.depoOwnId = depoOwnId;
            this.depoOwnIdType = depoOwnIdType;
        }
    }
}
