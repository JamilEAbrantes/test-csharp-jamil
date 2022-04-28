using MediatR;
using System.Collections.Generic;

namespace Candidate.Application.Candidate.Query.GetAllCandidates
{
    public class GetAllCandidatesQuery : IRequest<IEnumerable<GetAllCandidatesViewModel>>
    {
    }
}
