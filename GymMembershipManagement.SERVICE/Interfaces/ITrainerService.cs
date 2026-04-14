using GymMembershipManagement.SERVICE.DTOs.Schedule;
using GymMembershipManagement.SERVICE.DTOs.User;

namespace GymMembershipManagement.SERVICE.Interfaces
{
    public interface ITrainerService
    {
        Task<bool> AssignSchedule(AssignScheduleDTO dto);
        Task<ScheduleDTO> CreateSchedule(AssignScheduleDTO dto);
        Task<IEnumerable<ScheduleDTO>> GetSchedulesByTrainer(int trainerId);
        Task<IEnumerable<ScheduleDTO>> GetAllSchedules();
        Task<bool> UpdateSchedule(UpdateScheduleDTO dto);
        Task<bool> DeleteSchedule(int scheduleId);
        Task<IEnumerable<UserDTO>> GetAllTrainers();
    }
}
