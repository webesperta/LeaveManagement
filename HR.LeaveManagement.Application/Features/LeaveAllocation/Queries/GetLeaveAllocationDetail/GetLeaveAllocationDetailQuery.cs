using MediatR;
namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetail
{
    public class GetLeaveAllocationDetailQuery : IRequest<LeaveAllocationDetailsDto>
    {
        public int Id { get; set; }
    }
}