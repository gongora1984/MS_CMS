using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.ListItems;

namespace CMSSERVICE.APPLICATION.Persistence.ListItems.Commands;

internal sealed class RegisterListItemCommandHandler : ICommandHandler<RegisterListItemCommand, ListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterListItemCommandHandler(IListItemRepository listItemRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<ListItemResponse>> Handle(RegisterListItemCommand request, CancellationToken cancellationToken)
    {
        if (!await _listItemRepository.IsNameUniqueAsync(request.li.SystemCategory, request.li.SystemTag, request.li.DisplayText, cancellationToken))
        {
            return Result.Failure<ListItemResponse>(ListItemError.SystemCategoryTagDisplayInUse);
        }

        try
        {
            var newLi = _mapper.Map<ListItem>(request.li);

            if (newLi.ClientId == 0)
            {
                newLi.ClientId = null;
            }

            if (newLi.LawPracticeId == 0)
            {
                newLi.LawPracticeId = null;
            }

            _listItemRepository.AddListItem(newLi);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ListItemResponse>(newLi);
        }
        catch (Exception ex)
        {
            return Result.Failure<ListItemResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
