using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public enum Importance
    {
        NotImportant,
        SlightlyImportant,
        SomewhatImportant,
        Important,
        VeryImportant,
        Critical
    }
    public class LogsChangedEventArgs : EventArgs
    {
        public LogsChangedEventArgs(string newDisplay, LogEntry newEntry, List<LogEntry> displayedLogs, bool logLevelChanged)
        {
            DisplayedLogs = displayedLogs;
            NewDisplay = newDisplay;
            NewEntry = newEntry;
            LogLevelChanged = logLevelChanged;
        }

        public string NewDisplay { get; set; }
        public LogEntry NewEntry { get; set; }
        public List<LogEntry> DisplayedLogs { get; set; }
        public bool LogLevelChanged { get; set; }

    }
    public static class Log
    {
        public static List<LogEntry> History = new List<LogEntry>();
        private const Importance DefaultLogLevel = Importance.SomewhatImportant;
        private static Importance DisplayLogLevel = Importance.Important;
        public static string TextDisplay = "";
        public static readonly List<LogEntry> DisplayedLogs = new List<LogEntry>();
        public static event EventHandler LogsChanged;

        private static void UpdateDisplay(LogEntry mostRecentEntry = null)
        {
            TextDisplay = "";
            DisplayedLogs.Clear();
            for (int i = History.Count - 1; i >= 0; i--)
            {
                if (DisplayLogLevel <= History[i].importance)
                {
                    DisplayedLogs.Add(History[i]);
                    TextDisplay += History[i].GetMessage();
                }
            }

            LogsChanged.Invoke(null, new LogsChangedEventArgs(TextDisplay, mostRecentEntry, DisplayedLogs, mostRecentEntry == null));

        }
        public static void Add(string message, Importance importance = DefaultLogLevel)
        {
            LogEntry entry = new LogEntry(message, importance);
            Add(entry);
        }
        public static void Add(LogEntry log)
        {
            History.Add(log);
            if (log.importance >= DisplayLogLevel)
            {
                UpdateDisplay();
            }
            UpdateDisplay();

        }
        public static void ChangeDisplayLevel(Importance importance)
        {
            DisplayLogLevel = importance;
            UpdateDisplay();
        }
        public static Importance GetDisplayLevel()
        {
            return DisplayLogLevel;
        }
    }
    public class LogEntry
    {
        public string OriginalMessage { get; set; }
        public DateTime TimeStamp { get; set; }
        public Importance importance { get; set; }

        /// <summary>
        /// Print all of the logs information including time, importance and original message
        /// </summary>
        /// <param name="formatted">Use markup formatting (optimised for Unity)</param>
        /// <returns></returns>
        public string GetMessage(bool formatted = true)
        {
            if (formatted)
                return "\n<color=#FFFFFF55><b>(" + importance.ToString() + ")</b> " + TimeStamp.ToString("H:mm:ss.f") + "</color>   " + OriginalMessage;
            else
                return "(" + importance.ToString() + ") " + TimeStamp.ToString("H:mm:ss.f") + ": " + OriginalMessage;
        }
        public LogEntry(string message, Importance importance)
        {
            this.TimeStamp = DateTime.Now;
            this.OriginalMessage = message;
            this.importance = importance;
        }

    }
    public static class ListExtensions
    {
    }
}
