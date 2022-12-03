using Telegram.Bot.Types.Enums;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Types;

/// <summary>
/// Represents a photo to be sent
/// </summary>
public class InputMediaPhoto :
    InputMedia,
    IAlbumInputMedia
{
    /// <inheritdoc />
    [JsonProperty(Required = Required.Always)]
    public override InputMediaType Type => InputMediaType.Photo;

    /// <summary>
    /// Initializes a new photo media to send with an <see cref="IInputFile"/>
    /// </summary>
    /// <param name="media">File to send</param>
    public InputMediaPhoto(IInputFile media)
        : base(media)
    { }
}