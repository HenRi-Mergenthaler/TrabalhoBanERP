namespace TrabalhoBan.Tabelas
{
    internal static class Cobranca
    {
        public static decimal ValorTempo(DateTime inicio, DateTime fim, decimal valorHora)
        {
            double horas = (fim - inicio).TotalHours;

            if (horas < 0.5)
                horas = 0.5;

            return Math.Round((decimal)horas * valorHora, 2);
        }

        public static bool EhCorujao(DateTime inicio)
        {
            return inicio.Hour >= 22 || inicio.Hour < 6;
        }

        public static string FormatarTempo(TimeSpan tempo)
        {
            return $"{(int)tempo.TotalHours:00}:{tempo.Minutes:00}";
        }
    }
}
