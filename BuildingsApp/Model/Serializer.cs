using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace BuildingsApp.Model
{
    public static class Serializer
    {
        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        public static void Serialize(string appDataFolder, List<Building> buildings)
        {
            using (StreamWriter writer = new StreamWriter(appDataFolder))
            {
                writer.Write(JsonConvert.SerializeObject(buildings));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию строений.</returns>
        public static List<Building> Deserialize(string appDataFolder)
        {
            var building = new List<Building>();

            try
            {
                using (StreamReader reader = new StreamReader(appDataFolder))
                {
                    building = JsonConvert.DeserializeObject<List<Building>>(reader.ReadToEnd());
                }

                if (building == null) building = new List<Building>();
            }
            catch
            {
                return building;
            }

            return building;
        }
    }
}
