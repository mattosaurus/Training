using JsonPlaceholder.Common.Models.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonPlaceholder.Common.Models.Clients
{
    public class JsonPlaceholderClient : IJsonPlaceholderClient
    {
        private IJsonPlaceholderService _jsonPlaceholderService;

        public JsonPlaceholderClient(IJsonPlaceholderService jsonPlaceholderService)
        {
            _jsonPlaceholderService = jsonPlaceholderService;
        }

        // Implement interface methods using service to access API

        public List<User> GetUsers()
        {
            return _jsonPlaceholderService.GetUsers();
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
