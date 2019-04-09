using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommaChamelion
{
    public partial class Form1 : Form
    {
        private Boolean IS_QUOTED = false;
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Point p = ScaleContainer(new System.Drawing.Point(700, 600));
            this.Width = p.X + 20;
            this.Height = p.Y + 50;
            // string bean = this.textBox.Text;
            // this.textBox.Text = bean + String.Format("Form Size ({0}, {1})", this.Width, this.Height);
        }

    private string ControlSize(System.Windows.Forms.Control x)
    {
        return String.Format("{0} Location: ({1}, {2}), Size ({3}, {4})", x.Name, x.Location.X, x.Location.Y, x.Size.Width, x.Size.Height);
    }
    private System.Drawing.Point ScaleContainer(System.Drawing.Point maxSize)
    {
        int max_x = 0;
        int heights = 0;
        int max_y = 0;
        int width = 0;
        // StringBuilder b = new StringBuilder();
        foreach (Control c in this.Controls)
        {
            // b.Append(ControlSize(c));
            // b.AppendLine();
            int loc_x = c.Location.X;
            if (loc_x > max_x)
            {
                max_x = loc_x;
                width = c.Width;
            }

            // find bottom-most control
            int loc_y = c.Location.Y;
            if (loc_y > max_y)
            {
                max_y = loc_y;
                heights = c.Height;
            }
        }
        System.Drawing.Point box = new System.Drawing.Point(max_x + width, max_y + heights);
        // textBox.Text = b.ToString();
        //		Console.WriteLine( "Control Name: {0}  Text: {1}  Location ({2},{3}), Size ({4},{5})", "box", "Form", 0, 0, box.X, box.Y);
        return box;
    }
    
    private void btnCopy_Click(object sender, EventArgs e)
    {
        if ( outBox.Text.Trim().Length > 0)
        {
            Clipboard.SetText(outBox.Text.Trim());
        }
    }
    private void btnClear_Click(object sender, EventArgs e)
    {
        textBox.Text = String.Empty;
        outBox.Text = String.Empty;
    }
    private void btnSort_Click(object sender, EventArgs e)
    {
        string[] s = { Environment.NewLine };
        if (!String.IsNullOrWhiteSpace(textBox.Text.Trim()))
        {
                List<String> lst = new List<string>();
                lst.AddRange(textBox.Text.Split(s, StringSplitOptions.RemoveEmptyEntries));
                lst.Sort();
                outBox.Text = String.Join(Environment.NewLine, lst.ToArray());
                //Clipboard.SetText(String.Join(Environment.NewLine, lst.ToArray()));
                //Console.WriteLine("Result copied to clipboard");
        }
    }

    private void btnComma_Click(object sender, EventArgs e)
    {
            if ( !String.IsNullOrWhiteSpace( textBox.Text.Trim() ))
            {
                string[] s = { Environment.NewLine };
                List<string> list = new List<string>();
                list.AddRange( textBox.Text.Split(s, StringSplitOptions.RemoveEmptyEntries) );
                
                if ( IS_QUOTED )
                {
                    for(int i = 0; i < list.Count; i++ )
                        list[i] = "\"" + list[i].Trim() + "\"";
                }
                // string x = string.Join(",", list);
                outBox.Text = string.Join(",", list);
                //Clipboard.SetText(x);
                //Console.WriteLine("Result copied to clipboard");
            }
    }
    private void cbDelimiter_CheckChanged(object sender, EventArgs e)
    {
        this.IS_QUOTED = cbDelimiter.Checked;         
    }

    private void btnTableMaker_Click(object sender, EventArgs e)
    {
        string[] s = { Environment.NewLine };
        string [] p = textBox.Text.Split(s, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder b = new StringBuilder();
        for(int i = 0; i< p.Length; i++)
        {
            TableMaker t = new TableMaker(p[i]);
            b.AppendLine(t.ToString());
        }
        outBox.Text = b.ToString();
    }

    private void todo()
    {
            string[] s = { Environment.NewLine };
            string[] prx = textBox.Text.Split(s, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < prx.Length; i++)
            {
                prx[i] = "[ ] " + prx[i];
            }
            string x = string.Join(Environment.NewLine, prx);
            outBox.Text = x;
            //Clipboard.SetText(x);
            //Console.WriteLine("Result copied to clipboard");
    }

    private void btnProcDrop_Click(object sender, EventArgs e)
    {
            string[] s = { Environment.NewLine };
            string [] prx = textBox.Text.Split(s,StringSplitOptions.RemoveEmptyEntries);
            
            SQLObjectDropper o = new SQLObjectDropper();
            outBox.Text = o.DropProcs(prx);
            //Clipboard.SetText(outBox.Text);
            //Console.WriteLine("Result copied to clipboard");        
    }

    private void btnTableDrop_Click(object sender, EventArgs e)
    {
             string[] s = { Environment.NewLine };
             string[] tables = textBox.Text.Split(s, StringSplitOptions.RemoveEmptyEntries);

             SQLObjectDropper o = new SQLObjectDropper();
             outBox.Text = o.DropTables(tables);
             //Clipboard.SetText(textBox.Text);
             //Console.WriteLine("Result copied to clipboard");        
    }

private void btnViewDrop_Click(object sender, EventArgs e)
{
             string[] s = { Environment.NewLine };
             string[] views = textBox.Text.Split(s, StringSplitOptions.RemoveEmptyEntries);
             SQLObjectDropper o = new SQLObjectDropper();
             outBox.Text = o.DropViews(o.View, views);
             //Clipboard.SetText(textBox.Text);
             //Console.WriteLine("Result copied to clipboard");
}
///
/// To Do: get the user ID or name from somewhere
private void btnSQLVanity_Click(object sender, EventArgs e)
{
            string commentChar = "--";
            string[] s = { Environment.NewLine };
            List<string> lines = new List<string>();
            lines.AddRange(textBox.Text.Split(s, StringSplitOptions.RemoveEmptyEntries));
            string thing = lines[0];
            lines.RemoveAt(0);
            string description = String.Empty;
            if ( lines.Count > 0 )
                description = String.Join(Environment.NewLine + commentChar, lines.ToArray());
            
            string v = @"{0} =============================================
{0}   Object Name: {1}
{0}    Parameters:
{0} PreRequisites: 
{0}       Author : {2}
{0}  Created Date: {3}
{0} Updated Date : {3}
{0}   Description: {4}
{0}         USAGE:
{0}             EXEC {1}
{0} =============================================";
            string x = String.Format(v, commentChar, thing, String.Empty, DateTime.Now, description);
            outBox.Text = x;
            //Clipboard.SetText(textBox.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
