
using AutoMapper;
using MediatR;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Feature.UserSubsss.Commands.Models;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.UserSubsss.Commands.Handlers
{
    public class UserSubscriptionCommandHandler : IRequestHandler<AddUserSubscriptionCommand, string>,
         IRequestHandler<UpdateUserSubscriptionCommand, UserSubscription>,
        IRequestHandler<DeleteUserSubscriptionCommand, string>
    {
        private IUserSubscriptionSevice _userSubscriptionSevice;
        private IMapper _mapper;

        public UserSubscriptionCommandHandler(IUserSubscriptionSevice Service, IMapper mapper)
        {
            _userSubscriptionSevice = Service;
            _mapper = mapper;
        }
        public async Task<string> Handle(AddUserSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var SubscriptionPlan = _mapper.Map<UserSubscription>(request);


            return await _userSubscriptionSevice.AddUserSubscriptionsAsync(SubscriptionPlan);

        }
        public async Task<UserSubscription> Handle(UpdateUserSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var SubscriptionPlan = _mapper.Map<UserSubscription>(request);


            return await _userSubscriptionSevice.UpdateUserSubscriptionsAsync(SubscriptionPlan);

        }
        public async Task<string> Handle(DeleteUserSubscriptionCommand request, CancellationToken cancellationToken)
        {



            return await _userSubscriptionSevice.DeleteUserSubscriptionsAsync(request.Id);

        }
    }
}
