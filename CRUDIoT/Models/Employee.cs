// C# record type for items in the table

using Azure;
using System;
using Azure.Data.Tables;
public record Product : ITableEntity
{
    public string RowKey { get; set; } = default!;
    public string PartitionKey { get; set; } = default!;
    public string EmployeeName { get; init; } = default!;
    public int EmployeeID { get; init; }
    public bool Permanent { get; init; }
    public Azure.ETag ETag { get; set; } = default!;
    public System.DateTimeOffset? Timestamp { get; set; } = default!;
}