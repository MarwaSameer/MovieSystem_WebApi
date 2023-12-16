using AutoMapper;
using MediatR;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Rates.Commands.Models;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.Rates.Commands.Handlers
{
    public class RateCommandHandler : ResponseHandler, IRequestHandler<AddRateCommand, Response<string>>,
         IRequestHandler<UpdateRateCommand, Response<Rate>>,
        IRequestHandler<DeleteRateCommand, Response<string>>
    {
        private IRateService _rateService;
        private IMapper _mapper;

        public RateCommandHandler(IRateService Service, IMapper mapper)
        {
            _rateService = Service;
            _mapper = mapper;
        }
        public async Task<Response<string>> Handle(AddRateCommand request, CancellationToken cancellationToken)
        {

            var rate = _mapper.Map<Rate>(request);
            var result = await _rateService.AddRateAsync(rate);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Created(""); }

        }
        public async Task<Response<Rate>> Handle(UpdateRateCommand request, CancellationToken cancellationToken)
        {
            var rate = _mapper.Map<Rate>(request);
            var result = await _rateService.UpdateRateAsync(rate);
            if (result == null) { return BadRequest<Rate>(""); }
            else { return Success<Rate>(result); }

        }
        public async Task<Response<string>> Handle(DeleteRateCommand request, CancellationToken cancellationToken)
        {

            var result = await _rateService.DeleteRateAsync(request.RateId);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Deleted<string>(result); }



        }
    }
}
