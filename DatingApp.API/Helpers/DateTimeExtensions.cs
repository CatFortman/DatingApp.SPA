using System;

namespace DatingApp.API.Helpers
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime theDateTime)
        {
            int age = DateTime.Today.Year - theDateTime.Year;
            if (theDateTime.AddYears(age) > DateTime.Today)
            {
                age--;
            }
            
            return age;
        }
    }
}