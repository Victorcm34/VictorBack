using VictorBack.DTOs;

namespace VictorBack.Services
{
    public class UserService : IUserService
    {
        private readonly IData _data;

        public UserService(IData data)
        {
            _data = data;
        }

        // <inheritdoc cref="IUserService.GetExperience"/>
        public ExperienceDTO GetExperience()
        {
            return _data.GetExperience();
        }

        // <inheritdoc cref="IUserService.GetUserInfo"/>
        public UserDTO GetUserInfo()
        {
            return _data.GetAboutMe();
        }
    }
}