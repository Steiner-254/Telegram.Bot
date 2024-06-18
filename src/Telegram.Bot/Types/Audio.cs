﻿namespace Telegram.Bot.Types;

/// <summary>
/// This object represents an audio file to be treated as music by the Telegram clients.
/// </summary>
public partial class Audio : FileBase
{
    /// <summary>
    /// Duration of the audio in seconds as defined by sender
    /// </summary>
    [JsonRequired]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public int Duration { get; set; }

    /// <summary>
    /// <em>Optional</em>. Performer of the audio as defined by sender or by audio tags
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Performer { get; set; }

    /// <summary>
    /// <em>Optional</em>. Title of the audio as defined by sender or by audio tags
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Title { get; set; }

    /// <summary>
    /// <em>Optional</em>. Original filename as defined by sender
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FileName { get; set; }

    /// <summary>
    /// <em>Optional</em>. MIME type of the file as defined by sender
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MimeType { get; set; }

    /// <summary>
    /// <em>Optional</em>. Thumbnail of the album cover to which the music file belongs
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PhotoSize? Thumbnail { get; set; }
}
