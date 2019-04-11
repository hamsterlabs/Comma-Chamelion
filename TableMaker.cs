namespace CommaChamelion
{
using System;
    using System.Collections.Generic;
    using System.Text;


public class TableMaker
{
    private List<ColumnDef> fields;
    public string tableName { get; set; }
    public bool Active { get; set; }
    
    public TableMaker()
    {
        this.Active = false;
        this.tableName = "newTable";
        init();
    }
    
    private void init()
    {
        fields = new List<ColumnDef>();
        fields.Add(item: new ColumnDef() { name = "CreatedOn", type = "DateTime2", nully = "NULL" });
        fields.Add(item: new ColumnDef() { name = "CreatedBy", type = "nvarchar", size = 32, nully = "NULL" });
        fields.Add(item: new ColumnDef() { name = "EditedOn", type = "DateTime2", nully = "NULL" });
        fields.Add(item: new ColumnDef() { name = "EditedBy", type = "nvarchar", size = 32, nully = "NULL" });
        fields.Add(item: new ColumnDef() { name = "DeletedOn", type = "DateTime2", nully = "NULL" });
        fields.Add(item: new ColumnDef() { name = "DeletedBy", type = "nvarchar", size = 32, nully = "NULL" });
    }

    public TableMaker(string tablename)
    {
        this.Active = false;
        this.tableName = tablename;
        init();
    }

    public override string ToString()
    {
        StringBuilder b = new StringBuilder(String.Format("create table [{0}] (" + Environment.NewLine, this.tableName));

        if (this.tableName.StartsWith("cfg"))
        {
            ColumnDef key = new ColumnDef() { name = "ID", type = "int", nully = "IDENTITY(1,1) PRIMARY KEY" };
            this.fields.Insert(0, key);
        }
        else if (this.tableName.StartsWith("lst"))
        {
            ColumnDef name = new ColumnDef(){name = "Name", type = "nvarchar", size = 50, nully = "NOT NULL" };
            this.fields.Insert(0, name);            
            ColumnDef code = new ColumnDef(){name = "Code", type = "nvarchar", size = 16, nully = "NULL" };
            this.fields.Insert(0, code);
            ColumnDef key = new ColumnDef() { name = "ID", type = "int", nully = "IDENTITY(1,1) PRIMARY KEY" };
            this.fields.Insert(0, key);
        }
        else
        {
            ColumnDef key = new ColumnDef() { name = this.tableName + "Pk", type = "int", nully = "IDENTITY(1,1) PRIMARY KEY" };
            this.fields.Insert(0, key);
        }

        if (this.Active)
        {
            ColumnDef active = new ColumnDef() { name = "Active", type = "bit", nully = "NULL" };
            this.fields.Insert(1, active);
        }

        foreach (ColumnDef a in fields)
        {
            b.AppendLine(a.ToString() + ",");
        }
        b.AppendLine(");");
        return b.ToString();
    }
}

    public class ColumnDef
    {
        public string name { get; set; }
        public string type { get; set; }
        public int size { get; set; }
        public string nully { get; set; }

        public override string ToString()
        {
            string def = String.Empty;
            switch (type.ToLower())
            {
                case "varchar":
                case "nvarchar":
                    def = $"    [{name}] {type}({size}) {nully}";
                    break;
                default:
                    def = $"    [{name}] {type} {nully}";
                    break;
            }
            return def;
        }
    }

}