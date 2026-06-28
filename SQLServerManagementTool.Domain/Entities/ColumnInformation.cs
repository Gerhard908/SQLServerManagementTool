namespace SQLServerManagementTool.Domain.Entities;

public class ColumnInformation
{
    public string Name { get; set; } = string.Empty;

    public string DataType { get; set; } = string.Empty;

    public bool IsNullable { get; set; }

    public bool IsPrimaryKey { get; set; }

    public bool IsIdentity { get; set; }

    public int MaxLength { get; set; }
}