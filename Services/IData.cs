using VictorBack.Models;

namespace VictorBack.Services
{
    public interface IData
    {
        /// <summary>
        /// Method to retrieve all experience data.
        /// </summary>
        /// <returns></returns>
        public Experience GetExperience();
    }
}