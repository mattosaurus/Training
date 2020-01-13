using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace JsonPlaceholder.Common.Models.Services
{
    public class JsonPlaceholderHttpService : HttpClient, IJsonPlaceholderService
    {
        public JsonPlaceholderHttpService(string baseAdddress)
        {
            this.BaseAddress = BaseAddress;
        }

        // Implement interface methods using HttpClient
        // https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public Album GetAlbumById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAlbumsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public void CreateAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public List<Photo> GetPhotos()
        {
            throw new NotImplementedException();
        }

        public Photo GetPhotoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Photo> GetPhotosByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Photo> GetPhotosByAlbumId(int albumId)
        {
            throw new NotImplementedException();
        }

        public void CreatePhoto(Photo photo)
        {
            throw new NotImplementedException();
        }
    }
}
