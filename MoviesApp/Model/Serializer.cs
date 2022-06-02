using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MoviesApp.Model
{
    public static class Serializer
    {
        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        public static void Serialize(string fileName, List<Movie> movies)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(JsonConvert.SerializeObject(movies));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию строений.</returns>
        public static List<Movie> Deserialize(string fileName)
        {
            var movies = new List<Movie>();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    movies = JsonConvert.DeserializeObject<List<Movie>>(reader.ReadToEnd());
                }

                if (movies == null) movies = new List<Movie>();
            }
            catch
            {
                return movies;
            }

            return movies;
        }
    }
}
