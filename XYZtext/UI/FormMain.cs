//10.16.2025 OMG THIS CODE IS SHIT, I CAN'T BELIVE I WROTE LIKE THIS 2 YEARS AGO
//It'll be a complex task to rewrite it all. Plus there's a big part of this code by xytext dev
//10.21.2025 Code refactoring will be later.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;
using xyztext.UI.Theme;

namespace xyztext
{
    public partial class FormMain : Form
    {
        public string[] Files;
        private string _themeFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "XYZtext", "theme.txt");
        private string _configFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "XYZtext", "config.txt");
        private ThemeManager _themeManager;
        private bool _isModified = false;
        private string _currentFileName = "Null";
        private bool _ignoreInvalidVariables = false;

        public FormMain()
        {
            this.DragEnter += new DragEventHandler(file_DragEnter);
            this.DragDrop += new DragEventHandler(file_DragDrop);
            InitializeComponent();
            ShowAboutAppMessage();
            _themeManager = new ThemeManager();
            SetTheme();
            LoadConfig();
            setStringsTextBox(new string[]
            {
                "Step 1: Load a folder containing text files.",
                "Step 2: The text from the files will be displayed here.",
                "Step 3: Use the ComboBox to select which text entry to edit.",
                "",
                "Enjoy using XYZtext! Created by MrEffect"
            });
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            RTB_Text.TextChanged += OnTextChanged;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ApplyDataGridViewChangesToTextBox();
        }

        private void UpdateTitle()
        {
            string star = _isModified ? "*" : "";
            this.Text = $"XYZtext - current file: {_currentFileName}{star}";
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!_isModified)
            {
                _isModified = true;
                UpdateTitle();
            }
        }

        // IO
        private void dumpTXT_Click(object sender, EventArgs e)
        {
            if (Files.Length == 0)
                return;

            SaveFileDialog saveDump = new SaveFileDialog();
            saveDump.Filter = "Text File|*.txt";
            if (saveDump.ShowDialog() != DialogResult.OK)
                return;

            bool newline = false;
            if (MessageBox.Show("Remove newline formatting? Like /r /n /c", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                newline = true;

            string path = saveDump.FileName;

            using (ProgressForm progressForm = new ProgressForm())
            {
                progressForm.Show();
                progressForm.BringToFront();
                progressForm.UpdateProgress(0, "Starting export...");

                using (MemoryStream ms = new MemoryStream())
                {
                    using (TextWriter tw = new StreamWriter(ms))
                    {
                        for (int i = 0; i < Files.Length; i++)
                        {
                            string currentFile = Path.GetFileName(Files[i]);
                            string[] data = getStringsFromFile(Files[i]);

                            tw.WriteLine("~~~~~~~~~~~~~~~");
                            tw.WriteLine("File Name: " + currentFile);
                            tw.WriteLine("~~~~~~~~~~~~~~~");

                            if (data != null)
                            {
                                foreach (string line in data)
                                {
                                    if (newline)
                                        tw.WriteLine(line.Replace("\\n\\n", " ").Replace("\\n", " ").Replace("\\c", "").Replace("\\r", ""));
                                    else
                                        tw.WriteLine(line);
                                }
                            }

                            int percent = (int)((i + 1) * 100.0 / Files.Length);
                            progressForm.UpdateProgress(percent, currentFile);
                            Application.DoEvents();
                        }

                        tw.WriteLine("~~~~~~~~~~~~~~~");
                    }

                    File.WriteAllBytes(path, ms.ToArray());
                }

                progressForm.UpdateProgress(100, "Done!");
                System.Threading.Thread.Sleep(300);
                progressForm.Close();
            }

            MessageBox.Show("Dump completed successfully!", "Success");
        }


        private void ImportTXT_Click(object sender, EventArgs e)
        {
            OpenFileDialog importDump = new OpenFileDialog();
            importDump.Filter = "Text File|*.txt";
            DialogResult dialogResult = importDump.ShowDialog();

            if (dialogResult != DialogResult.OK)
                return;

            string outputFolderPath = "";

            using (var dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true;
                dialog.Title = "Select Output Folder";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    outputFolderPath = dialog.FileName;
                }
                else
                {
                    return;
                }
            }

            //MessageBox.Show("Sometimes errors may occur; the program will attempt to handle them automatically. Just press OK(Will be fixed in new versions)", "Notice");

            // --- Part 1: read the file ---
            string path = importDump.FileName;
            string[] lines = File.ReadAllLines(path);
            List<string> fileNames = new List<string>();
            List<string> fileContents = new List<string>();
            string currentFileName = "";
            StringBuilder currentFileContent = new StringBuilder();

            foreach (string line in lines)
            {
                if (line.StartsWith("File Name:"))
                {
                    if (!string.IsNullOrEmpty(currentFileName))
                    {
                        fileNames.Add(currentFileName);
                        fileContents.Add(currentFileContent.ToString().TrimEnd());
                        currentFileContent.Clear();
                    }
                    currentFileName = line.Substring(10).Trim();
                }
                else if (line.StartsWith("~~~~~~~~~~~~~~~"))
                {
                    continue; // skip separator
                }
                else
                {
                    currentFileContent.AppendLine(line);
                }
            }
            if (!string.IsNullOrEmpty(currentFileName))
            {
                fileNames.Add(currentFileName);
                fileContents.Add(currentFileContent.ToString().TrimEnd());
            }

            // --- Part 2: generate bytes ---
            List<byte[]> bytes = new List<byte[]>();
            for (int i = 0; i < fileContents.Count; i++)
            {
                RTB_Text.Text = fileContents[i];
                bytes.Add(getBytesForFile(getCurrentTextBoxLines()));
            }

            // --- Part 3: export files with progress ---
            using (ProgressForm progressForm = new ProgressForm())
            {
                progressForm.Show();
                progressForm.BringToFront();
                progressForm.UpdateProgress(0, "Starting export...");

                for (int i = 0; i < fileNames.Count; i++)
                {
                    string currentFile = fileNames[i].Trim();
                    byte[] data = bytes[i];

                    string outputPath = Path.Combine(outputFolderPath, currentFile);
                    File.WriteAllBytes(outputPath, data);

                    int percent = (int)((i + 1) * 100.0 / fileNames.Count);
                    progressForm.UpdateProgress(percent, currentFile);

                    Application.DoEvents();
                }

                progressForm.UpdateProgress(100, "Done!");
                System.Threading.Thread.Sleep(300);
                progressForm.Close();
            }
            openFolderPath(outputFolderPath);
            MessageBox.Show("All files exported successfully!", "Success");
        }


        private void file_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void file_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string path = files[0]; // open first D&D
            if (Directory.Exists(path))
                openFolderPath(path);
        }
        private void changeEntry(object sender, EventArgs e)
        {
            string file = Files[CB_Entry.SelectedIndex];
            string[] data = getStringsFromFile(file);
            _currentFileName = Path.GetFileName(Files[CB_Entry.SelectedIndex]);

            setStringsTextBox(data);
            SetStringsDataGridView(data);

            _isModified = false;
            UpdateTitle();
        }
        private void B_SaveText_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(Files[CB_Entry.SelectedIndex], getBytesForFile(getCurrentTextBoxLines()));
            _isModified = false;
            UpdateTitle();
        }
        private void openFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                openFolderPath(fbd.SelectedPath);
        }
        private void openFolderPath(string path)
        {
            Files = Directory.GetFiles(path, "*.dat*", SearchOption.TopDirectoryOnly);
            if (Files.Length == 0)
            {
                TB_Path.Text = "";
                return;
            }
            TB_Path.Text = path;
            CB_Entry.Items.Clear();

            // Add all the valid entries.
            //for (int i = 0; i < Files.Length; i++)
            //{
            //    CB_Entry.Items.Add(i.ToString());
            //}

            foreach (string file in Files)
            {
                CB_Entry.Items.Add(Path.GetFileName(file));
            }

            // Enable Text Line Editing Interface
            CB_Entry.Enabled = true;
            B_SaveText.Enabled = true;
            CB_Entry.SelectedIndex = 0;

            // Enable Dumping All Text
            menu_Tools.Enabled = true;
        }
        private void setStringsTextBox(string[] textArray)
        {
            if (textArray == null) // Error handling for bad inputs.
                return;
            RTB_Text.Clear();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < textArray.Length; i++)
            {
                sb.AppendLine(textArray[i]);
            }

            RTB_Text.Text = sb.ToString();
            RTB_Text.Text = RTB_Text.Text.TrimEnd('\r', '\n');
        }

        private string[] getCurrentTextBoxLines()
        {
            string[] lines = RTB_Text.Lines.ToArray();
            return lines;
        }

        // Top Level Functions
        private string[] getStringsFromFile(string path)
        {
            byte[] data = File.ReadAllBytes(path);
            ushort textSections = BitConverter.ToUInt16(data, 0);
            ushort lineCount = BitConverter.ToUInt16(data, 2);
            if (lineCount == 0) return null;
            uint totalLength = BitConverter.ToUInt32(data, 4);
            uint initialKey = BitConverter.ToUInt32(data, 8);
            int sectionData = BitConverter.ToInt32(data, 12);

            try // Some sanity checking to prevent errors.
            {
                if (initialKey != 0) throw new Exception("Invalid initial key! Not 0?");
                if (sectionData + totalLength != data.Length || textSections != 1) throw new Exception("Invalid Text File");

                uint sectionLength = BitConverter.ToUInt32(data, sectionData);
                if (sectionLength != totalLength) throw new Exception("Section size and overall size do not match.");
            }
            catch { return null; }
            ;

            // Prep result storage.
            ushort key = 0x7C89;
            string[] result = new string[lineCount];

            for (int i = 0; i < lineCount; i++)
            {
                // Init
                ushort k = key;
                string s = "";
                int offset = BitConverter.ToInt32(data, i * 8 + sectionData + 4) + sectionData;
                int length = BitConverter.ToInt16(data, i * 8 + sectionData + 8);
                int start = offset;
                ushort c = 0; // u16 char

                while (offset < start + length * 2) // loop through the entire text line
                {
                    decryptU16(data, ref offset, ref c, ref k);
                    if (c == 0)             // Terminated Line
                        break;
                    else if (c == '\n') s += "\\n";
                    else if (c == 0x10)     // Variable
                        decryptVar(data, ref offset, ref s, ref c, ref k);
                    else                    // Regular Character
                    {
                        // Check special characters...
                        if (c == 0xE07F)
                            s += (char)0x202F; // nbsp
                        else if (c == 0xE08D)
                            s += (char)0x2026; // …
                        else if (c == 0xE08E)
                            s += (char)0x2642; // ♂
                        else if (c == 0xE08F)
                            s += (char)0x2640; // ♀
                        // Else append character without modification.
                        else s += (char)c;
                    }
                }
                // store string and set key for next line (if needed)
                result[i] = s;
                key += 0x2983;
            }
            return result;
        }

        private byte[] getBytesForFile(string[] lines)
        {

            using (MemoryStream textFile = new MemoryStream())
            using (BinaryWriter bw = new BinaryWriter(textFile))
            using (MemoryStream data = new MemoryStream())
            using (BinaryWriter bz = new BinaryWriter(data))
            {
                ushort baseKey = 0x7C89;

                // Write up header template
                bw.Write((ushort)1);            // Always 1 ? 
                bw.Write((ushort)lines.Length); // Line Count
                bw.Write((uint)0);              // (Temporary) Data Length - fixed at the end.
                bw.Write((uint)0);              // Key, constant 0.
                bw.Write((uint)0x10);           // Pointer to line data.

                // Begin data
                bw.Write((uint)0);              // (Temporary) Data Length - fixed at the end.

                for (int i = 0; i < lines.Length; i++)
                {
                    ushort key = baseKey;
                    uint pos = (uint)data.Position;
                    // Get crypted line data.
                    {
                        {
                            // Write each character to the data stream, with handling for special characters.
                            for (int j = 0; j < lines[i].Length; j++)
                            {
                                ushort val = lines[i][j];

                                // Handle special text characters
                                // Private Use Area characters
                                if (val == 0x202F) val = 0xE07F;        // nbsp
                                else if (val == 0x2026) val = 0xE08D;   // …
                                else if (val == 0x2642) val = 0xE08E;   // ♂
                                else if (val == 0x2640) val = 0xE08F;   // ♀

                                // Variables
                                else if (val == '[' || val == '\\')          // Variable
                                    encryptVar(bz, lines[i], ref j, ref key);

                                // Text
                                else bz.Write(encryptU16(val, ref key));
                            }
                            bz.Write(encryptU16(0, ref key)); // Add the null terminator, after encrypting it.
                        }

                        // Write the lineOffset and charCount to the header.
                        bw.Write((uint)(pos + 0x4 + lines.Length * 8));
                        bw.Write((uint)(data.Position - pos) / 2);
                        if (data.Position % 4 > 0) bz.Write((ushort)0);

                        // Increment the line initial key for the next line.
                        baseKey += 0x2983;
                    }
                }

                // Copy the data stream to the textFile stream.
                data.Position = 0; data.CopyTo(textFile);

                // Fix the temp values
                textFile.Position = 0x4; bw.Write((uint)textFile.Length - 0x10);
                textFile.Position = 0x10; bw.Write((uint)textFile.Length - 0x10);

                return textFile.ToArray();
            }
        }

        private ushort encryptU16(ushort val, ref ushort key)
        {
            val = (ushort)(key ^ val);
            key = (ushort)(((key << 3) | (key >> 13)) & 0xffff);
            return val;
        }
        private ushort decryptU16(byte[] data, ref int offset, ref ushort val, ref ushort key)
        {
            val = (ushort)(BitConverter.ToUInt16(data, offset) ^ key);
            offset += 2;
            key = (ushort)(((key << 3) | (key >> 13)) & 0xffff);
            return val;
        }
        // Variable Handling
        private ushort getVariableBytes(string varType, ref List<ushort> args)
        {
            // Fetch the variable name...
            int bracket = varType.Count(c => c == '(') > 0 ? varType.IndexOf('(') : 0;
            string variable = bracket == 0 ? varType : varType.Substring(0, bracket);
            string[] arguments = bracket > 0 ?
                varType.Substring(bracket + 1, varType.Length - bracket - 2).Split(',') :
                new string[0];

            ushort varVal = 0;

            switch (variable)
            {
                case "COLOR": varVal = 0xFF00; break;
                case "TRNAME": varVal = 0x0100; break;
                case "PKNAME": varVal = 0x0101; break;
                case "PKNICK": varVal = 0x0102; break;
                case "TYPE": varVal = 0x0103; break;
                case "LOCATION": varVal = 0x0105; break;
                case "ABILITY": varVal = 0x0106; break;
                case "MOVE": varVal = 0x0107; break;
                case "ITEM1": varVal = 0x0108; break;
                case "ITEM2": varVal = 0x0109; break;
                case "sTRBAG": varVal = 0x010A; break;
                case "BOX": varVal = 0x010B; break;
                case "EVSTAT": varVal = 0x010D; break;
                case "OPOWER": varVal = 0x0110; break;
                case "RIBBON": varVal = 0x0127; break;
                case "MIINAME": varVal = 0x0134; break;
                case "WEATHER": varVal = 0x013E; break;
                case "TRNICK": varVal = 0x0189; break;
                case "1stchrTR": varVal = 0x018A; break;
                case "SHOUTOUT": varVal = 0x018B; break;
                case "BERRY": varVal = 0x018E; break;
                case "REMFEEL": varVal = 0x018F; break;
                case "REMQUAL": varVal = 0x0190; break;
                case "WEBSITE": varVal = 0x0191; break;
                case "CHOICECOS": varVal = 0x019C; break;
                case "GSYNCID": varVal = 0x01A1; break;
                case "PRVIDSAY": varVal = 0x0192; break;
                case "BTLTEST": varVal = 0x0193; break;
                case "GENLOC": varVal = 0x0195; break;
                case "CHOICEFOOD": varVal = 0x0199; break;
                case "HOTELITEM": varVal = 0x019A; break;
                case "TAXISTOP": varVal = 0x019B; break;
                case "MAISTITLE": varVal = 0x019F; break;
                case "ITEMPLUR0": varVal = 0x1000; break;
                case "ITEMPLUR1": varVal = 0x1001; break;
                case "GENDBR": varVal = 0x1100; break;
                case "NUMBRNCH": varVal = 0x1101; break;
                case "iCOLOR2": varVal = 0x1302; break;
                case "iCOLOR3": varVal = 0x1303; break;
                case "NUM1": varVal = 0x0200; break;
                case "NUM2": varVal = 0x0201; break;
                case "NUM3": varVal = 0x0202; break;
                case "NUM4": varVal = 0x0203; break;
                case "NUM5": varVal = 0x0204; break;
                case "NUM6": varVal = 0x0205; break;
                case "NUM7": varVal = 0x0206; break;
                case "NUM8": varVal = 0x0207; break;
                case "NUM9": varVal = 0x0208; break;
                default: varVal = Convert.ToUInt16(variable, 16); break;
            }
            // Set arguments in.
            foreach (var arg in arguments)
            {
                if (!string.IsNullOrWhiteSpace(arg))
                    args.Add(Convert.ToUInt16(arg, 16));
            }

            // All done.
            return varVal;
        }
        private void encryptVar(BinaryWriter bw, string line, ref int i, ref ushort key)
        {
            ushort val = line[i];
            if (val == '\\')        // Line Break
                if (line[i + 1] == 'n')
                {
                    i++;
                    bw.Write(encryptU16('\n', ref key));
                }
                else if (line[i + 1] == 'r')
                {
                    bw.Write(encryptU16(0x10, ref key)); i++;
                    bw.Write(encryptU16(1, ref key));
                    bw.Write(encryptU16(0xBE00, ref key));
                }
                else if (line[i + 1] == 'c')
                {
                    bw.Write(encryptU16(0x10, ref key)); i++;
                    bw.Write(encryptU16(1, ref key));
                    bw.Write(encryptU16(0xBE01, ref key));
                }
                else { throw new Exception($"Invalid completed string! On the line:\n{line}"); }
            else if (val == '[')    // Special Variable
            {
                int bracket = line.Substring(i + 1).IndexOf(']');
                if (bracket < 3) throw new Exception("Variable encoding error!");

                // [VAR X(a, b)]
                // Remove the [ ] -> VAR X(a, b)
                string varCMD = line.Substring(i + 1, bracket);
                i += bracket + 1; // Advance the index to the end of the bracket.

                string varMethod = varCMD.Split(' ')[0];                    // Returns VAR or WAIT or ~
                string varType = varCMD.Substring(Math.Min(varMethod.Length + 1, varCMD.Length));   // Returns the remainder of the var command data.
                ushort varValue = 0;

                // Set up argument storage (even if it not used)
                List<ushort> args = new List<ushort>();

                try
                {
                    switch (varMethod)
                    {
                        case "~":       // Blank Text Line Variable (No text set - debug/quality testing variable?)
                            {
                                varValue = 0xBDFF;
                                args.Add(Convert.ToUInt16(varType));
                                break;
                            }
                        case "WAIT":    // Event pause Variable.
                            {
                                varValue = 0xBE02;
                                args.Add(Convert.ToUInt16(varType));
                                break;
                            }
                        case "VAR":     // Text Variable
                            {
                                varValue = getVariableBytes(varType, ref args);
                                break;
                            }
                        default: throw new Exception("Unknown variable method type!");
                    }
                }
                catch (Exception e)
                {
                    if (!_ignoreInvalidVariables)
                        MessageBox.Show("Variable error. Text of the current line:\n\n" + line + "\n\n" + e.ToString(), "Alert");
                }

                // Write the Variable prefix.
                bw.Write(encryptU16(0x0010, ref key));
                // Write Length of the following Variable Data
                bw.Write(encryptU16((ushort)(1 + args.Count), ref key));
                // Write the Variable type.
                bw.Write(encryptU16(varValue, ref key));

                for (int j = 0; j < args.Count; j++)
                    bw.Write(encryptU16((ushort)args[j], ref key));

                // Done.
            }
        }
        private void decryptVar(byte[] d, ref int o, ref string s, ref ushort v, ref ushort k)
        {
            ushort length = decryptU16(d, ref o, ref v, ref k);
            ushort varType = decryptU16(d, ref o, ref v, ref k);
            switch (varType)
            {
                // Check the nonvariable types...
                case 0xBE00: // "Waitbutton then scroll text;; \r"
                    { s += "\\r"; return; }
                case 0xBE01: // "Waitbutton then clear text;; \c"
                    { s += "\\c"; return; }
                case 0xBE02: // Dramatic pause for a text line. New!
                    { s += "[WAIT " + decryptU16(d, ref o, ref v, ref k).ToString() + "]"; return; }
                case 0xBDFF: // Empty Text line? Includes linenum so maybe for betatest finding used-unused lines?
                    { s += "[~ " + decryptU16(d, ref o, ref v, ref k).ToString() + "]"; return; }

                // Else a text variable, so let's loop through all the variable types. If we cannot find it, we just write the u16 val.
                default:
                    {
                        ushort varCode = varType; // decryptU16(d, ref o, ref v, ref k);
                        string tvname = "";
                        switch (varCode) // get variable's info name
                        {
                            case 0xFF00: tvname = "COLOR"; break; // Change text line color (0 = white, 1 = red, 2 = blue...)
                            case 0x0100: tvname = "TRNAME"; break; // 
                            case 0x0101: tvname = "PKNAME"; break;
                            case 0x0102: tvname = "PKNICK"; break;
                            case 0x0103: tvname = "TYPE"; break;
                            case 0x0105: tvname = "LOCATION"; break;
                            case 0x0106: tvname = "ABILITY"; break;
                            case 0x0107: tvname = "MOVE"; break;
                            case 0x0108: tvname = "ITEM1"; break;
                            case 0x0109: tvname = "ITEM2"; break;
                            case 0x010A: tvname = "sTRBAG"; break;
                            case 0x010B: tvname = "BOX"; break;
                            case 0x010D: tvname = "EVSTAT"; break;
                            case 0x0110: tvname = "OPOWER"; break;
                            case 0x0127: tvname = "RIBBON"; break;
                            case 0x0134: tvname = "MIINAME"; break;
                            case 0x013E: tvname = "WEATHER"; break;
                            case 0x0189: tvname = "TRNICK"; break;
                            case 0x018A: tvname = "1stchrTR"; break;
                            case 0x018B: tvname = "SHOUTOUT"; break;
                            case 0x018E: tvname = "BERRY"; break;
                            case 0x018F: tvname = "REMFEEL"; break;
                            case 0x0190: tvname = "REMQUAL"; break;
                            case 0x0191: tvname = "WEBSITE"; break;
                            case 0x019C: tvname = "CHOICECOS"; break;
                            case 0x01A1: tvname = "GSYNCID"; break;
                            case 0x0192: tvname = "PRVIDSAY"; break;
                            case 0x0193: tvname = "BTLTEST"; break;
                            case 0x0195: tvname = "GENLOC"; break;
                            case 0x0199: tvname = "CHOICEFOOD"; break;
                            case 0x019A: tvname = "HOTELITEM"; break;
                            case 0x019B: tvname = "TAXISTOP"; break;
                            case 0x019F: tvname = "MAISTITLE"; break;
                            case 0x1000: tvname = "ITEMPLUR0"; break;
                            case 0x1001: tvname = "ITEMPLUR1"; break;
                            case 0x1100: tvname = "GENDBR"; break;
                            case 0x1101: tvname = "NUMBRNCH"; break;
                            case 0x1302: tvname = "iCOLOR2"; break;
                            case 0x1303: tvname = "iCOLOR3"; break;
                            case 0x0200: tvname = "NUM1"; break;
                            case 0x0201: tvname = "NUM2"; break;
                            case 0x0202: tvname = "NUM3"; break;
                            case 0x0203: tvname = "NUM4"; break;
                            case 0x0204: tvname = "NUM5"; break;
                            case 0x0205: tvname = "NUM6"; break;
                            case 0x0206: tvname = "NUM7"; break;
                            case 0x0207: tvname = "NUM8"; break;
                            case 0x0208: tvname = "NUM9"; break;
                            default: tvname = varCode.ToString("X4"); break;
                        }
                        s += "[VAR" + " " + tvname;
                        if (length > 1)
                        {
                            s += '(';
                            while (length > 1)
                            {
                                // Write arguments
                                ushort arg = decryptU16(d, ref o, ref v, ref k);
                                length--;
                                s += arg.ToString("X4");
                                if (length == 1) break;
                                s += ",";
                            }
                            s += ')';
                        }
                        s += "]";
                        break;
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenGithubPage(object sender, EventArgs e)
        {
            string url = "https://github.com/MrEffectDev";
            OpenBrowser(url);
        }

        private void OpenYoutubePage(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/@mreffect_dev";
            OpenBrowser(url);
        }

        private void OpenSupportPage(object sender, EventArgs e)
        {
            string url = "https://boosty.to/mreffect";
            OpenBrowser(url);
        }
        private void OpenBrowser(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening browser: {ex.Message}", "Error");
            }
        }

        private void SplitTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTB_Text.Visible && RTB_Text.SelectionLength > 0)
            {
                RTB_Text.SelectedText = SplitText(RTB_Text.SelectedText, 45);
            }
            else if (dataGridView1.Visible && dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    if (cell.Value != null)
                        cell.Value = SplitText(cell.Value.ToString(), 50);
                }
            }
            else
            {
                MessageBox.Show("Select some text or cells to split.");
            }
        }

        private void RemoveTextSplitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTB_Text.Visible && RTB_Text.SelectionLength > 0)
            {
                RTB_Text.SelectedText = RTB_Text.SelectedText.Replace("\\n", " ").Replace("\\r", " ").Replace("\\с", " ").Replace("  ", " ");
            }
            else if (dataGridView1.Visible && dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    if (cell.Value != null)
                        cell.Value = cell.Value.ToString().Replace("\\n", " ").Replace("\\r", " ").Replace("\\с", " ").Replace("  ", " ");
                }
            }
            else
            {
                MessageBox.Show("Select some text or cells to remove text separations.");
            }
        }

        private void trimLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTB_Text.Visible && RTB_Text.SelectionLength > 0)
            {
                RTB_Text.SelectedText = RTB_Text.SelectedText.Trim();
            }
            else if (dataGridView1.Visible && dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    if (cell.Value != null)
                        cell.Value = cell.Value.ToString().Trim();
                }
            }
            else
            {
                MessageBox.Show("Select some text or cells to trim.");
            }
        }

        private void lineInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTB_Text.Visible && RTB_Text.SelectionLength > 0)
            {
                ShowTextInfo(RTB_Text.SelectedText, "Selected Line Info");
            }
            else if (dataGridView1.Visible && dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    if (cell.Value != null)
                        ShowTextInfo(cell.Value.ToString(), $"Cell [{cell.RowIndex}, {cell.ColumnIndex}] Info");
                }
            }
            else
            {
                MessageBox.Show("Select some text or cells to see info.");
            }
        }

        private void ShowTextInfo(string text, string title)
        {
            int charCount = text.Length;
            int charNoSpaces = text.Replace(" ", "").Replace("\n", "").Replace("\r", "").Length;
            int wordCount = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int lineCount = text.Split(new string[] { "\r\n", "\n", "\r" }, StringSplitOptions.None).Length;

            MessageBox.Show(
                $"{title}:\n\n" +
                $"Characters (with spaces): {charCount}\n" +
                $"Characters (without spaces): {charNoSpaces}\n" +
                $"Words: {wordCount}\n" +
                $"Lines: {lineCount}",
                title
            );
        }

        private string SplitText(string text, int maxCharInSentence)
        {
            if (text.Length <= maxCharInSentence) return text;

            string output = "";
            List<int> spaces = FindSpaceIndexes(text);
            int charCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < spaces.Count; j++)
                {
                    if (i == spaces[j] && charCount >= maxCharInSentence)
                    {
                        output += "\\n";
                        charCount = 0;
                    }
                }
                output += text[i];
                charCount++;
            }

            return output;
        }

        private List<int> FindSpaceIndexes(string input)
        {
            input = Regex.Replace(input, @"\[.*?\]", "");
            List<int> spaceIndexes = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaceIndexes.Add(i);
                }
            }

            return spaceIndexes;
        }


        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string theme = "Dark";
            _themeManager.SetTheme(new Themes.Dark(), this);
            Directory.CreateDirectory(Path.GetDirectoryName(_themeFilePath));
            File.WriteAllText(_themeFilePath, theme);
            darkToolStripMenuItem.Checked = true;
            whiteToolStripMenuItem.Checked = false;
        }
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string theme = "White";
            _themeManager.SetTheme(new Themes.White(), this);
            Directory.CreateDirectory(Path.GetDirectoryName(_themeFilePath));
            File.WriteAllText(_themeFilePath, theme);
            darkToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = true;
        }
        private void SetTheme()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string themeFilePath = Path.Combine(appData, "XYZtext", "theme.txt");

            string themeName = "White";

            if (File.Exists(themeFilePath))
            {
                try
                {
                    themeName = File.ReadAllText(themeFilePath).Trim();
                }
                catch
                {

                }
            }

            if (string.Equals(themeName, "Dark", StringComparison.OrdinalIgnoreCase))
            {
                _themeManager.SetTheme(new Themes.Dark(), this);
                darkToolStripMenuItem.Checked = true;
            }
            else
            {
                _themeManager.SetTheme(new Themes.White(), this);
                whiteToolStripMenuItem.Checked = true;
            }
        }

        private void unloadFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Files = null;

            CB_Entry.Items.Clear();
            CB_Entry.Enabled = false;
            RTB_Text.Clear();
            menu_Tools.Enabled = false;
            TB_Path.Clear();
            B_SaveText.Enabled = false;

            _isModified = false;
            _currentFileName = "Null";
            UpdateTitle();

            MessageBox.Show("All files have been unloaded.", "Unload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowAboutAppMessage()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;

            MessageBox.Show(
                $"Welcome to XYZtext {version}!\n\n" +
                "XYZtext is a tool for editing localization files for Pokémon games.\n" +
                "(Tested on Pokémon Scarlet and Violet.)\n\n" +
                "This program is completely free and open-source, created by MrEffect.\n" +
                "You can find a link to me in the 'Help' menu.\n\n" +
                "Even though the program is free, your support is greatly appreciated ♡♡♡\n\n" +
                "Enjoy customizing your Pokémon game experience!",
                "Welcome to XYZtext",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAboutAppMessage();
        }

        private void ignoreInvalidVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ignoreInvalidVariables = !_ignoreInvalidVariables;
            ignoreInvalidVariablesToolStripMenuItem.Checked = _ignoreInvalidVariables;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveConfig();
        }

        private void SaveConfig()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_configFilePath));
                File.WriteAllText(_configFilePath, _ignoreInvalidVariables.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save config: {ex.Message}", "Warning");
            }
        }

        private void LoadConfig()
        {
            try
            {
                if (File.Exists(_configFilePath))
                {
                    string text = File.ReadAllText(_configFilePath).Trim();
                    if (bool.TryParse(text, out bool value))
                    {
                        _ignoreInvalidVariables = value;
                        ignoreInvalidVariablesToolStripMenuItem.Checked = _ignoreInvalidVariables;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load config: {ex.Message}", "Warning");
            }
        }

        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridViewToolStripMenuItem.Checked = !gridViewToolStripMenuItem.Checked;
            RTB_Text.Visible = !gridViewToolStripMenuItem.Checked;
            dataGridView1.Visible = !RTB_Text.Visible;
            if (gridViewToolStripMenuItem.Checked)
            {
                SetStringsDataGridView(getCurrentTextBoxLines());
            }
        }

        private void ApplyDataGridViewChangesToTextBox()
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var cellValue = dataGridView1.Rows[i].Cells[1].Value;
                if (cellValue != null)
                {
                    sb.AppendLine(cellValue.ToString());
                }
                else
                {
                    sb.AppendLine();
                }
            }
            RTB_Text.Text = sb.ToString().TrimEnd('\r', '\n');
        }

        private void SetStringsDataGridView(string[] textArray)
        {
            dataGridView1.CellValueChanged -= DataGridView1_CellValueChanged;
            dataGridView1.SuspendLayout();
            dataGridView1.Rows.Clear();

            if (textArray == null)
                return;

            dataGridView1.Columns.Clear();

            dataGridView1.AllowUserToResizeColumns = false;
            DataGridViewColumn dgvLine = new DataGridViewTextBoxColumn();
            {
                dgvLine.HeaderText = "Line";
                dgvLine.DisplayIndex = 0;
                dgvLine.Width = 34;
                dgvLine.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLine.ReadOnly = true;
                dgvLine.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DataGridViewTextBoxColumn dgvText = new DataGridViewTextBoxColumn();
            {
                dgvText.HeaderText = "Text";
                dgvText.DisplayIndex = 1;
                dgvText.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvText.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Columns.Add(dgvLine);
            dataGridView1.Columns.Add(dgvText);

            dataGridView1.Rows.Add(textArray.Length);

            for (int i = 0; i < textArray.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value = textArray[i];
            }
            dataGridView1.ResumeLayout();
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }
    }
}