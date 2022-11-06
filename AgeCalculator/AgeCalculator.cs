using System;

namespace AgeCalculator
{
    public class AgeCalculate
    {
        public string calculate(string startDate, string endDate)
        {
            DateTime bornDate = DateTime.ParseExact(startDate, "dd/MM/yyyy" , null);
            DateTime lastDate = DateTime.ParseExact(endDate, "dd/MM/yyyy", null);

            TimeSpan days = lastDate.Date - bornDate.Date;
            int age = (int)days.TotalDays /365;
            //age = age / 365;
            return  age.ToString();
        }
    }
}
