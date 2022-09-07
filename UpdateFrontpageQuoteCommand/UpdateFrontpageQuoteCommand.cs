using Dynamicweb.CoreUI.Data;

namespace Dynamicweb.VSUpdateFrontpageQuote;

public sealed class UpdateFrontpageQuoteCommand : CommandBase
{
    public string Message {get; set;}
    public override CommandResult Handle()
    {
        var paragraph = Services.Paragraphs.GetParagraph(9169);
        paragraph.Item["Quote"] = $"<p>{Message}</p>";
        paragraph.Item.Save();
        return new()
        {
            Status = CommandResult.ResultType.Ok,
            Message = "UpdateFrontpageQuoteCommand successfully run!",
        };
    }
}
