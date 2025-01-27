using JetBrains.Annotations;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Polling;

/// <summary>
/// Options to configure getUpdates requests
/// </summary>
[PublicAPI]
public sealed class ReceiverOptions
{
    int? _limit = 100;

    /// <summary>
    /// Identifier of the first update to be returned. Will be ignored if
    /// <see cref="DropPendingUpdates"/> is set to <see langword="true"/>.
    /// </summary>
    public int? Offset { get; set; }

    /// <summary>
    /// Indicates which <see cref="UpdateType"/>s are allowed to be received.
    /// In case of <c>null</c> the previous setting will be used
    /// </summary>
    public UpdateType[]? AllowedUpdates { get; set; }

    /// <summary>
    /// Limits the number of updates to be retrieved. Values between 1-100 are accepted.
    /// Defaults to 100 when is set to <c>null</c>.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the value doesn't satisfies constraints
    /// </exception>
    public int? Limit
    {
        get => _limit;
        set
        {
            if (value is < 1 or > 100)
            {
                throw new ArgumentOutOfRangeException(
                    paramName: nameof(value),
                    actualValue: value,
                    message: $"'{nameof(Limit)}' can not be less than 1 or greater than 100"
                );
            }
            _limit = value;
        }
    }

    /// <summary>
    /// Indicates if all pending <see cref="Update"/>s should be thrown out before start
    /// polling. If set to <see langword="true"/> <see cref="AllowedUpdates"/> should be set to not
    /// <c>null</c>, otherwise <see cref="AllowedUpdates"/> will effectively be set to
    /// receive all <see cref="Update"/>s.
    /// </summary>
    [Obsolete($"This property will be removed in future updates, use {nameof(DropPendingUpdates)} instead")]
    public bool ThrowPendingUpdates { get => DropPendingUpdates; set => DropPendingUpdates = value; }

    /// <summary>
    /// Indicates if all pending <see cref="Update"/>s should be thrown out before start
    /// polling. If set to <see langword="true"/> <see cref="AllowedUpdates"/> should be set to not
    /// <c>null</c>, otherwise <see cref="AllowedUpdates"/> will effectively be set to
    /// receive all <see cref="Update"/>s.
    /// </summary>
    public bool DropPendingUpdates { get; set; }
}
