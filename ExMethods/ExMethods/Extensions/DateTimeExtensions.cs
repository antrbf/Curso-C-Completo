using System.Globalization;

/*
 * Vamos criar um extension method chamado "ElapsedTime()" no struct
DateTime para apresentar um objeto DateTime na forma de tempo
decorrido, podendo ser em horas (se menor que 24h) ou em dias caso
contrário. Por exemplo:
DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
Console.WriteLine(dt.ElapsedTime());
"4.5 hours"
"3.2 days"
 */
namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
