namespace CommaChamelion
{
using System;
using System.Text;
public class SQLObjectDropper
{
    public SQLObjectDropper() {; }

    public string DropProcs(string[] procs)
    {
        StringBuilder b = new StringBuilder();
        foreach (string p in procs)
        {
            b.AppendLine(String.Format(ProcDropper, p));
            b.AppendLine();
        }
        return b.ToString();
    }

    public string DropTables(string[] obs)
    {
        StringBuilder b = new StringBuilder();
        foreach (string table in obs)
        {
            b.AppendLine(String.Format(TableDropper, table ));
            b.AppendLine();
        }
        return b.ToString();
    }

    public string DropFunctions(string[] fns)
    {
        StringBuilder b = new StringBuilder();
        foreach (string f in fns)
        {
            b.AppendLine(String.Format(TableDropper, f));
            b.AppendLine();
        }
        return b.ToString();
    }
    
    public string DropViews( string dropsql, string [] objects)
    {
        return Drop(dropsql, objects);
    }
    
    public string Drop( string dropper, string [] obs)
    {
        StringBuilder b = new StringBuilder();
        foreach (string f in obs)
        {
            b.AppendLine(String.Format(dropper, f));
            b.AppendLine();
        }
        return b.ToString();
    }

    public string View
    {
        get
        {
            return ViewDropper;
        }
    }
    
    public string Procedure
    {
        get
        {
            return ProcDropper;
        }
    }
    
    public string Table 
    {
        get
        {
            return TableDropper;
        }
    }
    
    
    private const string ViewDropper = @"IF EXISTS (SELECT * FROM sys.views WHERE name LIKE 'vwSurveyProgressCurrentYear' AND type IN (N'V'))
    DROP VIEW [dbo].[{0}]
    GO";

    private const string ProcDropper = @"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{0}]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[{0}]
GO";

    private const string TableDropper = @"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{0}]') AND type in (N'U'))
	DROP TABLE {0}
GO";
    private const string UDFDropper = @"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{0}]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[{0}]
GO";
}
}