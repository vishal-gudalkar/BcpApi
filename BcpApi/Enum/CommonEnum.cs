namespace Bcp.Api.Enum
{
    public enum StockChangesEnum : int
    {
        Bin = 1,
        Status = 2,
        Storage = 3
    }

    public enum ResultEnum : int
    {
        Success = 1,
        NotFound = 2,
        NoAction=3,
        Error = 4
    }
}
