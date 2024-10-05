using MediatR;
using Ordering.Domain.Common;

namespace Ordering.Api.Commands
{
    public record CreateOrderDraftCommand() : IRequest<bool>;

    public class CreateOrderDraftCommandHandler : IRequestHandler<CreateOrderDraftCommand, bool>
    {
        private IUnitOfWork _unitOfWork;
        private ILogger<CreateOrderDraftCommandHandler> _logger;

        public CreateOrderDraftCommandHandler(ILogger<CreateOrderDraftCommandHandler> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateOrderDraftCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
