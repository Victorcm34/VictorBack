using VictorBack.DTOs;

namespace VictorBack.Services
{
    public interface IUserService
    {
        /// <summary>
        /// Method that uses <see cref="IData.GetExperience"/> to get user experience
        /// </summary>
        /// <returns></returns>
        public ExperienceDTO GetExperience();

        /// <summary>
        /// Method that uses <see cref="IData.GetAboutMe"/> to get user information
        /// </summary>
        /// <returns></returns>
        public UserDTO GetUserInfo();
    }
}