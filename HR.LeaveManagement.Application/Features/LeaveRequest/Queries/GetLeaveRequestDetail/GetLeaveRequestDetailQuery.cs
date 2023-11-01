using MediatR;
namespace HR.LeaveManagement.Application.Features.LeaveRequest
{
    public class GetLeaveRequestDetailQuery : IRequest<LeaveRequestDetailsDto>
    {
        public int Id { get; set; }
    }
}