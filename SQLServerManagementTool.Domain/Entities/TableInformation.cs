namespace SQLServerManagementTool.Domain.Entities;

public class TableInformation
{
    public string Schema { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public int ColumnCount { get; set; }

    public long RowCount { get; set; }
}