# Training
Repository containg training exercises

# JsonPlaceholder
Exercises to introduce uses to accessing APIs, creating class libraries and returning data via API and Function.

1. JsonPlaceholder.Common - Class Library - https://jsonplaceholder.typicode.com/
   * Update Album, Photo and User properties
   * Implement API methods in JsonPlaceholderHttpService
   * Implement API methods in JsonPlaceholderRestSharpService
   * Implement service methods in JsonPlaceholderClient
2. JsonPlaceholder.Api - ASP.NET Core Web Application - API
   * Create a new instance of the API client JsonPlaceholderController
   * Add the remaining methods for accessing the client
   * Use Dependency Injection to create the client in Startup and inject it into JsonPlaceholderController
   * Add logging with Serilog in Startup, inject into JsonPlaceholderController and log the events
3. JsonPlaceholder.Function - Azure Function
   * Update JsonPlaceholderFunction with the missing client access methods
   * Refactor the project to have a Startup class to enable Dependency Injection of the client
   * Add logging with Serilog in Startup, inject into JsonPlaceholderFunction and log the events
4. JsonPlaceholder.WebSite - ASP.NET Core Web Application - Web Site
   * TBC
5. Extras
   * Refactor all methods to be async
   * Add error handling
   * Add tests
   * Publish to Azure
