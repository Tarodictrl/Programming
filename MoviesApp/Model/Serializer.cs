using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Environment;

namespace MoviesApp.Model
{
    /// <summary>
    ///  Предоставляет методы для сериализации и десериализации.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Serializer"/>.
        /// </summary>
        static Serializer()
        {
            Path = $@"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}"
                + "/Detter Daniil/MoviesApp/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        public static void Serialize(List<Movie> movies)
        {
            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(movies));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию строений.</returns>
        public static List<Movie> Deserialize()
        {
            var movies = new List<Movie>();

            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
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

        /// <summary>
        /// Возвращает и задает путь куда будут сериализоватся данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public static string FileName { get; set; }
    }
}
