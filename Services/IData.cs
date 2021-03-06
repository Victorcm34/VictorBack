using VictorBack.DTOs;

namespace VictorBack.Services
{
    public interface IData
    {
        /// <summary>
        /// Method to retrieve all experience data.
        /// </summary>
        /// <returns></returns>
        public ExperienceDTO GetExperience();

        /// <summary>
        /// Method to retrieve all user info.
        /// </summary>
        /// <returns></returns>
        public UserDTO GetAboutMe();
    }
}