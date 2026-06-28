namespace SQLServerManagementTool.Domain.Entities;

public class DatabaseInformation
{
    public string Name { get; set; } = string.Empty;

    public string Owner { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; }

    public long SizeInMb { get; set; }

    public string Status { get; set; } = string.Empty;
}