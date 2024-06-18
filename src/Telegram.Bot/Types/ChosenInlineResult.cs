﻿namespace Telegram.Bot.Types;

/// <summary>
/// Represents a <see cref="InlineQueryResult">result</see> of an inline query that was chosen by the user and sent to their chat partner.<br/><b>Note:</b> It is necessary to enable <a href="https://core.telegram.org/bots/inline#collecting-feedback">inline feedback</a> via <a href="https://t.me/botfather">@BotFather</a> in order to receive these objects in updates.
/// </summary>
public partial class ChosenInlineResult
{
    /// <summary>
    /// The unique identifier for the result that was chosen
    /// </summary>
    [JsonRequired]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string ResultId { get; set; } = default!;

    /// <summary>
    /// The user that chose the result
    /// </summary>
    [JsonRequired]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public User From { get; set; } = default!;

    /// <summary>
    /// <em>Optional</em>. Sender location, only for bots that require user location
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Location? Location { get; set; }

    /// <summary>
    /// <em>Optional</em>. Identifier of the sent inline message. Available only if there is an <see cref="InlineKeyboardMarkup">inline keyboard</see> attached to the message. Will be also received in <see cref="CallbackQuery">callback queries</see> and can be used to <a href="https://core.telegram.org/bots/api#updating-messages">edit</a> the message.
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? InlineMessageId { get; set; }

    /// <summary>
    /// The query that was used to obtain the result
    /// </summary>
    [JsonRequired]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string Query { get; set; } = default!;
}
