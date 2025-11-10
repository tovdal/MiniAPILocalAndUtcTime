namespace MinAPITime.Data
{
    public class LocalandUtcTime
    {
        public class LocalAndUtcTime
        {

            public LocalAndUtcTime(DateTime utc, DateTime local)
            {
                Utc = utc;
                Local = local;
            }
            public DateTime Utc { get; set; }
            public DateTime Local { get; set; }
        }
    }
}
