using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using System.Windows;
using System.IO;

namespace DayOrganizer
{
    public partial class Form1 : Form
    {
        private Label mostRecentBox;
        private Dictionary<Label, Task> map = new Dictionary<Label, Task>();
        private List<Label> boxes = new List<Label>();
        private Label[] timeLabels = new Label[9];
        private bool dirtyFlag = false;
        private Color currentCol = Color.White;
        public List<DaySet> sets = new List<DaySet>();
        private int currentlyShownSet;
        public static List<Task> suggestions = new List<Task>();
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };
        private bool _Moving = false;
        private Point _Offset;
        private Hotkeys.GlobalHotkey ghk;
        public bool startWriting = false;
        private bool isVisible = true;

        private Color lightFont = Color.White;
        private Color darkFont = Color.Black;

        private bool dragStart = false;
        private Point dragPos;

        public Form1()
        {
            InitializeComponent();
            ghk = new Hotkeys.GlobalHotkey(Hotkeys.Constants.SHIFT + Hotkeys.Constants.CTRL, Keys.X, this);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void HandleHotkey()
        {
            if (isVisible)
            {
                this.Hide();
                WriteListsToFile();
            }
            else
            {
                if (!ContainsToday())
                {
                    sets.Insert(0, DaySet.emptyTodaySet());
                    DisplaySet(sets[0]);
                }
                this.Show();
                this.Refresh();
            }
            isVisible = !isVisible;
        }

        bool ContainsToday()
        {
            if(sets[0].Date < DateTime.Today)
            {
                return false;
            }
            return true;
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult res = FileBrowser.ShowDialog();
            if (res == DialogResult.OK)
            {
                FileName.Text = FileBrowser.FileName;
                LoadListFromFile(FileName.Text);
            }
        }

        private void LoadListFromFile(string fileName)
        {
            ColorPicker.BackColor = currentCol;
            currentlyShownSet = 0;
            dirtyFlag = false;
            if (System.IO.File.Exists(fileName))
            {
                Properties.Settings.Default.GoalPath = fileName;
                Properties.Settings.Default.Save();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                int skipped = 0;
                bool hasToday = false;
                int current = 0;
                bool suggested = true;
                string[] split;
                string line;
                int todaySet = 0;
                for (int u = 0; u < lines.Length; u++)
                {
                    line = lines[u];
                    if (suggested)
                    {
                        skipped++;
                        current++;
                        if (line.StartsWith("--Suggestions--")) continue;
                        if (line == "--Day Plans--") suggested = false;
                        else
                        {
                            split = line.Split(":".ToCharArray());
                            suggestions.Add(new Task(skipped, split[0], Color.FromArgb(Convert.ToInt32(split[1]))));
                        }
                        continue;
                    }
                    else
                    {
                        if (line.StartsWith("-"))
                        {
                            DaySet ds = DaySet.SetFromString(line);
                            if (ds != null) sets.Add(ds);
                            if (ds.Date == DateTime.Now.Date) { skipped++; hasToday = true; todaySet = sets.Count - 1; }
                            current++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong format! \n");
                        }
                    }
                }

                if (hasToday)
                {
                    currentlyShownSet = todaySet;
                    DisplaySet(sets[todaySet]);
                }
                else
                {
                    sets.Insert(0, DaySet.emptyTodaySet());
                    DisplaySet(sets[0]);
                }
                DisplaySuggestions();

            }
        }

        /*

         */
        private void WriteListsToFile()
        {
            if (dirtyFlag)
            {
                if (System.IO.File.Exists(FileName.Text) || MessageBox.Show("This will create a new file, " + FileName.Text + ".", "Create New File", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    List<string> lines = new List<string>();
                    lines.Add("--Suggestions--");
                    foreach (Task t in suggestions)
                    {
                        lines.Add(t.ToString());
                    }
                    lines.Add("--Day Plans--");

                    for (int i = 0; i < sets.Count; i++)
                    {
                        lines.Add(sets[i].ToString());
                    }
                    System.IO.File.WriteAllLines(FileName.Text, lines);
                    Properties.Settings.Default.GoalPath = FileName.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    FileName.Text = Properties.Settings.Default.GoalPath;
                    WriteListsToFile();
                }
                dirtyFlag = false;
            }
        }

        void DisplaySuggestions()
        {
            TaskPanel.Controls.Clear();
            int i = 0;
            foreach (Task t in suggestions)
            {
                Label b = new Label();
                boxes.Add(b);
                map.Add(b, t);
                b.MouseClick += SelectBox;
                b.MouseDown += SuggestionDrag;
                b.MouseMove += Box_MouseMove;
                //b.ReadOnly = true;
                //b.Multiline = true;
                b.AutoSize = false;
                b.Text = t.name;
                b.BackColor = t.col;
                b.ForeColor = b.BackColor.GetBrightness() < 0.5f ? lightFont : darkFont;
                b.AutoSize = false;
                b.Size = new Size(100, 50);
                
                b.Parent = TaskPanel;
                b.Visible = true;
                //evtl position setzen
                b.Location = new Point((i % (TaskPanel.Width / 120)) * 120, (i / (TaskPanel.Width / 120)) * 70);
                i++;
            }
        }

        void AddSuggestion(Task t)
        {
            dirtyFlag = true;
            Label b = new Label();
            boxes.Add(b);
            map.Add(b, t);
            b.MouseClick += SelectBox;
            b.MouseDown += SuggestionDrag;
            b.MouseMove += Box_MouseMove;
            //b.ReadOnly = true;
            //b.Multiline = true;
            b.AutoSize = false;
            b.Text = t.name;
            b.BackColor = t.col;
            b.ForeColor = b.BackColor.GetBrightness() < 0.5f ? lightFont : darkFont;
            b.AutoSize = false;
            b.Size = new Size(100, 50);
            b.Parent = TaskPanel;
            b.Location = new Point(((suggestions.Count - 1) % (TaskPanel.Width / 120)) * 120, ((suggestions.Count - 1) / (TaskPanel.Width / 120)) * 70);
            b.Visible = true;

        }

        void RemSuggestion(Label t)
        {
            dirtyFlag = true;
            TaskPanel.Controls.Remove(t);
            boxes.Remove(t);
            map.Remove(t);
            suggestions.Remove(new Task(-1, t.Text));
        }

        void UpdateDisplay(List<Label> Labeles, Task t)
        {
            int i = 0;
            foreach (Label b in Labeles)
            {
                if (b.Text == t.GetName())
                {
                    b.BackColor = t.col;
                    b.ForeColor = b.BackColor.GetBrightness() < 0.5f ? lightFont : darkFont;
                }
                b.Location = new Point((i % (TaskPanel.Width / 120)) * 120, (i / (TaskPanel.Width / 120)) * 70);
                i++;
            }
            DisplaySet(sets[currentlyShownSet]);
        }

        void UpdateDisplay(List<Label> Labeles)
        {
            int i = 0;
            foreach (Label b in Labeles)
            {
                b.Location = new Point((i % (TaskPanel.Width / 120)) * 120, (i / (TaskPanel.Width / 120)) * 70);
                i++;
            }
        }

        void UpdateTexts(List<Label> Labeles)
        {
            int i = 0;
            Task t;
            foreach (Label b in Labeles)
            {
                if (map.TryGetValue(b, out t))
                    b.Text = t.name;
                b.Location = new Point((i % (TaskPanel.Width / 120)) * 120, (i / (TaskPanel.Width / 120)) * 70);
                i++;
            }
            DisplaySet(sets[currentlyShownSet]);
        }

        void DisplaySet(DaySet ds)
        {
            dateLabel.Text = ds.Date.GetDateTimeFormats('d')[0];
            for(int i = 0; i < 9; i++)
            {
                timeLabels[i].Text = ds.items[i].getName();
                timeLabels[i].BackColor = ds.items[i].GetColor();
                timeLabels[i].ForeColor = timeLabels[i].BackColor.GetBrightness() < 0.5f ? lightFont : darkFont;
            }
            /*time8.Text = ds.items[0].getName();
            time10.Text = ds.items[1].getName();
            time12.Text = ds.items[2].getName();
            time14.Text = ds.items[3].getName();
            time16.Text = ds.items[4].getName();
            time18.Text = ds.items[5].getName();
            time20.Text = ds.items[6].getName();
            time22.Text = ds.items[7].getName();
            time0.Text = ds.items[8].getName();
            time8.BackColor = ds.items[0].GetColor();
            time10.BackColor = ds.items[1].GetColor();
            time12.BackColor = ds.items[2].GetColor();
            time14.BackColor = ds.items[3].GetColor();
            time16.BackColor = ds.items[4].GetColor();
            time18.BackColor = ds.items[5].GetColor();
            time20.BackColor = ds.items[6].GetColor();
            time22.BackColor = ds.items[7].GetColor();
            time0.BackColor = ds.items[8].GetColor();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLabels[0] = time8;
            timeLabels[1] = time10;
            timeLabels[2] = time12;
            timeLabels[3] = time14;
            timeLabels[4] = time16;
            timeLabels[5] = time18;
            timeLabels[6] = time20;
            timeLabels[7] = time22;
            timeLabels[8] = time0;
            FileName.Text = Properties.Settings.Default.GoalPath;
            LoadListFromFile(FileName.Text);
            ghk.Register();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ghk.Unregiser();
            WriteListsToFile();
        }


        private void AddSuggest_Click(object sender, EventArgs e)
        {
            string f = Prompt.ShowDialog("Enter new task", "");
            if (f != "")
            {
                Task n = new Task(suggestions.Count, f, currentCol);
                if (!suggestions.Contains(n))
                {
                    suggestions.Add(n);
                    AddSuggestion(n);
                }
            }
        }

        private void RemSuggest_Click(object sender, EventArgs e)
        {
            if (mostRecentBox != null)
            {
                var result = MessageBox.Show("Do you really want to remove " + mostRecentBox.Text + "?", "Removing Task", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RemSuggestion(mostRecentBox);
                    UpdateDisplay(boxes);
                }
            }
        }

        private void LabelDragOver(object sender, DragEventArgs e)
        {
            Console.WriteLine("Text: " + e.Data.GetData("Text"));
            if (e.Data.GetDataPresent("Text"))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void LabelDragDrop(object sender, DragEventArgs e)
        {
            if (FutureOrToday(sets[currentlyShownSet].Date))
            {
                dirtyFlag = true;
                Task t = new Task(-1, (string)e.Data.GetData("Text"));
                if (suggestions.Contains(t))
                {
                    t = suggestions.Find(x => x.name == t.name);
                    ((Label)sender).Text = t.name;
                    ((Label)sender).BackColor = t.col;
                    ((Label) sender).ForeColor = t.col.GetBrightness() < 0.5f ? lightFont : darkFont;
                    if (((Label)sender) == time8) sets[currentlyShownSet].items[0].task = t;
                    else if (((Label)sender) == time10) sets[currentlyShownSet].items[1].task = t;
                    else if (((Label)sender) == time12) sets[currentlyShownSet].items[2].task = t;
                    else if (((Label)sender) == time14) sets[currentlyShownSet].items[3].task = t;
                    else if (((Label)sender) == time16) sets[currentlyShownSet].items[4].task = t;
                    else if (((Label)sender) == time18) sets[currentlyShownSet].items[5].task = t;
                    else if (((Label)sender) == time20) sets[currentlyShownSet].items[6].task = t;
                    else if (((Label)sender) == time22) sets[currentlyShownSet].items[7].task = t;
                    else if (((Label)sender) == time0) sets[currentlyShownSet].items[8].task = t;
                }
                else
                {
                    //suggestion doesn't exist, shouldnt happen
                    throw new ArgumentException();
                }
            }
        }

        public bool FutureOrToday(DateTime date)
        {
            if (date.Date < DateTime.Today.Date) return false;
            return true;
        }

        private void SuggestionDrag(object sender, MouseEventArgs e)
        {
            if (dragStart) dragStart = false;
             dragPos = new Point(e.X, e.Y);
            
            
        }

        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.None && FutureOrToday(sets[currentlyShownSet].Date) && !dragStart)
            {
                Console.WriteLine(dragPos + " " + Math.Sqrt(Math.Pow(dragPos.X - e.X, 2) + Math.Pow(dragPos.Y - e.Y, 2)));
                if (Math.Sqrt(Math.Pow(dragPos.X - e.X, 2) + Math.Pow(dragPos.Y - e.Y, 2)) > 15)
                {
                    dragStart = true;
                    ((Label)sender).DoDragDrop(((Label)sender).Text, DragDropEffects.Copy);
                }
            }
        }

        private void SelectBox(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Up event!");
            if (!dragStart)
            {
                Console.WriteLine("Lets go for this: " + ((Label)sender).Text);
                mostRecentBox = (Label)sender;
                SelectedLabel.Text = ((Label)sender).Text;
                ColorPicker2.BackColor = ((Label)sender).BackColor;
            }
            else dragStart = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _Moving = true;
            _Offset = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Moving)
            {
                Point newlocation = this.Location;
                newlocation.X += e.X - _Offset.X;
                newlocation.Y += e.Y - _Offset.Y;
                this.Location = newlocation;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_Moving)
            {
                _Moving = false;
            }
        }

        private void DatePrev_Click(object sender, EventArgs e)
        {
            if (currentlyShownSet + 1 < sets.Count)
            {
                currentlyShownSet++;
                DisplaySet(sets[currentlyShownSet]);
            }
        }

        private void DateNext_Click(object sender, EventArgs e)
        {
            if (currentlyShownSet > 0)
            {
                currentlyShownSet--;
                DisplaySet(sets[currentlyShownSet]);
            }
            else
            {
                //new set for the next day
                sets.Insert(0, DaySet.emptyTodaySet());
                sets[0].Date = sets[1].Date.AddDays(1);
                currentlyShownSet = 0;
                DisplaySet(sets[0]);
            }
        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentCol = colorDialog1.Color;
                ColorPicker.BackColor = currentCol;
            }
        }

        private void ColorPicker2_Click(object sender, EventArgs e)
        {
            if (mostRecentBox != null)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (ColorPicker2.BackColor != colorDialog1.Color)
                    {
                        dirtyFlag = true;
                        ColorPicker2.BackColor = colorDialog1.Color;
                        Task t = suggestions.Find(x => x.name == mostRecentBox.Text);
                        if (t != null)
                        {
                            t.col = ColorPicker2.BackColor;
                            UpdateDisplay(boxes, t);
                        }
                    }
                }
            }
        }

        private void SelectedLabel_TextChanged(object sender, EventArgs e)
        {
            TextBox texter = (TextBox)sender;
            if (mostRecentBox != null)
            {
                Task t;
                if (map.TryGetValue(mostRecentBox, out t))
                {
                    dirtyFlag = true;
                    t.name = texter.Text;
                    UpdateTexts(boxes);
                }
            }
        }

        private void ColorPicker2_DragDrop(object sender, DragEventArgs e)
        {
            if (mostRecentBox != null)
            {
                Task t = new Task(-1, (string)e.Data.GetData("Text"));
                if (suggestions.Contains(t))
                {
                    t = suggestions.Find(x => x.name == t.name);
                    Task current;
                    if (map.TryGetValue(mostRecentBox, out current))
                    {
                        if (current.col != t.col)
                        {
                            dirtyFlag = true;
                            current.col = t.col;
                            ColorPicker2.BackColor = t.col;
                            UpdateDisplay(boxes, current);
                        }
                    }
                    else
                    {
                        //suggestion doesn't exist, shouldnt happen
                        throw new ArgumentException();
                    }
                }
                else
                {
                    //suggestion doesn't exist, shouldnt happen
                    throw new ArgumentException();
                }
            }
        }

        private void ColorPicker2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Text"))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else e.Effect = DragDropEffects.None;
        }

        int colorcompare(Label l1, Label l2)
        {
            return map[l1].col.ToArgb() - map[l2].col.ToArgb();
        }

        int alphabetcomparer(Label l1, Label l2)
        {
            return String.Compare(l1.Text, l2.Text, true);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            boxes.Sort(colorcompare);
            UpdateDisplay(boxes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxes.Sort(alphabetcomparer);
            UpdateDisplay(boxes);
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }

}
