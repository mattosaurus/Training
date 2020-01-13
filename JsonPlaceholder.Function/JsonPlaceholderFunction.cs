using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using JsonPlaceholder.Common.Models;
using JsonPlaceholder.Common.Models.Clients;

namespace JsonPlaceholder.Function
{
    public static class JsonPlaceholderFunction
    {
        [FunctionName("GetUsers")]
        public static async Task<IActionResult> GetUsers(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "User")] HttpRequest req,
            ILogger log)
        {
            // Create client and return users
            return new NotFoundResult();
        }

        [FunctionName("GetUserById")]
        public static async Task<IActionResult> GetUserById(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "User/{id}")] HttpRequest req, int id,
            ILogger log)
        {
            // Create client and return user
            return new NotFoundResult();
        }

        [FunctionName("CreateUser")]
        public static async Task<IActionResult> CreateUser(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "User")] HttpRequest req,
            ILogger log)
        {
            // Create client and return OK result
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            User user = JsonConvert.DeserializeObject<User>(requestBody);

            return new NotFoundResult();
        }

        [FunctionName("GetAlbumsByUserId")]
        public static async Task<IActionResult> GetAlbumsByUserId(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Album")] HttpRequest req,
            ILogger log)
        {
            // Create client and return albums
            int userId = int.Parse(req.Query["userId"]);

            return new NotFoundResult();
        }
    }
}
