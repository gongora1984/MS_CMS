using CMSSERVICE.APPLICATION.Persistence.ListItems.Commands;
using CMSSERVICE.APPLICATION.Persistence.ListItems.Queries;
using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.ListItems;
using CMSSERVICE.INFRASTRUCTURE.Authentication;
using CMSSERVICE.PRESENTATION.Abstractions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace CMSSERVICE.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/ListItem")]
public sealed class ListItemController : ApiController
{
    public ListItemController(ISender sender)
        : base(sender)
    {
    }

    [HttpPost("CreateListItem", Name = "Create List Item")]
    [ProducesResponseType(typeof(ListItemResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HasPermission("Admin")]
    public async Task<IActionResult> CreateListItem(
    [FromBody] ListItemRequest request,
    CancellationToken cancellationToken)
    {
        var command = new RegisterListItemCommand(request);

        Result<ListItemResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllListItem", Name = "All List Items")]
    [ProducesResponseType(typeof(AllListItemResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllListItem(CancellationToken cancellationToken)
    {
        var command = new GetAllListItemQuery();

        Result<AllListItemResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("ListItemById", Name = "List Item By Id")]
    [ProducesResponseType(typeof(ListItemResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListItemById(int id, CancellationToken cancellationToken)
    {
        var command = new GetListItemByIdQuery(id);

        Result<ListItemResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("ListItemByCategory", Name = "List Item By Category")]
    [ProducesResponseType(typeof(AllListItemResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListItemByCategory(string category, CancellationToken cancellationToken)
    {
        var command = new GetListItemByCategoryQuery(category);

        Result<AllListItemResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("ListItemByTag", Name = "List Item By Tag")]
    [ProducesResponseType(typeof(AllListItemResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListItemByTag(string tag, CancellationToken cancellationToken)
    {
        var command = new GetListItemByTagQuery(tag);

        Result<AllListItemResponse> response = await Sender.Send(command, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [AllowAnonymous]
    [HttpGet("ListItemByCategoryTag", Name = "Get List Item By System Category Tag")]
    [ProducesResponseType(typeof(AllListItemResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListItemBySystemCategoryTag(string category, string tag, CancellationToken cancellationToken)
    {
        var command = new GetListItemBySystemCategoryTagQuery(category, tag);

        Result<AllListItemResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("ListItemByCategoryTagText", Name = "Get List Item By Category Tag Text")]
    [ProducesResponseType(typeof(ListItemResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListItemBySystemCategoryTagDisplayText(string category, string tag, string displaytext, CancellationToken cancellationToken)
    {
        var command = new GetListItemBySystemCategoryTagDisplayTextQuery(category, tag, displaytext);

        Result<ListItemResponse> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }
}
