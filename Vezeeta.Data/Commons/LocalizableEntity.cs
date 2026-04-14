
namespace Vezeeta.Data.Commons
{
    public class LocalizableEntity
    {

        public string GetLocalizedName(string textEn, string textAr)
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            return currentCulture.ThreeLetterISOLanguageName.ToLower() switch
            {
                "ar" => textAr,
                _ => textEn
            };
        }
    }
}
