﻿using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public DeletePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetByIdAsync(request.PostId);
            await _postRepository.DeleteAsync(post);
            return Unit.Value;
        }
    }
}
