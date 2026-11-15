using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class LogManager
    {
        private static readonly string logFilePath = "Log";
        public static string GetCurrentDirectoryPath()
        {
            // יוצר מבנה תיקיות לפי שנה-חודש, לדוגמה: Log/2026-06
            string monthFolder = DateTime.Now.ToString("yyyy-MM");
            return Path.Combine(logFilePath, monthFolder);
        }
        public static string GetCurrentFilePath()
        {
            string dirPath = GetCurrentDirectoryPath();
            // יוצר שם קובץ לפי התאריך היומי, לדוגמה: 07-06-2026.log
            string fileName = DateTime.Now.ToString("dd-MM-yyyy") + ".log";
            return Path.Combine(dirPath, fileName);
        }
        public static void WriteLog(string project, string funcName, string message)
        {
            string dirPath = GetCurrentDirectoryPath();

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            string filePath = GetCurrentFilePath();

            string logLine = $"{DateTime.Now}\t{project}.{funcName}:\t{message}";

            File.AppendAllText(filePath, logLine + Environment.NewLine);
        }
        public static void CleanOldLogs()
        {
            if (!Directory.Exists(logFilePath))
            {
                return;
            }

            // מקבלת את כל נתיבי התיקיות תחת תיקיית Log
            string[] monthDirectories = Directory.GetDirectories(logFilePath);

            foreach (string dirPath in monthDirectories)
            {
                // מחלצים את שם התיקיה (שמורכב לפי פורמט yyyy-MM)
                string folderName = Path.GetFileName(dirPath);

                // מנסים להמיר את מחרוזת התיקיה לתאריך
                if (DateTime.TryParseExact(folderName, "yyyy-MM", null, System.Globalization.DateTimeStyles.None, out DateTime folderDate))
                {
                    // אם התיקיה ישנה יותר מחודשיים אחורה
                    if (folderDate < DateTime.Now.AddMonths(-2))
                    {
                        // מחיקת התיקיה יחד עם כל הקבצים שבתוכה
                        Directory.Delete(dirPath, true);
                    }
                }
            }
        }
    }
}
