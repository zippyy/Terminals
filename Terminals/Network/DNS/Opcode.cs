namespace Terminals.Network.DNS
{
    /// <summary>
    ///     (RFC1035 4.1.1) These are the Query Types which apply to all questions in a request
    /// </summary>
    public enum Opcode
    {
        StandardQuery = 0,
        InverseQuerty = 1,
        StatusRequest = 2,
        Reserverd3 = 3,
        Reserverd4 = 4,
        Reserverd5 = 5,
        Reserverd6 = 6,
        Reserverd7 = 7,
        Reserverd8 = 8,
        Reserverd9 = 9,
        Reserverd10 = 10,
        Reserverd11 = 11,
        Reserverd12 = 12,
        Reserverd13 = 13,
        Reserverd14 = 14,
        Reserverd15 = 15,
    }
}