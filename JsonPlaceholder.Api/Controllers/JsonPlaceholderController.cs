using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonPlaceholder.Common.Models;
using JsonPlaceholder.Common.Models.Clients;
using JsonPlaceholder.Common.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JsonPlaceholder.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class JsonPlaceholderController : ControllerBase
    {
        private readonly IJsonPlaceholderClient _jsonPlaceholderClient;
        private readonly ILogger<IJsonPlaceholderClient> _logger;

        public JsonPlaceholderController()
        {
            // Create client here initially and then move to creating it in Startup and passing through to controller using Dependency Injection
            IJsonPlaceholderService jsonPlaceholderService = new JsonPlaceholderHttpService("https://jsonplaceholder.typicode.com/");
            _jsonPlaceholderClient = new JsonPlaceholderClient(jsonPlaceholderService);
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1
            // Then inject a logger and use to log requests
        }

        // Add endpoints for the rest of the client methods
        [HttpGet]
        [ActionName("User")]
        public List<User> GetUsers()
        {
            return _jsonPlaceholderClient.GetUsers();
        }

        [HttpGet]
        [ActionName("User/{id}")]
        public User GetUserById(int id)
        {
            return _jsonPlaceholderClient.GetUserById(id);
        }

        [HttpPost]
        [ActionName("User")]
        public void CreateUser(User user)
        {
            _jsonPlaceholderClient.CreateUser(user);
        }

        [HttpGet]
        [ActionName("Album")]
        public List<Album> GetAlbumsByUserId(int userId)
        {
            return _jsonPlaceholderClient.GetAlbumsByUserId(userId);
        }
    }
}
