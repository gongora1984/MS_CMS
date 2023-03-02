using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.ListItems;

namespace CMSSERVICE.APPLICATION.Persistence.ListItems.Queries;

/// <summary>
/// Get list of all List Items.
/// </summary>
internal sealed class GetAllListItemQueryHandler : IQueryHandler<GetAllListItemQuery, AllListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetAllListItemQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllListItemResponse>> Handle(GetAllListItemQuery request, CancellationToken cancellationToken)
    {
        var roles = await _listItemRepository.GetAllAsync();

        var rtn = _mapper.Map<AllListItemResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get list of all List Items by Id.
/// </summary>
internal sealed class GetListItemByIdQueryHandler : IQueryHandler<GetListItemByIdQuery, ListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetListItemByIdQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<Result<ListItemResponse>> Handle(GetListItemByIdQuery request, CancellationToken cancellationToken)
    {
        var roles = await _listItemRepository.GetByIdAsync(request.id);

        var rtn = _mapper.Map<ListItemResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get list of all List Items by Category.
/// </summary>
internal sealed class GetListItemByCategoryQueryHandler : IQueryHandler<GetListItemByCategoryQuery, AllListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetListItemByCategoryQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllListItemResponse>> Handle(GetListItemByCategoryQuery request, CancellationToken cancellationToken)
    {
        var roles = await _listItemRepository.GetBySystemCategoryAsync(request.category);

        var rtn = _mapper.Map<AllListItemResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get list of all List Items by Tag.
/// </summary>
internal sealed class GetListItemByTagQueryHandler : IQueryHandler<GetListItemByTagQuery, AllListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetListItemByTagQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllListItemResponse>> Handle(GetListItemByTagQuery request, CancellationToken cancellationToken)
    {
        var roles = await _listItemRepository.GetBySystemTagAsync(request.tag);

        var rtn = _mapper.Map<AllListItemResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get list of all List Items by Category/Tag.
/// </summary>
internal sealed class GetListItemBySystemCategoryTagQueryHandler : IQueryHandler<GetListItemBySystemCategoryTagQuery, AllListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetListItemBySystemCategoryTagQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllListItemResponse>> Handle(GetListItemBySystemCategoryTagQuery request, CancellationToken cancellationToken)
    {
        var roles = await _listItemRepository.GetBySystemCategoryTagAsync(request.category, request.tag);

        var rtn = _mapper.Map<AllListItemResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get list of all List Items by Category/Tag/Text.
/// </summary>
internal sealed class GetListItemBySystemCategoryTagDisplayTextQueryHandler : IQueryHandler<GetListItemBySystemCategoryTagDisplayTextQuery, ListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetListItemBySystemCategoryTagDisplayTextQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<Result<ListItemResponse>> Handle(GetListItemBySystemCategoryTagDisplayTextQuery request, CancellationToken cancellationToken)
    {
        var roles = await _listItemRepository.GetBySystemCategoryTagDisplayTextAsync(request.category, request.tag, request.displayText);

        var rtn = _mapper.Map<ListItemResponse>(roles);

        return rtn;
    }
}
