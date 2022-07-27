using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CFilzenFunctionApp
{
    public static class BirthdayFunction
    {
        [FunctionName("BirthdayFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("We translated birthday to age.");

            string name = req.Query["name"];
            string birthdate = req.Query["birthdate"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;
            birthdate = birthdate ?? data?.birthdate;

            //"08/08/2020" format
            var age = CalculateAge(DateTime.Parse(birthdate));

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. You told me your birthday is {birthdate}. Your age is {age}..";

            return new OkObjectResult(responseMessage);
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            var age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
