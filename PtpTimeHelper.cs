namespace Uetm_2_0
{
    public static class PtpTimeHelper
    {
        public static (uint ns, uint slo, ushort ptsecHi) DateTimeToPtp(DateTime dateTime)
        {
            DateTime utc = dateTime.ToUniversalTime();
            long seconds = (long)(utc - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            uint slo = (uint)(seconds & 0xFFFFFFFF);
            ushort ptsecHi = (ushort)((seconds >> 32) & 0xFFFF);
            // Наносекунды из дробной части секунды
            long ticks = utc.Ticks % TimeSpan.TicksPerSecond; // 1 тик = 100 нс
            uint ns = (uint)(ticks * 100); // конвертация в наносекунды
            return (ns, slo, ptsecHi);
        }

        public static DateTime PtpToDateTime(uint ns, uint slo, ushort ptsecHi)
        {
            long seconds = ((long)ptsecHi << 32) | slo;
            DateTime epoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime utc = epoch.AddSeconds(seconds).AddTicks(ns / 100);
            return utc.ToLocalTime();
        }

        public static DateTime PtpToDateTime(uint ns, uint slo)
        {
            return PtpToDateTime(ns, slo, 0);
        }
    }
}