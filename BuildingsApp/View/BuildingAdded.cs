using BuildingsApp.Model;
using System;

namespace BuildingsApp.View
{
    public class BuildingAddedEventArgs : EventArgs
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="BuildingAddedEventArgs"/>.
        /// </summary>
        /// <param name="build">Строение.</param>
        public BuildingAddedEventArgs(Building build)
        {
            Build = build;
        }

        /// <summary>
        /// Возвращает и задаёт cтроение.
        /// </summary>
        public Building Build { get; set; }
    }
}
