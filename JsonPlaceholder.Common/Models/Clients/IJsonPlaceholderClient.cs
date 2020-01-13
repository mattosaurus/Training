using System.Collections.Generic;

namespace JsonPlaceholder.Common.Models.Clients
{
    public interface IJsonPlaceholderClient
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
