using System;
namespace LearnCS
{
    class Institute
    {
        private string _CourseName;
        private decimal _Fees;
        public void SetCourse(string courseName, decimal fees)
        {
            this._CourseName = courseName;
            this._Fees = fees;
        }
        public void GetDiscount(decimal percentage, out decimal discount)
        {
            discount = percentage * 10;
        }
        public void UpdateCourseFees(ref decimal fees, decimal discount)
        {
            fees -= discount;
        }
        public string GetCourseName()
        {
            return _CourseName;
        }
        public decimal GetCourseFees()
        {
            return _Fees;
        }
    }
    public class Demo
    {
        public static void Main(string[] args)
        {
            Institute inst = new Institute();
            inst.SetCourse(".NET Core", 25000);
            string courseName = inst.GetCourseName();
            decimal fees = inst.GetCourseFees();
            Console.WriteLine($"Course Name : {courseName}");
            Console.WriteLine($"Original Course Fees : {fees}");
            Console.Write("Enter Your Percentage :");
            //decimal percentage = decimal.Parse(Console.ReadLine());
            decimal.TryParse(Console.ReadLine(), out decimal percentage);
            //decimal discount;
            //inst.GetDiscount(percentage, out discount);
            inst.GetDiscount(percentage, out decimal discount);
            Console.WriteLine($"Congrats, You have got a discount of Rs. {discount}");
            inst.UpdateCourseFees(ref fees, discount);
            Console.WriteLine($"After Discount Fees: {fees}");
            Console.ReadLine();
        }
    }
}