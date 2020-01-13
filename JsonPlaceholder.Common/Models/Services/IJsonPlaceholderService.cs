using System;
using System.Collections.Generic;
using System.Text;

namespace JsonPlaceholder.Common.Models.Services
{
    public interface IJsonPlaceholderService
    {
        List<User> GetUsers();

        User GetUserById(int id);

        void CreateUser(User user);

        List<Album> GetAlbums();

        Album GetAlbumById(int id);

        List<Album> GetAlbumsByUserId(int userId);

        void CreateAlbum(Album album);

        List<Photo> GetPhotos();

        Photo GetPhotoById(int id);

        List<Photo> GetPhotosByUserId(int userId);

        List<Photo> GetPhotosByAlbumId(int albumId);

        void CreatePhoto(Photo photo);
    }
}
