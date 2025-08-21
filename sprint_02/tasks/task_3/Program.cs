/* task_3
Create a class Checker. In the method Main() of this class write code for solving the next task:


Read a number of HTTP Error (400, 401, 402, 403, 404) and write the name of this error
(Declare enum HTTPError inside of the class Checker with values     
    BadRequest,
    Unauthorized,
    PaymentRequired,
    Forbidden,
    NotFound )
*/



using System;


namespace task_3
{
    public class Checker
    {

        public enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404
        }


        public static void Main()
        {
            HTTPError http_errors = HTTPError.BadRequest;

            int errorCode = (int)http_errors;
            errorCode = Convert.ToInt32(Console.ReadLine());


            switch (errorCode)
            {
                case 400:
                    http_errors = HTTPError.BadRequest;
                    Console.WriteLine("BadRequest");
                    break;
                case 401:
                    http_errors = HTTPError.Unauthorized;
                    Console.WriteLine("Unauthorized");
                    break;
                case 402:
                    http_errors = HTTPError.PaymentRequired;
                    Console.WriteLine("PaymentRequired");
                    break;
                case 403:
                    http_errors = HTTPError.Forbidden;
                    Console.WriteLine("Forbidden");
                    break;
                case 404:
                    http_errors = HTTPError.NotFound;
                    Console.WriteLine("NotFound");
                    break;
                default:
                    Console.WriteLine("Unknown error code");
                    break;
            }
        }
    }
}
