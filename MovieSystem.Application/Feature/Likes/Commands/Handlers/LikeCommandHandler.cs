using AutoMapper;
using MediatR;
using MoviesSystem.Domain.Entities;
using MovieSystem.Application.Bases;
using MovieSystem.Application.Feature.Categories.Commands.Models;
using MovieSystem.Application.Feature.Likes.Commands.Models;
using MovieSystem.Application.IServices;

namespace MovieSystem.Application.Feature.Likes.Commands.Handlers
{
    public class LikeCommandHandler : ResponseHandler, IRequestHandler<AddLikeCommand, Response<string>>,
                                      IRequestHandler<UpdateLikeCommand, Response<Like>>,
                                      IRequestHandler<DeleteLikeCommand, Response<string>>
    {
        #region CTOR
        private ILikeService _likeService;
        private IMapper _mapper;

        public LikeCommandHandler(ILikeService likeService, IMapper mapper)
        {
            _likeService = likeService;
            _mapper = mapper;
        }
        #endregion
        public async Task<Response<string>> Handle(AddLikeCommand request, CancellationToken cancellationToken)
        {
            var like = _mapper.Map<Like>(request);

            var result = await _likeService.AddLikeAsync(like);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Created(""); }

        }
        public async Task<Response<Like>> Handle(UpdateLikeCommand request, CancellationToken cancellationToken)
        {
            var like = _mapper.Map<Like>(request);
            var result = await _likeService.UpdateLikeAsync(like);
            if (result == null) { return BadRequest<Like>(""); }
            else { return Success<Like>(result); }

        }
        public async Task<Response<string>> Handle(DeleteLikeCommand request, CancellationToken cancellationToken)
        {
            var result = await _likeService.DeleteLikeAsync(request.LikeId);
            if (result != "success") { return BadRequest<string>(""); }
            else { return Deleted<string>(result); }


        }
    }
}
