using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOrganizer
{

    public class DaySet
    {
        public DateTime Date;
        //always exactly nine elements
        public DayItem[] items;
        public DaySet(DateTime dat, DayItem[] newItems)
        {
            Date = dat;
            items = newItems;
        }

        public static DaySet emptyTodaySet()
        {
            DayItem[] emptyItems = new DayItem[9];
            for(int i = 0; i < 9; i++)
            {
                emptyItems[i] = new DayItem(null, i);
            }
            return new DaySet(DateTime.Today.Date, emptyItems);
        }

        public static DaySet SetFromString(string line)
        {
            string[] lines = line.Split("\t".ToCharArray());
            if (lines.Length < 10) return null;
            DateTime d = DateTime.ParseExact(lines[0].TrimStart("-".ToCharArray()), "d", null);
            DayItem[] nItems = new DayItem[9];
            for (int i = 1; i < 10; i++)
            {
                nItems[i - 1] = DayItem.ItemFromString(lines[i], i-1);
                if (nItems[i - 1] == null) return null;
            }
            return new DaySet(d, nItems);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-");
            sb.Append(Date.ToString("d"));
            sb.Append("\t");
            for (int i = 0; i < 9; i++)
            {
                sb.Append(items[i].ToString());
                sb.Append("\t");
            }
            return sb.ToString();
        }
    }

    public class Task
    {
        //if this is in the suggestions, it receives some unique identifier, otherwise just -1, currently unused
        public int identifier;
        public string name;
        public Color col;
        public Task(int ident, string n)
        {
            identifier = ident;
            name = n;
            col = Color.White;
        }

        public Task(int ident, string n, Color c)
        {
            identifier = ident;
            name = n;
            col = c;
        } 
        public override string ToString()
        {
            return name+ ":" + col.ToArgb().ToString();
        }
        public string GetName()
        {
            return name;
        }

        public string GetColString()
        {
            return col.ToArgb().ToString();
        }

        public override bool Equals(object obj)
        {
            return ((Task)obj).name == name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }

    public class DayItem
    {
        public Task task;
        public int index;
        public DayItem(Task tk, int ind)
        {
            task = tk;
            index = ind;
        }

        public string getName()
        {
            if (task == null) return "";
            else return task.name;
        }

        public Color GetColor()
        {
            if (task == null) return Color.FromArgb(32,32,32);
            else return task.col;
        }

        //returns null if the string wasn't formatted correctly
        internal static DayItem ItemFromString(string v)
        {
            Task t = null;
            string[] splitter = v.Split(":".ToCharArray());
            if (splitter.Length < 2) return null;
            int _index = int.Parse(splitter[0]);
            if (_index < 0 || _index > 8) return null;
            if (splitter[1] != "NULL")
            {
                t = Form1.suggestions.Find(x => x.name == splitter[1]);
                if (t == null)
                {
                    t = new Task(-1, splitter[1]);
                }
            }
            
            return new DayItem(t, _index);
        }

        internal static DayItem ItemFromString(string v, int i)
        {
            Task t = null;
            if (v != "NULL" && v.Trim() != "")
            {
                t = Form1.suggestions.Find(x => x.name == v);
                if (t == null)
                {
                    t = new Task(-1, v);
                }
            }

            return new DayItem(t, i);
        }

        public string ToIndexString()
        {
            if (task != null)
                return (index +":" + task.GetName());
            else return (index + ":" + "NULL");
        }

        public override string ToString()
        {
            if (task != null)
                return (task.GetName());
            else return ("NULL");
        }
    }
}
